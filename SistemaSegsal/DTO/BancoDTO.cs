using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSegsal.DTO
{
    internal class BancoDTO
    {
        private Int32 _id;
        private string _nome;
        private string _codigo;

        public int Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Codigo { get => _codigo; set => _codigo = value; }
    }
}
