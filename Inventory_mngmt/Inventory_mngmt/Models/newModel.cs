namespace Inventory_mngmt.Models
{
    public class newModel
    {
        public PersonModel Person { get; set; }
    }

    public class PersonModel
    {
        public String Name { get; set; }
        public int Age { get; set; }

        public ContactModel Contact { get; set; }

    }

    public class ContactModel
    {
        public String Email { get; set; }
        public int mobileNumber { get; set; }

        public AddressModel Address { get; set; }
    }

    public class AddressModel
    {
        public String street { get; set; }
        public String city { get; set; }
        public int zip { get; set; }
    }
}
