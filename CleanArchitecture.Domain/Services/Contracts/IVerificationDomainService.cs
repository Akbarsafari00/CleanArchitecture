using System.Security.Cryptography.X509Certificates;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Domain.Services.Contracts;

public interface IVerificationDomainService
{
    Task<VerificationCode> GenerateCodeForUserAsync(Users users , CancellationToken cancellationToken = default);
}