using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductStore.WebAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_CATEGORIA",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NOME = table.Column<string>(maxLength: 15, nullable: false),
                    DESCRICAO = table.Column<string>(maxLength: 50, nullable: true),
                    CATEGORIA_PAI_ID = table.Column<int>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_CATEGORIA", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_CATEGORIA_TB_CATEGORIA_CATEGORIA_PAI_ID",
                        column: x => x.CATEGORIA_PAI_ID,
                        principalTable: "TB_CATEGORIA",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TB_PRODUTO",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NOME = table.Column<string>(maxLength: 30, nullable: false),
                    DESCRICAO = table.Column<string>(maxLength: 200, nullable: false),
                    PRECO = table.Column<decimal>(nullable: false),
                    ESTOQUE = table.Column<int>(nullable: false),
                    CATEGORIA_ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_PRODUTO", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_PRODUTO_TB_CATEGORIA_CATEGORIA_ID",
                        column: x => x.CATEGORIA_ID,
                        principalTable: "TB_CATEGORIA",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TB_DOCUMENTO",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NOME = table.Column<string>(maxLength: 50, nullable: false),
                    ARQUIVO = table.Column<byte[]>(nullable: false),
                    ProductId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_DOCUMENTO", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_DOCUMENTO_TB_PRODUTO_ProductId",
                        column: x => x.ProductId,
                        principalTable: "TB_PRODUTO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_CATEGORIA_CATEGORIA_PAI_ID",
                table: "TB_CATEGORIA",
                column: "CATEGORIA_PAI_ID");

            migrationBuilder.CreateIndex(
                name: "IX_TB_DOCUMENTO_ProductId",
                table: "TB_DOCUMENTO",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_PRODUTO_CATEGORIA_ID",
                table: "TB_PRODUTO",
                column: "CATEGORIA_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_DOCUMENTO");

            migrationBuilder.DropTable(
                name: "TB_PRODUTO");

            migrationBuilder.DropTable(
                name: "TB_CATEGORIA");
        }
    }
}
