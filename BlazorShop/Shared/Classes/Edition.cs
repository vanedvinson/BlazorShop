﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BlazorShop.Shared.Classes
{
    public class Edition
    {
        public int ID { get; set; } 
        public string Name { get; set; }
        [JsonIgnore]
        public List<Product> Products { get; set; }
    }
}
