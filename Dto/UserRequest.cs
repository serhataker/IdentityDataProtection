using System.ComponentModel.DataAnnotations;

namespace IdentityDataProtection.Dto
{
    public class UserRequest
    {
      // for the data transit
        public string Email { get; set; }

     
        public string Password { get; set; }
    }
}
