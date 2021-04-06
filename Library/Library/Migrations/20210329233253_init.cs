using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LoanedBooks");

            migrationBuilder.CreateTable(
                name: "LoanedBook",
                columns: table => new
                {
                    Book_Id = table.Column<int>(nullable: false),
                    Member_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanedBook", x => new { x.Book_Id, x.Member_Id });
                    table.ForeignKey(
                        name: "FK_LoanedBook_Members_Book_Id",
                        column: x => x.Book_Id,
                        principalTable: "Members",
                        principalColumn: "Member_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LoanedBook_Books_Member_Id",
                        column: x => x.Member_Id,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LoanedBook_Member_Id",
                table: "LoanedBook",
                column: "Member_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LoanedBook");

            migrationBuilder.CreateTable(
                name: "LoanedBooks",
                columns: table => new
                {
                    LoanedId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BookId = table.Column<int>(nullable: false),
                    MemberId = table.Column<int>(nullable: false),
                    RecieptDate = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanedBooks", x => x.LoanedId);
                    table.ForeignKey(
                        name: "FK_LoanedBooks_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LoanedBooks_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "Member_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LoanedBooks_BookId",
                table: "LoanedBooks",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_LoanedBooks_MemberId",
                table: "LoanedBooks",
                column: "MemberId");
        }
    }
}
