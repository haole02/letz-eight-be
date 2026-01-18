using System.Diagnostics.CodeAnalysis;

namespace Wrkom.ApplicationCore.Entities;

public class User
{
    public required string Username { get; set; }
    public required string PasswordHash { get; set; }
    public DateOnly DateOfBirth { get; set; }

    public User()
    {
        var now = DateTime.Now;
        DateOfBirth = DateOnly.FromDateTime(now);
    }

    [SetsRequiredMembers]
    public User(string username, string password) : this()
    {
        Username = username;
        PasswordHash = password.ToUpper();
    }
}