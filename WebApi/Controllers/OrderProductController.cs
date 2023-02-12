using Domain.Entities;
using Domain.Dtos;
using Domain.Wrapper;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WepApi.Controllers;

[ApiController]
[Route("[controller]")]

public class OrderProductController : ControllerBase
{

    private readonly OrderProductService _orderProductService;

    public OrderProductController(OrderProductService orderProductService)
    {
        _orderProductService = orderProductService;
    }


    [HttpGet("Get")]
    public async Task<Response<List<GetOrderProductDto>>> Gett()
    {
        return await _orderProductService.Get();
    }

    [HttpPost("Add")]
    public async Task<Response<AddOrderProductDto>> Addd(AddOrderProductDto model)
    {
        return  await _orderProductService.Add(model);

    }
}


