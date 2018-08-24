using System;
using System.Collections.Generic;
using System.Text;

namespace CopyVisterma.Entities
{
    public class ServiceTechnician 
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public List<ClientTechnician> ClientsTechnicians { get; set; }
    }
}
