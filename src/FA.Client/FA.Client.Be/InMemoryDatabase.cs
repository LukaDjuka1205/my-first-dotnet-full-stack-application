using FA.Client.Be.Entity;

namespace FA.Client.Be;

public static class InMemoryDatabase
{
    public static List<UserEntity> Users { get; set; } = new()
    {
        new UserEntity
        {
            Id = 1,
            Username = "admin",
            Password = "admin",
            FirstName = "Admin",
            LastName = "Admin"
        },
        new UserEntity
        {
            Id = 2,
            Username = "user",
            Password = "user",
            FirstName = "User",
            LastName = "User"
        },
        new UserEntity
        {
            Id = 3,
            Username = "john",
            Password = "john",
            FirstName = "John",
            LastName = "Doe"
        },
        new UserEntity
        {
            Id = 4,
            Username = "jane",
            Password = "jane",
            FirstName = "Jane",
            LastName = "Doe"
        },
        new UserEntity
        {
            Id = 5,
            Username = "jim",
            Password = "jim",
            FirstName = "Jim",
            LastName = "Beam"
        },
        new UserEntity
        {
            Id = 6,
            Username = "jack",
            Password = "jack",
            FirstName = "Jack",
            LastName = "Daniels"
        },
        new UserEntity
        {
            Id = 7,
            Username = "jerry",
            Password = "jerry",
            FirstName = "Jerry",
            LastName = "Tom"
        },
        new UserEntity
        {
            Id = 8,
            Username = "tom",
            Password = "tom",
            FirstName = "Tom",
            LastName = "Jerry"
        },
        new UserEntity
        {
            Id = 9,
            Username = "jimmy",
            Password = "jimmy",
            FirstName = "Jimmy",
            LastName = "Hendrix"
        },
        new UserEntity
        {
            Id = 10,
            Username = "jimi",
            Password = "jimi",
            FirstName = "Jimi",
            LastName = "Hendrix"
        }
    };
}