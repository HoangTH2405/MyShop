using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyShop.Entities;

namespace MyShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryesController : ControllerBase
    {
        private MyShopContext _context;

        public CategoryesController(MyShopContext ctx) 
        {
            _context = ctx;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_context.Categories.ToList());
        }
    }

}
