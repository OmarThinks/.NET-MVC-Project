using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Application.Data;
using Application.Models;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using System.Text.Json;

namespace Application.Controllers
{
    public class commentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public commentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: comments
        public async Task<IActionResult> Index(
            string searchString, int? pageNumber)
        {
            ViewData["searchString"] = searchString;
            var comments = from c in _context.Comment
                        select c;

            if (!String.IsNullOrEmpty(searchString))
            {
                comments = comments.Where(s => s.Content.Contains(searchString));
            }
            comments = comments.OrderBy(s => s.CommentId);
            int pageSize = 5;

            return View(await PaginatedList<Comment>.CreateAsync(comments.AsNoTracking(), pageNumber ?? 1, pageSize));
        }

        // GET: comments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comment = await _context.Comment
                .Include(c => c.Post)
                .FirstOrDefaultAsync(m => m.CommentId == id);
            if (comment == null)
            {
                return NotFound();
            }

            return View(comment);
        }

        // GET: comments/Create
        [Authorize]
        public IActionResult Create()
        {
            ViewData["PostId"] = new SelectList(_context.Set<Post>(), "PostId", "PostId");
            return View();
        }

        // POST: comments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Create([Bind("CommentId,Content,PostId")] Comment comment)
        {
            //Console.WriteLine(JsonSerializer.Serialize(comment));
            comment.AuthorId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            comment.Author = null;
            if (ModelState.IsValid)
            {
                _context.Add(comment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PostId"] = new SelectList(_context.Set<Post>(), "PostId", "PostId", comment.PostId);
            return View(comment);
        }

        // GET: comments/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comment = await _context.Comment.FindAsync(id);
            if (comment == null)
            {
                return NotFound();
            }
            ViewData["PostId"] = new SelectList(_context.Set<Post>(), "PostId", "PostId", comment.PostId);
            return View(comment);
        }

        // POST: comments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Edit(int id, [Bind("CommentId,Content,PostId")] Comment comment)
        {
            comment.AuthorId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            comment.Author = null;
            if (id != comment.CommentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(comment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CommentExists(comment.CommentId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["PostId"] = new SelectList(_context.Set<Post>(), "PostId", "PostId", comment.PostId);
            return View(comment);
        }

        // GET: comments/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comment = await _context.Comment
                .Include(c => c.Post)
                .FirstOrDefaultAsync(m => m.CommentId == id);
            if (comment == null)
            {
                return NotFound();
            }

            return View(comment);
        }

        // POST: comments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var comment = await _context.Comment.FindAsync(id);
            _context.Comment.Remove(comment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CommentExists(int id)
        {
            return _context.Comment.Any(e => e.CommentId == id);
        }
    }
}
