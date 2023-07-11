﻿using ShoppingListApp.Models;

namespace ShoppingListApp.ViewModels
{
    public class AddressViewModel
    {
        public int Id { get; set; }

        public int? UserId { get; set; }

        public User? User { get; set; }

        public string AddressName { get; set; }

        public string CountryName { get; set; }

        public string CityName { get; set; }

        public string TownName { get; set; }

        public string DistrictName { get; set; }

        public int PostCode { get; set; }

        public string AddressText { get; set; }

        public List<Order>? Orders { get; set; }

        public List<Invoice>? Invoices { get; set; }
    }
}
