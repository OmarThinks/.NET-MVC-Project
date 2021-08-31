using Microsoft.EntityFrameworkCore.Migrations;

namespace Application.Data.Migrations
{
    public partial class UserIdStringNotInteger : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_AspNetUsers_AuthorId1",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_Post_AspNetUsers_AuthorId1",
                table: "Post");

            migrationBuilder.DropIndex(
                name: "IX_Post_AuthorId1",
                table: "Post");

            migrationBuilder.DropIndex(
                name: "IX_Comment_AuthorId1",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "AuthorId1",
                table: "Post");

            migrationBuilder.DropColumn(
                name: "AuthorId1",
                table: "Comment");

            migrationBuilder.AlterColumn<string>(
                name: "AuthorId",
                table: "Post",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "AuthorId",
                table: "Comment",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.CreateIndex(
                name: "IX_Post_AuthorId",
                table: "Post",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_AuthorId",
                table: "Comment",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_AspNetUsers_AuthorId",
                table: "Comment",
                column: "AuthorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Post_AspNetUsers_AuthorId",
                table: "Post",
                column: "AuthorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_AspNetUsers_AuthorId",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_Post_AspNetUsers_AuthorId",
                table: "Post");

            migrationBuilder.DropIndex(
                name: "IX_Post_AuthorId",
                table: "Post");

            migrationBuilder.DropIndex(
                name: "IX_Comment_AuthorId",
                table: "Comment");

            migrationBuilder.AlterColumn<int>(
                name: "AuthorId",
                table: "Post",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AuthorId1",
                table: "Post",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AuthorId",
                table: "Comment",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AuthorId1",
                table: "Comment",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Post_AuthorId1",
                table: "Post",
                column: "AuthorId1");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Post_AspNetUsers_AuthorId1",
                table: "Post",
                column: "AuthorId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
