using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSegsal.DTO
{
    internal class TecnicoEpiDTO
    {
        private Int32 _id;
        private string _tecnico;
        private Int32 _qtd;
        private string _epi;
        private DateTime _dataEntrega;
        private DateTime _dataDevolucao;

        public int Id { get => _id; set => _id = value; }
        public string Tecnico { get => _tecnico; set => _tecnico = value; }
        public int Qtd { get => _qtd; set => _qtd = value; }
        public string Epi { get => _epi; set => _epi = value; }
        public DateTime DataEntrega { get => _dataEntrega; set => _dataEntrega = value; }
        public DateTime DataDevolucao { get => _dataDevolucao; set => _dataDevolucao = value; }
    }
}
