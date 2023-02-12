using Domain.Entities;
using Domain.Dtos;
using Domain.Wrapper;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WepApi.Controllers;

[ApiController]
[Route("[controller]")]

public class GetLinqController : ControllerBase
{

    private readonly LinqService _linqService;

    public GetLinqController(LinqService linqService)
    {
        _linqService = linqService;
    }
        
    [HttpGet("Get")]
    public async Task<Response<string>> GetPriceCount(string product, decimal price, string phoneNumber, int range)
    {
        return await _linqService.GetPriceCount(product,price,phoneNumber,range);
    }
    
    }

