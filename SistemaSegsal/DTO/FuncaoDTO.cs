using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSegsal.DTO
{
    internal class FuncaoDTO
    {
        private Int32 _id;
        private string _funcao;

        public int Id { get => _id; set => _id = value; }
        public string Funcao { get => _funcao; set => _funcao = value; }
    }
}
