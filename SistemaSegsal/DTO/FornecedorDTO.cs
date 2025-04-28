using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSegsal.DTO
{
    class FornecedorDTO
    {
        private Int32 _id;
        private string _codigo;
        private string _razaoSocial;
        private string _nomeFantasia;
        private string _tipoFornecedor;
        private string _site;
        private string _instagram;
        private string _facebook;
        private string _status;

        public int Id { get => _id; set => _id = value; }
        public string Codigo { get => _codigo; set => _codigo = value; }
        public string RazaoSocial { get => _razaoSocial; set => _razaoSocial = value; }
        public string NomeFantasia { get => _nomeFantasia; set => _nomeFantasia = value; }
        public string TipoFornecedor { get => _tipoFornecedor; set => _tipoFornecedor = value; }
        public string Status { get => _status; set => _status = value; }
        public string Site { get => _site; set => _site = value; }
        public string Instagram { get => _instagram; set => _instagram = value; }
        public string Facebook { get => _facebook; set => _facebook = value; }
    }
}
