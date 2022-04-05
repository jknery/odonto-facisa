using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using odonto_facisa.models;

namespace odonto_facisa.dao
{
    public abstract class InMemory<T>
    {

        public abstract void Save(T entidade);

        public abstract T Get(string id);

        public abstract List<T> GetAll();

        public abstract void delete(T entidade);
    }
}
