using odonto_facisa.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odonto_facisa.dao.impl
{
    internal class InMemoryProcedimento : InMemory<Procedimento>
    {
        private static List<Procedimento> procedimentos = new();

        public override void delete(Procedimento entidade)
        {
            procedimentos.Remove(entidade);
        }

        public override Procedimento Get(string codigo)
        {
            var exists = procedimentos.Find(pr => pr.Codigo.Equals(codigo));

            return exists != null ? exists : throw new Exception("Não foi possivel encontrar o Procedimento com o CÓDIGO:" + codigo);
        }

        public override List<Procedimento> GetAll()
        {
            return procedimentos;
        }

        public override void Save(Procedimento entidade)
        {
           procedimentos.Add(entidade);
        }
    }
}
