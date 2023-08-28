using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSegsal.DTO
{
    class ChamadoAssuntoDTO
    {
        private Int32 _id;
        private string _assunto;

        public int Id { get => _id; set => _id = value; }
        public string Assunto { get => _assunto; set => _assunto = value; }
    }
}
