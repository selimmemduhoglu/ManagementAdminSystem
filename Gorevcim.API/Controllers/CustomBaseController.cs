using Gorevcim.Core.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Gorevcim.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomBaseController : ControllerBase
    {


        //Aşağıdaki tanımlama Endpoint olmadığı için NonAction


        [NonAction]
        public IActionResult CreateActionResult<T>(CustomResponseDto<T> response)
        {
            if (Response.StatusCode == 204)
                //Dönen değer boş olsun .Kodu al
                return new ObjectResult(null)
                {
                    StatusCode = Response.StatusCode
                };
            return new ObjectResult(response)
            {
                StatusCode = response.StatusCode
            };
        }











    }
}
