using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TemperatureSensor.Migrations
{
    public partial class SeedingDataInTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "StateLimits",
                columns: new[] { "StateLimitsId", "Name", "Value" },
                values: new object[] { 1, "COLD", 19 });

            migrationBuilder.InsertData(
                table: "StateLimits",
                columns: new[] { "StateLimitsId", "Name", "Value" },
                values: new object[] { 2, "WARM", 30 });

            migrationBuilder.InsertData(
                table: "StateLimits",
                columns: new[] { "StateLimitsId", "Name", "Value" },
                values: new object[] { 3, "HOT", 30 });

            migrationBuilder.InsertData(
                table: "TemperatureInfos",
                columns: new[] { "Id", "Date", "State", "Temperature" },
                values: new object[] { 1, new DateTime(2023, 10, 4, 15, 3, 8, 379, DateTimeKind.Local).AddTicks(3261), "COLD", 18 });

            migrationBuilder.InsertData(
                table: "TemperatureInfos",
                columns: new[] { "Id", "Date", "State", "Temperature" },
                values: new object[] { 2, new DateTime(2023, 10, 4, 15, 3, 8, 379, DateTimeKind.Local).AddTicks(3303), "WARM", 24 });

            migrationBuilder.InsertData(
                table: "TemperatureInfos",
                columns: new[] { "Id", "Date", "State", "Temperature" },
                values: new object[] { 3, new DateTime(2023, 10, 4, 15, 3, 8, 379, DateTimeKind.Local).AddTicks(3305), "WARM", 30 });

            migrationBuilder.InsertData(
                table: "TemperatureInfos",
                columns: new[] { "Id", "Date", "State", "Temperature" },
                values: new object[] { 4, new DateTime(2023, 10, 4, 15, 3, 8, 379, DateTimeKind.Local).AddTicks(3308), "WARM", 26 });

            migrationBuilder.InsertData(
                table: "TemperatureInfos",
                columns: new[] { "Id", "Date", "State", "Temperature" },
                values: new object[] { 5, new DateTime(2023, 10, 4, 15, 3, 8, 379, DateTimeKind.Local).AddTicks(3309), "HOT", 34 });

            migrationBuilder.InsertData(
                table: "TemperatureInfos",
                columns: new[] { "Id", "Date", "State", "Temperature" },
                values: new object[] { 6, new DateTime(2023, 10, 4, 15, 3, 8, 379, DateTimeKind.Local).AddTicks(3311), "WARM", 24 });

            migrationBuilder.InsertData(
                table: "TemperatureInfos",
                columns: new[] { "Id", "Date", "State", "Temperature" },
                values: new object[] { 7, new DateTime(2023, 10, 4, 15, 3, 8, 379, DateTimeKind.Local).AddTicks(3313), "WARM", 30 });

            migrationBuilder.InsertData(
                table: "TemperatureInfos",
                columns: new[] { "Id", "Date", "State", "Temperature" },
                values: new object[] { 8, new DateTime(2023, 10, 4, 15, 3, 8, 379, DateTimeKind.Local).AddTicks(3316), "WARM", 26 });

            migrationBuilder.InsertData(
                table: "TemperatureInfos",
                columns: new[] { "Id", "Date", "State", "Temperature" },
                values: new object[] { 9, new DateTime(2023, 10, 4, 15, 3, 8, 379, DateTimeKind.Local).AddTicks(3318), "HOT", 34 });

            migrationBuilder.InsertData(
                table: "TemperatureInfos",
                columns: new[] { "Id", "Date", "State", "Temperature" },
                values: new object[] { 10, new DateTime(2023, 10, 4, 15, 3, 8, 379, DateTimeKind.Local).AddTicks(3320), "COLD", 8 });

            migrationBuilder.InsertData(
                table: "TemperatureInfos",
                columns: new[] { "Id", "Date", "State", "Temperature" },
                values: new object[] { 11, new DateTime(2023, 10, 4, 15, 3, 8, 379, DateTimeKind.Local).AddTicks(3321), "COLD", 18 });

            migrationBuilder.InsertData(
                table: "TemperatureInfos",
                columns: new[] { "Id", "Date", "State", "Temperature" },
                values: new object[] { 12, new DateTime(2023, 10, 4, 15, 3, 8, 379, DateTimeKind.Local).AddTicks(3324), "WARM", 24 });

            migrationBuilder.InsertData(
                table: "TemperatureInfos",
                columns: new[] { "Id", "Date", "State", "Temperature" },
                values: new object[] { 13, new DateTime(2023, 10, 4, 15, 3, 8, 379, DateTimeKind.Local).AddTicks(3326), "WARM", 30 });

            migrationBuilder.InsertData(
                table: "TemperatureInfos",
                columns: new[] { "Id", "Date", "State", "Temperature" },
                values: new object[] { 14, new DateTime(2023, 10, 4, 15, 3, 8, 379, DateTimeKind.Local).AddTicks(3328), "WARM", 26 });

            migrationBuilder.InsertData(
                table: "TemperatureInfos",
                columns: new[] { "Id", "Date", "State", "Temperature" },
                values: new object[] { 15, new DateTime(2023, 10, 4, 15, 3, 8, 379, DateTimeKind.Local).AddTicks(3330), "HOT", 34 });

            migrationBuilder.InsertData(
                table: "TemperatureInfos",
                columns: new[] { "Id", "Date", "State", "Temperature" },
                values: new object[] { 16, new DateTime(2023, 10, 4, 15, 3, 8, 379, DateTimeKind.Local).AddTicks(3332), "COLD", 18 });

            migrationBuilder.InsertData(
                table: "TemperatureInfos",
                columns: new[] { "Id", "Date", "State", "Temperature" },
                values: new object[] { 17, new DateTime(2023, 10, 4, 15, 3, 8, 379, DateTimeKind.Local).AddTicks(3334), "COLD", 2 });

            migrationBuilder.InsertData(
                table: "TemperatureInfos",
                columns: new[] { "Id", "Date", "State", "Temperature" },
                values: new object[] { 18, new DateTime(2023, 10, 4, 15, 3, 8, 379, DateTimeKind.Local).AddTicks(3336), "COLD", 6 });

            migrationBuilder.InsertData(
                table: "TemperatureInfos",
                columns: new[] { "Id", "Date", "State", "Temperature" },
                values: new object[] { 19, new DateTime(2023, 10, 4, 15, 3, 8, 379, DateTimeKind.Local).AddTicks(3338), "HOT", 40 });

            migrationBuilder.InsertData(
                table: "TemperatureInfos",
                columns: new[] { "Id", "Date", "State", "Temperature" },
                values: new object[] { 20, new DateTime(2023, 10, 4, 15, 3, 8, 379, DateTimeKind.Local).AddTicks(3339), "WARM", 25 });

            migrationBuilder.InsertData(
                table: "TemperatureInfos",
                columns: new[] { "Id", "Date", "State", "Temperature" },
                values: new object[] { 21, new DateTime(2023, 10, 4, 15, 3, 8, 379, DateTimeKind.Local).AddTicks(3341), "COLD", 18 });

            migrationBuilder.InsertData(
                table: "TemperatureInfos",
                columns: new[] { "Id", "Date", "State", "Temperature" },
                values: new object[] { 22, new DateTime(2023, 10, 4, 15, 3, 8, 379, DateTimeKind.Local).AddTicks(3343), "HOT", 47 });

            migrationBuilder.InsertData(
                table: "TemperatureInfos",
                columns: new[] { "Id", "Date", "State", "Temperature" },
                values: new object[] { 23, new DateTime(2023, 10, 4, 15, 3, 8, 379, DateTimeKind.Local).AddTicks(3345), "HOT", 38 });

            migrationBuilder.InsertData(
                table: "TemperatureInfos",
                columns: new[] { "Id", "Date", "State", "Temperature" },
                values: new object[] { 24, new DateTime(2023, 10, 4, 15, 3, 8, 379, DateTimeKind.Local).AddTicks(3347), "COLD", 14 });

            migrationBuilder.InsertData(
                table: "TemperatureInfos",
                columns: new[] { "Id", "Date", "State", "Temperature" },
                values: new object[] { 25, new DateTime(2023, 10, 4, 15, 3, 8, 379, DateTimeKind.Local).AddTicks(3349), "COLD", 15 });

            migrationBuilder.InsertData(
                table: "TemperatureInfos",
                columns: new[] { "Id", "Date", "State", "Temperature" },
                values: new object[] { 26, new DateTime(2023, 10, 4, 15, 3, 8, 379, DateTimeKind.Local).AddTicks(3351), "HOT", 36 });

            migrationBuilder.InsertData(
                table: "TemperatureInfos",
                columns: new[] { "Id", "Date", "State", "Temperature" },
                values: new object[] { 27, new DateTime(2023, 10, 4, 15, 3, 8, 379, DateTimeKind.Local).AddTicks(3353), "COLD", 18 });

            migrationBuilder.InsertData(
                table: "TemperatureInfos",
                columns: new[] { "Id", "Date", "State", "Temperature" },
                values: new object[] { 28, new DateTime(2023, 10, 4, 15, 3, 8, 379, DateTimeKind.Local).AddTicks(3355), "WARM", 27 });

            migrationBuilder.InsertData(
                table: "TemperatureInfos",
                columns: new[] { "Id", "Date", "State", "Temperature" },
                values: new object[] { 29, new DateTime(2023, 10, 4, 15, 3, 8, 379, DateTimeKind.Local).AddTicks(3356), "HOT", 50 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StateLimits",
                keyColumn: "StateLimitsId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StateLimits",
                keyColumn: "StateLimitsId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "StateLimits",
                keyColumn: "StateLimitsId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TemperatureInfos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TemperatureInfos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TemperatureInfos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TemperatureInfos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TemperatureInfos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TemperatureInfos",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TemperatureInfos",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TemperatureInfos",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TemperatureInfos",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TemperatureInfos",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TemperatureInfos",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TemperatureInfos",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TemperatureInfos",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "TemperatureInfos",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "TemperatureInfos",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "TemperatureInfos",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "TemperatureInfos",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "TemperatureInfos",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "TemperatureInfos",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "TemperatureInfos",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "TemperatureInfos",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "TemperatureInfos",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "TemperatureInfos",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "TemperatureInfos",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "TemperatureInfos",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "TemperatureInfos",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "TemperatureInfos",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "TemperatureInfos",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "TemperatureInfos",
                keyColumn: "Id",
                keyValue: 29);
        }
    }
}
