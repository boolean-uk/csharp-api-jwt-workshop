using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace workshop.webapi.Migrations
{
    /// <inheritdoc />
    public partial class AddedPosts2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Posts",
                table: "Posts");

            migrationBuilder.RenameTable(
                name: "Posts",
                newName: "posts");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "posts",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "Body",
                table: "posts",
                newName: "body");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "posts",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "AuthorId",
                table: "posts",
                newName: "fk_authorid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_posts",
                table: "posts",
                column: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_posts",
                table: "posts");

            migrationBuilder.RenameTable(
                name: "posts",
                newName: "Posts");

            migrationBuilder.RenameColumn(
                name: "title",
                table: "Posts",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "body",
                table: "Posts",
                newName: "Body");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Posts",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "fk_authorid",
                table: "Posts",
                newName: "AuthorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Posts",
                table: "Posts",
                column: "Id");
        }
    }
}
