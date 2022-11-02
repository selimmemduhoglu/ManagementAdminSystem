using AutoMapper;
using Gorevcim.Core.DTOs;
using Gorevcim.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorevcim.Service.Mappings
{
    public class MapProfiles:Profile
    {
        public MapProfiles()
        {
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Products, ProductsDto>().ReverseMap();
            CreateMap<ProductsFeatures, ProductsGeaturesDto>().ReverseMap();
            CreateMap<ProductColorDto, ProductColorDto>().ReverseMap();
            CreateMap<ProductCurrencyUnits, ProductCurrencyUnitsDto>().ReverseMap();
            CreateMap<ProductMeasurementUnits, ProductMeasurementUnitsDto>().ReverseMap();
            CreateMap<ProductProjects, ProductProjectsDto>().ReverseMap();
            CreateMap<ProductVatUnits, ProductVatUnitsDto>().ReverseMap();
            CreateMap<ProductWeightUnits, ProductWeightUnitsDto>().ReverseMap();
            CreateMap<ProductBrands, ProductBrandsDto>().ReverseMap();
            CreateMap<Products, ProductCategoryDto>();
            CreateMap<Category, CategoryProductDto>();












        }
    }
}
