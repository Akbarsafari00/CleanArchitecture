using CleanArchitecture.Domain.Core;

namespace CleanArchitecture.Domain.Entities;

public class Users : Entity
{
    public string UserName { get; set; }
    public string FullName { get; set; }
    public string LastName { get; set; }
    
}