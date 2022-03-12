using Microsoft.EntityFrameworkCore.Migrations;

namespace Business.Migrations
{
    public partial class addedOrganiser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Organiser",
                table: "Events",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Organiser",
                table: "Events");
        }
    }
}
