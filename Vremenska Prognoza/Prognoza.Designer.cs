namespace Vremenska_Prognoza {
    partial class winPrognoza {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(winPrognoza));
            this.lblImeGrada = new System.Windows.Forms.Label();
            this.pctrBxNazad = new System.Windows.Forms.PictureBox();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.lblVlaga = new System.Windows.Forms.Label();
            this.lblVrijeme = new System.Windows.Forms.Label();
            this.lblTlak = new System.Windows.Forms.Label();
            this.lblSmjerVjetra = new System.Windows.Forms.Label();
            this.lblBrzinaVjetra = new System.Windows.Forms.Label();
            this.lblTempTxt = new System.Windows.Forms.Label();
            this.pctrBoxVrijeme = new System.Windows.Forms.PictureBox();
            this.menuIzadiOprogramu = new System.Windows.Forms.MenuStrip();
            this.izađiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramu = new System.Windows.Forms.ToolStripMenuItem();
            this.minimiziraj = new System.Windows.Forms.ToolStripMenuItem();
            this.lblVlagaTxt = new System.Windows.Forms.Label();
            this.lblTlakTxt = new System.Windows.Forms.Label();
            this.lblBrzinaVjetraTxt = new System.Windows.Forms.Label();
            this.pctrBxVisokaTemp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBxNazad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBoxVrijeme)).BeginInit();
            this.menuIzadiOprogramu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBxVisokaTemp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblImeGrada
            // 
            this.lblImeGrada.BackColor = System.Drawing.Color.Transparent;
            this.lblImeGrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImeGrada.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblImeGrada.Location = new System.Drawing.Point(84, 39);
            this.lblImeGrada.Name = "lblImeGrada";
            this.lblImeGrada.Size = new System.Drawing.Size(861, 66);
            this.lblImeGrada.TabIndex = 0;
            this.lblImeGrada.Text = "Loading";
            this.lblImeGrada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pctrBxNazad
            // 
            this.pctrBxNazad.BackColor = System.Drawing.Color.Transparent;
            this.pctrBxNazad.BackgroundImage = global::Vremenska_Prognoza.Properties.Resources._65218257_479536202782810_3702791696447176704_n;
            this.pctrBxNazad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pctrBxNazad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctrBxNazad.Location = new System.Drawing.Point(0, 42);
            this.pctrBxNazad.Name = "pctrBxNazad";
            this.pctrBxNazad.Size = new System.Drawing.Size(78, 66);
            this.pctrBxNazad.TabIndex = 1;
            this.pctrBxNazad.TabStop = false;
            this.pctrBxNazad.Click += new System.EventHandler(this.pctrBxNazad_Click);
            // 
            // lblDatum
            // 
            this.lblDatum.BackColor = System.Drawing.Color.Transparent;
            this.lblDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatum.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDatum.Location = new System.Drawing.Point(413, 108);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(195, 46);
            this.lblDatum.TabIndex = 7;
            this.lblDatum.Text = "Loading";
            this.lblDatum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.BackColor = System.Drawing.Color.Transparent;
            this.lblTemperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTemperatura.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTemperatura.Location = new System.Drawing.Point(307, 310);
            this.lblTemperatura.Margin = new System.Windows.Forms.Padding(0);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(114, 28);
            this.lblTemperatura.TabIndex = 0;
            this.lblTemperatura.Text = "Loading temperature";
            this.lblTemperatura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVlaga
            // 
            this.lblVlaga.BackColor = System.Drawing.Color.Transparent;
            this.lblVlaga.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblVlaga.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblVlaga.Location = new System.Drawing.Point(656, 257);
            this.lblVlaga.Name = "lblVlaga";
            this.lblVlaga.Size = new System.Drawing.Size(289, 37);
            this.lblVlaga.TabIndex = 9;
            this.lblVlaga.Text = "Loading vlage";
            this.lblVlaga.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVrijeme
            // 
            this.lblVrijeme.BackColor = System.Drawing.Color.Transparent;
            this.lblVrijeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblVrijeme.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblVrijeme.Location = new System.Drawing.Point(136, 257);
            this.lblVrijeme.Name = "lblVrijeme";
            this.lblVrijeme.Size = new System.Drawing.Size(269, 37);
            this.lblVrijeme.TabIndex = 10;
            this.lblVrijeme.Text = "Loading vremena";
            this.lblVrijeme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTlak
            // 
            this.lblTlak.BackColor = System.Drawing.Color.Transparent;
            this.lblTlak.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTlak.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTlak.Location = new System.Drawing.Point(651, 310);
            this.lblTlak.Name = "lblTlak";
            this.lblTlak.Size = new System.Drawing.Size(294, 38);
            this.lblTlak.TabIndex = 11;
            this.lblTlak.Text = "Loading tlaka";
            this.lblTlak.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSmjerVjetra
            // 
            this.lblSmjerVjetra.BackColor = System.Drawing.Color.Transparent;
            this.lblSmjerVjetra.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSmjerVjetra.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSmjerVjetra.Location = new System.Drawing.Point(307, 426);
            this.lblSmjerVjetra.Name = "lblSmjerVjetra";
            this.lblSmjerVjetra.Size = new System.Drawing.Size(414, 35);
            this.lblSmjerVjetra.TabIndex = 12;
            this.lblSmjerVjetra.Text = "Loading smjera vjetra";
            this.lblSmjerVjetra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBrzinaVjetra
            // 
            this.lblBrzinaVjetra.BackColor = System.Drawing.Color.Transparent;
            this.lblBrzinaVjetra.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBrzinaVjetra.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBrzinaVjetra.Location = new System.Drawing.Point(483, 473);
            this.lblBrzinaVjetra.Name = "lblBrzinaVjetra";
            this.lblBrzinaVjetra.Size = new System.Drawing.Size(238, 36);
            this.lblBrzinaVjetra.TabIndex = 13;
            this.lblBrzinaVjetra.Text = "Loading brzine vjetra";
            this.lblBrzinaVjetra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTempTxt
            // 
            this.lblTempTxt.BackColor = System.Drawing.Color.Transparent;
            this.lblTempTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTempTxt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTempTxt.Location = new System.Drawing.Point(91, 310);
            this.lblTempTxt.Name = "lblTempTxt";
            this.lblTempTxt.Size = new System.Drawing.Size(189, 28);
            this.lblTempTxt.TabIndex = 14;
            this.lblTempTxt.Text = "Temperatura:";
            this.lblTempTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pctrBoxVrijeme
            // 
            this.pctrBoxVrijeme.BackColor = System.Drawing.Color.Transparent;
            this.pctrBoxVrijeme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctrBoxVrijeme.Location = new System.Drawing.Point(222, 159);
            this.pctrBoxVrijeme.Name = "pctrBoxVrijeme";
            this.pctrBoxVrijeme.Size = new System.Drawing.Size(100, 87);
            this.pctrBoxVrijeme.TabIndex = 15;
            this.pctrBoxVrijeme.TabStop = false;
            // 
            // menuIzadiOprogramu
            // 
            this.menuIzadiOprogramu.AutoSize = false;
            this.menuIzadiOprogramu.BackColor = System.Drawing.Color.Transparent;
            this.menuIzadiOprogramu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuIzadiOprogramu.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuIzadiOprogramu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izađiToolStripMenuItem,
            this.oProgramu,
            this.minimiziraj});
            this.menuIzadiOprogramu.Location = new System.Drawing.Point(0, 0);
            this.menuIzadiOprogramu.Name = "menuIzadiOprogramu";
            this.menuIzadiOprogramu.Size = new System.Drawing.Size(1013, 39);
            this.menuIzadiOprogramu.TabIndex = 16;
            // 
            // izađiToolStripMenuItem
            // 
            this.izađiToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.izađiToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 16.75F);
            this.izađiToolStripMenuItem.ForeColor = System.Drawing.Color.Snow;
            this.izađiToolStripMenuItem.Name = "izađiToolStripMenuItem";
            this.izađiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.End)));
            this.izađiToolStripMenuItem.Size = new System.Drawing.Size(74, 35);
            this.izađiToolStripMenuItem.Text = "Izađi";
            this.izađiToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.izađiToolStripMenuItem.Click += new System.EventHandler(this.izađiToolStripMenuItem_Click_1);
            // 
            // oProgramu
            // 
            this.oProgramu.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.oProgramu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.oProgramu.Name = "oProgramu";
            this.oProgramu.Size = new System.Drawing.Size(138, 35);
            this.oProgramu.Text = "O programu";
            this.oProgramu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.oProgramu.Click += new System.EventHandler(this.oProgramu_Click_1);
            // 
            // minimiziraj
            // 
            this.minimiziraj.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.minimiziraj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.minimiziraj.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.minimiziraj.Name = "minimiziraj";
            this.minimiziraj.Size = new System.Drawing.Size(43, 35);
            this.minimiziraj.Text = "___";
            this.minimiziraj.Click += new System.EventHandler(this.minimiziraj_Click_1);
            // 
            // lblVlagaTxt
            // 
            this.lblVlagaTxt.BackColor = System.Drawing.Color.Transparent;
            this.lblVlagaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblVlagaTxt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblVlagaTxt.Location = new System.Drawing.Point(575, 257);
            this.lblVlagaTxt.Name = "lblVlagaTxt";
            this.lblVlagaTxt.Size = new System.Drawing.Size(158, 37);
            this.lblVlagaTxt.TabIndex = 17;
            this.lblVlagaTxt.Text = "Vlaga:";
            this.lblVlagaTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTlakTxt
            // 
            this.lblTlakTxt.BackColor = System.Drawing.Color.Transparent;
            this.lblTlakTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTlakTxt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTlakTxt.Location = new System.Drawing.Point(575, 310);
            this.lblTlakTxt.Name = "lblTlakTxt";
            this.lblTlakTxt.Size = new System.Drawing.Size(158, 28);
            this.lblTlakTxt.TabIndex = 18;
            this.lblTlakTxt.Text = "Tlak:";
            this.lblTlakTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBrzinaVjetraTxt
            // 
            this.lblBrzinaVjetraTxt.BackColor = System.Drawing.Color.Transparent;
            this.lblBrzinaVjetraTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBrzinaVjetraTxt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBrzinaVjetraTxt.Location = new System.Drawing.Point(328, 473);
            this.lblBrzinaVjetraTxt.Name = "lblBrzinaVjetraTxt";
            this.lblBrzinaVjetraTxt.Size = new System.Drawing.Size(199, 36);
            this.lblBrzinaVjetraTxt.TabIndex = 19;
            this.lblBrzinaVjetraTxt.Text = "Brzina vjetra:";
            this.lblBrzinaVjetraTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pctrBxVisokaTemp
            // 
            this.pctrBxVisokaTemp.BackColor = System.Drawing.Color.Transparent;
            this.pctrBxVisokaTemp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctrBxVisokaTemp.Location = new System.Drawing.Point(411, 277);
            this.pctrBxVisokaTemp.Name = "pctrBxVisokaTemp";
            this.pctrBxVisokaTemp.Size = new System.Drawing.Size(135, 91);
            this.pctrBxVisokaTemp.TabIndex = 20;
            this.pctrBxVisokaTemp.TabStop = false;
            // 
            // winPrognoza
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1013, 651);
            this.Controls.Add(this.pctrBxVisokaTemp);
            this.Controls.Add(this.lblBrzinaVjetraTxt);
            this.Controls.Add(this.lblTlakTxt);
            this.Controls.Add(this.lblVlagaTxt);
            this.Controls.Add(this.menuIzadiOprogramu);
            this.Controls.Add(this.pctrBoxVrijeme);
            this.Controls.Add(this.lblTempTxt);
            this.Controls.Add(this.lblBrzinaVjetra);
            this.Controls.Add(this.lblSmjerVjetra);
            this.Controls.Add(this.lblTlak);
            this.Controls.Add(this.lblVrijeme);
            this.Controls.Add(this.lblVlaga);
            this.Controls.Add(this.lblTemperatura);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.pctrBxNazad);
            this.Controls.Add(this.lblImeGrada);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "winPrognoza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pctrBxNazad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBoxVrijeme)).EndInit();
            this.menuIzadiOprogramu.ResumeLayout(false);
            this.menuIzadiOprogramu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBxVisokaTemp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Label lblImeGrada;
        private System.Windows.Forms.PictureBox pctrBxNazad;
        private System.Windows.Forms.Label lblDatum;
        protected System.Windows.Forms.Label lblTemperatura;
        protected System.Windows.Forms.Label lblVlaga;
        protected System.Windows.Forms.Label lblVrijeme;
        protected System.Windows.Forms.Label lblTlak;
        protected System.Windows.Forms.Label lblSmjerVjetra;
        protected System.Windows.Forms.Label lblBrzinaVjetra;
        protected System.Windows.Forms.Label lblTempTxt;
        private System.Windows.Forms.PictureBox pctrBoxVrijeme;
        private System.Windows.Forms.MenuStrip menuIzadiOprogramu;
        private System.Windows.Forms.ToolStripMenuItem izađiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramu;
        private System.Windows.Forms.ToolStripMenuItem minimiziraj;
        protected System.Windows.Forms.Label lblVlagaTxt;
        protected System.Windows.Forms.Label lblTlakTxt;
        protected System.Windows.Forms.Label lblBrzinaVjetraTxt;
        private System.Windows.Forms.PictureBox pctrBxVisokaTemp;
    }
}