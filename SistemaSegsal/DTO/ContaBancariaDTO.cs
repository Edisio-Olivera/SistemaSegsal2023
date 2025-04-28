using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSegsal.DTO
{
    class ContaBancariaDTO
    {
        private Int32 _id;
        private DateTime _dataRegistro;
        private string _nome;
        private string _tipo;
        private string _banco;
        private string _agencia;
        private string _numero;
        private Int32 _saldo;

        public int Id { get => _id; set => _id = value; }
        public DateTime DataRegistro { get => _dataRegistro; set => _dataRegistro = value; }
        public string Tipo { get => _tipo; set => _tipo = value; }
        public string Banco { get => _banco; set => _banco = value; }
        public string Agencia { get => _agencia; set => _agencia = value; }
        public string Numero { get => _numero; set => _numero = value; }
        public int Saldo { get => _saldo; set => _saldo = value; }
        public string Nome { get => _nome; set => _nome = value; }
    }
}
