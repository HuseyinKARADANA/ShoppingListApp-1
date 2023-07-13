namespace ShoppingListApp.Models
{
    public class Town
    {
        public int Id { get; set; }

        public int CityId { get; set; }

        public City City { get; set; }

        public string Name { get; set; }

        public List<District> Districts { get; set; }

        public List<Address> Addresses { get; set; }
    }
}
