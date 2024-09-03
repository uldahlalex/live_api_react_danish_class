using Microsoft.AspNetCore.Mvc;
using service;

namespace api.Controllers;

[ApiController]
[Route("api/products")]
public class ProductController(ProductService service) : ControllerBase
{
    [HttpGet]
    [Route("")]
    public ActionResult GetProducts()
    {
        var products = service.GetProducts();
        return Ok(products);
    }


    [HttpPost]
    [Route("{id}")]
    public ActionResult CreateProduct([FromBody] Product p)
    {
        var product = service.CreateProduct(p);
        return Ok(product);
    }
    
}