namespace SmartERP.Models
{
    public class Vendor :ModificationActivity
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string VATNumber { get; set; }
        public string Website { get; set; }
        public int StatusId { get; set; }
        public SystemCodeDetail Status { get; set; }
        public int VendorTypeId { get; set; }
        public SystemCodeDetail VendorType { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
}
