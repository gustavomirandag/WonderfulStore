using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WonderfulStore.Application.Interfaces;
using WonderfulStore.Domain.Entities;

namespace WonderfulStore.Service.ProductApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductApiApp _productApiApp;

        public ProductsController(IProductApiApp productApiApp)
        {
            _productApiApp = productApiApp;
        }



        // GET: api/Products
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _productApiApp.GetAllProducts();
        }

        // POST: api/Products
        [HttpPost]
        public void Post([FromBody] Product product)
        {
            _productApiApp.AddProduct(product);
        }

        // PUT: api/Products/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] Product product)
        {
            product.Id = id;
            _productApiApp.UpdateProduct(product);
        }

    }
}
