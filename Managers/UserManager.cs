using IdentityDataProtection.Data;
using IdentityDataProtection.Dto;
using IdentityDataProtection.Entities;
using IdentityDataProtection.Services;
using IdentityDataProtection.Types;

namespace IdentityDataProtection.Managers
{
    
    public class UserManager : IUserService
    {

        private readonly DataContext _dataContext; // for the dependncy db context
        private readonly PasswordService _passwordService;// for the hash password
        public UserManager(DataContext dataContext, PasswordService passwordService)

        {
            _dataContext = dataContext;
            _passwordService = passwordService;
            
        }
        public async Task<ServiceMessage> AddUser(UserRequest user)
        {
            //To send the data from the userentity we will derive

            var hashedPassword = _passwordService.HashPassword(user.Password);// Hash

            var newUser = new UserEntity
            {
                Email = user.Email,
                Password = hashedPassword


            };
            _dataContext.Add(newUser);// add db with context 
            await _dataContext.SaveChangesAsync();

            return new ServiceMessage
            {
                IsSucceed = true,
                Message = "Create user success."
            };
        }

       
    }
}
