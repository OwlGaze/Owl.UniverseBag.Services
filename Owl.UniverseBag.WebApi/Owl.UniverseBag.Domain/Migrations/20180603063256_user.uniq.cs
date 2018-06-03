using Microsoft.EntityFrameworkCore.Migrations;

namespace Owl.UniverseBag.Domain.Migrations
{
    public partial class useruniq : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "User",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(string));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "User",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 11);
        }
    }
}
