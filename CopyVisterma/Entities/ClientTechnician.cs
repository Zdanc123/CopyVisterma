using System;
using System.Collections.Generic;
using System.Text;

namespace CopyVisterma.Entities
{
    public class ClientTechnician 
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public int ServiceTechnicianId { get; set; }
        public ServiceTechnician ServiceTechnician { get; set; }
    }
}
