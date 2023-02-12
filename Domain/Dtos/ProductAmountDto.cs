using System.ComponentModel.DataAnnotations;

namespace Domain.Dtos;

public class ProductAmountDto
{
    
    public decimal PriceCount { get; set; }
   

    public ProductAmountDto()
    {
        
    }

    public ProductAmountDto(decimal priceCount)
    {
        PriceCount = priceCount;    
    }
}