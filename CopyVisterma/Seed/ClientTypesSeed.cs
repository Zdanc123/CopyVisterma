using System;
using System.Collections.Generic;
using System.Text;
using CopyVisterma.Entities;

namespace CopyVisterma.Seed
{
    public class ClientTypesSeed
    {
        public static ClientType[] ClientTypes = {
            new ClientType { Id = 1, Name = "Spółdzielnia Mieszkaniowa"},
            new ClientType { Id = 2, Name = "Wspólnota Mieszkaniowa"}
        };
    }
}
