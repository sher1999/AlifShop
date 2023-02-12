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

public class ProductService
{
    private readonly DataContext _context;
    private readonly IMapper _mapper;

    public ProductService(DataContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }


    public async Task<Response<List<GetProductDto>>> Get()
    {
        var response = await _context.Products.ToListAsync();
        var mapped = _mapper.Map<List<GetProductDto>>(response);
        return new Response<List<GetProductDto>>(mapped);
    }

    public async Task<Response<AddProductDto>> Add(AddProductDto model)
    {

       
        var mapped = _mapper.Map<Product>(model);
        await _context.Products.AddAsync(mapped);
        await _context.SaveChangesAsync();
        model.Id = mapped.Id;
        return new Response<AddProductDto>(model);
       
    }
    
    public async Task<Response<AddProductDto>> Update(AddProductDto todo)
    {
        var existing = await _context.Products.FindAsync(todo.Id);
        if(existing == null) return new Response<AddProductDto>(HttpStatusCode.NotFound,new List<string>(){$"Not found"});
        existing.Id = todo.Id;
        existing.ProductName = todo.ProductName;
        existing.Price = todo.Price;
        existing.CategoryId = todo.CategoryId;
        await _context.SaveChangesAsync();
        return new Response<AddProductDto>(todo);


    }

}
