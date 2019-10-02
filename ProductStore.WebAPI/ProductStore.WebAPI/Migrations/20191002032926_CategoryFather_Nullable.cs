using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductStore.WebAPI.Migrations
{
    public partial class CategoryFather_Nullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CATEGORIA_PAI_ID",
                table: "TB_CATEGORIA",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(int),
                oldMaxLength: 50);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CATEGORIA_PAI_ID",
                table: "TB_CATEGORIA",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(int),
                oldMaxLength: 50,
                oldNullable: true);
        }
    }
}
