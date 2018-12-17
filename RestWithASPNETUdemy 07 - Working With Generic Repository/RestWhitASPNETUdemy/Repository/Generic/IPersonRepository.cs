using RestWhitASPNETUdemy.Model;
using System.Collections.Generic;

namespace RestWhitASPNETUdemy.Repository.Generic
{
    public interface IPersonRepository : IRepository<Person>
    {
        List<Person> FindByName(string firstName, string lastName);
    }
}
