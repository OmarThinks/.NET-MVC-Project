using Microsoft.EntityFrameworkCore.Migrations;

namespace Application.Data.Migrations
{
    public partial class RelatedCommentWithUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Comment",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "AuthorId1",
                table: "Comment",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comment_AuthorId1",
                table: "Comment",
                column: "AuthorId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_AspNetUsers_AuthorId1",
                table: "Comment",
                column: "AuthorId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_AspNetUsers_AuthorId1",
                table: "Comment");

            migrationBuilder.DropIndex(
                name: "IX_Comment_AuthorId1",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "AuthorId1",
                table: "Comment");
        }
    }
}
