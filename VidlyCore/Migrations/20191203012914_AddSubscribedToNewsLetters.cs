using Microsoft.EntityFrameworkCore.Migrations;

namespace VidlyCore.Migrations
{
    public partial class AddSubscribedToNewsLetters : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsSubscribedToNewsLetters",
                table: "Customers",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsSubscribedToNewsLetters",
                table: "Customers");
        }
    }
}
