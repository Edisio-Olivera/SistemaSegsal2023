using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSegsal.DTO
{
    class ChamadoAtendimentoDTO
    {
        private Int32 _id;
        private string _chamado;
        private string _tipo;
        private string _tecnico;
        private string _dataInicio;
        private string _horaInicio;
        private string _atividadeRealizada;
        private string _dataFinal;
        private string _horaFinal;
        private Int32 _valor;

        public int Id { get => _id; set => _id = value; }
        public string Chamado { get => _chamado; set => _chamado = value; }
        public string Tecnico { get => _tecnico; set => _tecnico = value; }
        public string DataInicio { get => _dataInicio; set => _dataInicio = value; }
        public string HoraInicio { get => _horaInicio; set => _horaInicio = value; }
        public string AtividadeRealizada { get => _atividadeRealizada; set => _atividadeRealizada = value; }
        public string DataFinal { get => _dataFinal; set => _dataFinal = value; }
        public string HoraFinal { get => _horaFinal; set => _horaFinal = value; }
        public int Valor { get => _valor; set => _valor = value; }
        public string Tipo { get => _tipo; set => _tipo = value; }
    }
}
