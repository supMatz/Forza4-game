namespace Forza4_Mk2_Cerioni
{
    partial class FrmGioco
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbGiallo = new System.Windows.Forms.PictureBox();
            this.pbRosso = new System.Windows.Forms.PictureBox();
            this.pbCella = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbGiallo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRosso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCella)).BeginInit();
            this.SuspendLayout();
            // 
            // pbGiallo
            // 
            this.pbGiallo.Image = global::Forza4_Mk2_Cerioni.Properties.Resources.Giallo;
            this.pbGiallo.Location = new System.Drawing.Point(95, 812);
            this.pbGiallo.Name = "pbGiallo";
            this.pbGiallo.Size = new System.Drawing.Size(70, 70);
            this.pbGiallo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGiallo.TabIndex = 3;
            this.pbGiallo.TabStop = false;
            this.pbGiallo.Visible = false;
            // 
            // pbRosso
            // 
            this.pbRosso.Image = global::Forza4_Mk2_Cerioni.Properties.Resources.Rosso;
            this.pbRosso.Location = new System.Drawing.Point(182, 812);
            this.pbRosso.Name = "pbRosso";
            this.pbRosso.Size = new System.Drawing.Size(70, 70);
            this.pbRosso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRosso.TabIndex = 2;
            this.pbRosso.TabStop = false;
            this.pbRosso.Visible = false;
            // 
            // pbCella
            // 
            this.pbCella.Image = global::Forza4_Mk2_Cerioni.Properties.Resources.cella;
            this.pbCella.Location = new System.Drawing.Point(6, 812);
            this.pbCella.Name = "pbCella";
            this.pbCella.Size = new System.Drawing.Size(70, 70);
            this.pbCella.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCella.TabIndex = 1;
            this.pbCella.TabStop = false;
            this.pbCella.Visible = false;
            // 
            // FrmGioco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(887, 894);
            this.Controls.Add(this.pbGiallo);
            this.Controls.Add(this.pbRosso);
            this.Controls.Add(this.pbCella);
            this.Name = "FrmGioco";
            this.Text = "FrmGioco";
            ((System.ComponentModel.ISupportInitialize)(this.pbGiallo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRosso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCella)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCella;
        private System.Windows.Forms.PictureBox pbRosso;
        private System.Windows.Forms.PictureBox pbGiallo;
    }
}