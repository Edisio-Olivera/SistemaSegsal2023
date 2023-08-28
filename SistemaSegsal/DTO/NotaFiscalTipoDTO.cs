using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSegsal.DTO
{
    class NotaFiscalTipoDTO
    {
        private Int32 _id;
        private string _tipoNotaFiscal;

        public int Id { get => _id; set => _id = value; }
        public string TipoNotaFiscal { get => _tipoNotaFiscal; set => _tipoNotaFiscal = value; }
    }
}
