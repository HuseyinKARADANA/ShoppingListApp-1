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
        }
    }
}
