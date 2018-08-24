using System;
using System.Collections.Generic;
using System.Text;

namespace CopyVisterma.Entities
{
    public class ClientType 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Client> Clients { get; set; }
    }
}
