using LibM.Common.Dtos;
using LibM.Services.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibM.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService service;

        public BookController(IBookService service)
        {
            this.service = service;
        }
        [HttpPost("add")]
        public IActionResult Insert([FromBody] NewBookDto dto)
        {
            var result = service.Add(dto);
            if (result)
            {
                return Ok();
            }
            return BadRequest();
        }
    }
}
