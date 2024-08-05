namespace FA.Client.Common.Contracts.Request.Users;

public class UsersRegisterRequest
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}