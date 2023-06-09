﻿using BlazorApp1.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorApp1.Client.Services.CategoryService
{
    public interface ICategoryService
    {
         List<Category> Categories { get; set; }
         Task LoadCategories();
    }
}
