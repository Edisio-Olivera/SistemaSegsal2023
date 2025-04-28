using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSegsal.DTO
{
    internal class TecnicoDocumentoDTO
    {
        private Int32 _id;
        private string _tecnico;
        private string _tipo;
        private string _documento;
        private DateTime _dataRealizado;
        private DateTime _dataVencimento;
        private string _observacao;
        private string _status;

        public int Id { get => _id; set => _id = value; }
        public string Tecnico { get => _tecnico; set => _tecnico = value; }
        public string Documento { get => _documento; set => _documento = value; }
        public DateTime DataRealizado { get => _dataRealizado; set => _dataRealizado = value; }
        public DateTime DataVencimento { get => _dataVencimento; set => _dataVencimento = value; }
        public string Observacao { get => _observacao; set => _observacao = value; }
        public string Tipo { get => _tipo; set => _tipo = value; }
        public string Status { get => _status; set => _status = value; }
    }
}
