using odonto_facisa.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odonto_facisa.controller
{
    internal abstract class View<T>
    {
        public abstract void ShowMenuSave();

        public abstract void ShowMenuGet();

        public abstract void ShowMenuGetAll();

        public abstract void ShowMenuDelete();

        public abstract InMemory<T> getRepository();
        public static void getHistoryByCpf() { }

        //public abstract void getHistoryByCpf();

    }
}

