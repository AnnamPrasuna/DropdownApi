namespace OneToOneRelDropdownApi.Models
{
    public class Addresss
    {
        public int AddressId { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        //Navigation Property
        public Employee Employee { get; set; }
    }
}
