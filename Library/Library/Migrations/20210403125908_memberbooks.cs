using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Migrations
{
    public partial class memberbooks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LoanedBook");

            migrationBuilder.CreateTable(
                name: "MemberBooks",
                columns: table => new
                {
                    LoanedTime = table.Column<DateTime>(nullable: false),
                    Book_Id = table.Column<int>(nullable: false),
                    BookId = table.Column<int>(nullable: true),
                    Member_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberBooks", x => new { x.Member_Id, x.Book_Id });
                    table.ForeignKey(
                        name: "FK_MemberBooks_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MemberBooks_Members_Member_Id",
                        column: x => x.Member_Id,
                        principalTable: "Members",
                        principalColumn: "Member_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MemberBooks_BookId",
                table: "MemberBooks",
                column: "BookId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MemberBooks");

            migrationBuilder.CreateTable(
                name: "LoanedBook",
                columns: table => new
                {
                    Member_Id = table.Column<int>(nullable: false),
                    Book_Id = table.Column<int>(nullable: false),
                    LoanedTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanedBook", x => new { x.Member_Id, x.Book_Id });
                    table.ForeignKey(
                        name: "FK_LoanedBook_Books_Book_Id",
                        column: x => x.Book_Id,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LoanedBook_Members_Member_Id",
                        column: x => x.Member_Id,
                        principalTable: "Members",
                        principalColumn: "Member_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LoanedBook_Book_Id",
                table: "LoanedBook",
                column: "Book_Id");
        }
    }
}
