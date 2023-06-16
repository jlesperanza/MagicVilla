using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla_API.Migrations
{
    /// <inheritdoc />
    public partial class AlimentaTablaVilla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenidad", "Detalle", "FechaActualizacion", "FechaCreacion", "ImagenUrl", "MetrosCuadrados", "Nombre", "Ocupantes", "Tarifa" },
                values: new object[,]
                {
                    { 1, "", "Detalle de la Villa...", new DateTime(2023, 5, 31, 11, 42, 55, 79, DateTimeKind.Local).AddTicks(6799), new DateTime(2023, 5, 31, 11, 42, 55, 79, DateTimeKind.Local).AddTicks(6743), "", 200, "Villa Real", 5, 0.0 },
                    { 2, "", "Detalle de la Villa...", new DateTime(2023, 5, 31, 11, 42, 55, 79, DateTimeKind.Local).AddTicks(6808), new DateTime(2023, 5, 31, 11, 42, 55, 79, DateTimeKind.Local).AddTicks(6806), "", 150, "Villa Grande", 4, 0.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
