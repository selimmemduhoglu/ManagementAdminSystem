using Gorevcim.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gorevcim.Core;
using Gorevcim.Core.DTOs;
using Gorevcim.Core.Services;
using Gorevcim.Core.UnitOfWork;
using AutoMapper;
using Gorevcim.Core.Models;

namespace Gorevcim.Service.Services
{
    public class ProductService : GenericService<Products>,IProductService
    {
        private readonly IProductsRepository _productRepository;
        private readonly IMapper _mapper;
        public ProductService(IGenericRepository<Products>repository, IGenericUnitOfWork unitOfWork, IProductsRepository productRepository,IMapper mapper):base(repository, unitOfWork)
        {

            _productRepository = _productRepository;
            _mapper = mapper;
        }

        public async Task<List<ProductCategoryDto>>GetWebAllProductsCategorys()
        {
            var products = await _productRepository.GetWebAllProductsCategoryAsync();
            var productsDtos = _mapper.Map<List<ProductCategoryDto>>(products);
            return productsDtos;

        }
        public async Task<CustomResponseDto<List<ProductCategoryDto>>> GetApiAllProductsCategorys()
        {
            var products = await _productRepository.GetApiAllProductsCategoryAsync();
            var productsDtos = _mapper.Map<List<ProductCategoryDto>>(products);
            return CustomResponseDto<List<ProductCategoryDto>>.Success(200, productsDtos);

        }

        public async Task<List<ProductCategoryDto>> GetWebAllProductsAsync()
        {
            var products = await _productRepository.GetWebAllProductsAsync();
            var productsDtos = _mapper.Map<List<ProductCategoryDto>>(products);
            return productsDtos;

        }




    }
}
