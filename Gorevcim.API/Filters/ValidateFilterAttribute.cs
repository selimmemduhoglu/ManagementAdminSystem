using System;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Microsoft.AspNetCore.Mvc.Filters;
using Gorevcim.Core;
using Gorevcim.Core.Services;
using Gorevcim.Core.DTOs;
using Microsoft.AspNetCore.Mvc;
using Gorevcim.Core.Models;


namespace Gorevcim.API.Filters
{
    public class ValidateFilterAttribute :ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
           if(!context.ModelState.IsValid)
            {
                var errors = context.ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList();
                    context.Result = new BadRequestObjectResult(CustomResponseDto<NoContentDto>.Fail(400, errors));

            }
        }

    }
}
