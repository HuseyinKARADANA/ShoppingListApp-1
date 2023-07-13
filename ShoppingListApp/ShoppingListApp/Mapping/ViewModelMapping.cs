using AutoMapper;
using ShoppingListApp.Models;
using ShoppingListApp.ViewModels;

namespace ShoppingListApp.Mapping
{
    public class ViewModelMapping : Profile
    {
        public ViewModelMapping()
        {
            CreateMap<User, UserViewModel>().ReverseMap();

            CreateMap<Address, AddressViewModel>().ReverseMap();

            CreateMap<Category, CategoryViewModel>().ReverseMap();

            CreateMap<SubCategory, SubCategoryViewModel>().ReverseMap();

            CreateMap<ItemDetail, ItemDetailViewModel>().ReverseMap();
        }
    }
}
