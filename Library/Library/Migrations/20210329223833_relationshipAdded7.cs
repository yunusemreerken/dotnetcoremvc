using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Migrations
{
    public partial class relationshipAdded7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_LoanedBooks_BookId",
                table: "LoanedBooks");

            migrationBuilder.CreateIndex(
                name: "IX_LoanedBooks_BookId",
                table: "LoanedBooks",
                column: "BookId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_LoanedBooks_BookId",
                table: "LoanedBooks");

            migrationBuilder.CreateIndex(
                name: "IX_LoanedBooks_BookId",
                table: "LoanedBooks",
                column: "BookId",
                unique: true);
        }
    }
}
