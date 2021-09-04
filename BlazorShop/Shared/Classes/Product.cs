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
        [Column(TypeName = "decimal(18,2)")] //two characters after the point
        public decimal Price { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal OriginalPrice { get; set; }
        public bool IsPublic { get; set; }
        public bool IsDeleted { get; set; }
        public Category Category { get; set; }
        public int CategoryID { get; set; }
        public DateTime? DateCreated { get; set; } = DateTime.Now;
        public DateTime? DateUpdated { get; set; }
        public List<Edition> Editions { get; set; }
    }
}