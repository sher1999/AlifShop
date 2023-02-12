namespace Domain.Dtos;

public class GetOrderProductDto
{
    public int OrderId { get; set; }
    public int ProductId { get; set; }
   
    
    public GetOrderProductDto()
    {
        
    }
          
    public GetOrderProductDto(int orderId, int productId)
    {
        OrderId = orderId;
        ProductId = productId;
    }
}