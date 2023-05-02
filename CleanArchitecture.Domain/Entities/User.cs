using CleanArchitecture.Domain.Core;

namespace CleanArchitecture.Domain.Entities;

public class User : Entity
{
    public string PhoneNumber { get; set; }
    public string UserName { get; set; }
    public string FullName { get; set; }
    public string LastName { get; set; }
    
}