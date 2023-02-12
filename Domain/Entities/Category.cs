namespace Domain.Entities;

public class Category
{
    public int Id { get; set; }
    public string CategoryName { get; set; }
     public List<Product> Products { get; set; }
    public Category()
    {
            
    }

    public Category(int id, string categoryName)
    {
        Id = id;
        CategoryName = categoryName;    
    }
}