using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Repositories;
using CleanArchitecture.Domain.Services.Contracts;

namespace CleanArchitecture.Domain.Services;

public class VerificationDomainService : IVerificationDomainService
{
    private readonly IVerificationCodeRepository _verificationCodeRepository;

    public VerificationDomainService(IVerificationCodeRepository verificationCodeRepository)
    {
        _verificationCodeRepository = verificationCodeRepository;
    }

    public Task<VerificationCode> GenerateCodeForUserAsync(User user, CancellationToken cancellationToken = default)
    {
        var code = new VerificationCode()
        {
            Id = Guid.NewGuid(),
            Code = "12345",
            PhoneNumber = user.PhoneNumber,
            ExpireAt = DateTime.UtcNow.AddMinutes(5)
        };

        return _verificationCodeRepository.InsertAsync(code, cancellationToken);
    }
}