using Gorevcim.Core.DTOs;
using Gorevcim.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorevcim.Core.Services
{
    public interface IProductMeasurementUnitsService : IGenericService<ProductMeasurementUnits>
    {
        public Task<CustomResponseDto<List<ProductMeasurementUnitsDto>>> GetApiAllProductMeasurementUnits();
        public Task<List<ProductMeasurementUnitsDto>> GetWebAllProductMeasurementUnits();

    }
}