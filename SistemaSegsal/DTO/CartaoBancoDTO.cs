using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSegsal.DTO
{
    internal class CartaoBancoDTO
    {
        private Int32 _id;
        private DateTime _dataRegistro;
        private string _tipoCartao;
        private string _banco;
        private string _apelido;
        private string _numero;
        private string _bandeira;
        private Int32 _diaVencimento;
        private Int32 _melhorDia;
        private Int32 _limite;
        private Int32 _limiteUtilizado;
        private Int32 _limiteDisponivel;
        private string _imagem;

        public int Id { get => _id; set => _id = value; }
        public DateTime DataRegistro { get => _dataRegistro; set => _dataRegistro = value; }
        public string TipoCartao { get => _tipoCartao; set => _tipoCartao = value; }
        public string Banco { get => _banco; set => _banco = value; }
        public string Apelido { get => _apelido; set => _apelido = value; }
        public string Numero { get => _numero; set => _numero = value; }
        public string Bandeira { get => _bandeira; set => _bandeira = value; }
        public int DiaVencimento { get => _diaVencimento; set => _diaVencimento = value; }
        public int MelhorDia { get => _melhorDia; set => _melhorDia = value; }
        public int Limite { get => _limite; set => _limite = value; }
        public int LimiteUtilizado { get => _limiteUtilizado; set => _limiteUtilizado = value; }
        public int LimiteDisponivel { get => _limiteDisponivel; set => _limiteDisponivel = value; }
        public string Imagem { get => _imagem; set => _imagem = value; }
    }
}
