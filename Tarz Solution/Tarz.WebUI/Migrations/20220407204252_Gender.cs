using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Tarz.WebUI.Migrations
{
    public partial class Gender : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductSizeColorPrice_Colors_ColorId",
                table: "ProductSizeColorPrice");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSizeColorPrice_Products_ProductId",
                table: "ProductSizeColorPrice");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSizeColorPrice_Sizes_ProductSizeId",
                table: "ProductSizeColorPrice");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductSizeColorPrice",
                table: "ProductSizeColorPrice");

            migrationBuilder.RenameTable(
                name: "ProductSizeColorPrice",
                newName: "ProductSizeColorPrices");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSizeColorPrice_ProductSizeId",
                table: "ProductSizeColorPrices",
                newName: "IX_ProductSizeColorPrices_ProductSizeId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSizeColorPrice_ProductId",
                table: "ProductSizeColorPrices",
                newName: "IX_ProductSizeColorPrices_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSizeColorPrice_ColorId",
                table: "ProductSizeColorPrices",
                newName: "IX_ProductSizeColorPrices_ColorId");

            migrationBuilder.AddColumn<int>(
                name: "GenderId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GenderId",
                table: "ProductSizeColorPrices",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductSizeColorPrices",
                table: "ProductSizeColorPrices",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedByUserId = table.Column<int>(type: "int", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_GenderId",
                table: "Products",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSizeColorPrices_GenderId",
                table: "ProductSizeColorPrices",
                column: "GenderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Genders_GenderId",
                table: "Products",
                column: "GenderId",
                principalTable: "Genders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSizeColorPrices_Colors_ColorId",
                table: "ProductSizeColorPrices",
                column: "ColorId",
                principalTable: "Colors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSizeColorPrices_Genders_GenderId",
                table: "ProductSizeColorPrices",
                column: "GenderId",
                principalTable: "Genders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSizeColorPrices_Products_ProductId",
                table: "ProductSizeColorPrices",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSizeColorPrices_Sizes_ProductSizeId",
                table: "ProductSizeColorPrices",
                column: "ProductSizeId",
                principalTable: "Sizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Genders_GenderId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSizeColorPrices_Colors_ColorId",
                table: "ProductSizeColorPrices");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSizeColorPrices_Genders_GenderId",
                table: "ProductSizeColorPrices");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSizeColorPrices_Products_ProductId",
                table: "ProductSizeColorPrices");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSizeColorPrices_Sizes_ProductSizeId",
                table: "ProductSizeColorPrices");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropIndex(
                name: "IX_Products_GenderId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductSizeColorPrices",
                table: "ProductSizeColorPrices");

            migrationBuilder.DropIndex(
                name: "IX_ProductSizeColorPrices_GenderId",
                table: "ProductSizeColorPrices");

            migrationBuilder.DropColumn(
                name: "GenderId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "GenderId",
                table: "ProductSizeColorPrices");

            migrationBuilder.RenameTable(
                name: "ProductSizeColorPrices",
                newName: "ProductSizeColorPrice");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSizeColorPrices_ProductSizeId",
                table: "ProductSizeColorPrice",
                newName: "IX_ProductSizeColorPrice_ProductSizeId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSizeColorPrices_ProductId",
                table: "ProductSizeColorPrice",
                newName: "IX_ProductSizeColorPrice_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSizeColorPrices_ColorId",
                table: "ProductSizeColorPrice",
                newName: "IX_ProductSizeColorPrice_ColorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductSizeColorPrice",
                table: "ProductSizeColorPrice",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSizeColorPrice_Colors_ColorId",
                table: "ProductSizeColorPrice",
                column: "ColorId",
                principalTable: "Colors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSizeColorPrice_Products_ProductId",
                table: "ProductSizeColorPrice",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSizeColorPrice_Sizes_ProductSizeId",
                table: "ProductSizeColorPrice",
                column: "ProductSizeId",
                principalTable: "Sizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
