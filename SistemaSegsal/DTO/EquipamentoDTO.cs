using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSegsal.DTO
{
    class EquipamentoDTO
    {
        private Int32 _id;
        private string _fabricante;
        private string _categoria;
        private string _modelo;
        private string _ncm;
        private string _unidade;
        private Int32 _estoque;
        private Int32 _valorCompra;
        private Int32 _valorVenda;
        private string _imagem;

        public int Id { get => _id; set => _id = value; }
        public string Fabricante { get => _fabricante; set => _fabricante = value; }
        public string Categoria { get => _categoria; set => _categoria = value; }
        public string Modelo { get => _modelo; set => _modelo = value; }
        public string Ncm { get => _ncm; set => _ncm = value; }
        public string Unidade { get => _unidade; set => _unidade = value; }
        public int Estoque { get => _estoque; set => _estoque = value; }
        public int ValorCompra { get => _valorCompra; set => _valorCompra = value; }
        public int ValorVenda { get => _valorVenda; set => _valorVenda = value; }
        public string Imagem { get => _imagem; set => _imagem = value; }
    }
}
