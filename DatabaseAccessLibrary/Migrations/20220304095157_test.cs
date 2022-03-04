using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseAccessLibrary.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cars",
                columns: table => new
                {
                    Registration = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Size = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Parkingspot = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cars", x => x.Registration);
                });

            migrationBuilder.CreateTable(
                name: "motorcycles",
                columns: table => new
                {
                    Registration = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Size = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Parkingspot = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_motorcycles", x => x.Registration);
                });

            migrationBuilder.InsertData(
                table: "cars",
                columns: new[] { "Registration", "Parkingspot", "Size", "StartTime" },
                values: new object[,]
                {
                    { "0AGVG0", 0, 38, null },
                    { "1076952", 0, 16, null },
                    { "1CK7456", 0, 41, null },
                    { "22528MC", 0, 40, null },
                    { "446AH", 0, 50, null },
                    { "487TBS", 0, 33, null },
                    { "4GUG721", 0, 48, null },
                    { "4JWR404", 0, 45, null },
                    { "535621B", 0, 44, null },
                    { "5WAS727", 0, 15, null },
                    { "630XDK", 0, 7, null },
                    { "6855OP", 0, 25, null },
                    { "6JMW833", 0, 43, null },
                    { "6LME062", 0, 19, null },
                    { "7AAA642", 0, 26, null },
                    { "7K44135", 0, 13, null },
                    { "7UFH698", 0, 20, null },
                    { "7YBK462", 0, 27, null },
                    { "7Z50T2", 0, 18, null },
                    { "7ZEE285", 0, 2, null },
                    { "8236TE", 0, 6, null },
                    { "8739698", 0, 9, null },
                    { "8DGP853", 0, 28, null },
                    { "8EYV287", 0, 24, null },
                    { "8GTS234", 0, 49, null },
                    { "AEH9540", 0, 42, null },
                    { "BB9487", 0, 32, null },
                    { "BCF9407", 0, 30, null },
                    { "BENCH", 0, 11, null },
                    { "BWN8988", 0, 36, null },
                    { "CKH7844", 0, 31, null },
                    { "DKVQ31", 0, 39, null },
                    { "DRG4N6", 0, 37, null },
                    { "EUG190", 0, 21, null },
                    { "FXZ6807", 0, 5, null },
                    { "GBD5472", 0, 1, null },
                    { "HTM4861", 0, 14, null },
                    { "HYB4966", 0, 12, null },
                    { "K9CRZY", 0, 47, null },
                    { "KK9915", 0, 10, null },
                    { "KQVR90", 0, 23, null },
                    { "L4802T", 0, 35, null }
                });

            migrationBuilder.InsertData(
                table: "cars",
                columns: new[] { "Registration", "Parkingspot", "Size", "StartTime" },
                values: new object[,]
                {
                    { "LKY3494", 0, 4, null },
                    { "LOVE", 0, 8, null },
                    { "N73EXY", 0, 46, null },
                    { "QFX241", 0, 17, null },
                    { "SC20337", 0, 34, null },
                    { "SC20365", 0, 29, null },
                    { "T5540N", 0, 3, null },
                    { "X35FNH", 0, 22, null }
                });

            migrationBuilder.InsertData(
                table: "motorcycles",
                columns: new[] { "Registration", "Parkingspot", "Size", "StartTime" },
                values: new object[,]
                {
                    { "11AP780", 0, 38, null },
                    { "11AV356", 0, 49, null },
                    { "12AR787", 0, 48, null },
                    { "13AY794", 0, 33, null },
                    { "18AD512", 0, 30, null },
                    { "19AX641", 0, 1, null },
                    { "20AF377", 0, 43, null },
                    { "21AJ791", 0, 13, null },
                    { "23AH141", 0, 3, null },
                    { "23AL427", 0, 15, null },
                    { "24AI416", 0, 24, null },
                    { "24AO379", 0, 20, null },
                    { "25AG915", 0, 47, null },
                    { "26AA587", 0, 8, null },
                    { "26AI615", 0, 10, null },
                    { "30AD500", 0, 35, null },
                    { "30AG809", 0, 28, null },
                    { "30AQ301", 0, 44, null },
                    { "33AX623", 0, 31, null },
                    { "34AF518", 0, 22, null },
                    { "34AT620", 0, 26, null },
                    { "35AA351", 0, 18, null },
                    { "35AA969", 0, 6, null },
                    { "35AZ101", 0, 7, null },
                    { "38AF650", 0, 36, null },
                    { "38AI537", 0, 16, null },
                    { "38AQ555", 0, 23, null },
                    { "40AD140", 0, 27, null },
                    { "45AO853", 0, 42, null },
                    { "51AT445", 0, 9, null },
                    { "51AX141", 0, 50, null },
                    { "52AD117", 0, 5, null },
                    { "52AZ687", 0, 14, null },
                    { "54AG156", 0, 39, null }
                });

            migrationBuilder.InsertData(
                table: "motorcycles",
                columns: new[] { "Registration", "Parkingspot", "Size", "StartTime" },
                values: new object[,]
                {
                    { "55AC734", 0, 34, null },
                    { "55AN371", 0, 19, null },
                    { "55AR583", 0, 2, null },
                    { "57AT653", 0, 11, null },
                    { "59AO966", 0, 25, null },
                    { "5AF5358", 0, 17, null },
                    { "61AS803", 0, 46, null },
                    { "61AY262", 0, 40, null },
                    { "62AB104", 0, 12, null },
                    { "62AK646", 0, 41, null },
                    { "62AZ570", 0, 45, null },
                    { "64AP580", 0, 32, null },
                    { "64AR362", 0, 21, null },
                    { "66AP991", 0, 29, null },
                    { "6AM1722", 0, 37, null },
                    { "7AR1649", 0, 4, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cars");

            migrationBuilder.DropTable(
                name: "motorcycles");
        }
    }
}
