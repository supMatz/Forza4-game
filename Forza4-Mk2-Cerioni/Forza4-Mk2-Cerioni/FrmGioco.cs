using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Forza4_Mk2_Cerioni
{
    public partial class FrmGioco : Form
    {
        ClsGiocatore GiocatoreGiallo = new ClsGiocatore();
        ClsGiocatore GiocatoreRosso = new ClsGiocatore();
        ClsMatrix Griglia;
        bool turnoGiallo = true;
        private Label lblTurno;

        public FrmGioco(string nomeGiallo, string nomeRosso, int r, int c)
        {
            InitializeComponent();

            GiocatoreGiallo.Nome = nomeGiallo;
            GiocatoreRosso.Nome = nomeRosso;

            Griglia = new ClsMatrix(r, c);

            lblTurno = new Label()
            {
                Text = $"Turno di: {GiocatoreGiallo.Nome}",
                Location = new Point(10, 10),
                AutoSize = true
            };
            this.Controls.Add(lblTurno);

            DrawGriglia(Griglia);
            DrawBottoni(Griglia);
        }

        private void DrawGriglia(ClsMatrix griglia)
        {
            for (int i = 0; i < griglia.Colonne; i++)
            {
                for (int j = 0; j < griglia.Righe; j++)
                {
                    CreaCella(i, j);
                }
            }
        }

        private void DrawBottoni(ClsMatrix griglia)
        {
            for (int i = 0; i < griglia.Colonne; i++)
            {
                Button btn = new Button()
                {
                    Name = $"btnColonna{i}",
                    Size = new Size(pbCella.Width, 30),
                    Location = new Point(i * pbCella.Width, lblTurno.Bottom + 10),
                    Text = $"↓ {i + 1}",
                };
                btn.Click += new EventHandler(BottoneColonna_Click);
                this.Controls.Add(btn);
            }
        }

        private void CreaCella(int x, int y)
        {
            Size s = pbCella.Size;
            Image i = pbCella.Image;

            PictureBox pb = new PictureBox()
            {
                Name = $"pb{x}-{y}",
                Size = s,
                Location = new Point(x * pbCella.Width, (y + 1) * pbCella.Height + 60), //offset per i bottoni e la label
                Image = i,
                Visible = true,
                Enabled = true,
                BorderStyle = BorderStyle.FixedSingle,
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            this.Controls.Add(pb);
        }

        private void BottoneColonna_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int colonna = int.Parse(btn.Name.Replace("btnColonna", ""));
            InserisciPedina(colonna);
        }

        private void InserisciPedina(int colonna)
        {
            ClsPedina pedina = new ClsPedina
            {
                Giocatore = turnoGiallo ? GiocatoreGiallo : GiocatoreRosso,
                Colore = turnoGiallo ? Color.Yellow : Color.Red
            };

            int riga = Griglia.InserisciPedina(colonna, pedina);

            if (riga != -1) //se la pedina è stata inserita con successo
            {
                var cella = this.Controls.Find($"pb{colonna}-{riga}", false).FirstOrDefault() as PictureBox;

                if (cella != null)
                {
                    //assegnamento immagine in base al turno
                    cella.Image = turnoGiallo ? pbGiallo.Image : pbRosso.Image;

                    //switch turno
                    turnoGiallo = !turnoGiallo;

                    lblTurno.Text = turnoGiallo ? $"Turno di: {GiocatoreGiallo.Nome}" : $"Turno di: {GiocatoreRosso.Nome}";

                    //controllo vincitore
                    ControlloVincitore();
                }
            }
            else
                MessageBox.Show("La colonna è piena!");
        }

        private void ControlloVincitore()
        {
            var vincitore = Griglia.ControllaCombinazioni();

            if (vincitore != null)
            {
                MessageBox.Show($"{(vincitore == Color.Yellow ? GiocatoreRosso.Nome : GiocatoreGiallo.Nome)} ha vinto!", "Vittoria", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
                this.Hide();

                FrmMain frmMain = new FrmMain(); //restart
                frmMain.ShowDialog();
            }
        }
    }
}