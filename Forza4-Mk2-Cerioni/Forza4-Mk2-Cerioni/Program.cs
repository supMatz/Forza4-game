using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forza4_Mk2_Cerioni
{
    static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }

        #region Controlli Generici
        public static bool AreValidGenericStrings(params string[] strings)
        {
            foreach (string s in strings)
            {
                if (string.IsNullOrWhiteSpace(s))
                    return false;
            }
            return true;
        }
        #endregion
    }
}
