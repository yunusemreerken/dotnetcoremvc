using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Migrations
{
    public partial class manytomanyTry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LoanedBook_Members_Book_Id",
                table: "LoanedBook");

            migrationBuilder.DropForeignKey(
                name: "FK_LoanedBook_Books_Member_Id",
                table: "LoanedBook");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LoanedBook",
                table: "LoanedBook");

            migrationBuilder.DropIndex(
                name: "IX_LoanedBook_Member_Id",
                table: "LoanedBook");

            migrationBuilder.AddColumn<DateTime>(
                name: "LoanedTime",
                table: "LoanedBook",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_LoanedBook",
                table: "LoanedBook",
                columns: new[] { "Member_Id", "Book_Id" });

            migrationBuilder.CreateIndex(
                name: "IX_LoanedBook_Book_Id",
                table: "LoanedBook",
                column: "Book_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LoanedBook_Books_Book_Id",
                table: "LoanedBook",
                column: "Book_Id",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LoanedBook_Members_Member_Id",
                table: "LoanedBook",
                column: "Member_Id",
                principalTable: "Members",
                principalColumn: "Member_Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LoanedBook_Books_Book_Id",
                table: "LoanedBook");

            migrationBuilder.DropForeignKey(
                name: "FK_LoanedBook_Members_Member_Id",
                table: "LoanedBook");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LoanedBook",
                table: "LoanedBook");

            migrationBuilder.DropIndex(
                name: "IX_LoanedBook_Book_Id",
                table: "LoanedBook");

            migrationBuilder.DropColumn(
                name: "LoanedTime",
                table: "LoanedBook");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LoanedBook",
                table: "LoanedBook",
                columns: new[] { "Book_Id", "Member_Id" });

            migrationBuilder.CreateIndex(
                name: "IX_LoanedBook_Member_Id",
                table: "LoanedBook",
                column: "Member_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LoanedBook_Members_Book_Id",
                table: "LoanedBook",
                column: "Book_Id",
                principalTable: "Members",
                principalColumn: "Member_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LoanedBook_Books_Member_Id",
                table: "LoanedBook",
                column: "Member_Id",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
