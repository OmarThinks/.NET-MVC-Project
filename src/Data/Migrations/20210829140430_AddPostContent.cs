using Microsoft.EntityFrameworkCore.Migrations;

namespace SocialApp.Data.Migrations
{
    public partial class AddPostContent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "Post",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Content",
                table: "Post");
        }
    }
}
