using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoV2.Data.Migrations
{
    public partial class soft_delete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Todos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "People",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Todos");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "People");
        }
    }
}
