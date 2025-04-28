using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSegsal.DTO
{
    internal class SexoDTO
    {
        private Int32 _id;
        private string _sexo;

        public int Id { get => _id; set => _id = value; }
        public string Sexo { get => _sexo; set => _sexo = value; }
    }
}
