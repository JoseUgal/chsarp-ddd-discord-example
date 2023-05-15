using Discord.Contexts.Users.Domain;

namespace Discord.Contexts.Users.Application.Create;

public class UserCreator
{
    private readonly IUserRepository _userRepository;

    public UserCreator(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task Create(UserId id, UserWebName webName, UserEmail email, UserDateOfBirth dateOfBirth, UserImageUrl? imageUrl)
    {
        var user = User.Create(id, webName, email, dateOfBirth, imageUrl);

        await _userRepository.Save(user);

        // TODO: _eventBus.Publish(user.PullDomainEvents());
    }
}