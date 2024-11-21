namespace Inventory_mngmt.NewFolder
{
    public class PersonEntity
    {
        public String Name { get; set; }
        public int Age { get; set; }

    }

    public class ContactEntity
    {
        public String Email { get; set; }
        public int mobileNumber { get; set; }
    }

    public class AddressEntity
    {
        public String street { get; set; }
        public String city { get; set; }
        public int zip { get; set; }
    }
}
