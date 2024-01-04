using AppGallery.Models;
using AppGallery.Views.Layouts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGallery.Repositories
{
    internal class CategoryRepository
    {
        public CategoryRepository() { }

        public List<Category> GetCategories()
        {
            var categories = new List<Category>();

            categories.Add(new Category
            {
                Name = "Layout",
                Components = new List<Component>
                {
                    new Component{Title = "StackLayout1", Description = "1. Organização sequencial dos elementos...", Page = new StackLayoutPage() },
                    new Component{Title = "StackLayout2", Description = "2. Organização sequencial dos elementos...", Page = new StackLayoutPage() },
                    new Component{Title = "StackLayout3", Description = "3. Organização sequencial dos elementos...", Page = new StackLayoutPage() },
                }
            });
            
            return categories;
        }
    }
}
