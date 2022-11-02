using Gorevcim.Core.DTOs;
using Gorevcim.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorevcim.Core.Services
{
    public interface IProductColorsService : IGenericService<ProductColors>
    {
        public Task<CustomResponseDto<List<ProductColorDto>>> GetApiAllProductColors();
        public Task<List<ProductColorDto>> GetWebAllProductColors();

    }
}
