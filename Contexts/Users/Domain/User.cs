using Discord.Shared.Domain.Entities;

namespace Discord.Contexts.Users.Domain;

public class User : Entity
{
    public UserId Id { get; }
    public UserWebName WebName { get; private set; }
    public UserEmail Email { get; private set; }
    public UserDateOfBirth DateOfBirth { get; private set; }
    public UserImageUrl? ImageUrl { get; private set; }

    public static User Create(UserId id, UserWebName webName, UserEmail email, UserDateOfBirth dateOfBirth,
        UserImageUrl? imageUrl)
    {
        var user = new User(id, webName, email, dateOfBirth, imageUrl);

        // user.Record(null);
        
        return user;
    }

    public void ChangeEmail(UserEmail email)
    {
        Email = email;
    }

    public void ChangeDateOfBirth(UserDateOfBirth dateOfBirth)
    {
        DateOfBirth = dateOfBirth;
    }
    
    public void ChangeImageUrl(UserImageUrl? imageUrl)
    {
        ImageUrl = imageUrl;
    }

    protected User(UserId id, UserWebName webName, UserEmail email, UserDateOfBirth dateOfBirth, UserImageUrl? imageUrl)
    {
        Id = id;
        WebName = webName;
        Email = email;
        DateOfBirth = dateOfBirth;
        ImageUrl = imageUrl;
    }
    
    private User () {}
}