using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSegsal.DTO
{
    class BaseClienteDTO
    {
		private Int32 _id;
		private string _codigo;
		private string _dataRegistro;
		private string _cliente;
		private string _nomeBase;
		private string _cnpj;
		private string _inscEstadual;
		private string _endereco;
		private string _complemento;
		private string _bairro;
		private string _cidade;
		private string _uf;
		private string _cep;
		private string _telefone;
		private string _email;
		private string _status;

        public int Id { get => _id; set => _id = value; }
        public string Codigo { get => _codigo; set => _codigo = value; }
        public string DataRegistro { get => _dataRegistro; set => _dataRegistro = value; }
        public string Cliente { get => _cliente; set => _cliente = value; }
        public string NomeBase { get => _nomeBase; set => _nomeBase = value; }
        public string Cnpj { get => _cnpj; set => _cnpj = value; }
        public string InscEstadual { get => _inscEstadual; set => _inscEstadual = value; }
        public string Endereco { get => _endereco; set => _endereco = value; }
        public string Complemento { get => _complemento; set => _complemento = value; }
        public string Bairro { get => _bairro; set => _bairro = value; }
        public string Cidade { get => _cidade; set => _cidade = value; }
        public string Uf { get => _uf; set => _uf = value; }
        public string Cep { get => _cep; set => _cep = value; }
        public string Telefone { get => _telefone; set => _telefone = value; }
        public string Email { get => _email; set => _email = value; }
        public string Status { get => _status; set => _status = value; }
    }
}
