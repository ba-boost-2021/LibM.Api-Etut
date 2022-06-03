using LibM.Common.Dtos;
using LibM.Services.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibM.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService service;

        public StudentController(IStudentService service)
        {
            this.service = service;
        }
        [HttpGet("list")]
        public IActionResult GetStudentByGradeId([FromQuery] Guid id)
        {
            var result = service.ListStudentByGrade(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
