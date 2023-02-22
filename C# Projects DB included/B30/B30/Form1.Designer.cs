namespace B30
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.unosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gostiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analizaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuplaceneRezervacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slobodneSobeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.krajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.klikerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosToolStripMenuItem,
            this.analizaToolStripMenuItem,
            this.klikerToolStripMenuItem,
            this.krajToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(340, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // unosToolStripMenuItem
            // 
            this.unosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobeToolStripMenuItem,
            this.gostiToolStripMenuItem});
            this.unosToolStripMenuItem.Name = "unosToolStripMenuItem";
            this.unosToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.unosToolStripMenuItem.Text = "Unos";
            // 
            // sobeToolStripMenuItem
            // 
            this.sobeToolStripMenuItem.Name = "sobeToolStripMenuItem";
            this.sobeToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.sobeToolStripMenuItem.Text = "Sobe";
            // 
            // gostiToolStripMenuItem
            // 
            this.gostiToolStripMenuItem.Name = "gostiToolStripMenuItem";
            this.gostiToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.gostiToolStripMenuItem.Text = "Gosti";
            this.gostiToolStripMenuItem.Click += new System.EventHandler(this.gostiToolStripMenuItem_Click);
            // 
            // analizaToolStripMenuItem
            // 
            this.analizaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuplaceneRezervacijeToolStripMenuItem,
            this.slobodneSobeToolStripMenuItem});
            this.analizaToolStripMenuItem.Name = "analizaToolStripMenuItem";
            this.analizaToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.analizaToolStripMenuItem.Text = "Analiza";
            // 
            // neuplaceneRezervacijeToolStripMenuItem
            // 
            this.neuplaceneRezervacijeToolStripMenuItem.Name = "neuplaceneRezervacijeToolStripMenuItem";
            this.neuplaceneRezervacijeToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.neuplaceneRezervacijeToolStripMenuItem.Text = "Neuplacene rezervacije";
            // 
            // slobodneSobeToolStripMenuItem
            // 
            this.slobodneSobeToolStripMenuItem.Name = "slobodneSobeToolStripMenuItem";
            this.slobodneSobeToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.slobodneSobeToolStripMenuItem.Text = "Slobodne sobe";
            this.slobodneSobeToolStripMenuItem.Click += new System.EventHandler(this.slobodneSobeToolStripMenuItem_Click);
            // 
            // krajToolStripMenuItem
            // 
            this.krajToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izlazToolStripMenuItem});
            this.krajToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.krajToolStripMenuItem.Name = "krajToolStripMenuItem";
            this.krajToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.krajToolStripMenuItem.Text = "Kraj";
            // 
            // izlazToolStripMenuItem
            // 
            this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            this.izlazToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.izlazToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.izlazToolStripMenuItem.Text = "Izlaz";
            this.izlazToolStripMenuItem.Click += new System.EventHandler(this.izlazToolStripMenuItem_Click);
            // 
            // klikerToolStripMenuItem
            // 
            this.klikerToolStripMenuItem.Name = "klikerToolStripMenuItem";
            this.klikerToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.klikerToolStripMenuItem.Text = "Kliker";
            this.klikerToolStripMenuItem.Click += new System.EventHandler(this.KlikerToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(340, 255);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Red;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Rezervacija Hotelskih Soba";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem unosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gostiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analizaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neuplaceneRezervacijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem slobodneSobeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem krajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem klikerToolStripMenuItem;
    }
}

