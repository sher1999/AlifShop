using System.ComponentModel.DataAnnotations;
using Domain.Entities;

namespace Domain.Dtos;

public class GetOrderDto
{
    public  int Id { get; set; }
    public DateTime OrdeDate { get; set; }
    [Required]
    public int Range { get; set; }
  
    public int CustomerId { get; set; }

    public GetOrderDto()
    {
        
    }

    public GetOrderDto(int id, int range,  int customerId) 
    {
        Id = id;
        OrdeDate = DateTime.UtcNow;
        Range = range;
        CustomerId = customerId;
        
    }
}