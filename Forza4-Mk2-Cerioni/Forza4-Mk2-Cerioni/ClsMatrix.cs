using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forza4_Mk2_Cerioni
{
    public class ClsMatrix
    {
        public ClsPedina[,] Celle { get; private set; }
        private int _righe;
        private int _colonne;

        public ClsMatrix(int r, int c)
        {
            Righe = r;
            Colonne = c;
            Celle = new ClsPedina[Righe, Colonne];
        }

        public int Righe
        {
            get => _righe;
            set
            {
                if (value > 5)
                    _righe = value;
            }
        }

        public int Colonne
        {
            get => _colonne;
            set
            {
                if (value > 6)
                    _colonne = value;
            }
        }

        #region Metodi

        /// <summary>
        /// Inserisce una pedina nella colonna specificata
        /// </summary>
        /// <param name="colonna">La colonna in cui inserire la pedina</param>
        /// <param name="pedina">La pedina da inserire</param>
        /// <returns>La riga in cui la pedina è stata inserita, o -1 se la colonna è piena</returns>
        public int InserisciPedina(int colonna, ClsPedina pedina)
        {
            for (int riga = Righe - 1; riga >= 0; riga--)
            {
                if (Celle[riga, colonna] == null)
                {
                    Celle[riga, colonna] = pedina;
                    return riga; //restituisce la riga in cui la pedina è stata inserita
                }
            }
            return -1; //colonna è piena
        }

        /// <summary>
        /// Se torna NULL nessuno ha vinto, se torna un colore è il colore vincente
        /// </summary>
        /// <returns></returns>
        public Color? ControllaCombinazioni()
        {
            for (int riga = 0; riga < Righe; riga++)
            {
                for (int colonna = 0; colonna < Colonne; colonna++)
                {
                    ClsPedina pedina = Celle[riga, colonna];
                    if (pedina != null)
                    {
                        // controlla orizzontalmente
                        if (ColoreConsecutivo(pedina, riga, colonna, 0, 1))
                            return pedina.Giocatore.Colore;

                        // controlla verticalmente
                        if (ColoreConsecutivo(pedina, riga, colonna, 1, 0))
                            return pedina.Giocatore.Colore;

                        // controlla diagonale (in basso a destra)
                        if (ColoreConsecutivo(pedina, riga, colonna, 1, 1))
                            return pedina.Giocatore.Colore;

                        // controlla diagonale (in alto a destra)
                        if (ColoreConsecutivo(pedina, riga, colonna, -1, 1))
                            return pedina.Giocatore.Colore;
                    }
                }
            }
            return null;
        }

        private bool ColoreConsecutivo(ClsPedina pedina, int riga, int colonna, int deltaRiga, int deltaColonna)
        {
            for (int i = 1; i < 4; i++)
            {
                int nuovaRiga = riga + deltaRiga * i;
                int nuovaColonna = colonna + deltaColonna * i;

                if (nuovaRiga < 0 || nuovaRiga >= Righe || nuovaColonna < 0 || nuovaColonna >= Colonne)
                    return false;

                if (Celle[nuovaRiga, nuovaColonna] == null || Celle[nuovaRiga, nuovaColonna].Colore != pedina.Colore)
                    return false;
            }
            return true;
        }
        #endregion
    }

}
