using Domain.Entities;
using Domain.Dtos;
using Domain.Wrapper;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WepApi.Controllers;

[ApiController]
[Route("[controller]")]

public class ProductController : ControllerBase
{

    private readonly ProductService _productService;

    public ProductController(ProductService productService)
    {
        _productService = productService;
    }


    [HttpGet("Get")]
    public async Task<Response<List<GetProductDto>>> Gett()
    {
        return await _productService.Get();
    }

    [HttpPost("Add")]
    public async Task<Response<AddProductDto>> Addd(AddProductDto model)
    {
        return  await _productService.Add(model);

    }
    
    [HttpPut("Update")]
    public async Task<Response<AddProductDto>> UpdateTodo(AddProductDto todo)
    {
        return await _productService.Update(todo);
    }
}

