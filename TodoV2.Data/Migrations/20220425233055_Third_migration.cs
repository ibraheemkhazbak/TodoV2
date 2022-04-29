using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoV2.Data.Migrations
{
    public partial class Third_migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_People_PersonId",
                table: "Todos");

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "Todos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_People_PersonId",
                table: "Todos",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_People_PersonId",
                table: "Todos");

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "Todos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_People_PersonId",
                table: "Todos",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
