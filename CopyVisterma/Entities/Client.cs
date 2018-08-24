using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CopyVisterma.Entities
{
    public class Client 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string NIP { get; set; }
        public string REGON { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int TypeId { get; set; }
        public ClientType Type{ get; set; }
        public string Street { get; set; }
        public string BuildingNumber { get; set; }
        public string ApartmentNumber { get; set; }
        public string PersonGuardianId { get; set; }
        public IdentityUser PersonGuardian { get; set; }
        public string PersonWaterId { get; set; }
        public IdentityUser PersonWater { get; set; }
        public string PersonHeatingId { get; set; }
        public IdentityUser PersonHeating { get; set; }
        public List<ClientTechnician> ClientsTechnicians { get; set; }
        public List<Employee> Employees { get; set; }
        public List<Building> Buildings { get; set; }
    }
}
