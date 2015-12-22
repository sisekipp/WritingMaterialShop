﻿using System;
using System.Collections.Generic;

namespace WritingMaterialsShop.Models.Data
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> Tags { get; set; }
        public float Price { get; set; }
    }
}