using odonto_facisa.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odonto_facisa.dao.impl
{
    internal class InMemoryAtendimento : InMemory<Atendimento>
    {
        private static List<Atendimento> atendimentos = new();

        public override void delete(Atendimento entidade)
        {
           atendimentos.Remove(entidade);
        }

        public override Atendimento Get(string id)
        {
            var exists = atendimentos.Find(at => at.Id.Equals(id));

           return exists != null ? exists : throw new Exception("Não foi possivel encontrar o Atendimento com o ID:" + id);
        }

        public override List<Atendimento> GetAll()
        {
            return atendimentos;
        }

        public override void Save(Atendimento entidade)
        {
           atendimentos.Add(entidade);
        }
    }
}
