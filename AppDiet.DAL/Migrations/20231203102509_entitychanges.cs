using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppDiet.DAL.Migrations
{
    public partial class entitychanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AksamYemegiBesin");

            migrationBuilder.DropTable(
                name: "AraOgunBesin");

            migrationBuilder.DropTable(
                name: "BesinKahvalti");

            migrationBuilder.DropTable(
                name: "BesinOgleYemegi");

            migrationBuilder.AddColumn<int>(
                name: "AksamYemegiID",
                table: "Besinler",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AraOgunID",
                table: "Besinler",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KahvaltiID",
                table: "Besinler",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OgleYemegiID",
                table: "Besinler",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 1, new DateTime(2023, 12, 3, 13, 25, 7, 344, DateTimeKind.Local).AddTicks(7630) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 1, new DateTime(2023, 12, 3, 13, 25, 7, 344, DateTimeKind.Local).AddTicks(7649) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 1, new DateTime(2023, 12, 3, 13, 25, 7, 344, DateTimeKind.Local).AddTicks(7651) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 1, new DateTime(2023, 12, 3, 13, 25, 7, 344, DateTimeKind.Local).AddTicks(7652) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 1, new DateTime(2023, 12, 3, 13, 25, 7, 344, DateTimeKind.Local).AddTicks(7655) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 1, new DateTime(2023, 12, 3, 13, 25, 7, 344, DateTimeKind.Local).AddTicks(7657) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 1, new DateTime(2023, 12, 3, 13, 25, 7, 344, DateTimeKind.Local).AddTicks(7658) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 1, new DateTime(2023, 12, 3, 13, 25, 7, 344, DateTimeKind.Local).AddTicks(7660) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 1, new DateTime(2023, 12, 3, 13, 25, 7, 344, DateTimeKind.Local).AddTicks(7661) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 1, new DateTime(2023, 12, 3, 13, 25, 7, 344, DateTimeKind.Local).AddTicks(7662) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 1, new DateTime(2023, 12, 3, 13, 25, 7, 344, DateTimeKind.Local).AddTicks(7664) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 1, new DateTime(2023, 12, 3, 13, 25, 7, 344, DateTimeKind.Local).AddTicks(7666) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 1, new DateTime(2023, 12, 3, 13, 25, 7, 344, DateTimeKind.Local).AddTicks(7668) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 1, new DateTime(2023, 12, 3, 13, 25, 7, 344, DateTimeKind.Local).AddTicks(7669) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 1, new DateTime(2023, 12, 3, 13, 25, 7, 344, DateTimeKind.Local).AddTicks(7670) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 1, new DateTime(2023, 12, 3, 13, 25, 7, 344, DateTimeKind.Local).AddTicks(7672) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 1, new DateTime(2023, 12, 3, 13, 25, 7, 344, DateTimeKind.Local).AddTicks(7673) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 1, new DateTime(2023, 12, 3, 13, 25, 7, 344, DateTimeKind.Local).AddTicks(7716) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 1, new DateTime(2023, 12, 3, 13, 25, 7, 344, DateTimeKind.Local).AddTicks(7718) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 1, new DateTime(2023, 12, 3, 13, 25, 7, 344, DateTimeKind.Local).AddTicks(7720) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 1, new DateTime(2023, 12, 3, 13, 25, 7, 344, DateTimeKind.Local).AddTicks(7721) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 1, new DateTime(2023, 12, 3, 13, 25, 7, 344, DateTimeKind.Local).AddTicks(7723) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 1, new DateTime(2023, 12, 3, 13, 25, 7, 344, DateTimeKind.Local).AddTicks(7725) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 1, new DateTime(2023, 12, 3, 13, 25, 7, 344, DateTimeKind.Local).AddTicks(7726) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 1, new DateTime(2023, 12, 3, 13, 25, 7, 344, DateTimeKind.Local).AddTicks(7727) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 1, new DateTime(2023, 12, 3, 13, 25, 7, 344, DateTimeKind.Local).AddTicks(7729) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 1, new DateTime(2023, 12, 3, 13, 25, 7, 344, DateTimeKind.Local).AddTicks(7730) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 1, new DateTime(2023, 12, 3, 13, 25, 7, 344, DateTimeKind.Local).AddTicks(7733) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 1, new DateTime(2023, 12, 3, 13, 25, 7, 344, DateTimeKind.Local).AddTicks(7734) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 1, new DateTime(2023, 12, 3, 13, 25, 7, 344, DateTimeKind.Local).AddTicks(7735) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 1, new DateTime(2023, 12, 3, 13, 25, 7, 344, DateTimeKind.Local).AddTicks(7737) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 1, new DateTime(2023, 12, 3, 13, 25, 7, 344, DateTimeKind.Local).AddTicks(7738) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 1, new DateTime(2023, 12, 3, 13, 25, 7, 344, DateTimeKind.Local).AddTicks(7740) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 1, new DateTime(2023, 12, 3, 13, 25, 7, 344, DateTimeKind.Local).AddTicks(7741) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 1, new DateTime(2023, 12, 3, 13, 25, 7, 344, DateTimeKind.Local).AddTicks(7742) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 1, new DateTime(2023, 12, 3, 13, 25, 7, 344, DateTimeKind.Local).AddTicks(7745) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 1, new DateTime(2023, 12, 3, 13, 25, 7, 344, DateTimeKind.Local).AddTicks(7746) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 1, new DateTime(2023, 12, 3, 13, 25, 7, 344, DateTimeKind.Local).AddTicks(7748) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 1, new DateTime(2023, 12, 3, 13, 25, 7, 344, DateTimeKind.Local).AddTicks(7749) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 1, new DateTime(2023, 12, 3, 13, 25, 7, 344, DateTimeKind.Local).AddTicks(7751) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 1, new DateTime(2023, 12, 3, 13, 25, 7, 344, DateTimeKind.Local).AddTicks(7753) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 1, new DateTime(2023, 12, 3, 13, 25, 7, 344, DateTimeKind.Local).AddTicks(7754) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 1, new DateTime(2023, 12, 3, 13, 25, 7, 344, DateTimeKind.Local).AddTicks(7755) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 1, new DateTime(2023, 12, 3, 13, 25, 7, 344, DateTimeKind.Local).AddTicks(7758) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 1, new DateTime(2023, 12, 3, 13, 25, 7, 344, DateTimeKind.Local).AddTicks(7759) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 1, new DateTime(2023, 12, 3, 13, 25, 7, 344, DateTimeKind.Local).AddTicks(7761) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 1, new DateTime(2023, 12, 3, 13, 25, 7, 344, DateTimeKind.Local).AddTicks(7763) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 1, new DateTime(2023, 12, 3, 13, 25, 7, 344, DateTimeKind.Local).AddTicks(7766) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 1, new DateTime(2023, 12, 3, 13, 25, 7, 344, DateTimeKind.Local).AddTicks(7767) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 1, new DateTime(2023, 12, 3, 13, 25, 7, 344, DateTimeKind.Local).AddTicks(7769) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 51,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 1, new DateTime(2023, 12, 3, 13, 25, 7, 344, DateTimeKind.Local).AddTicks(7770) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 53,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 1, new DateTime(2023, 12, 3, 13, 25, 7, 344, DateTimeKind.Local).AddTicks(7772) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 54,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 1, new DateTime(2023, 12, 3, 13, 25, 7, 344, DateTimeKind.Local).AddTicks(7774) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 55,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 1, new DateTime(2023, 12, 3, 13, 25, 7, 344, DateTimeKind.Local).AddTicks(7814) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 56,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 1, new DateTime(2023, 12, 3, 13, 25, 7, 344, DateTimeKind.Local).AddTicks(7815) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 57,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 1, new DateTime(2023, 12, 3, 13, 25, 7, 344, DateTimeKind.Local).AddTicks(7817) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 58,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 1, new DateTime(2023, 12, 3, 13, 25, 7, 344, DateTimeKind.Local).AddTicks(7818) });

            migrationBuilder.UpdateData(
                table: "Kullanicilar",
                keyColumn: "ID",
                keyValue: 1,
                column: "OlusturulmaTarihi",
                value: new DateTime(2023, 12, 3, 13, 25, 7, 344, DateTimeKind.Local).AddTicks(9623));

            migrationBuilder.CreateIndex(
                name: "IX_Besinler_AksamYemegiID",
                table: "Besinler",
                column: "AksamYemegiID");

            migrationBuilder.CreateIndex(
                name: "IX_Besinler_AraOgunID",
                table: "Besinler",
                column: "AraOgunID");

            migrationBuilder.CreateIndex(
                name: "IX_Besinler_KahvaltiID",
                table: "Besinler",
                column: "KahvaltiID");

            migrationBuilder.CreateIndex(
                name: "IX_Besinler_OgleYemegiID",
                table: "Besinler",
                column: "OgleYemegiID");

            migrationBuilder.AddForeignKey(
                name: "FK_Besinler_AksamYemekleri_AksamYemegiID",
                table: "Besinler",
                column: "AksamYemegiID",
                principalTable: "AksamYemekleri",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Besinler_AraOgunler_AraOgunID",
                table: "Besinler",
                column: "AraOgunID",
                principalTable: "AraOgunler",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Besinler_Kahvaltilar_KahvaltiID",
                table: "Besinler",
                column: "KahvaltiID",
                principalTable: "Kahvaltilar",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Besinler_OgleYemekleri_OgleYemegiID",
                table: "Besinler",
                column: "OgleYemegiID",
                principalTable: "OgleYemekleri",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Besinler_AksamYemekleri_AksamYemegiID",
                table: "Besinler");

            migrationBuilder.DropForeignKey(
                name: "FK_Besinler_AraOgunler_AraOgunID",
                table: "Besinler");

            migrationBuilder.DropForeignKey(
                name: "FK_Besinler_Kahvaltilar_KahvaltiID",
                table: "Besinler");

            migrationBuilder.DropForeignKey(
                name: "FK_Besinler_OgleYemekleri_OgleYemegiID",
                table: "Besinler");

            migrationBuilder.DropIndex(
                name: "IX_Besinler_AksamYemegiID",
                table: "Besinler");

            migrationBuilder.DropIndex(
                name: "IX_Besinler_AraOgunID",
                table: "Besinler");

            migrationBuilder.DropIndex(
                name: "IX_Besinler_KahvaltiID",
                table: "Besinler");

            migrationBuilder.DropIndex(
                name: "IX_Besinler_OgleYemegiID",
                table: "Besinler");

            migrationBuilder.DropColumn(
                name: "AksamYemegiID",
                table: "Besinler");

            migrationBuilder.DropColumn(
                name: "AraOgunID",
                table: "Besinler");

            migrationBuilder.DropColumn(
                name: "KahvaltiID",
                table: "Besinler");

            migrationBuilder.DropColumn(
                name: "OgleYemegiID",
                table: "Besinler");

            migrationBuilder.CreateTable(
                name: "AksamYemegiBesin",
                columns: table => new
                {
                    AksamYemekleriID = table.Column<int>(type: "int", nullable: false),
                    BesinlerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AksamYemegiBesin", x => new { x.AksamYemekleriID, x.BesinlerID });
                    table.ForeignKey(
                        name: "FK_AksamYemegiBesin_AksamYemekleri_AksamYemekleriID",
                        column: x => x.AksamYemekleriID,
                        principalTable: "AksamYemekleri",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AksamYemegiBesin_Besinler_BesinlerID",
                        column: x => x.BesinlerID,
                        principalTable: "Besinler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AraOgunBesin",
                columns: table => new
                {
                    AraOgunlerID = table.Column<int>(type: "int", nullable: false),
                    BesinlerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AraOgunBesin", x => new { x.AraOgunlerID, x.BesinlerID });
                    table.ForeignKey(
                        name: "FK_AraOgunBesin_AraOgunler_AraOgunlerID",
                        column: x => x.AraOgunlerID,
                        principalTable: "AraOgunler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AraOgunBesin_Besinler_BesinlerID",
                        column: x => x.BesinlerID,
                        principalTable: "Besinler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BesinKahvalti",
                columns: table => new
                {
                    BesinlerID = table.Column<int>(type: "int", nullable: false),
                    KahvaltilarID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BesinKahvalti", x => new { x.BesinlerID, x.KahvaltilarID });
                    table.ForeignKey(
                        name: "FK_BesinKahvalti_Besinler_BesinlerID",
                        column: x => x.BesinlerID,
                        principalTable: "Besinler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BesinKahvalti_Kahvaltilar_KahvaltilarID",
                        column: x => x.KahvaltilarID,
                        principalTable: "Kahvaltilar",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BesinOgleYemegi",
                columns: table => new
                {
                    BesinlerID = table.Column<int>(type: "int", nullable: false),
                    OgleYemekleriID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BesinOgleYemegi", x => new { x.BesinlerID, x.OgleYemekleriID });
                    table.ForeignKey(
                        name: "FK_BesinOgleYemegi_Besinler_BesinlerID",
                        column: x => x.BesinlerID,
                        principalTable: "Besinler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BesinOgleYemegi_OgleYemekleri_OgleYemekleriID",
                        column: x => x.OgleYemekleriID,
                        principalTable: "OgleYemekleri",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5033) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5050) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5053) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5056) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5058) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5060) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5070) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5073) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5076) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5078) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5083) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5086) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5088) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5090) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5093) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5095) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5098) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5100) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5102) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5105) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5107) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5109) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5112) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5114) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5117) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5119) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5121) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5205) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5209) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5211) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5213) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5215) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5218) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5220) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5222) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5224) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5226) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5228) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5230) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5232) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5234) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5236) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5241) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5243) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5246) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5248) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5250) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5253) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5254) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5267) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 51,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5269) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 53,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5271) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 54,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5273) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 55,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5275) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 56,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5277) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 57,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5279) });

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "ID",
                keyValue: 58,
                columns: new[] { "Miktar", "OlusturulmaTarihi" },
                values: new object[] { 0, new DateTime(2023, 12, 1, 16, 59, 9, 838, DateTimeKind.Local).AddTicks(5281) });

            migrationBuilder.UpdateData(
                table: "Kullanicilar",
                keyColumn: "ID",
                keyValue: 1,
                column: "OlusturulmaTarihi",
                value: new DateTime(2023, 12, 1, 16, 59, 9, 839, DateTimeKind.Local).AddTicks(144));

            migrationBuilder.CreateIndex(
                name: "IX_AksamYemegiBesin_BesinlerID",
                table: "AksamYemegiBesin",
                column: "BesinlerID");

            migrationBuilder.CreateIndex(
                name: "IX_AraOgunBesin_BesinlerID",
                table: "AraOgunBesin",
                column: "BesinlerID");

            migrationBuilder.CreateIndex(
                name: "IX_BesinKahvalti_KahvaltilarID",
                table: "BesinKahvalti",
                column: "KahvaltilarID");

            migrationBuilder.CreateIndex(
                name: "IX_BesinOgleYemegi_OgleYemekleriID",
                table: "BesinOgleYemegi",
                column: "OgleYemekleriID");
        }
    }
}
