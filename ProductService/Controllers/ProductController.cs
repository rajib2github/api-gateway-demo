using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductService.Models;

namespace ProductService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        // GET api/product
        [HttpGet("getProduct")]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(GetDummyData());
        }

        private Product GetDummyData()
        {
            Product product = new Product
            {
                Id = 1,
                Name = "Alexa",
                Price = "$98"
            };
            return product;
        }

    }
}
