using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaSegsal.DTO;
using SistemaSegsal.BLL;
using SistemaSegsal.DAO;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SistemaSegsal.BLL
{
    internal class AprBLL
    {
        Conexao conexao = new Conexao();
        OleDbCommand cmd = new OleDbCommand();

        AprStatusDTO staDto = new AprStatusDTO();
        AprStatusBLL staBll = new AprStatusBLL();

        Int32 qtdIdApr;

        string tabela = "tb_apr";


        public void CriarNovoApr(AprDTO a)
        {
            this.ContarApr();

            if (qtdIdApr == 0)
            {
                a.Id = 1;
            }
            else
            {
                cmd.CommandText = "SELECT MAX(id) FROM " + tabela;

                try
                {
                    cmd.Connection = conexao.conectar();
                    OleDbDataReader leitor = cmd.ExecuteReader();

                    leitor.Read();
                    a.Id = leitor.GetInt32(0) + 1;

                    conexao.desconectar();
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public Int32 ContarApr()
        {
            cmd.CommandText = "SELECT COUNT(id) FROM " + tabela;

            try
            {
                cmd.Connection = conexao.conectar();
                OleDbDataReader leitor = cmd.ExecuteReader();

                leitor.Read();
                qtdIdApr = leitor.GetInt32(0);

                conexao.desconectar();
                cmd.Dispose();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return qtdIdApr;
        }

        public void SalvarApr(AprDTO a)
        {
            staDto.Status = staDto.Status;
            staBll.SelecionarIdStatus(staDto);

            cmd.CommandText = "INSERT INTO " + tabela + " (" +
                "id, " +
                "codigo, " +
                "dataEmissao, " +
                "localSetor, " +
                "equipamento, " +
                "dataInicio, " +
                "dataFinal, " +
                "descricao, " +
                "espacoConfinado, " +
                "eletrica, " +
                "icamentoCarga, " +
                "trabalhoQuente, " +
                "trabalhoAltura, " +
                "motorExplosao, " +
                "sistemaIncendio, " +
                "travamento, " +
                "choqueEletrico, " +
                "quedaObjetos, " +
                "elevarCargas, " +
                "cargaDescargaEquipamento, " +
                "fogoExplosao, " +
                "pontosPrensagem, " +
                "objetosCortantes, " +
                "particulasOlhos, " +
                "equipamentosMoveis, " +
                "acessoInadequado, " +
                "quedaAltura, " +
                "elevacaoCargaManual, " +
                "escaladaLivre, " +
                "queimaduraTermica, " +
                "amianto, " +
                "chumbo, " +
                "iluminacaoDeficiente, " +
                "isolamentoArea, " +
                "ruidoElevado, " +
                "vazamentoQuimico, " +
                "materialPerigoso, " +
                "queimaduraQuimica, " +
                "radiacaoIonizante, " +
                "sobrecarga, " +
                "inalacaoPerigosa, " +
                "martelete, " +
                "marreta, " +
                "macarico, " +
                "lixadeira, " +
                "policorte, " +
                "enxada, " +
                "broca, " +
                "betoneira, " +
                "compactador, " +
                "furadeira, " +
                "parafusadeira, " +
                "voltimetro, " +
                "pa, " +
                "ferramentasManuais, " +
                "cavaleteDobravel, " +
                "escadaTelescopica, " +
                "andaimes, " +
                "plataformaArticulada, " +
                "plataformaTesoura, " +
                "miniPlataforma, " +
                "plataformaTelescopica, " +
                "botas, " +
                "oculos, " +
                "capacete, " +
                "protetorAuricular, " +
                "mascara, " +
                "mascaraGas, " +
                "luvas, " +
                "colete, " +
                "cintoTalabarte, " +
                "cones, " +
                "fitaZebradaCorrente, " +
                "extintorIncendio, " +
                "lavaOlhos, " +
                "redesProtecao, " +
                "sistemaExaustor, " +
                "anteparoAntichama, " +
                "kitContencao, " +
                "placaAdvertencia, " +
                "outros, " +
                "outro, " +
                "idStatus) " +
                "VALUES (" +
                a.Id + ", '" +
                a.Codigo + "', '" +
                a.DataEmissao + "', '" +
                a.LocalSetor + "', '" +
                a.Equipamento + "', '" +
                a.DataInicio + "', '" +
                a.DataFinal + "', '" +
                a.Descricao + "', " +
                a.EspacoConfinado + ", " +
                a.Eletrica + ", " +
                a.IcamentoCarga + ", " +
                a.TrabalhoQuente + ", " +
                a.TrabalhoAltura + ", " +
                a.MotorExplosao + ", " +
                a.SistemaIncendio + ", " +
                a.Travamento + ", " +
                a.ChoqueEletrico + ", " +
                a.QuedaObjetos + ", " +
                a.ElevarCargas + ", " +
                a.CargaDescargaEquipamento + ", " +
                a.FogoExplosao + ", " +
                a.PontosPrensagem + ", " +
                a.ObjetosCortantes + ", " +
                a.ParticulasOlhos + ", " +
                a.EquipamentosMoveis + ", " +
                a.AcessoInadequado + ", " +
                a.QuedaAltura + ", " +
                a.ElevacaoCargaManual + ", " +
                a.EscaladaLivre + ", " +
                a.QueimaduraTermica + ", " +
                a.Amianto + ", " +
                a.Chumbo + ", " +
                a.IluminacaoDeficiente + ", " +
                a.IsolamentoArea + ", " +
                a.RuidoElevado + ", " +
                a.VazamentoQuimico + ", " +
                a.MaterialPerigoso + ", " +
                a.QueimaduraQuimica + ", " +
                a.RadiacaoIonizante + ", " +
                a.Sobrecarga + ", " +
                a.InalacaoPerigosa + ", " +
                a.Martelete + ", " +
                a.Marreta + ", " +
                a.Macarico + ", " +
                a.Lixadeira + ", " +
                a.Policorte + ", " +
                a.Enxada + ", " +
                a.Broca + ", " +
                a.Betoneira + ", " +
                a.Compactador + ", " +
                a.Furadeira + ", " +
                a.Parafusadeira + ", " +
                a.Voltimetro + ", " +
                a.Pa + ", " +
                a.FerramentasManuais + ", " +
                a.CavaleteDobravel + ", " +
                a.EscadaTelescopica + ", " +
                a.Andaimes + ", " +
                a.PlataformaArticulada + ", " +
                a.PlataformaTesoura + ", " +
                a.MiniPlataforma + ", " +
                a.PlataformaTelescopica + ", " +
                a.Botas + ", " +
                a.Oculos + ", " +
                a.Capacete + ", " +
                a.ProtetorAuricular + ", " +
                a.Mascara + ", " +
                a.MascaraGas + ", " +
                a.Luvas + ", " +
                a.Colete + ", " +
                a.CintoTalabarte + ", " +
                a.Cones + ", " +
                a.FitaZebradaCorrente + ", " +
                a.ExtintorIncendio + ", " +
                a.LavaOlhos + ", " +
                a.RedesProtecao + ", " +
                a.SistemaExaustor + ", " +
                a.AnteparoAntichama + ", " +
                a.KitContencao + ", " +
                a.PlacaAdvertencia + ", " +
                a.Outros + ", '" +
                a.Outro + "', " +
                staDto.Id + ")";

            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();

                conexao.desconectar();
                cmd.Dispose();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void EditarApr(AprDTO a)
        {
            staDto.Status = staDto.Status;
            staBll.SelecionarIdStatus(staDto);

            cmd.CommandText = "UPDATE " + tabela + " SET " +
                "dataEmissao = '" + a.DataEmissao + "', " +
                "localSetor = '" + a.LocalSetor + "', " +
                "equipamento = '" + a.Equipamento + "', " +
                "dataInicio = '" + a.DataInicio + "', " +
                "dataFinal = '" + a.DataFinal + "', " +
                "descricao = '" + a.Descricao + "', " +
                "espacoConfinado = " + a.EspacoConfinado + ", " +
                "eletrica = " + a.Eletrica + ", " +
                "icamentoCarga = " + a.IcamentoCarga + ", " +
                "trabalhoQuente = " + a.TrabalhoQuente + ", " +
                "trabalhoAltura = " + a.TrabalhoAltura + ", " +
                "motorExplosao = " + a.MotorExplosao + ", " +
                "sistemaIncendio = " + a.SistemaIncendio + ", " +
                "travamento = " + a.Travamento + ", " +
                "choqueEletrico = " + a.ChoqueEletrico + ", " +
                "quedaObjetos = " + a.QuedaObjetos + ", " +
                "elevarCargas = " + a.ElevarCargas + ", " +
                "cargaDescargaEquipamento = " + a.CargaDescargaEquipamento + ", " +
                "fogoExplosao = " + a.FogoExplosao + ", " +
                "pontosPrensagem = " + a.PontosPrensagem + ", " +
                "objetosCortantes = " + a.ObjetosCortantes + ", " +
                "particulasOlhos = " + a.ParticulasOlhos + ", " +
                "equipamentosMoveis = " + a.EquipamentosMoveis + ", " +
                "acessoInadequado = " + a.AcessoInadequado + ", " +
                "quedaAltura = " + a.QuedaAltura + ", " +
                "elevacaoCargaManual = " + a.ElevacaoCargaManual + ", " +
                "escaladaLivre = " + a.EscaladaLivre + ", " +
                "queimaduraTermica = " + a.QueimaduraTermica + ", " +
                "amianto = " + a.Amianto + ", " +
                "chumbo = " + a.Chumbo + ", " +
                "iluminacaoDeficiente = " + a.IluminacaoDeficiente + ", " +
                "isolamentoArea = " + a.IsolamentoArea + ", " +
                "ruidoElevado = " + a.RuidoElevado + ", " +
                "vazamentoQuimico = " + a.VazamentoQuimico + ", " +
                "materialPerigoso = " + a.MaterialPerigoso + ", " +
                "queimaduraQuimica = " + a.QueimaduraQuimica + ", " +
                "radiacaoIonizante = " + a.RadiacaoIonizante + ", " +
                "sobrecarga = " + a.Sobrecarga + ", " +
                "inalacaoPerigosa = " + a.InalacaoPerigosa + ", " +
                "martelete = " + a.Martelete + ", " +
                "marreta = " + a.Marreta + ", " +
                "macarico = " + a.Macarico + ", " +
                "lixadeira = " + a.Lixadeira + ", " +
                "policorte = " + a.Policorte + ", " +
                "enxada = " + a.Enxada + ", " +
                "broca = " + a.Broca + ", " +
                "betoneira = " + a.Betoneira + ", " +
                "compactador = " + a.Compactador + ", " +
                "furadeira = " + a.Furadeira + ", " +
                "parafusadeira = " + a.Parafusadeira + ", " +
                "voltimetro = " + a.Voltimetro + ", " +
                "pa = " + a.Pa + ", " +
                "ferramentasManuais = " + a.FerramentasManuais + ", " +
                "cavaleteDobravel = " + a.CavaleteDobravel + ", " +
                "escadaTelescopica = " + a.EscadaTelescopica + ", " +
                "andaimes = " + a.Andaimes + ", " +
                "plataformaArticulada = " + a.PlataformaArticulada + ", " +
                "plataformaTesoura = " + a.PlataformaTesoura + ", " +
                "miniPlataforma = " + a.MiniPlataforma + ", " +
                "plataformaTelescopica = " + a.PlataformaTelescopica + ", " +
                "botas = " + a.Botas + ", " +
                "oculos = " + a.Oculos + ", " +
                "capacete = " + a.Capacete + ", " +
                "protetorAuricular = " + a.ProtetorAuricular + ", " +
                "mascara = " + a.Mascara + ", " +
                "mascaraGas = " + a.MascaraGas + ", " +
                "luvas = " + a.Luvas + ", " +
                "colete = " + a.Colete + ", " +
                "cintoTalabarte = " + a.CintoTalabarte + ", " +
                "cones = " + a.Cones + ", " +
                "fitaZebradaCorrente = " + a.FitaZebradaCorrente + ", " +
                "extintorIncendio = " + a.ExtintorIncendio + ", " +
                "lavaOlhos = " + a.LavaOlhos + ", " +
                "redesProtecao = " + a.RedesProtecao + ", " +
                "sistemaExaustor = " + a.SistemaExaustor + ", " +
                "anteparoAntichama = " + a.AnteparoAntichama + ", " +
                "kitContencao = " + a.KitContencao + ", " +
                "placaAdvertencia = " + a.PlacaAdvertencia + ", " +
                "outros = " + a.Outros + ", " +
                "outro = '" + a.Outro + "', " +
                "idStatus = " + staDto.Id + " " +
                "WHERE código = '" + a.Codigo + "'";

            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();

                conexao.desconectar();
                cmd.Dispose();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ExcluirApr(AprDTO a)
        {
            cmd.CommandText = "DELETE FROM " + tabela + " " +
                "WHERE codigo = '" + a.Codigo + "'";

            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();

                conexao.desconectar();
                cmd.Dispose();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<AprDTO> SelecionarApr(AprDTO a)
        {
            cmd.CommandText = "SELECT " +
                tabela + ".id, " +
                tabela + ".codigo, " +
                tabela + ".dataEmissao, " +
                tabela + ".localSetor, " +
                tabela + ".equipamento, " +
                tabela + ".dataInicio, " +
                tabela + ".dataFinal, " +
                tabela + ".descricao, " +
                tabela + ".espacoConfinado, " +
                tabela + ".eletrica, " +
                tabela + ".icamentoCarga, " +
                tabela + ".trabalhoQuente, " +
                tabela + ".trabalhoAltura, " +
                tabela + ".motorExplosao, " +
                tabela + ".sistemaIncendio, " +
                tabela + ".travamento, " +
                tabela + ".choqueEletrico, " +
                tabela + ".quedaObjetos, " +
                tabela + ".elevarCargas, " +
                tabela + ".cargaDescargaEquipamento, " +
                tabela + ".fogoExplosao, " +
                tabela + ".pontosPrensagem, " +
                tabela + ".objetosCortantes, " +
                tabela + ".particulasOlhos, " +
                tabela + ".equipamentosMoveis, " +
                tabela + ".acessoInadequado, " +
                tabela + ".quedaAltura, " +
                tabela + ".elevacaoCargaManual, " +
                tabela + ".escaladaLivre, " +
                tabela + ".queimaduraTermica, " +
                tabela + ".amianto, " +
                tabela + ".chumbo, " +
                tabela + ".iluminacaoDeficiente, " +
                tabela + ".isolamentoArea, " +
                tabela + ".ruidoElevado, " +
                tabela + ".vazamentoQuimico, " +
                tabela + ".materialPerigoso, " +
                tabela + ".queimaduraQuimica, " +
                tabela + ".radiacaoIonizante, " +
                tabela + ".sobrecarga, " +
                tabela + ".inalacaoPerigosa, " +
                tabela + ".martelete, " +
                tabela + ".marreta, " +
                tabela + ".macarico, " +
                tabela + ".lixadeira, " +
                tabela + ".policorte, " +
                tabela + ".enxada, " +
                tabela + ".broca, " +
                tabela + ".betoneira, " +
                tabela + ".compactador, " +
                tabela + ".furadeira, " +
                tabela + ".parafusadeira, " +
                tabela + ".voltimetro, " +
                tabela + ".pa, " +
                tabela + ".ferramentasManuais, " +
                tabela + ".cavaleteDobravel, " +
                tabela + ".escadaTelescopica, " +
                tabela + ".andaimes, " +
                tabela + ".plataformaArticulada, " +
                tabela + ".plataformaTesoura, " +
                tabela + ".miniPlataforma, " +
                tabela + ".plataformaTelescopica, " +
                tabela + ".botas, " +
                tabela + ".oculos, " +
                tabela + ".capacete, " +
                tabela + ".protetorAuricular, " +
                tabela + ".mascara, " +
                tabela + ".mascaraGas, " +
                tabela + ".luvas, " +
                tabela + ".colete, " +
                tabela + ".cintoTalabarte, " +
                tabela + ".cones, " +
                tabela + ".fitaZebradaCorrente, " +
                tabela + ".extintorIncendio, " +
                tabela + ".lavaOlhos, " +
                tabela + ".redesProtecao, " +
                tabela + ".sistemaExaustor, " +
                tabela + ".anteparoAntichama, " +
                tabela + ".kitContencao, " +
                tabela + ".placaAdvertencia, " +
                tabela + ".outros, " +
                tabela + ".outro, " +
                "tb_apr_status.status " + " " +
                "FROM " + tabela + " " +
                "INNER JOIN tb_apr_status ON " + tabela + ".idStatus = tb_apr_status.id " +
                "WHERE " + tabela + ".codigo = '" + a.Codigo + "'";


            cmd.Connection = conexao.conectar();
            OleDbDataReader leitor = cmd.ExecuteReader();

            List<AprDTO> apr = new List<AprDTO>(83);

            leitor.Read();

            apr.Add(new AprDTO());

            apr[0].Id = leitor.GetInt32(0);
            apr[0].Codigo = leitor.GetString(1);
            apr[0].DataEmissao = leitor.GetDateTime(2);
            apr[0].LocalSetor = leitor.GetString(3);
            apr[0].Equipamento = leitor.GetString(4);
            apr[0].DataInicio = leitor.GetDateTime(5);
            apr[0].DataFinal = leitor.GetDateTime(6);
            apr[0].Descricao = leitor.GetString(7);
            apr[0].EspacoConfinado = leitor.GetBoolean(8);
            apr[0].Eletrica = leitor.GetBoolean(9);
            apr[0].IcamentoCarga = leitor.GetBoolean(10);
            apr[0].TrabalhoQuente = leitor.GetBoolean(11);
            apr[0].TrabalhoAltura = leitor.GetBoolean(12);
            apr[0].MotorExplosao = leitor.GetBoolean(13);
            apr[0].SistemaIncendio = leitor.GetBoolean(14);
            apr[0].Travamento = leitor.GetBoolean(15);
            apr[0].ChoqueEletrico = leitor.GetBoolean(16);
            apr[0].QuedaObjetos = leitor.GetBoolean(17);
            apr[0].ElevarCargas = leitor.GetBoolean(18);
            apr[0].CargaDescargaEquipamento = leitor.GetBoolean(19);
            apr[0].FogoExplosao = leitor.GetBoolean(20);
            apr[0].PontosPrensagem = leitor.GetBoolean(21);
            apr[0].ObjetosCortantes = leitor.GetBoolean(22);
            apr[0].ParticulasOlhos = leitor.GetBoolean(23);
            apr[0].EquipamentosMoveis = leitor.GetBoolean(24);
            apr[0].AcessoInadequado = leitor.GetBoolean(25);
            apr[0].QuedaAltura = leitor.GetBoolean(26);
            apr[0].ElevacaoCargaManual = leitor.GetBoolean(27);
            apr[0].EscaladaLivre = leitor.GetBoolean(28);
            apr[0].QueimaduraTermica = leitor.GetBoolean(29);
            apr[0].Amianto = leitor.GetBoolean(30);
            apr[0].Chumbo = leitor.GetBoolean(31);
            apr[0].IluminacaoDeficiente = leitor.GetBoolean(32);
            apr[0].IsolamentoArea = leitor.GetBoolean(33);
            apr[0].RuidoElevado = leitor.GetBoolean(34);
            apr[0].VazamentoQuimico = leitor.GetBoolean(35);
            apr[0].MaterialPerigoso = leitor.GetBoolean(36);
            apr[0].QueimaduraQuimica = leitor.GetBoolean(37);
            apr[0].RadiacaoIonizante = leitor.GetBoolean(38);
            apr[0].Sobrecarga = leitor.GetBoolean(39);
            apr[0].InalacaoPerigosa = leitor.GetBoolean(40);
            apr[0].Martelete = leitor.GetBoolean(41);
            apr[0].Marreta = leitor.GetBoolean(42);
            apr[0].Macarico = leitor.GetBoolean(43);
            apr[0].Lixadeira = leitor.GetBoolean(44);
            apr[0].Policorte = leitor.GetBoolean(45);
            apr[0].Enxada = leitor.GetBoolean(46);
            apr[0].Broca = leitor.GetBoolean(47);
            apr[0].Betoneira = leitor.GetBoolean(48);
            apr[0].Compactador = leitor.GetBoolean(49);
            apr[0].Furadeira = leitor.GetBoolean(50);
            apr[0].Parafusadeira = leitor.GetBoolean(51);
            apr[0].Voltimetro = leitor.GetBoolean(52);
            apr[0].Pa = leitor.GetBoolean(53);
            apr[0].FerramentasManuais = leitor.GetBoolean(54);
            apr[0].CavaleteDobravel = leitor.GetBoolean(55);
            apr[0].EscadaTelescopica = leitor.GetBoolean(56);
            apr[0].Andaimes = leitor.GetBoolean(57);
            apr[0].PlataformaArticulada = leitor.GetBoolean(58);
            apr[0].PlataformaTesoura = leitor.GetBoolean(59);
            apr[0].MiniPlataforma = leitor.GetBoolean(60);
            apr[0].PlataformaTelescopica = leitor.GetBoolean(61);
            apr[0].Botas = leitor.GetBoolean(62);
            apr[0].Oculos = leitor.GetBoolean(63);
            apr[0].Capacete = leitor.GetBoolean(64);
            apr[0].ProtetorAuricular = leitor.GetBoolean(65);
            apr[0].Mascara = leitor.GetBoolean(66);
            apr[0].MascaraGas = leitor.GetBoolean(67);
            apr[0].Luvas = leitor.GetBoolean(68);
            apr[0].Colete = leitor.GetBoolean(69);
            apr[0].CintoTalabarte = leitor.GetBoolean(70);
            apr[0].Cones = leitor.GetBoolean(71);
            apr[0].FitaZebradaCorrente = leitor.GetBoolean(72);
            apr[0].ExtintorIncendio = leitor.GetBoolean(73);
            apr[0].LavaOlhos = leitor.GetBoolean(74);
            apr[0].RedesProtecao = leitor.GetBoolean(75);
            apr[0].SistemaExaustor = leitor.GetBoolean(76);
            apr[0].AnteparoAntichama = leitor.GetBoolean(77);
            apr[0].KitContencao = leitor.GetBoolean(78);
            apr[0].PlacaAdvertencia = leitor.GetBoolean(79);
            apr[0].Outros = leitor.GetBoolean(80);
            apr[0].Outro = leitor.GetString(81);
            apr[0].Status = leitor.GetString(82);

            conexao.desconectar();
            cmd.Dispose();

            return apr;
        }

        public List<AprDTO> ListarApr()
        {
            cmd.CommandText = "SELECT " +
                tabela + ".id, " +
                tabela + ".codigo, " +
                tabela + ".dataEmissao, " +
                tabela + ".localSetor, " +
                tabela + ".equipamento, " +
                tabela + ".dataInicio, " +
                tabela + ".dataFinal, " +
                tabela + ".descricao, " +
                "tb_apr_status.status " + " " +
                "FROM " + tabela + " " +
                "INNER JOIN tb_apr_status ON " + tabela + ".idStatus = tb_apr_status.id";


            cmd.Connection = conexao.conectar();
            OleDbDataReader leitor = cmd.ExecuteReader();

            List<AprDTO> apr = new List<AprDTO>(9);

            while (leitor.Read())
            {
                AprDTO ap = new AprDTO();

                ap.Id = leitor.GetInt32(0);
                ap.Codigo = leitor.GetString(1);
                ap.DataEmissao = leitor.GetDateTime(2);
                ap.LocalSetor = leitor.GetString(3);
                ap.Equipamento = leitor.GetString(4);
                ap.DataInicio = leitor.GetDateTime(5);
                ap.DataFinal = leitor.GetDateTime(6);
                ap.Descricao = leitor.GetString(7);
                ap.Status = leitor.GetString(8);

                apr.Add(ap);
            }            

            conexao.desconectar();
            cmd.Dispose();

            return apr;
        }
    }
}
