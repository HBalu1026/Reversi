using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Reversi
{
    internal class Tabla
    {
        char[,] t;
        public Tabla(string fajlnev)
        {
            t = new char[8, 8];
            var be = File.ReadAllLines(fajlnev);
            for (int i = 0; i < be.Length; i++)
            {
                for (int j = 0; j < be[i].Length; j++)
                {
                    t[i, j] = be[i][j];
                }
                Console.WriteLine();
            }
        }

        public byte MezokSzama(char c)
        {
            byte darab = 0;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (t[i, j] == c) darab++;
                }
            }
            return darab;
        }

        public bool VanForditas(char jatekos, byte sor, byte oszlop, byte iranySor, byte iranyOszlop)
        {
            int aktSor, aktOszlop;
            char ellenfel;
            bool nincsEllenfel;
            aktSor = sor + iranySor;
            aktOszlop = oszlop + iranyOszlop;
            ellenfel = 'K';

            if (jatekos == 'K') ellenfel = 'F';
            nincsEllenfel = true;

            while (aktSor > 0 && aktSor < 8 && aktOszlop > 0 && aktOszlop < 8 && t[akt]) 
            {
                aktSor = aktSor + iranySor;
                aktOszlop = aktOszlop + iranyOszlop;
                nincsEllenfel = false;
            }

            if (nincsEllenfel || aktSor < 0 || aktSor > 7 || aktOszlop < 0)
            {
                return false;
            }
            else return true;
        }

        public bool SzabalyosLepes(char jatekos, byte sor, byte oszlop)
        {

        }
    }
}
