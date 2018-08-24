using System;
using System.Collections.Generic;
using System.Text;

namespace CopyVisterma.Entities
{
    public class Building 
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string PostalCode { get; set; }
        public string Comments { get; set; }
        public List<BillingPeriod> BillingPeriods { get; set; }
    }
}
