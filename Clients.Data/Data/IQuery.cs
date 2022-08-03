namespace Clients.Services.Services.Generic
{
    using System.Collections.Generic;

    public interface IQuery<T>
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
    }
}
