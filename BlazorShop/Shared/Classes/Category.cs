using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorShop.Shared.Classes
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string URL { get; set; }
        public string Icon { get; set; }

        public List<Product> Products { get; set; }

    }
}
