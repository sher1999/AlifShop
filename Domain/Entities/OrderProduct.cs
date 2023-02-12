namespace Domain.Entities;

public class OrderProduct
{
    public int OrderId { get; set; }
    public Order Order { get; set; }
    public int ProductId { get; set; }
    public Product Product { get; set; }
    
    public OrderProduct()
    {
        
    }
          
    public OrderProduct(int orderId, int productId)
    {
        OrderId = orderId;
        ProductId = productId;
    }
}