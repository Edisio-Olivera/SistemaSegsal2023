using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSegsal.DTO
{
    class ChamadoUrgenciaDTO
    {
        private Int32 _id;
        private string _urgencia;

        public int Id { get => _id; set => _id = value; }
        public string Urgencia { get => _urgencia; set => _urgencia = value; }
    }
}
