using AutoMapper;
using Gorevcim.API.Filters;
using Gorevcim.Core.DTOs;
using Gorevcim.Core.Models;
using Gorevcim.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Gorevcim.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IProductService _services;

        public ProductsController(IGenericService<Products> service, IMapper mapper, IProductService productService)
        {
            _mapper = mapper;
            _services = productService;
        }



        [HttpGet("[action]")]
        public async Task<IActionResult> GetProductsCategorys()
        {
            return CreateActionResult(await _services.GetApiAllProductsCategorys());

        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var product = await _services.GetAllAsync();
            var productDtos = _mapper.Map<List<ProductDto>>(product.ToList());
            return CreateActionResult(CustomResponseDto<List<ProductDto>>.Success(200, productDtos));

        }

        [ServiceFilter(typeof(NotFoundFilter<Products>))]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var product = await _services.GetByIdAsync(id);
            var productDtos = _mapper.Map<ProductDto>(product);
            return CreateActionResult(CustomResponseDto<ProductDto>.Success(200, productDtos));

        }

        [HttpPost]
        public async Task<IActionResult> Save(ProductDto productDto)
        {
            var product = await _services.AddAsync(_mapper.Map<Products>(productDto));
            var productDtos = _mapper.Map<ProductDto>(product);
            return CreateActionResult(CustomResponseDto<ProductDto>.Success(201, productDtos));

        }

        [HttpPut]
        public async Task<IActionResult> Update(ProductDto productDto)
        {
            await _services.UpdateAsync(_mapper.Map<Products>(productDto));
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));

        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var product = await _services.GetByIdAsync(id);
            await _services.RemoveAsync(product);
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }

    }
}
