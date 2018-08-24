using System;
using System.Collections.Generic;
using System.Text;

namespace CopyVisterma.Entities
{
    public class Employee 
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Position { get; set; }
        public string Email { get; set; }
        public string PhoneLandline { get; set; }
        public string PhoneMobile { get; set; }
        public string Comments { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}
