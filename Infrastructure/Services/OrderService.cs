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
using Domain.Wrapper;

namespace Infrastructure.Services;

public class OrderService
{
    private readonly DataContext _context;
    private readonly IMapper _mapper;

    public OrderService(DataContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }


    public async Task<Response<List<GetOrderDto>>> Get()
    {
        var response = await _context.Orders.ToListAsync();
        var mapped = _mapper.Map<List<GetOrderDto>>(response);
        return new Response<List<GetOrderDto>>(mapped);
    }

    public async Task<Response<AddOrderDto>> Add(AddOrderDto model)
    {

        if ( model.Range==3 || model.Range==6 || model.Range==9 || model.Range==12 || model.Range==18 || model.Range==24)
        {
            var mapped = _mapper.Map<Order>(model);
            await _context.Orders.AddAsync(mapped);
            await _context.SaveChangesAsync();
            model.Id = mapped.Id;
            return new Response<AddOrderDto>(model);
        }
        return new Response<AddOrderDto>(HttpStatusCode.BadRequest,new List<string>(){$"Diapazon nodurust"});
      
       
    }

}


