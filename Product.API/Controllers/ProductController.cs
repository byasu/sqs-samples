using Microsoft.AspNetCore.Mvc;
using Product.API.Contracts.Requests;
using Product.API.Mapping;
using Product.API.Services;

namespace Product.API.Controllers;

[ApiController]
public class ProductController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpPost("api/products")]
    public async Task<IActionResult> PostAsync([FromBody] ProductRequest productRequest)
    {
        var product = productRequest.ToProduct();
        await _productService.AddAsync(product);
        return Ok();
    }

    [HttpGet("api/products")]
    public async Task<IActionResult> GetProducts()
    {
        return Ok(await _productService.GetAllAsync());
    }
}