using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Customer
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
    public List<Order> Orders { get; set; }
    
    public Customer()
    {
        
    }

    public Customer(int id, string firstName, string lastName, string phoneNumber, string email, string address)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        PhoneNumber = phoneNumber;
        Email = email;
        Address = address;
        
    }


   
    

}