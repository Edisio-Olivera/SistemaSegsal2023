using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSegsal.DTO
{
    class EquipamentoModeloDTO
    {
        private Int32 _id;
        private string _categoria;
        private string _fabricante;
        private string _descritivo;
        private string _unidade;
        private string _ncm;
        private string _imagem;

        public int Id { get => _id; set => _id = value; }
        public string Categoria { get => _categoria; set => _categoria = value; }
        public string Fabricante { get => _fabricante; set => _fabricante = value; }
        public string Descritivo { get => _descritivo; set => _descritivo = value; }
        public string Ncm { get => _ncm; set => _ncm = value; }
        public string Imagem { get => _imagem; set => _imagem = value; }
        public string Unidade { get => _unidade; set => _unidade = value; }
    }
}
