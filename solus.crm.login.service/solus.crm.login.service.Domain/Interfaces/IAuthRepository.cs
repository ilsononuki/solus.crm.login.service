using solus.crm.login.service.Domain.Domain;
using System;

namespace solus.crm.login.service.Domain.Interfaces
{
    public interface IAuthRepository
    {
        AuthModel GetAuth(string Email, string Password);
        void Update(Guid id, AuthModel model);
        bool ExistAccount(string email);
        void Register(AuthModel model);
    }
}
