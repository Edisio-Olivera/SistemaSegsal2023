using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSegsal.DTO
{
    class MedidasGeraisDTO
    {
        public Int32 larguraForm = 1359;
        public Int32 alturaForm = 687;
        public static Int32 posicaoVer = 5;
        public static Int32 posicaoHor01 = 1176;
        public static Int32 posicaoHor02 = MedidasGeraisDTO.posicaoHor01 - 156;
        public static Int32 posicaoHor03 = MedidasGeraisDTO.posicaoHor02 - 156;
        public static Int32 posicaoHor04 = MedidasGeraisDTO.posicaoHor03 - 156;
        public static Int32 posicaoHor05 = MedidasGeraisDTO.posicaoHor04 - 156;
        public static Int32 posicaoHor06 = MedidasGeraisDTO.posicaoHor05 - 156;
        public static Int32 posicaoHor07 = MedidasGeraisDTO.posicaoHor06 - 156;
        public static Int32 posicaoHor08 = MedidasGeraisDTO.posicaoHor07 - 156;
        public static Int32 posicaoHor09 = MedidasGeraisDTO.posicaoHor08 - 156;
        public static Int32 posicaoHor10 = MedidasGeraisDTO.posicaoHor09 - 156;
        public Int32 red;
        public Int32 green;
        public Int32 blue;
        public static BaseColor azulClaro = new BaseColor(128, 216, 255, 50);
        public static Color azulEscuro = Color.FromArgb(0, 0, 64);
        public static Color cinzaClaro = Color.FromArgb(224, 224, 224);
        public static Color amareloClaro = Color.FromArgb(255, 255, 192);

        public static Int32 posicaoSubMenuHor01 = 1176;
        public static Int32 posicaoSubMenuHor02 = MedidasGeraisDTO.posicaoSubMenuHor01 - 156;
        public static Int32 posicaoSubMenuHor03 = MedidasGeraisDTO.posicaoSubMenuHor02 - 156;
        public static Int32 posicaoSubMenuHor04 = MedidasGeraisDTO.posicaoSubMenuHor03 - 156;
        public static Int32 posicaoSubMenuHor05 = MedidasGeraisDTO.posicaoSubMenuHor04 - 156;
        public static Int32 posicaoSubMenuHor06 = MedidasGeraisDTO.posicaoSubMenuHor05 - 156;
        public static Int32 posicaoSubMenuHor07 = MedidasGeraisDTO.posicaoSubMenuHor06 - 156;
        public static Int32 posicaoSubMenuHor08 = MedidasGeraisDTO.posicaoSubMenuHor07 - 156;
        public static Int32 posicaoSubMenuHor09 = MedidasGeraisDTO.posicaoSubMenuHor08 - 156;
        public static Int32 posicaoSubMenuHor10 = MedidasGeraisDTO.posicaoSubMenuHor09 - 156;
        public static Int32 posicaoSubMenuVer = 5;

    }
}
