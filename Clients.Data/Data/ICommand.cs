using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clients.Services.Services.Generic
{
    public interface ICommand<T>
    {
        void Insert(T obj);
        void Update(T obj);
        void Delete(T obj);
    }
}
