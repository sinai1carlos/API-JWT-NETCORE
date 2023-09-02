using jwt.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace jwt.Controllers
    //solo acceden usuarios autenticados
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        [Authorize]//para proteger el metodo y accedan cualquier rol con token, pero tambien se puede poner arriba de la clase para proteger el controlador
        public IActionResult Get()
        {
            var listProduct = ProductsConstants.Products;
            return Ok(listProduct);
        }
    }
}
