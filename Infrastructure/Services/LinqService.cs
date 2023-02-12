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

public class LinqService
{
    private readonly DataContext _context;
    private readonly IMapper _mapper;

    public LinqService(DataContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

   
    public async Task<Response<string>> GetPriceCount(string product, decimal price, string phoneNumber, int range)
    {
        var categoriId = await (from p in _context.Products
            where (p.ProductName == product && p.Price == price)
            select p.CategoryId).FirstOrDefaultAsync();
        
       
        var test2 =await _context.Customers.Where(x => x.PhoneNumber == phoneNumber).CountAsync();
        if (test2 >0)
        { 
            
            if (categoriId == 1 )
            {   
               
                
                if (range==3 || range==6 || range==9)
                {
                    return new Response<string>($" Total payment amount : {price} somoni");
                }

                if (range == 12)
                {
                    return new Response<string>($"Total payment amount : {((price * 3) / 100) + price} somoni");

                }

                if (range == 18)
                {
                    return new Response<string>($"Total payment amount : {((price * 6) / 100) + price} somoni");

                }

                if (range == 24)
                {
                    return new Response<string>($"Total payment amount : {((price * 9) / 100) + price} somoni");

                }

                return new Response<string>("Diapazon xato");

            }

            if (categoriId == 2)
            {
                if (range==3 || range==6 || range==9 || range==12)
                {
                    return new Response<string>($"Total payment amount : {price} somoni");
                }

                if (range == 18)
                {
                    return new Response<string>($"Total payment amount : {((price * 4) / 100) + price} somoni");

                }

                if (range == 24)
                {
                    return new Response<string>($"Total payment amount : {((price * 8) / 100) + price} somoni");

                }
                return new Response<string>("Diapazon xato");
            }

            if (categoriId == 3)
                    {
                        if (range==3 || range==6 || range==9 || range==12 || range==18)
                        {
                            return new Response<string>($"Total payment amount : {price} somoni");
                        }

                        if (range == 24)
                        {
                            return new Response<string>($"Total payment amount : {((price * 5) / 100) + price} somoni");

                        }
                        return new Response<string>("Diapazon xato");
                    }

            else
            {
                return new Response<string>("Product vujud nadorad");
            }

        }

                return new Response<string>($"poneNumber xato  ");
            }


        }
    

