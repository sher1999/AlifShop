using System.ComponentModel.DataAnnotations;
using Domain.Entities;

namespace Domain.Dtos;

public class GetProductDto
{
    public  int Id { get; set; }
    [Required,MaxLength(100)]
    public string ProductName { get; set; }
    [Required]
    public decimal Price { get; set; }
    public int CategoryId { get; set; }
  
    public GetProductDto()
    {
            
    }

    public GetProductDto(int id, string productName, decimal price, int categoryId)
    {
        Id = id;
        ProductName = productName;
        Price = price;
        CategoryId = categoryId;    
    }
}