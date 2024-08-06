namespace IG.API.SUNAT.Web.Pages.ComboEjemplo
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetCategoriesAsync();
    }

    public class CategoryService : ICategoryService
    {
        public async Task<IEnumerable<Category>> GetCategoriesAsync()
        {
            // Simula una llamada a una base de datos o API
            await Task.Delay(500);
            return new List<Category>
        {
            new Category { Id = 1, Name = "Electronics" },
            new Category { Id = 2, Name = "Books" },
            new Category { Id = 3, Name = "Clothing" }
        };
        }
    }

    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }


}
