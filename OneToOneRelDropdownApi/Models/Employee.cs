using System.Net;

namespace OneToOneRelDropdownApi.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
       
        // Foreign key to Address
        public int AddressId { get; set; }
        public Addresss Address { get; set; }

    }
}
