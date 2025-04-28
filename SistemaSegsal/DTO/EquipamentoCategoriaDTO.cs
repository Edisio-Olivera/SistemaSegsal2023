using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSegsal.DTO
{
    class EquipamentoCategoriaDTO
    {
        private Int32 _id;
        private string _categoria;

        public int Id { get => _id; set => _id = value; }
        public string Categoria { get => _categoria; set => _categoria = value; }
    }
}
