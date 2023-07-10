using System.Diagnostics.Metrics;

namespace ShoppingListApp.Models
{
    public class Address
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public int CountryId { get; set; }

        public Country Country { get; set; }

        public int CityId { get; set; }

        public City City { get; set; }

        public int DistrictId { get; set; }

        public District District { get; set; }

        public int PostCode { get; set; }

        public string AddressText { get; set; }

        public List<Order> Orders { get; set; }

        public List<Invoice> Invoices { get; set; }
    }
}

