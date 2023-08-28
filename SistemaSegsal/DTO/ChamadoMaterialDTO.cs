using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSegsal.DTO
{
    class ChamadoMaterialDTO
    {
        private Int32 _id;
        private string _chamado;
        private string _tipoMaterial;
        private string _descricao;
        private string _unidade;
        private Int32 _qtd;
        private Int32 _valorUnitario;
        private Int32 _valorTotal;

        public int Id { get => _id; set => _id = value; }
        public string Chamado { get => _chamado; set => _chamado = value; }
        public string TipoMaterial { get => _tipoMaterial; set => _tipoMaterial = value; }
        public string Descricao { get => _descricao; set => _descricao = value; }
        public string Unidade { get => _unidade; set => _unidade = value; }
        public int Qtd { get => _qtd; set => _qtd = value; }
        public int ValorUnitario { get => _valorUnitario; set => _valorUnitario = value; }
        public int ValorTotal { get => _valorTotal; set => _valorTotal = value; }
    }
}
