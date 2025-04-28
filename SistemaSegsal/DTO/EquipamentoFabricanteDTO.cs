using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSegsal.DTO
{
    class EquipamentoFabricanteDTO
    {
        private Int32 _id;
        private string _fabricante;

        public int Id { get => _id; set => _id = value; }
        public string Fabricante { get => _fabricante; set => _fabricante = value; }
    }
}
