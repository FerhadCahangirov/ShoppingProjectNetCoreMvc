﻿using ShoppingMvc.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoppingMvc.ViewModels.ProductVm
{
    public class ProductCreateVm
    {
        [Required]
        public string? Title { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        [Column(TypeName = "smallmoney")]
        public decimal Price { get; set; }
        public int DiscountRate { get; set; }
        public int StockNumber { get; set; }
        public string? Color { get; set; }
        public string? Size { get; set; }
        public int CategoryId { get; set; } 
        public List<int> TagsId { get; set; }

        public List<AdditionalInfo>? AdditionalInfos { get; set; }
        public IFormFileCollection? ProductImages { get; set; }
    }

}
