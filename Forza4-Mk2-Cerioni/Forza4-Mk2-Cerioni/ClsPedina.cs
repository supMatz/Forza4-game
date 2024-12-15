using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Forza4_Mk2_Cerioni
{
    public class ClsPedina
    {
        #region Var e Enum
        public enum CellStatus { Vuota, Occupata };

        private CellStatus _stato;
        private Color _colore;
        private ClsGiocatore _giocatore;
        #endregion

        public ClsPedina() { } //inizializzazione

        #region Metodi
        public void Reset(params ClsPedina[] celle)
        {
            foreach (ClsPedina p in celle)
            {
                p.Stato = CellStatus.Vuota;
                p.Colore = null;
            }
        }

        public void ResetCell()
        {
            this.Stato = CellStatus.Vuota;
            this.Colore = null;
        }

        public bool IsCellEmpty()
        {
            if (Stato == CellStatus.Vuota && Colore == null)
                return true;

            return false;
        }

        public bool SetPlayer(Color p)
        {
            if (IsCellEmpty() && (p != null))
            {
                Colore = p;
                Stato = CellStatus.Occupata;
                return true;
            }
            return false;
        }
        #endregion

        #region Proprietà
        public CellStatus Stato { get => _stato; set => _stato = value; }
        public Color? Colore { get; set; }
        public ClsGiocatore Giocatore { get => _giocatore; set => _giocatore = value; }
        #endregion
    }
}
