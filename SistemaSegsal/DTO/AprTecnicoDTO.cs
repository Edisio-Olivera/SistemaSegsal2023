using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSegsal.DTO
{
    internal class AprTecnicoDTO
    {
        private Int32 _id;
        private string _apr;
        private string _tecnico;

        public int Id { get => _id; set => _id = value; }
        public string Apr { get => _apr; set => _apr = value; }
        public string Tecnico { get => _tecnico; set => _tecnico = value; }
    }
}
