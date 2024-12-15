namespace Forza4_Mk2_Cerioni
{
    partial class FrmMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAvviaPartita = new System.Windows.Forms.Button();
            this.tbRosso = new System.Windows.Forms.TextBox();
            this.tbGiallo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudRighe = new System.Windows.Forms.NumericUpDown();
            this.nudColonne = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudRighe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColonne)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAvviaPartita
            // 
            this.btnAvviaPartita.Location = new System.Drawing.Point(234, 189);
            this.btnAvviaPartita.Name = "btnAvviaPartita";
            this.btnAvviaPartita.Size = new System.Drawing.Size(125, 49);
            this.btnAvviaPartita.TabIndex = 10;
            this.btnAvviaPartita.Text = "AVVIA PARTITA";
            this.btnAvviaPartita.UseVisualStyleBackColor = true;
            this.btnAvviaPartita.Click += new System.EventHandler(this.btnAvviaPartita_Click);
            // 
            // tbRosso
            // 
            this.tbRosso.Location = new System.Drawing.Point(349, 73);
            this.tbRosso.Name = "tbRosso";
            this.tbRosso.Size = new System.Drawing.Size(241, 20);
            this.tbRosso.TabIndex = 9;
            // 
            // tbGiallo
            // 
            this.tbGiallo.Location = new System.Drawing.Point(17, 73);
            this.tbGiallo.Name = "tbGiallo";
            this.tbGiallo.Size = new System.Drawing.Size(235, 20);
            this.tbGiallo.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(395, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nome Rosso :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome Giallo :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Forza 4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(221, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Dimensione Griglia :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(291, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "x";
            // 
            // nudRighe
            // 
            this.nudRighe.Location = new System.Drawing.Point(244, 142);
            this.nudRighe.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudRighe.Name = "nudRighe";
            this.nudRighe.Size = new System.Drawing.Size(41, 20);
            this.nudRighe.TabIndex = 15;
            this.nudRighe.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // nudColonne
            // 
            this.nudColonne.Location = new System.Drawing.Point(312, 142);
            this.nudColonne.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.nudColonne.Name = "nudColonne";
            this.nudColonne.Size = new System.Drawing.Size(41, 20);
            this.nudColonne.TabIndex = 16;
            this.nudColonne.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(602, 241);
            this.Controls.Add(this.nudColonne);
            this.Controls.Add(this.nudRighe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAvviaPartita);
            this.Controls.Add(this.tbRosso);
            this.Controls.Add(this.tbGiallo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.MaximumSize = new System.Drawing.Size(618, 280);
            this.MinimumSize = new System.Drawing.Size(618, 280);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            ((System.ComponentModel.ISupportInitialize)(this.nudRighe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColonne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAvviaPartita;
        private System.Windows.Forms.TextBox tbRosso;
        private System.Windows.Forms.TextBox tbGiallo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudRighe;
        private System.Windows.Forms.NumericUpDown nudColonne;
    }
}

