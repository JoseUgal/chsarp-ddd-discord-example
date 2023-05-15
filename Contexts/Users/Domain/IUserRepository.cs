namespace Discord.Contexts.Users.Domain;

public interface IUserRepository
{
    Task<User?> Search(UserId userId);
    
    Task Save(User user);
}