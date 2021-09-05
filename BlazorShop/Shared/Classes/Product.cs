using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorShop.Shared.Classes
{
    public class Product
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Descripton { get; set; }
        public string ImageLink { get; set; } = "https://via.placeholder.com/300x300";
        
        public bool IsPublic { get; set; }
        public bool IsDeleted { get; set; }
        public Category Category { get; set; }
        public int CategoryID { get; set; }
        public DateTime? DateCreated { get; set; } = DateTime.Now;
        public DateTime? DateUpdated { get; set; }

        public List<ProductVariant> Variants { get; set; } = new List<ProductVariant>();
    }
}