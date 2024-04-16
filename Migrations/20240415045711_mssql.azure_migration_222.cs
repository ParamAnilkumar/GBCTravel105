using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GBCTravel105.Migrations
{
    /// <inheritdoc />
    public partial class mssqlazure_migration_222 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: 1,
                column: "BookingDate",
                value: new DateOnly(2024, 4, 15));

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 4, 16, 6, 57, 10, 757, DateTimeKind.Local).AddTicks(1192), new DateTime(2024, 4, 15, 0, 57, 10, 757, DateTimeKind.Local).AddTicks(1189) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 4, 16, 14, 57, 10, 757, DateTimeKind.Local).AddTicks(1207), new DateTime(2024, 4, 16, 0, 57, 10, 757, DateTimeKind.Local).AddTicks(1204) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 4, 17, 10, 57, 10, 757, DateTimeKind.Local).AddTicks(1212), new DateTime(2024, 4, 17, 0, 57, 10, 757, DateTimeKind.Local).AddTicks(1210) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 4, 18, 12, 57, 10, 757, DateTimeKind.Local).AddTicks(1216), new DateTime(2024, 4, 18, 0, 57, 10, 757, DateTimeKind.Local).AddTicks(1214) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 4, 19, 16, 57, 10, 757, DateTimeKind.Local).AddTicks(1220), new DateTime(2024, 4, 19, 0, 57, 10, 757, DateTimeKind.Local).AddTicks(1218) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 4, 16, 6, 57, 10, 757, DateTimeKind.Local).AddTicks(1201), new DateTime(2024, 4, 15, 0, 57, 10, 757, DateTimeKind.Local).AddTicks(1200) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 4, 16, 6, 57, 10, 757, DateTimeKind.Local).AddTicks(1224), new DateTime(2024, 4, 15, 0, 57, 10, 757, DateTimeKind.Local).AddTicks(1222) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 4, 16, 14, 57, 10, 757, DateTimeKind.Local).AddTicks(1228), new DateTime(2024, 4, 16, 0, 57, 10, 757, DateTimeKind.Local).AddTicks(1227) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 4, 17, 10, 57, 10, 757, DateTimeKind.Local).AddTicks(1232), new DateTime(2024, 4, 17, 0, 57, 10, 757, DateTimeKind.Local).AddTicks(1231) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 4, 18, 12, 57, 10, 757, DateTimeKind.Local).AddTicks(1236), new DateTime(2024, 4, 18, 0, 57, 10, 757, DateTimeKind.Local).AddTicks(1235) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 4, 19, 16, 57, 10, 757, DateTimeKind.Local).AddTicks(1240), new DateTime(2024, 4, 19, 0, 57, 10, 757, DateTimeKind.Local).AddTicks(1239) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 4, 16, 6, 57, 10, 757, DateTimeKind.Local).AddTicks(1244), new DateTime(2024, 4, 15, 0, 57, 10, 757, DateTimeKind.Local).AddTicks(1243) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 4, 20, 12, 57, 10, 757, DateTimeKind.Local).AddTicks(1248), new DateTime(2024, 4, 20, 0, 57, 10, 757, DateTimeKind.Local).AddTicks(1247) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 4, 21, 13, 57, 10, 757, DateTimeKind.Local).AddTicks(1253), new DateTime(2024, 4, 21, 0, 57, 10, 757, DateTimeKind.Local).AddTicks(1251) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 4, 22, 2, 57, 10, 757, DateTimeKind.Local).AddTicks(1257), new DateTime(2024, 4, 22, 0, 57, 10, 757, DateTimeKind.Local).AddTicks(1256) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 4, 23, 6, 57, 10, 757, DateTimeKind.Local).AddTicks(1261), new DateTime(2024, 4, 23, 0, 57, 10, 757, DateTimeKind.Local).AddTicks(1260) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 4, 24, 4, 57, 10, 757, DateTimeKind.Local).AddTicks(1266), new DateTime(2024, 4, 24, 0, 57, 10, 757, DateTimeKind.Local).AddTicks(1264) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 4, 25, 8, 57, 10, 757, DateTimeKind.Local).AddTicks(1270), new DateTime(2024, 4, 25, 0, 57, 10, 757, DateTimeKind.Local).AddTicks(1268) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 4, 26, 4, 57, 10, 757, DateTimeKind.Local).AddTicks(1274), new DateTime(2024, 4, 26, 0, 57, 10, 757, DateTimeKind.Local).AddTicks(1272) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 4, 27, 9, 57, 10, 757, DateTimeKind.Local).AddTicks(1278), new DateTime(2024, 4, 27, 0, 57, 10, 757, DateTimeKind.Local).AddTicks(1276) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 4, 29, 0, 57, 10, 757, DateTimeKind.Local).AddTicks(1282), new DateTime(2024, 4, 28, 0, 57, 10, 757, DateTimeKind.Local).AddTicks(1280) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 4, 29, 11, 57, 10, 757, DateTimeKind.Local).AddTicks(1286), new DateTime(2024, 4, 29, 0, 57, 10, 757, DateTimeKind.Local).AddTicks(1284) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 4, 30, 10, 57, 10, 757, DateTimeKind.Local).AddTicks(1290), new DateTime(2024, 4, 30, 0, 57, 10, 757, DateTimeKind.Local).AddTicks(1289) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 5, 1, 9, 57, 10, 757, DateTimeKind.Local).AddTicks(1294), new DateTime(2024, 5, 1, 0, 57, 10, 757, DateTimeKind.Local).AddTicks(1293) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 5, 2, 1, 57, 10, 757, DateTimeKind.Local).AddTicks(1298), new DateTime(2024, 5, 2, 0, 57, 10, 757, DateTimeKind.Local).AddTicks(1297) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: 1,
                column: "BookingDate",
                value: new DateOnly(2024, 4, 14));

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 4, 16, 4, 54, 43, 607, DateTimeKind.Local).AddTicks(9324), new DateTime(2024, 4, 14, 22, 54, 43, 607, DateTimeKind.Local).AddTicks(9318) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 4, 16, 12, 54, 43, 607, DateTimeKind.Local).AddTicks(9341), new DateTime(2024, 4, 15, 22, 54, 43, 607, DateTimeKind.Local).AddTicks(9338) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 4, 17, 8, 54, 43, 607, DateTimeKind.Local).AddTicks(9346), new DateTime(2024, 4, 16, 22, 54, 43, 607, DateTimeKind.Local).AddTicks(9344) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 4, 18, 10, 54, 43, 607, DateTimeKind.Local).AddTicks(9350), new DateTime(2024, 4, 17, 22, 54, 43, 607, DateTimeKind.Local).AddTicks(9348) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 4, 19, 14, 54, 43, 607, DateTimeKind.Local).AddTicks(9355), new DateTime(2024, 4, 18, 22, 54, 43, 607, DateTimeKind.Local).AddTicks(9353) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 4, 16, 4, 54, 43, 607, DateTimeKind.Local).AddTicks(9335), new DateTime(2024, 4, 14, 22, 54, 43, 607, DateTimeKind.Local).AddTicks(9333) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 4, 16, 4, 54, 43, 607, DateTimeKind.Local).AddTicks(9360), new DateTime(2024, 4, 14, 22, 54, 43, 607, DateTimeKind.Local).AddTicks(9358) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 4, 16, 12, 54, 43, 607, DateTimeKind.Local).AddTicks(9364), new DateTime(2024, 4, 15, 22, 54, 43, 607, DateTimeKind.Local).AddTicks(9362) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 4, 17, 8, 54, 43, 607, DateTimeKind.Local).AddTicks(9369), new DateTime(2024, 4, 16, 22, 54, 43, 607, DateTimeKind.Local).AddTicks(9367) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 4, 18, 10, 54, 43, 607, DateTimeKind.Local).AddTicks(9374), new DateTime(2024, 4, 17, 22, 54, 43, 607, DateTimeKind.Local).AddTicks(9372) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 4, 19, 14, 54, 43, 607, DateTimeKind.Local).AddTicks(9378), new DateTime(2024, 4, 18, 22, 54, 43, 607, DateTimeKind.Local).AddTicks(9377) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 4, 16, 4, 54, 43, 607, DateTimeKind.Local).AddTicks(9382), new DateTime(2024, 4, 14, 22, 54, 43, 607, DateTimeKind.Local).AddTicks(9381) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 4, 20, 10, 54, 43, 607, DateTimeKind.Local).AddTicks(9387), new DateTime(2024, 4, 19, 22, 54, 43, 607, DateTimeKind.Local).AddTicks(9385) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 4, 21, 11, 54, 43, 607, DateTimeKind.Local).AddTicks(9392), new DateTime(2024, 4, 20, 22, 54, 43, 607, DateTimeKind.Local).AddTicks(9390) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 4, 22, 0, 54, 43, 607, DateTimeKind.Local).AddTicks(9397), new DateTime(2024, 4, 21, 22, 54, 43, 607, DateTimeKind.Local).AddTicks(9395) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 4, 23, 4, 54, 43, 607, DateTimeKind.Local).AddTicks(9402), new DateTime(2024, 4, 22, 22, 54, 43, 607, DateTimeKind.Local).AddTicks(9400) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 4, 24, 2, 54, 43, 607, DateTimeKind.Local).AddTicks(9407), new DateTime(2024, 4, 23, 22, 54, 43, 607, DateTimeKind.Local).AddTicks(9405) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 4, 25, 6, 54, 43, 607, DateTimeKind.Local).AddTicks(9413), new DateTime(2024, 4, 24, 22, 54, 43, 607, DateTimeKind.Local).AddTicks(9410) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 4, 26, 2, 54, 43, 607, DateTimeKind.Local).AddTicks(9417), new DateTime(2024, 4, 25, 22, 54, 43, 607, DateTimeKind.Local).AddTicks(9415) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 4, 27, 7, 54, 43, 607, DateTimeKind.Local).AddTicks(9422), new DateTime(2024, 4, 26, 22, 54, 43, 607, DateTimeKind.Local).AddTicks(9420) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 4, 28, 22, 54, 43, 607, DateTimeKind.Local).AddTicks(9426), new DateTime(2024, 4, 27, 22, 54, 43, 607, DateTimeKind.Local).AddTicks(9425) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 4, 29, 9, 54, 43, 607, DateTimeKind.Local).AddTicks(9431), new DateTime(2024, 4, 28, 22, 54, 43, 607, DateTimeKind.Local).AddTicks(9429) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 4, 30, 8, 54, 43, 607, DateTimeKind.Local).AddTicks(9435), new DateTime(2024, 4, 29, 22, 54, 43, 607, DateTimeKind.Local).AddTicks(9434) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 5, 1, 7, 54, 43, 607, DateTimeKind.Local).AddTicks(9440), new DateTime(2024, 4, 30, 22, 54, 43, 607, DateTimeKind.Local).AddTicks(9438) });

            migrationBuilder.UpdateData(
                table: "Flight",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ArrivalTime", "DepartureTime" },
                values: new object[] { new DateTime(2024, 5, 1, 23, 54, 43, 607, DateTimeKind.Local).AddTicks(9444), new DateTime(2024, 5, 1, 22, 54, 43, 607, DateTimeKind.Local).AddTicks(9443) });
        }
    }
}
