using System.Text.Json.Serialization;
using Core.Enums;

namespace Core.Models;

public class User
{
    public long Id { get; set; }
    public required string Username { get; set; }
    public required string Email { get; set; }
    public required string PasswordHash { get; set; }
    public required string ProfileImageUri { get; set; }

    public int Height { get; set; }
    public int Weight { get; set; }
    public int Age { get; set; }
    public ActivityLevel ActivityLevel { get; set; }

    public List<Follow> Follows { get; set; } = [];
    public List<Follow> Followers { get; set; } = [];
}