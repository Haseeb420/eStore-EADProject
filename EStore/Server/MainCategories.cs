using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EStore.Server
{
    public class MainCategories
    {
        public int category_ID { get; set; }

        public string categoryName { get; set; }


        public List<MainCategories> getMainCategories()
        {
            List<MainCategories> categories = new List<MainCategories>();
            categories.Add(new MainCategories { category_ID = 1, categoryName = "Women's Collection" });
            categories.Add(new MainCategories { category_ID = 2, categoryName = "Men's Collection" });
            categories.Add(new MainCategories { category_ID = 3, categoryName = "Electornic Devices" });
            return categories;
        }
    }
    public class SubCategories
    {
        public int sub_category_id { get; set; }
        public string SubCategoriesname { get; set; }

        public int mainCategoryName { get; set; }
    }
}
