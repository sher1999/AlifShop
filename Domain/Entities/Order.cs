using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Order
{
    public  int Id { get; set; }
    public DateTime OrdeDate { get; set; }
    [Required]
    public int Range { get; set; }
    public int CustomerId { get; set; }
    public Customer Customer { get; set; }
    public List<OrderProduct> OrderProducts { get; set; }
    public Order()
    {
        
    }

    public Order(int id, int range, int customerId) 
    {
        Id = id;
        OrdeDate = DateTime.UtcNow;
        Range = range;
      
        CustomerId = customerId;
        
    }
}