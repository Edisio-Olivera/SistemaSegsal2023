using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSegsal.DTO
{
    class UfDTO
    {
        private Int32 _id;
        private string _estado;
        private string _sigla;

        public int Id { get => _id; set => _id = value; }
        public string Estado { get => _estado; set => _estado = value; }
        public string Sigla { get => _sigla; set => _sigla = value; }
    }
}
