namespace Vremenska_Prognoza {
    partial class winIzaberiGrad {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(winIzaberiGrad));
            this.btnPotvrde = new System.Windows.Forms.Button();
            this.lblIzaberiteGrad = new System.Windows.Forms.Label();
            this.lblUpozorenje = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuIzadiOprogramu = new System.Windows.Forms.MenuStrip();
            this.izađiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrlEndToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            cmBxIzaberiGrad = new System.Windows.Forms.ComboBox();
            this.menuIzadiOprogramu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPotvrde
            // 
            this.btnPotvrde.BackColor = System.Drawing.Color.Transparent;
            this.btnPotvrde.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnPotvrde, "btnPotvrde");
            this.btnPotvrde.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPotvrde.Name = "btnPotvrde";
            this.btnPotvrde.UseVisualStyleBackColor = false;
            this.btnPotvrde.Click += new System.EventHandler(this.btnPotvrde_Click);
            // 
            // lblIzaberiteGrad
            // 
            this.lblIzaberiteGrad.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lblIzaberiteGrad, "lblIzaberiteGrad");
            this.lblIzaberiteGrad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIzaberiteGrad.Name = "lblIzaberiteGrad";
            // 
            // lblUpozorenje
            // 
            this.lblUpozorenje.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lblUpozorenje, "lblUpozorenje");
            this.lblUpozorenje.ForeColor = System.Drawing.Color.Red;
            this.lblUpozorenje.Name = "lblUpozorenje";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // menuIzadiOprogramu
            // 
            resources.ApplyResources(this.menuIzadiOprogramu, "menuIzadiOprogramu");
            this.menuIzadiOprogramu.BackColor = System.Drawing.Color.Transparent;
            this.menuIzadiOprogramu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izađiToolStripMenuItem,
            this.oProgramuToolStripMenuItem,
            this.ctrlEndToolStripMenuItem1});
            this.menuIzadiOprogramu.Name = "menuIzadiOprogramu";
            // 
            // izađiToolStripMenuItem
            // 
            this.izađiToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.izađiToolStripMenuItem, "izađiToolStripMenuItem");
            this.izađiToolStripMenuItem.ForeColor = System.Drawing.Color.Snow;
            this.izađiToolStripMenuItem.Name = "izađiToolStripMenuItem";
            this.izađiToolStripMenuItem.Click += new System.EventHandler(this.izađiToolStripMenuItem_Click);
            // 
            // oProgramuToolStripMenuItem
            // 
            resources.ApplyResources(this.oProgramuToolStripMenuItem, "oProgramuToolStripMenuItem");
            this.oProgramuToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.oProgramuToolStripMenuItem.Name = "oProgramuToolStripMenuItem";
            this.oProgramuToolStripMenuItem.Click += new System.EventHandler(this.oProgramuToolStripMenuItem_Click);
            // 
            // ctrlEndToolStripMenuItem1
            // 
            this.ctrlEndToolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ctrlEndToolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ctrlEndToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ctrlEndToolStripMenuItem1.Name = "ctrlEndToolStripMenuItem1";
            resources.ApplyResources(this.ctrlEndToolStripMenuItem1, "ctrlEndToolStripMenuItem1");
            this.ctrlEndToolStripMenuItem1.Click += new System.EventHandler(this.minimiziraj);
            // 
            // cmBxIzaberiGrad
            // 
            cmBxIzaberiGrad.BackColor = System.Drawing.SystemColors.ControlLightLight;
            cmBxIzaberiGrad.Cursor = System.Windows.Forms.Cursors.Hand;
            cmBxIzaberiGrad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(cmBxIzaberiGrad, "cmBxIzaberiGrad");
            cmBxIzaberiGrad.Name = "cmBxIzaberiGrad";
            cmBxIzaberiGrad.Sorted = true;
            cmBxIzaberiGrad.Tag = "";
            cmBxIzaberiGrad.SelectedIndexChanged += new System.EventHandler(this.cmBxIzaberiGrad_SelectedIndexChanged);
            // 
            // winIzaberiGrad
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Vremenska_Prognoza.Properties.Resources.Weather_Blog_Image;
            this.Controls.Add(this.lblUpozorenje);
            this.Controls.Add(this.btnPotvrde);
            this.Controls.Add(cmBxIzaberiGrad);
            this.Controls.Add(this.lblIzaberiteGrad);
            this.Controls.Add(this.menuIzadiOprogramu);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.MainMenuStrip = this.menuIzadiOprogramu;
            this.MaximizeBox = false;
            this.Name = "winIzaberiGrad";
            this.menuIzadiOprogramu.ResumeLayout(false);
            this.menuIzadiOprogramu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmBxIzaberiGrad;
        private System.Windows.Forms.Button btnPotvrde;
        private System.Windows.Forms.Label lblIzaberiteGrad;
        private System.Windows.Forms.Label lblUpozorenje;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuIzadiOprogramu;
        private System.Windows.Forms.ToolStripMenuItem izađiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ctrlEndToolStripMenuItem1;

    }
}

