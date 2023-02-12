using System.ComponentModel.DataAnnotations;
using Domain.Entities;

namespace Domain.Dtos;

public class GetCostomerDto
{
    public  int Id { get; set; }
    [Required,MaxLength(50)]
    public string FirstName { get; set; }
    [Required,MaxLength(50)]
    public string LastName { get; set; }
    [Required,MaxLength(20)]
    public string PhoneNumber { get; set; }
    [Required,MaxLength(100)]
    public string Email { get; set; }
    [Required,MaxLength(50)]
    public string Address { get; set; }
   
    
    public GetCostomerDto()
    {
        
    }

    public GetCostomerDto(int id, string firstName, string lastName, string phoneNumber, string email, string address)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        PhoneNumber = phoneNumber;
        Email = email;
        Address = address;
        
    }


}