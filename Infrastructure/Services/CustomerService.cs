using  Domain.Dtos;
using Domain.Entities;
using Infrastructure.MapperProfiles;
using Infrastructure.SeedData;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using System.Net;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices.JavaScript;
using Domain.Wrapper;

namespace Infrastructure.Services;

public class CustomerService
{
    private readonly DataContext _context;
    private readonly IMapper _mapper;

    public CustomerService(DataContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }


    public async Task<Response<List<GetCostomerDto>>> Get()
    {
        var response = await _context.Customers.ToListAsync();
        var mapped = _mapper.Map<List<GetCostomerDto>>(response);
        return new Response<List<GetCostomerDto>>(mapped);
    }

    public async Task<Response<string>> Add(AddCostomerDto model)
    {

        var test =await _context.Customers.Where(x => x.PhoneNumber == model.PhoneNumber).CountAsync();
        if (test==0)
        {
            var mapped = _mapper.Map<Customer>(model);
            await _context.Customers.AddAsync(mapped);
            await _context.SaveChangesAsync();
            model.Id = mapped.Id;
            return new Response<string>("Xushru ilova shud");
        }

        return new Response<string>("PhonNumber vujud dorad");
    }
      
       

 
public async Task<bool>  Delete(int id)
{
    var entity=await _context.Customers.FindAsync(id);
    _context.Remove(entity);
    await  _context.SaveChangesAsync();
    return true;
      
}

}

