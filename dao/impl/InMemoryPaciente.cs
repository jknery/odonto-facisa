using odonto_facisa.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odonto_facisa.dao.impl
{
    internal class InMemoryPaciente : InMemory<Paciente>
    {
        private List<Paciente> pacientes = new();

        public void delete(string id)
        {
            throw new NotImplementedException();
        }

        public Paciente Get(string cpf)
        {
            var Exist = this.pacientes.Find(paciente => paciente.Cpf.Equals(cpf));

            return Exist != null ? Exist : throw new Exception("Não foi possivel encontrar o Paciente com o CPF:" + cpf);
        }

        public List<Paciente> GetAll()
        {
            return this.pacientes;
        }

        public void Save(Paciente entidade)
        {
            this.pacientes.Add(entidade);
        }
    }
}
