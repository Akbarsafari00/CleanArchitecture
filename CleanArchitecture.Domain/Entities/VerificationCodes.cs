namespace CleanArchitecture.Domain.Entities;

public class VerificationCode
{
    public string Id { get; set; }
    public string Phone { get; set; }
    public string Code { get; set; }
    public DateTime ExpireAt { get; set; }
}