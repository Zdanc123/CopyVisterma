using System;
using System.Collections.Generic;
using System.Text;
using CopyVisterma.Entities;

namespace CopyVisterma.Seed
{
    public class BillingPeriodsSeed
    {
        public static BillingPeriod[] BillingPeriods =
        {
            new BillingPeriod { Id= 1, BuildingId= 1, StartingDate= new DateTime(2018,8,01), EndDate=new DateTime(2018,8,31), Type= 1 },
            new BillingPeriod { Id= 2, BuildingId= 1, StartingDate= new DateTime(2018,9,01), EndDate=new DateTime(2018,9,30), Type= 1 },
            new BillingPeriod { Id= 3, BuildingId= 1, StartingDate= new DateTime(2018,9,01), EndDate=new DateTime(2018,9,30), Type= 2 }
        };
    }
}
