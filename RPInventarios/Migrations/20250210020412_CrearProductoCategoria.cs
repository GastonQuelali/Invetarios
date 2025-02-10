using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RPInventarios.Migrations
{
    public partial class CrearProductoCategoria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categoria_Categoria_CategoriaIdPadre",
                table: "Categoria");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductoCategoria_Categoria_CategoriaId",
                table: "ProductoCategoria");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductoCategoria_Producto_ProductoId",
                table: "ProductoCategoria");

            migrationBuilder.AddForeignKey(
                name: "FK_Categoria_Categoria_CategoriaIdPadre",
                table: "Categoria",
                column: "CategoriaIdPadre",
                principalTable: "Categoria",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductoCategoria_Categoria_CategoriaId",
                table: "ProductoCategoria",
                column: "CategoriaId",
                principalTable: "Categoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductoCategoria_Producto_ProductoId",
                table: "ProductoCategoria",
                column: "ProductoId",
                principalTable: "Producto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categoria_Categoria_CategoriaIdPadre",
                table: "Categoria");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductoCategoria_Categoria_CategoriaId",
                table: "ProductoCategoria");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductoCategoria_Producto_ProductoId",
                table: "ProductoCategoria");

            migrationBuilder.AddForeignKey(
                name: "FK_Categoria_Categoria_CategoriaIdPadre",
                table: "Categoria",
                column: "CategoriaIdPadre",
                principalTable: "Categoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductoCategoria_Categoria_CategoriaId",
                table: "ProductoCategoria",
                column: "CategoriaId",
                principalTable: "Categoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductoCategoria_Producto_ProductoId",
                table: "ProductoCategoria",
                column: "ProductoId",
                principalTable: "Producto",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
