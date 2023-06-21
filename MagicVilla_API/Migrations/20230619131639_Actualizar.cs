using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_API.Migrations
{
    /// <inheritdoc />
    public partial class Actualizar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Detalle", "FechaActualizacion", "FechaCreacion", "MetrosCuadrados", "Ocupantes" },
                values: new object[] { "Detalle de la Real...", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 150, 4 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenidad", "Detalle", "FechaActualizacion", "FechaCreacion", "ImagenUrl", "MetrosCuadrados", "Nombre", "Ocupantes", "Tarifa" },
                values: new object[] { 3, "", "Detalle de la Villa...", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", 150, "Villa Rodrigo", 5, 0.0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Detalle", "FechaActualizacion", "FechaCreacion", "MetrosCuadrados", "Ocupantes" },
                values: new object[] { "Detalle de la Villa...", new DateTime(2023, 5, 31, 11, 42, 55, 79, DateTimeKind.Local).AddTicks(6799), new DateTime(2023, 5, 31, 11, 42, 55, 79, DateTimeKind.Local).AddTicks(6743), 200, 5 });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2023, 5, 31, 11, 42, 55, 79, DateTimeKind.Local).AddTicks(6808), new DateTime(2023, 5, 31, 11, 42, 55, 79, DateTimeKind.Local).AddTicks(6806) });
        }
    }
}
