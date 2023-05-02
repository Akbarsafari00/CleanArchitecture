using CleanArchitecture.Domain.Core;

namespace CleanArchitecture.Domain.Entities;

public class VerificationCode : Entity
{
    public string PhoneNumber { get; set; }
    public string Code { get; set; }
    public DateTime ExpireAt { get; set; }
}