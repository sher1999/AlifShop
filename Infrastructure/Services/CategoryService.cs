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

public class CategoryService
{
    private readonly DataContext _context;
    private readonly IMapper _mapper;

    public CategoryService(DataContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }


    public async Task<Response<List<GetCategoryDto>>> Get()
    {
        var response = await _context.Categories.ToListAsync();
        var mapped = _mapper.Map<List<GetCategoryDto>>(response);
        return new Response<List<GetCategoryDto>>(mapped);
    }

    public async Task<Response<AddCategoryDto>> Add(AddCategoryDto model)
    {

       
            var mapped = _mapper.Map<Category>(model);
            await _context.Categories.AddAsync(mapped);
            await _context.SaveChangesAsync();
            model.Id = mapped.Id;
            return new Response<AddCategoryDto>(model);
       
    }

}