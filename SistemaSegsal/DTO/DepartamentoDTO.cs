using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSegsal.DTO
{
    class DepartamentoDTO
    {
        private Int32 _id;
        private string _departamento;

        public int Id { get => _id; set => _id = value; }
        public string Departamento { get => _departamento; set => _departamento = value; }
    }
}
