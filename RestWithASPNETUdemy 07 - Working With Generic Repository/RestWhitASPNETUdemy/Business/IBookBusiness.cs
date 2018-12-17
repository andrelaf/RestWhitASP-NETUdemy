using RestWhitASPNETUdemy.Data.VO;
using System.Collections.Generic;

namespace RestWhitASPNETUdemy.Busines
{
    public interface IBookBusiness
    {
        BookVO Create(BookVO book);
        BookVO FindById(long id);
        List<BookVO> FindAll();
        BookVO Update(BookVO book);
        void Delete(long id);
    }
}
