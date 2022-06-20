using AutoMapper;
using NLayerApp.Core.DTOs;
using NLayerApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.Service.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            // reverseMap ile iki sınıfında birbirine dönüştürülebilmesini sağladık.
            // ReverseMap olmasaydı yalnızca Product->ProductDto'ya dönüştürülürdü.
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<ProductFeature, ProductFeatureDto>().ReverseMap();
            CreateMap<ProductUpdateDto, Product>();
            CreateMap<Product, ProductWithCategoryDto>();
            CreateMap<Category, CategoryWithProductsDto>();
        }
    }
}
