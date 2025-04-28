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
        private DateTime _dataCadastro;
        private string _nome;
        private string _nomeUsual;
        private string _sexo;
        private string _rg;
        private string _cpf;
        private DateTime _dataNascimento;
        private string _endereco;
        private string _bairro;
        private string _cidade;
        private string _uf;
        private string _cep;
        private string _telefone;
        private string _celular;
        private string _email;
        private string _funcao;
        private string _foto;
        private string _pasta;
        private DateTime _dataAdmissao;
        private string _assinatura;
        private Int32 _classificacao;
        private string _status;

        public int Id { get => _id; set => _id = value; }
        public string Codigo { get => _codigo; set => _codigo = value; }
        public DateTime DataCadastro { get => _dataCadastro; set => _dataCadastro = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Rg { get => _rg; set => _rg = value; }
        public string Cpf { get => _cpf; set => _cpf = value; }
        public DateTime DataNascimento { get => _dataNascimento; set => _dataNascimento = value; }
        public string Endereco { get => _endereco; set => _endereco = value; }
        public string Bairro { get => _bairro; set => _bairro = value; }
        public string Cidade { get => _cidade; set => _cidade = value; }
        public string Uf { get => _uf; set => _uf = value; }
        public string Cep { get => _cep; set => _cep = value; }
        public string Telefone { get => _telefone; set => _telefone = value; }
        public string Celular { get => _celular; set => _celular = value; }
        public string Email { get => _email; set => _email = value; }
        public string Foto { get => _foto; set => _foto = value; }
        public string Status { get => _status; set => _status = value; }
        public string NomeUsual { get => _nomeUsual; set => _nomeUsual = value; }
        public string Sexo { get => _sexo; set => _sexo = value; }
        public string Funcao { get => _funcao; set => _funcao = value; }
        public string Pasta { get => _pasta; set => _pasta = value; }
        public DateTime DataAdmissao { get => _dataAdmissao; set => _dataAdmissao = value; }
        public string Assinatura { get => _assinatura; set => _assinatura = value; }
        public int Classificacao { get => _classificacao; set => _classificacao = value; }
    }
}
