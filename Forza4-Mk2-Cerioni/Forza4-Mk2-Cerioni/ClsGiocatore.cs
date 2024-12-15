using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forza4_Mk2_Cerioni
{
    public class ClsGiocatore
    {
        #region Var
        private Color _colore;
        private string _nome;
        #endregion

        public string Nome
        {
            get => _nome;
            set
            {
                if (Program.AreValidGenericStrings(value))
                    _nome = value;
            }
        }
        public Color Colore { get; set; }
    }
}
