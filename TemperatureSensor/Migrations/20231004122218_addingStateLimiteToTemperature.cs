using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TemperatureSensor.Migrations
{
    public partial class addingStateLimiteToTemperature : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "StateLimits",
                newName: "StateLimitsId");

            migrationBuilder.AddColumn<int>(
                name: "StateLimitId",
                table: "TemperatureInfos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TemperatureInfos_StateLimitId",
                table: "TemperatureInfos",
                column: "StateLimitId");

            migrationBuilder.AddForeignKey(
                name: "FK_TemperatureInfos_StateLimits_StateLimitId",
                table: "TemperatureInfos",
                column: "StateLimitId",
                principalTable: "StateLimits",
                principalColumn: "StateLimitsId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TemperatureInfos_StateLimits_StateLimitId",
                table: "TemperatureInfos");

            migrationBuilder.DropIndex(
                name: "IX_TemperatureInfos_StateLimitId",
                table: "TemperatureInfos");

            migrationBuilder.DropColumn(
                name: "StateLimitId",
                table: "TemperatureInfos");

            migrationBuilder.RenameColumn(
                name: "StateLimitsId",
                table: "StateLimits",
                newName: "Id");
        }
    }
}
