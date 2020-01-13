using System.Collections.Generic;

namespace Drink_Menu.Models
{
    internal class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                {
                    new Category{CategoryName = "Alcoholic", Description = "All alcoholic drinks."},
                    new Category { CategoryName = "Non-Alcoholic", Description = "All non-alcoholic drinks." }
                };
            }
        }
    }
}