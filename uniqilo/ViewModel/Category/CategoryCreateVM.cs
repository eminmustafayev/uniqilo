﻿using System.ComponentModel.DataAnnotations;

namespace uniqilo.ViewModel.Category
{
    public class CategoryCreateVM
    {
        [MaxLength(32, ErrorMessage = "Name must be less than 32"), Required(ErrorMessage = "Name is required")]
        public string Name { get; set; } = null!;
    }
}
