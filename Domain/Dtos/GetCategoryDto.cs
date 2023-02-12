

namespace Domain.Dtos;

public class GetCategoryDto
{
    public int Id { get; set; }
    public string CategoryName { get; set; }
    public GetCategoryDto()
    {
            
    }

    public GetCategoryDto(int id, string categoryName)
    {
        Id = id;
        CategoryName = categoryName;    
    }
}

