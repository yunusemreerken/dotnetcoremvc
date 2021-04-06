using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Migrations
{
    public partial class relationshipAdded5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LoanedBook_Books_BookId",
                table: "LoanedBook");

            migrationBuilder.DropForeignKey(
                name: "FK_LoanedBook_Members_MemberId",
                table: "LoanedBook");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LoanedBook",
                table: "LoanedBook");

            migrationBuilder.RenameTable(
                name: "LoanedBook",
                newName: "LoanedBooks");

            migrationBuilder.RenameIndex(
                name: "IX_LoanedBook_MemberId",
                table: "LoanedBooks",
                newName: "IX_LoanedBooks_MemberId");

            migrationBuilder.RenameIndex(
                name: "IX_LoanedBook_BookId",
                table: "LoanedBooks",
                newName: "IX_LoanedBooks_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LoanedBooks",
                table: "LoanedBooks",
                column: "LoanedId");

            migrationBuilder.AddForeignKey(
                name: "FK_LoanedBooks_Books_BookId",
                table: "LoanedBooks",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LoanedBooks_Members_MemberId",
                table: "LoanedBooks",
                column: "MemberId",
                principalTable: "Members",
                principalColumn: "Member_Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LoanedBooks_Books_BookId",
                table: "LoanedBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_LoanedBooks_Members_MemberId",
                table: "LoanedBooks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LoanedBooks",
                table: "LoanedBooks");

            migrationBuilder.RenameTable(
                name: "LoanedBooks",
                newName: "LoanedBook");

            migrationBuilder.RenameIndex(
                name: "IX_LoanedBooks_MemberId",
                table: "LoanedBook",
                newName: "IX_LoanedBook_MemberId");

            migrationBuilder.RenameIndex(
                name: "IX_LoanedBooks_BookId",
                table: "LoanedBook",
                newName: "IX_LoanedBook_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LoanedBook",
                table: "LoanedBook",
                column: "LoanedId");

            migrationBuilder.AddForeignKey(
                name: "FK_LoanedBook_Books_BookId",
                table: "LoanedBook",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LoanedBook_Members_MemberId",
                table: "LoanedBook",
                column: "MemberId",
                principalTable: "Members",
                principalColumn: "Member_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
