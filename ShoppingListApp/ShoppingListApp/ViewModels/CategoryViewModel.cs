using ShoppingListApp.Models;

namespace ShoppingListApp.ViewModels
{
    public class CategoryViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<CategoryDetail> CategoryDetail { get; set; }
    }
}
