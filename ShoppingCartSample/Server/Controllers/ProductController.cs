using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShoppingCartSample.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ShoppingCartSample.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet("list")]
        public Product[] GetProducts()
        {
            var json = System.IO.File.ReadAllText("Products.json");
            return JsonConvert.DeserializeObject<Product[]>(json);
        }
    }
}
