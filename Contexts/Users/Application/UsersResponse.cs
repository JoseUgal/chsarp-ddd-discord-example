namespace Discord.Contexts.Users.Application;

public class UsersResponse
{
    public IEnumerable<UserResponse> Users { get; set; }

    public UsersResponse(IEnumerable<UserResponse> users)
    {
        Users = users;
    }
}