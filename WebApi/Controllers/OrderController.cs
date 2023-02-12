using Domain.Entities;
using Domain.Dtos;
using Domain.Wrapper;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WepApi.Controllers;

[ApiController]
[Route("[controller]")]

public class OrderController : ControllerBase
{

    private readonly OrderService _orderService;

    public OrderController(OrderService orderService)
    {
        _orderService = orderService;
    }


    [HttpGet("Get")]
    public async Task<Response<List<GetOrderDto>>> Gett()
    {
        return await _orderService.Get();
    }

    [HttpPost("Add")]
    public async Task<Response<AddOrderDto>> Addd(AddOrderDto model)
    {
        return  await _orderService.Add(model);

    }
}


