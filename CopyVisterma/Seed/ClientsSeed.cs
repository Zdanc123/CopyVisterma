using CopyVisterma.Entities;

namespace CopyVisterma.Seed
{
    public class ClientsSeed
    {
        public static Client[] Clients = {
            new Client { Id= 1, Name= "Antypody", City= "Augustów", PostalCode= "06-408", NIP= "2461974504", REGON= "000482938", Phone= "87 523 66 23", Email= "antypody@example.com", Street= "Turystyczna", BuildingNumber= "3", ApartmentNumber= "2", TypeId= 1 },
            new Client { Id= 2, Name= "Białostocka Spółdzielnia Mieszkaniowa", City= "Białystok", PostalCode= "15-268", NIP= "8747154398", REGON= "001822375", Phone= "85 678 34 56", Email= "bsm@example.com", Street= "Transportowa", BuildingNumber="10", TypeId= 1 },
            new Client { Id= 3, Name= "Centrum Suwałki", City= "Suwałki", PostalCode= "16-400", NIP= "2615397366", REGON= "000029935", Phone= "87 566 20 44", Email= "cs@example.com", Street= "Wigierska", BuildingNumber= "13", ApartmentNumber= "3", TypeId= 2 },
            new Client { Id= 4, Name= "Dom na wzgórzu - Skółka", City= "Sokółka", PostalCode= "16-100", NIP= "2619836711", REGON= "00571963", Phone= "85 437 23 99", Email= "wzgorze@example.com", Street= "Wesoła", BuildingNumber= "8", ApartmentNumber= "6", TypeId= 2 },
            new Client { Id= 5, Name= "Domowy zakątek Gliwice ", City= "Gliwice", PostalCode= "44-100", NIP= "9085825691", REGON= "001264861", Phone= "32 782 98 02", Email= "zakatek@example.com", Street= "Mickiewicza", BuildingNumber= "5b", TypeId= 2 },
            new Client { Id= 6, Name= "Enklawa Centrum", City= "Bydgoszcz", PostalCode= "85-790", NIP= "7674301638", REGON= "000562815", Phone= "52 892 63 55", Email= "ecentrum@example.com", Street= "Witosa", BuildingNumber= "11", ApartmentNumber= "13", TypeId= 1 },
            new Client { Id= 7, Name= "Enklawa Poludnie", City= "Bydgoszcz", PostalCode= "85-160", NIP= "1670267291", REGON= "001257361", Phone= "52 871 75 21", Email= "epoludnie@example.com", Street= "Kowalskiego", BuildingNumber= "1", ApartmentNumber= "8", TypeId= 2 },
            new Client { Id= 8, Name= "Enklawa Północ", City= "Bydgoszcz", PostalCode= "85-792", NIP= "5370081620", REGON= "000071532", Phone= "52 872 65 35", Email= "epolnoc@example.com", Street= "Andersa", BuildingNumber= "16", ApartmentNumber= "2", TypeId= 1 },
            new Client { Id= 9, Name= "Enklawa Wschód", City= "Bydgoszcz", PostalCode= "85-623", NIP= "2267825615", REGON= "000265183", Phone= "52 871 44 27", Email= "ewschod@example.com", Street= "Tuwima", BuildingNumber= "4", ApartmentNumber= "4", TypeId= 2 },
            new Client { Id= 10, Name= "Enklawa Zachód", City= "Bydgoszcz", PostalCode= "85-188", NIP= "3568256814", REGON= "000163429", Phone= "52 872 76 90", Email= "ezachod@example.com", Street= "Pogodna", BuildingNumber= "11", TypeId= 2 },
            new Client { Id= 11, Name= "Garwolin Centrum", City= "Garwolin", PostalCode= "08-400", NIP= "1553498624", REGON= "003520188", Phone= "26 581 65 87", Email= "gawrolin@example.com", Street= "Gawędy", BuildingNumber= "8", ApartmentNumber= "7", TypeId= 2 },
            new Client { Id= 12, Name= "Krakowskie przedmieście SM", City= "Warszawa", PostalCode= "05-075", NIP= "1342753273", REGON= "002514782", Phone= "22 650 87 25", Email= "przedmiescie@example.com", Street= "Krótka", BuildingNumber= "2", TypeId= 2 },
            new Client { Id= 13, Name= "Mokotów", City= "Warszawa", PostalCode= "04-026", NIP= "6542985025", REGON= "000853815", Phone= "22 672 46 28", Email= "mokotow@example.com", Street= "Armii Krajowej", BuildingNumber= "14", TypeId= 1 },
            new Client { Id= 14, Name= "Nałeczów", City= "Nałeczów", PostalCode= "24-150", NIP= "2568163957", REGON= "002617825", Phone= "41 763 88 52", Email= "naleczow@example.com", Street= "Beskidzka", BuildingNumber= "12a", ApartmentNumber= "13", TypeId= 1 },
            new Client { Id= 15, Name= "Olsztyn Nowodwory", City= "Olsztyn", PostalCode= "11-041", NIP= "4557300202", REGON= "000625183", Phone= "89 541 99 58", Email= "olsztyn@example.com", Street= "Dolna", BuildingNumber= "5", TypeId= 1 },
            new Client { Id= 16, Name= "Płock Kamena", City= "Płock", PostalCode= "09-402", NIP= "1563802662", REGON= "000263816", Phone= "24 452 65 24", Email= "kamena@example.com", Street= "Cisowa", BuildingNumber= "16", TypeId= 2 },
            new Client { Id= 17, Name= "Przedmieścia Wrocław", City= "Wroclaw", PostalCode= "56-300", NIP= "3452865026", REGON= "000125388", Phone= "71 652 76 41", Email= "wroclawprzedmiescia@example.com", Street= "Działkowa", BuildingNumber= "7", ApartmentNumber= "4", TypeId= 2 },
            new Client { Id= 18, Name= "Rodzina Kolejowa", City= "Bialystok", PostalCode= "15-180", NIP= "2237169836", REGON= "000361937", Phone= "85 352 76 34", Email= "kolejowa@example.com", Street= "Krzywa", BuildingNumber= "6", ApartmentNumber= "9", TypeId= 1 },
            new Client { Id= 19, Name= "Rodzinny zakątek", City= "Wroclaw", PostalCode= "51-180", NIP= "3433670130", REGON= "002589269", Phone= "71 351 76 27", Email= "r.zakatek@example.com", Street= "Pomorska", BuildingNumber= "19", TypeId= 1 },
            new Client { Id= 20, Name= "Stogi", City= "Gdańsk", PostalCode= "80-299", NIP= "9800265017", REGON= "000251738", Phone= "58 482 72 90", Email= "stogi@example.com", Street= "Mleczna", BuildingNumber= "5", ApartmentNumber= "9", TypeId= 1 },
            new Client { Id= 21, Name= "Solihska", City= "Szczecin", PostalCode= "70-512", NIP= "2763971152", REGON= "002614365", Phone= "94 802 76 16", Email= "solihska@example.com", Street= "Lubelska", BuildingNumber= "6", ApartmentNumber= "2", TypeId= 2 }
        };
    }
}
