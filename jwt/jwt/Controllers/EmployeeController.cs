using jwt.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace jwt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        [Authorize(Roles =("Administrador"))]//para proteger el metodo y accedan el rol del campo con token, pero tambien se puede poner arriba de la clase para proteger el controlador
        public IActionResult Get()
        {
            var listEmployee = EmployeeConstants.Employees;
            return Ok(listEmployee);
        }
    }
}
