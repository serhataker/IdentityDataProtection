using IdentityDataProtection.Dto;
using IdentityDataProtection.Types;
using Microsoft.AspNetCore.Mvc;


namespace IdentityDataProtection.Services
{

    
    public interface IUserService
    {

        // for the user servixe interface
        Task<ServiceMessage> AddUser(UserRequest User);
    }
}
