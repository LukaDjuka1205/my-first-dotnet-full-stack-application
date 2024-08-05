namespace FA.Client.Be.Repository.Entity;

public class UserEntity
{
    public long Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }
}