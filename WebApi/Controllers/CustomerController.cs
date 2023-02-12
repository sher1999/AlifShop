using Domain.Entities;
using Domain.Dtos;
using Domain.Wrapper;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WepApi.Controllers;

[ApiController]
[Route("[controller]")]

public class CustomerController : ControllerBase
{

    private readonly CustomerService _customerService;

    public CustomerController(CustomerService customerService)
    {
        _customerService = customerService;
    }


    [HttpGet("Get")]
    public async Task<Response<List<GetCostomerDto>>> Gett()
    {
        return await _customerService.Get();
    }

    [HttpPost("Add")]
    public async Task<Response<string>> Addd(AddCostomerDto model)
    {
        return  await _customerService.Add(model);

    }
    [HttpDelete("{id}")]
    public async Task Deletee(int id) => await _customerService.Delete(id);
}


