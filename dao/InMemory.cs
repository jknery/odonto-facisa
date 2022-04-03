using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using odonto_facisa.models;

namespace odonto_facisa.dao
{
    public interface InMemory<T>
    {

        void Save(T entidade);

        T Get(string id);

        List<T> GetAll();

        void delete(string id);
    }
}
