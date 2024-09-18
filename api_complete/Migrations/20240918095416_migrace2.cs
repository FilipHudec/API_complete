using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_complete.Migrations
{
    /// <inheritdoc />
    public partial class migrace2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "CommentId", "ArticleId", "Text", "UserId" },
                values: new object[,]
                {
                    { 1, 1, "This is the first comment", 0 },
                    { 2, 1, "This is the second comment", 0 },
                    { 3, 2, "This is the third comment", 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 3);
        }
    }
}
