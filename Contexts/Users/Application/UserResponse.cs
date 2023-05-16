using Discord.Contexts.Users.Domain;

namespace Discord.Contexts.Users.Application;

public class UserResponse
{
    public string Id { get; set; }
    public string WebName { get; set; }
    public string Email { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string? ImageUrl { get; set; }
    
    public UserResponse(string id, string webName, string email, DateTime dateOfBirth, string? imageUrl)
    {
        Id = id;
        WebName = webName;
        Email = email;
        DateOfBirth = dateOfBirth;
        ImageUrl = imageUrl;
    }
    
    
    public static UserResponse FromAggregate(User user)
    {
        return new UserResponse(
            user.Id.Value,
            user.WebName.Value,
            user.Email.Value,
            user.DateOfBirth.Value,
            user.ImageUrl?.Value
        );
    }
}