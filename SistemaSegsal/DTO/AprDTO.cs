using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSegsal.DTO
{
    internal class AprDTO
    {
        private Int32 _id;
        private string _codigo;
        private DateTime _dataEmissao;
        private string _localSetor;
        private string _equipamento;
        private DateTime _dataInicio;
        private DateTime _dataFinal;
        private string _descricao;
        private bool _espacoConfinado;
        private bool _eletrica;
        private bool _icamentoCarga;
        private bool _trabalhoQuente;
        private bool _trabalhoAltura;
        private bool _motorExplosao;
        private bool _sistemaIncendio;
        private bool _travamento;
        private bool _choqueEletrico;
        private bool _quedaObjetos;
        private bool _elevarCargas;
        private bool _cargaDescargaEquipamento;
        private bool _fogoExplosao;
        private bool _pontosPrensagem;
        private bool _objetosCortantes;
        private bool _particulasOlhos;
        private bool _equipamentosMoveis;
        private bool _acessoInadequado;
        private bool _quedaAltura;
        private bool _elevacaoCargaManual;
        private bool _escaladaLivre;
        private bool _queimaduraTermica;
        private bool _amianto;
        private bool _chumbo;
        private bool _iluminacaoDeficiente;
        private bool _isolamentoArea;
        private bool _ruidoElevado;
        private bool _vazamentoQuimico;
        private bool _materialPerigoso;
        private bool _queimaduraQuimica;
        private bool _radiacaoIonizante;
        private bool _sobrecarga;
        private bool _inalacaoPerigosa;
        private bool _martelete;
        private bool _marreta;
        private bool _macarico;
        private bool _lixadeira;
        private bool _policorte;
        private bool _enxada;
        private bool _broca;
        private bool _betoneira;
        private bool _compactador;
        private bool _furadeira;
        private bool _parafusadeira;
        private bool _voltimetro;
        private bool _pa;
        private bool _ferramentasManuais;
        private bool _cavaleteDobravel;
        private bool _escadaTelescopica;
        private bool _andaimes;
        private bool _plataformaArticulada;
        private bool _plataformaTesoura;
        private bool _miniPlataforma;
        private bool _plataformaTelescopica;
        private bool _botas;
        private bool _oculos;
        private bool _capacete;
        private bool _protetorAuricular;
        private bool _mascara;
        private bool _mascaraGas;
        private bool _luvas;
        private bool _colete;
        private bool _cintoTalabarte;
        private bool _cones;
        private bool _fitaZebradaCorrente;
        private bool _extintorIncendio;
        private bool _lavaOlhos;
        private bool _redesProtecao;
        private bool _sistemaExaustor;
        private bool _anteparoAntichama;
        private bool _kitContencao;
        private bool _placaAdvertencia;
        private bool _outros;
        private string _outro;
        private string _status;

        public int Id { get => _id; set => _id = value; }
        public string Codigo { get => _codigo; set => _codigo = value; }
        public DateTime DataEmissao { get => _dataEmissao; set => _dataEmissao = value; }
        public string LocalSetor { get => _localSetor; set => _localSetor = value; }
        public string Equipamento { get => _equipamento; set => _equipamento = value; }
        public DateTime DataInicio { get => _dataInicio; set => _dataInicio = value; }
        public DateTime DataFinal { get => _dataFinal; set => _dataFinal = value; }
        public string Descricao { get => _descricao; set => _descricao = value; }
        public bool EspacoConfinado { get => _espacoConfinado; set => _espacoConfinado = value; }
        public bool Eletrica { get => _eletrica; set => _eletrica = value; }
        public bool IcamentoCarga { get => _icamentoCarga; set => _icamentoCarga = value; }
        public bool TrabalhoQuente { get => _trabalhoQuente; set => _trabalhoQuente = value; }
        public bool TrabalhoAltura { get => _trabalhoAltura; set => _trabalhoAltura = value; }
        public bool MotorExplosao { get => _motorExplosao; set => _motorExplosao = value; }
        public bool SistemaIncendio { get => _sistemaIncendio; set => _sistemaIncendio = value; }
        public bool Travamento { get => _travamento; set => _travamento = value; }
        public bool ChoqueEletrico { get => _choqueEletrico; set => _choqueEletrico = value; }
        public bool QuedaObjetos { get => _quedaObjetos; set => _quedaObjetos = value; }
        public bool ElevarCargas { get => _elevarCargas; set => _elevarCargas = value; }
        public bool CargaDescargaEquipamento { get => _cargaDescargaEquipamento; set => _cargaDescargaEquipamento = value; }
        public bool FogoExplosao { get => _fogoExplosao; set => _fogoExplosao = value; }
        public bool PontosPrensagem { get => _pontosPrensagem; set => _pontosPrensagem = value; }
        public bool ObjetosCortantes { get => _objetosCortantes; set => _objetosCortantes = value; }
        public bool ParticulasOlhos { get => _particulasOlhos; set => _particulasOlhos = value; }
        public bool EquipamentosMoveis { get => _equipamentosMoveis; set => _equipamentosMoveis = value; }
        public bool AcessoInadequado { get => _acessoInadequado; set => _acessoInadequado = value; }
        public bool QuedaAltura { get => _quedaAltura; set => _quedaAltura = value; }
        public bool ElevacaoCargaManual { get => _elevacaoCargaManual; set => _elevacaoCargaManual = value; }
        public bool EscaladaLivre { get => _escaladaLivre; set => _escaladaLivre = value; }
        public bool QueimaduraTermica { get => _queimaduraTermica; set => _queimaduraTermica = value; }
        public bool Amianto { get => _amianto; set => _amianto = value; }
        public bool Chumbo { get => _chumbo; set => _chumbo = value; }
        public bool IluminacaoDeficiente { get => _iluminacaoDeficiente; set => _iluminacaoDeficiente = value; }
        public bool IsolamentoArea { get => _isolamentoArea; set => _isolamentoArea = value; }
        public bool RuidoElevado { get => _ruidoElevado; set => _ruidoElevado = value; }
        public bool VazamentoQuimico { get => _vazamentoQuimico; set => _vazamentoQuimico = value; }
        public bool MaterialPerigoso { get => _materialPerigoso; set => _materialPerigoso = value; }
        public bool QueimaduraQuimica { get => _queimaduraQuimica; set => _queimaduraQuimica = value; }
        public bool RadiacaoIonizante { get => _radiacaoIonizante; set => _radiacaoIonizante = value; }
        public bool Sobrecarga { get => _sobrecarga; set => _sobrecarga = value; }
        public bool InalacaoPerigosa { get => _inalacaoPerigosa; set => _inalacaoPerigosa = value; }
        public bool Martelete { get => _martelete; set => _martelete = value; }
        public bool Marreta { get => _marreta; set => _marreta = value; }
        public bool Macarico { get => _macarico; set => _macarico = value; }
        public bool Lixadeira { get => _lixadeira; set => _lixadeira = value; }
        public bool Policorte { get => _policorte; set => _policorte = value; }
        public bool Enxada { get => _enxada; set => _enxada = value; }
        public bool Broca { get => _broca; set => _broca = value; }
        public bool Betoneira { get => _betoneira; set => _betoneira = value; }
        public bool Compactador { get => _compactador; set => _compactador = value; }
        public bool Furadeira { get => _furadeira; set => _furadeira = value; }
        public bool Parafusadeira { get => _parafusadeira; set => _parafusadeira = value; }
        public bool Voltimetro { get => _voltimetro; set => _voltimetro = value; }
        public bool Pa { get => _pa; set => _pa = value; }
        public bool FerramentasManuais { get => _ferramentasManuais; set => _ferramentasManuais = value; }
        public bool CavaleteDobravel { get => _cavaleteDobravel; set => _cavaleteDobravel = value; }
        public bool EscadaTelescopica { get => _escadaTelescopica; set => _escadaTelescopica = value; }
        public bool Andaimes { get => _andaimes; set => _andaimes = value; }
        public bool PlataformaArticulada { get => _plataformaArticulada; set => _plataformaArticulada = value; }
        public bool PlataformaTesoura { get => _plataformaTesoura; set => _plataformaTesoura = value; }
        public bool MiniPlataforma { get => _miniPlataforma; set => _miniPlataforma = value; }
        public bool PlataformaTelescopica { get => _plataformaTelescopica; set => _plataformaTelescopica = value; }
        public bool Botas { get => _botas; set => _botas = value; }
        public bool Oculos { get => _oculos; set => _oculos = value; }
        public bool Capacete { get => _capacete; set => _capacete = value; }
        public bool ProtetorAuricular { get => _protetorAuricular; set => _protetorAuricular = value; }
        public bool Mascara { get => _mascara; set => _mascara = value; }
        public bool MascaraGas { get => _mascaraGas; set => _mascaraGas = value; }
        public bool Luvas { get => _luvas; set => _luvas = value; }
        public bool Colete { get => _colete; set => _colete = value; }
        public bool CintoTalabarte { get => _cintoTalabarte; set => _cintoTalabarte = value; }
        public bool Cones { get => _cones; set => _cones = value; }
        public bool FitaZebradaCorrente { get => _fitaZebradaCorrente; set => _fitaZebradaCorrente = value; }
        public bool ExtintorIncendio { get => _extintorIncendio; set => _extintorIncendio = value; }
        public bool LavaOlhos { get => _lavaOlhos; set => _lavaOlhos = value; }
        public bool RedesProtecao { get => _redesProtecao; set => _redesProtecao = value; }
        public bool SistemaExaustor { get => _sistemaExaustor; set => _sistemaExaustor = value; }
        public bool AnteparoAntichama { get => _anteparoAntichama; set => _anteparoAntichama = value; }
        public bool KitContencao { get => _kitContencao; set => _kitContencao = value; }
        public bool PlacaAdvertencia { get => _placaAdvertencia; set => _placaAdvertencia = value; }
        public bool Outros { get => _outros; set => _outros = value; }
        public string Outro { get => _outro; set => _outro = value; }
        public string Status { get => _status; set => _status = value; }
    }
}
