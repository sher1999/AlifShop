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

public class OrderProductService
{
    private readonly DataContext _context;
    private readonly IMapper _mapper;

    public OrderProductService(DataContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }


    public async Task<Response<List<GetOrderProductDto>>> Get()
    {
        var response = await _context.OrderProducts.ToListAsync();
        var mapped = _mapper.Map<List<GetOrderProductDto>>(response);
        return new Response<List<GetOrderProductDto>>(mapped);
    }

    public async Task<Response<AddOrderProductDto>> Add(AddOrderProductDto model)
    {

       
        var mapped = _mapper.Map<OrderProduct>(model);
        await _context.OrderProducts.AddAsync(mapped);
        await _context.SaveChangesAsync();
        return new Response<AddOrderProductDto>(model);
       
    }

}

