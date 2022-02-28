using Dotsql.Models;

namespace Dotsql.Repositories;

public interface IUserRepository
{
    Task<User> Create(User Item);
    Task Update(User Item);
    Task Delete(long EmployeeNumber);
    Task<User> GetById(long EmployeeNumber);
    Task<List<User>> GetList();

}
public class UserRepository : IUserRepository
{
    public UserRepository()
    {

    }

    public Task<User> Create(User Item)
    {
        throw new NotImplementedException();
    }

    public Task Delete(long EmployeeNumber)
    {
        throw new NotImplementedException();
    }

    public Task<User> GetById(long EmployeeNumber)
    {
        throw new NotImplementedException();
    }

    public Task<List<User>> GetList()
    {
        throw new NotImplementedException();
    }

    public Task Update(User Item)
    {
        throw new NotImplementedException();
    }
}