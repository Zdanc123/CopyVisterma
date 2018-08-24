using System;
using System.Collections.Generic;
using System.Text;

namespace CopyVisterma.Entities
{
    public class BillingPeriod
    {
        public static int TYPE_HEATING = 1;
        public static int TYPE_WATER = 2;

        public int Id { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Type { get; set; }
        public int BuildingId { get; set; }
        public Building Building { get; set; }
    }
}
