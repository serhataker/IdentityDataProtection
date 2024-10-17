using Microsoft.AspNetCore.Identity;

public class PasswordService
{
    private readonly PasswordHasher<object> _passwordHasher;// dependency for the hasher password

    public PasswordService()
    {
        _passwordHasher = new PasswordHasher<object>();
    }

    public string HashPassword(string password)
    {
        // create the hasher
        return _passwordHasher.HashPassword(null, password);
    }

    public bool VerifyPassword(string hashedPassword, string password)
    {
        // To verify the hashed password.
        var verificationResult = _passwordHasher.VerifyHashedPassword(null, hashedPassword, password);
        return verificationResult == PasswordVerificationResult.Success;
    }
}
