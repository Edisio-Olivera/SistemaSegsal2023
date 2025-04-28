using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSegsal.DTO
{
    internal class DocumentoTipoDTO
    {
        private Int32 _id;
        private string _tipo;
        private string _documento;
        private Int32 _validade;

        public int Id { get => _id; set => _id = value; }
        public string Tipo { get => _tipo; set => _tipo = value; }
        public string Documento { get => _documento; set => _documento = value; }
        public int Validade { get => _validade; set => _validade = value; }
    }
}
