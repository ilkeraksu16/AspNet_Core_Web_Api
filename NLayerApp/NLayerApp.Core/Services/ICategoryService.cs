﻿using NLayerApp.Core.DTOs;
using NLayerApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.Core.Services
{
    public interface ICategoryService:IService<Category>
    {
        public Task<CustomResponseDto<CategoryWithProductsDto>>GetSingleCategoryByIdWithProductsAsync(int categoryId);
    }
}
 