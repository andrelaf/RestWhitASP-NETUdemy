using RestWhitASPNETUdemy.Data.VO;

namespace RestWhitASPNETUdemy.Busines
{
    public interface ILoginBusines
    {
        object FindBYLogin(UserVO user);
    }
}
