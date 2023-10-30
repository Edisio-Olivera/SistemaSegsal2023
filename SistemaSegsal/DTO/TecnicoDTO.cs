using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSegsal.DTO
{
    class TecnicoDTO
    {
        private Int32 _id;
        private string _codigo;
        private string _dataCadastro;
        private string _nome;
        private string _nomeCurto;
        private string _rg;
        private string _cpf;
        private string _dataNascimento;
        private string _endereco;
        private string _complemento;
        private string _bairro;
        private string _cidade;
        private string _uf;
        private string _cep;
        private string _telefone;
        private string _celular;
        private string _email;
        private string _foto;
        private string _status;

        public int Id { get => _id; set => _id = value; }
        public string Codigo { get => _codigo; set => _codigo = value; }
        public string DataCadastro { get => _dataCadastro; set => _dataCadastro = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Rg { get => _rg; set => _rg = value; }
        public string Cpf { get => _cpf; set => _cpf = value; }
        public string DataNascimento { get => _dataNascimento; set => _dataNascimento = value; }
        public string Endereco { get => _endereco; set => _endereco = value; }
        public string Complemento { get => _complemento; set => _complemento = value; }
        public string Bairro { get => _bairro; set => _bairro = value; }
        public string Cidade { get => _cidade; set => _cidade = value; }
        public string Uf { get => _uf; set => _uf = value; }
        public string Cep { get => _cep; set => _cep = value; }
        public string Telefone { get => _telefone; set => _telefone = value; }
        public string Celular { get => _celular; set => _celular = value; }
        public string Email { get => _email; set => _email = value; }
        public string Foto { get => _foto; set => _foto = value; }
        public string Status { get => _status; set => _status = value; }
        public string NomeCurto { get => _nomeCurto; set => _nomeCurto = value; }
    }
}
