using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Migrations
{
    public partial class memberbooks2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MemberBooks_Books_BookId",
                table: "MemberBooks");

            migrationBuilder.DropIndex(
                name: "IX_MemberBooks_BookId",
                table: "MemberBooks");

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "MemberBooks");

            migrationBuilder.AlterColumn<string>(
                name: "LoanedTime",
                table: "MemberBooks",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.CreateIndex(
                name: "IX_MemberBooks_Book_Id",
                table: "MemberBooks",
                column: "Book_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MemberBooks_Books_Book_Id",
                table: "MemberBooks",
                column: "Book_Id",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MemberBooks_Books_Book_Id",
                table: "MemberBooks");

            migrationBuilder.DropIndex(
                name: "IX_MemberBooks_Book_Id",
                table: "MemberBooks");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LoanedTime",
                table: "MemberBooks",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "MemberBooks",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MemberBooks_BookId",
                table: "MemberBooks",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_MemberBooks_Books_BookId",
                table: "MemberBooks",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
