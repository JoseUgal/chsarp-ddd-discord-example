using Discord.Contexts.Users.Domain;

namespace Discord.Contexts.Users.Application.Search;

public class UserSearcher
{
    private readonly IUserRepository _userRepository;
    
    public UserSearcher(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    
    public async Task<UserResponse?> Search(UserId userId)
    {
        var user = await _userRepository.Search(userId);

        if (user is null) return null;
        
        return UserResponse.FromAggregate(user);
    }
}