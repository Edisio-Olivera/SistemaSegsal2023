using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSegsal.DTO
{
    class EmpresaDTO
    {
		private Int32 _id;
		private string _razaoSocial;
		private string _nomeFantasia;
		private string _porte;
		private DateTime _dataAbertura;
		private string _cnpj;
		private string _inscricaoEstadual;
		private string _naturezaJuridica;
		private string _endereco;
		private string _complemento;
		private string _bairro;
		private string _cidade;
		private string _uf;
		private string _cep;
		private string _email;
		private string _senha;
		private string _telefone;
		private string _celular;
		private string _atividadePrincipal;
		private string _logo;
        private string _logoImpressao;
        private string _site;
        private string _instagram;
        private string _facebook;
        private string _youtube;

        public int Id { get => _id; set => _id = value; }
        public string RazaoSocial { get => _razaoSocial; set => _razaoSocial = value; }
        public string NomeFantasia { get => _nomeFantasia; set => _nomeFantasia = value; }
        public string Porte { get => _porte; set => _porte = value; }
        public DateTime DataAbertura { get => _dataAbertura; set => _dataAbertura = value; }
        public string Cnpj { get => _cnpj; set => _cnpj = value; }
        public string InscricaoEstadual { get => _inscricaoEstadual; set => _inscricaoEstadual = value; }
        public string NaturezaJuridica { get => _naturezaJuridica; set => _naturezaJuridica = value; }
        public string Endereco { get => _endereco; set => _endereco = value; }
        public string Complemento { get => _complemento; set => _complemento = value; }
        public string Bairro { get => _bairro; set => _bairro = value; }
        public string Cidade { get => _cidade; set => _cidade = value; }
        public string Uf { get => _uf; set => _uf = value; }
        public string Cep { get => _cep; set => _cep = value; }
        public string Email { get => _email; set => _email = value; }
        public string Senha { get => _senha; set => _senha = value; }
        public string Telefone { get => _telefone; set => _telefone = value; }
        public string Celular { get => _celular; set => _celular = value; }
        public string AtividadePrincipal { get => _atividadePrincipal; set => _atividadePrincipal = value; }
        public string Logo { get => _logo; set => _logo = value; }
        public string LogoImpressao { get => _logoImpressao; set => _logoImpressao = value; }
        public string Site { get => _site; set => _site = value; }
        public string Instagram { get => _instagram; set => _instagram = value; }
        public string Facebook { get => _facebook; set => _facebook = value; }
        public string Youtube { get => _youtube; set => _youtube = value; }
    }
}
