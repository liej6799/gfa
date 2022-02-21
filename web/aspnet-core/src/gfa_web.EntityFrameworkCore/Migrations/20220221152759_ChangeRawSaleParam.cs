using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace gfa_web.Migrations
{
    public partial class ChangeRawSaleParam : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RawSaleItems_Items_ItemId",
                table: "RawSaleItems");

            migrationBuilder.DropForeignKey(
                name: "FK_RawSaleItems_RawSales_SaleId",
                table: "RawSaleItems");

            migrationBuilder.DropIndex(
                name: "IX_RawSaleItems_ItemId",
                table: "RawSaleItems");

            migrationBuilder.DropIndex(
                name: "IX_RawSaleItems_SaleId",
                table: "RawSaleItems");

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "RawSaleItems");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "RawSaleItems");

            migrationBuilder.DropColumn(
                name: "SaleId",
                table: "RawSaleItems");

            migrationBuilder.AddColumn<int>(
                name: "SourceItemId",
                table: "RawSaleItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SourceSaleId",
                table: "RawSaleItems",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SourceItemId",
                table: "RawSaleItems");

            migrationBuilder.DropColumn(
                name: "SourceSaleId",
                table: "RawSaleItems");

            migrationBuilder.AddColumn<Guid>(
                name: "ItemId",
                table: "RawSaleItems",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "RawSaleItems",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<Guid>(
                name: "SaleId",
                table: "RawSaleItems",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_RawSaleItems_ItemId",
                table: "RawSaleItems",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_RawSaleItems_SaleId",
                table: "RawSaleItems",
                column: "SaleId");

            migrationBuilder.AddForeignKey(
                name: "FK_RawSaleItems_Items_ItemId",
                table: "RawSaleItems",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RawSaleItems_RawSales_SaleId",
                table: "RawSaleItems",
                column: "SaleId",
                principalTable: "RawSales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
