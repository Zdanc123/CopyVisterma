using System;
using System.Collections.Generic;
using System.Text;
using CopyVisterma.Entities;

namespace CopyVisterma.Seed
{
    public class ServiceTechniciansSeed
    {
        public static ServiceTechnician[] ServiceTechnicians = {
            new ServiceTechnician { Id = 1, FullName = "Andrzej Nowak" },
            new ServiceTechnician { Id = 2, FullName = "Jan Wasilewski" },
            new ServiceTechnician { Id = 3, FullName = "Tomasz Żuk" }
        };
    }
}
