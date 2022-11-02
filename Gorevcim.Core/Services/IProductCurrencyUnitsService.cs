﻿using Gorevcim.Core.DTOs;
using Gorevcim.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorevcim.Core.Services
{
    public interface IProductCurrencyUnitsService : IGenericService<ProductCurrencyUnits>
    {
        public Task<CustomResponseDto<List<ProductCurrencyUnitsDto>>> GetApiAllProductCurrencyUnits();
        public Task<List<ProductCurrencyUnitsDto>> GetWebAllProductCurrencyUnits();
    
    }
}
