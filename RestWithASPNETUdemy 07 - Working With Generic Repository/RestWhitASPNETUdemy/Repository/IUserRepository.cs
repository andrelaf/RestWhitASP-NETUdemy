using RestWhitASPNETUdemy.Model;

namespace RestWhitASPNETUdemy.Business
{
    public interface IUserRepository
    {
        User FindByLogin(string login);
    }
}
