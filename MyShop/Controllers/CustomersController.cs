using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.MyShop.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MyShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerServices _customerServices;

        public CustomersController(ICustomerServices customerServices)
        {
            _customerServices = customerServices;
        }

        [HttpGet]
        public IActionResult GetCustomers()
        {

            return Ok(_customerServices.GetList());
        }


        [HttpGet("{id}")]
        public IActionResult GetById(string id)
        {

            return Ok(_customerServices.GetById(id));
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCustomer(string id)
        {
            return Ok(_customerServices.Delete(id));
        }


    }
}
