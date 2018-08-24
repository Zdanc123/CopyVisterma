using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CopyVisterma.Migrations
{
    public partial class AddSeeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ClientTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Spółdzielnia Mieszkaniowa" },
                    { 2, "Wspólnota Mieszkaniowa" }
                });

            migrationBuilder.InsertData(
                table: "ServiceTechnicians",
                columns: new[] { "Id", "FullName" },
                values: new object[,]
                {
                    { 1, "Andrzej Nowak" },
                    { 2, "Jan Wasilewski" },
                    { 3, "Tomasz Żuk" }
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "ApartmentNumber", "BuildingNumber", "City", "Email", "NIP", "Name", "PersonGuardianId", "PersonHeatingId", "PersonWaterId", "Phone", "PostalCode", "REGON", "Street", "TypeId" },
                values: new object[,]
                {
                    { 1, "2", "3", "Augustów", "antypody@example.com", "2461974504", "Antypody", null, null, null, "87 523 66 23", "06-408", "000482938", "Turystyczna", 1 },
                    { 16, null, "16", "Płock", "kamena@example.com", "1563802662", "Płock Kamena", null, null, null, "24 452 65 24", "09-402", "000263816", "Cisowa", 2 },
                    { 12, null, "2", "Warszawa", "przedmiescie@example.com", "1342753273", "Krakowskie przedmieście SM", null, null, null, "22 650 87 25", "05-075", "002514782", "Krótka", 2 },
                    { 11, "7", "8", "Garwolin", "gawrolin@example.com", "1553498624", "Garwolin Centrum", null, null, null, "26 581 65 87", "08-400", "003520188", "Gawędy", 2 },
                    { 10, null, "11", "Bydgoszcz", "ezachod@example.com", "3568256814", "Enklawa Zachód", null, null, null, "52 872 76 90", "85-188", "000163429", "Pogodna", 2 },
                    { 9, "4", "4", "Bydgoszcz", "ewschod@example.com", "2267825615", "Enklawa Wschód", null, null, null, "52 871 44 27", "85-623", "000265183", "Tuwima", 2 },
                    { 7, "8", "1", "Bydgoszcz", "epoludnie@example.com", "1670267291", "Enklawa Poludnie", null, null, null, "52 871 75 21", "85-160", "001257361", "Kowalskiego", 2 },
                    { 5, null, "5b", "Gliwice", "zakatek@example.com", "9085825691", "Domowy zakątek Gliwice ", null, null, null, "32 782 98 02", "44-100", "001264861", "Mickiewicza", 2 },
                    { 4, "6", "8", "Sokółka", "wzgorze@example.com", "2619836711", "Dom na wzgórzu - Skółka", null, null, null, "85 437 23 99", "16-100", "00571963", "Wesoła", 2 },
                    { 17, "4", "7", "Wroclaw", "wroclawprzedmiescia@example.com", "3452865026", "Przedmieścia Wrocław", null, null, null, "71 652 76 41", "56-300", "000125388", "Działkowa", 2 },
                    { 3, "3", "13", "Suwałki", "cs@example.com", "2615397366", "Centrum Suwałki", null, null, null, "87 566 20 44", "16-400", "000029935", "Wigierska", 2 },
                    { 19, null, "19", "Wroclaw", "r.zakatek@example.com", "3433670130", "Rodzinny zakątek", null, null, null, "71 351 76 27", "51-180", "002589269", "Pomorska", 1 },
                    { 18, "9", "6", "Bialystok", "kolejowa@example.com", "2237169836", "Rodzina Kolejowa", null, null, null, "85 352 76 34", "15-180", "000361937", "Krzywa", 1 },
                    { 15, null, "5", "Olsztyn", "olsztyn@example.com", "4557300202", "Olsztyn Nowodwory", null, null, null, "89 541 99 58", "11-041", "000625183", "Dolna", 1 },
                    { 14, "13", "12a", "Nałeczów", "naleczow@example.com", "2568163957", "Nałeczów", null, null, null, "41 763 88 52", "24-150", "002617825", "Beskidzka", 1 },
                    { 13, null, "14", "Warszawa", "mokotow@example.com", "6542985025", "Mokotów", null, null, null, "22 672 46 28", "04-026", "000853815", "Armii Krajowej", 1 },
                    { 8, "2", "16", "Bydgoszcz", "epolnoc@example.com", "5370081620", "Enklawa Północ", null, null, null, "52 872 65 35", "85-792", "000071532", "Andersa", 1 },
                    { 6, "13", "11", "Bydgoszcz", "ecentrum@example.com", "7674301638", "Enklawa Centrum", null, null, null, "52 892 63 55", "85-790", "000562815", "Witosa", 1 },
                    { 2, null, "10", "Białystok", "bsm@example.com", "8747154398", "Białostocka Spółdzielnia Mieszkaniowa", null, null, null, "85 678 34 56", "15-268", "001822375", "Transportowa", 1 },
                    { 20, "9", "5", "Gdańsk", "stogi@example.com", "9800265017", "Stogi", null, null, null, "58 482 72 90", "80-299", "000251738", "Mleczna", 1 },
                    { 21, "2", "6", "Szczecin", "solihska@example.com", "2763971152", "Solihska", null, null, null, "94 802 76 16", "70-512", "002614365", "Lubelska", 2 }
                });

            migrationBuilder.InsertData(
                table: "Buildings",
                columns: new[] { "Id", "ClientId", "Comments", "Number", "PostalCode", "Street" },
                values: new object[,]
                {
                    { 1, 2, "Tylko nowa część budynku", "1B", "16-400", "Noniewicza" },
                    { 3, 6, null, "21", "16-400", "Kościuszki" },
                    { 4, 8, null, "8A", "16-400", "Dwernickiego" },
                    { 2, 4, null, "2", "16-400", "Kościuszki" }
                });

            migrationBuilder.InsertData(
                table: "BillingPeriods",
                columns: new[] { "Id", "BuildingId", "EndDate", "StartingDate", "Type" },
                values: new object[] { 1, 1, new DateTime(2018, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "BillingPeriods",
                columns: new[] { "Id", "BuildingId", "EndDate", "StartingDate", "Type" },
                values: new object[] { 2, 1, new DateTime(2018, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "BillingPeriods",
                columns: new[] { "Id", "BuildingId", "EndDate", "StartingDate", "Type" },
                values: new object[] { 3, 1, new DateTime(2018, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BillingPeriods",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BillingPeriods",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BillingPeriods",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ServiceTechnicians",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ServiceTechnicians",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ServiceTechnicians",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ClientTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ClientTypes",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
