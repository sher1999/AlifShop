using Domain.Entities;
using Domain.Dtos;
using Domain.Wrapper;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WepApi.Controllers;

[ApiController]
[Route("[controller]")]

public class CategoryController : ControllerBase
{

    private readonly CategoryService _categoryService;

    public CategoryController(CategoryService categoryService)
    {
        _categoryService = categoryService;
    }


    [HttpGet("Get")]
    public async Task<Response<List<GetCategoryDto>>> Gett()
    {
        return await _categoryService.Get();
    }

    [HttpPost("Add")]
    public async Task<Response<AddCategoryDto>> Addd(AddCategoryDto model)
    {
      return  await _categoryService.Add(model);

    }
}

