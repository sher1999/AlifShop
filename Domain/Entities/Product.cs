using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Product
{
    public  int Id { get; set; }
    [Required,MaxLength(100)]
    public string ProductName { get; set; }
    [Required]
    public decimal Price { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    public List<OrderProduct> OrderProducts { get; set; }
    public Product()
    {
            
    }

    public Product(int id, string productName, decimal price, int categoryId)
    {
        Id = id;
        ProductName = productName;
        Price = price;
        CategoryId = categoryId;    
    }
}