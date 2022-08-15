using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class blogmodified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserAdminId",
                table: "Blogs",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_UserAdminId",
                table: "Blogs",
                column: "UserAdminId");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_AspNetUsers_UserAdminId",
                table: "Blogs",
                column: "UserAdminId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_AspNetUsers_UserAdminId",
                table: "Blogs");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_UserAdminId",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "UserAdminId",
                table: "Blogs");
        }
    }
}
