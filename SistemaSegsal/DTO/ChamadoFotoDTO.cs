using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSegsal.DTO
{
    class ChamadoFotoDTO
    {
        private Int32 _id;
        private string _chamado;
        private string _rotulo;
        private string _foto;

        public int Id { get => _id; set => _id = value; }
        public string Chamado { get => _chamado; set => _chamado = value; }
        public string Rotulo { get => _rotulo; set => _rotulo = value; }
        public string Foto { get => _foto; set => _foto = value; }
    }
}
