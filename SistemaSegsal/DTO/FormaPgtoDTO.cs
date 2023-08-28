using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSegsal.DTO
{
    class FormaPgtoDTO
    {
        private Int32 _id;
        private string _condicaoPgto;
        private string _formaPgto;

        public int Id { get => _id; set => _id = value; }
        public string CondicaoPgto { get => _condicaoPgto; set => _condicaoPgto = value; }
        public string FormaPgto { get => _formaPgto; set => _formaPgto = value; }
    }
}
