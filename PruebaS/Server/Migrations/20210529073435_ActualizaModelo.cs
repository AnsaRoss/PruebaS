using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PruebaS.Server.Migrations
{
    public partial class ActualizaModelo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descripcion",
                table: "HistoriaProducto");

            migrationBuilder.DropColumn(
                name: "Marca",
                table: "HistoriaProducto");

            migrationBuilder.DropColumn(
                name: "Medida",
                table: "HistoriaProducto");

            migrationBuilder.AlterColumn<decimal>(
                name: "PrecioUnitario",
                table: "Producto",
                type: "decimal(9,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,0)");

            migrationBuilder.AddColumn<DateTime>(
                name: "fechaRegistro",
                table: "HistoriaProducto",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "fechaRegistro",
                table: "HistoriaProducto");

            migrationBuilder.AlterColumn<decimal>(
                name: "PrecioUnitario",
                table: "Producto",
                type: "decimal(18,0)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(9,2)");

            migrationBuilder.AddColumn<string>(
                name: "Descripcion",
                table: "HistoriaProducto",
                type: "varchar(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Marca",
                table: "HistoriaProducto",
                type: "varchar(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Medida",
                table: "HistoriaProducto",
                type: "varchar(15)",
                nullable: false,
                defaultValue: "");
        }
    }
}
