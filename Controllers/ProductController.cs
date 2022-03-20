using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductEf.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductEf.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Products> Get()
        {
            using (var context = new Shopping_Cart_dbContext())
            {
                return context.Products.ToList();
            }
        }
    }
}
