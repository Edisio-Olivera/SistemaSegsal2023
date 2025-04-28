using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using SistemaSegsal.DTO;
using SistemaSegsal.BLL;
using System.Windows.Forms;

namespace SistemaSegsal.Auxiliar
{
    internal class Class1
    {
        PropostaComercialDTO dto = new PropostaComercialDTO();
        PropostaComercialBLL bll = new PropostaComercialBLL();

        Excel.Application app = new Excel.Application();
        Workbook pasta;
        Worksheet plan;
        string path = @"C:\Users\seris\OneDrive\= DESENVOLVIMENTO =\= SISTEMA SEGSAL =\Tabela Nota Fiscal.xlsx";



        private void SalvarDados()
        {
            Int32 qtdLinhas = plan.Rows.Count;

            MessageBox.Show(qtdLinhas.ToString());

            for(int i = 2; i <= qtdLinhas; i++)
            {
                dto.Id = plan.Cells[i, 2].Value;
            }
            






        }






    }
}
