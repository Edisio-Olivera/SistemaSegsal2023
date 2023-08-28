using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSegsal.DTO
{
    class CidadeDTO
    {
        private Int32 _id;
        private string _uf;
        private string _cidade;

        public int Id { get => _id; set => _id = value; }
        public string Uf { get => _uf; set => _uf = value; }
        public string Cidade { get => _cidade; set => _cidade = value; }
    }
}
