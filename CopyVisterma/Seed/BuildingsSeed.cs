using System;
using System.Collections.Generic;
using System.Text;
using CopyVisterma.Entities;

namespace CopyVisterma.Seed
{
    class BuildingsSeed
    {
        public static Building[] Buildings = {
            new Building { Id= 1, ClientId = 2, Street= "Noniewicza", Number= "1B", PostalCode= "16-400", Comments= "Tylko nowa część budynku"},
            new Building { Id= 2, ClientId = 4, Street= "Kościuszki", Number= "2", PostalCode= "16-400"},
            new Building { Id= 3, ClientId = 6, Street= "Kościuszki", Number= "21", PostalCode= "16-400"},
            new Building { Id= 4, ClientId = 8, Street= "Dwernickiego", Number= "8A", PostalCode= "16-400"}
        };
    }
}
