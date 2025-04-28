using System;

namespace SistemaSegsal.DTO
{
    class AtividadePrincipalDTO
    {
        private Int32 _id;
        private string _atividade;

        public int Id { get => _id; set => _id = value; }
        public string Atividade { get => _atividade; set => _atividade = value; }
    }
}
