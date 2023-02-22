namespace B1
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
            this.prijaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prijavaPasaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spisakPasaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlozbeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spisakPasaPoRasiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.krajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prijaveToolStripMenuItem,
            this.izlozbeToolStripMenuItem,
            this.krajToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(272, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // prijaveToolStripMenuItem
            // 
            this.prijaveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prijavaPasaToolStripMenuItem,
            this.spisakPasaToolStripMenuItem});
            this.prijaveToolStripMenuItem.Name = "prijaveToolStripMenuItem";
            this.prijaveToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.prijaveToolStripMenuItem.Text = "Prijave";
            // 
            // prijavaPasaToolStripMenuItem
            // 
            this.prijavaPasaToolStripMenuItem.Name = "prijavaPasaToolStripMenuItem";
            this.prijavaPasaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.prijavaPasaToolStripMenuItem.Text = "Prijava pasa";
            this.prijavaPasaToolStripMenuItem.Click += new System.EventHandler(this.PrijavaPasaToolStripMenuItem_Click);
            // 
            // spisakPasaToolStripMenuItem
            // 
            this.spisakPasaToolStripMenuItem.Name = "spisakPasaToolStripMenuItem";
            this.spisakPasaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.spisakPasaToolStripMenuItem.Text = "Spisak Pasa";
            // 
            // izlozbeToolStripMenuItem
            // 
            this.izlozbeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosToolStripMenuItem,
            this.spisakPasaPoRasiToolStripMenuItem});
            this.izlozbeToolStripMenuItem.Name = "izlozbeToolStripMenuItem";
            this.izlozbeToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.izlozbeToolStripMenuItem.Text = "Izlozbe";
            // 
            // unosToolStripMenuItem
            // 
            this.unosToolStripMenuItem.Name = "unosToolStripMenuItem";
            this.unosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.unosToolStripMenuItem.Text = "Unos";
            // 
            // spisakPasaPoRasiToolStripMenuItem
            // 
            this.spisakPasaPoRasiToolStripMenuItem.Name = "spisakPasaPoRasiToolStripMenuItem";
            this.spisakPasaPoRasiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.spisakPasaPoRasiToolStripMenuItem.Text = "Spisak pasa po rasi";
            this.spisakPasaPoRasiToolStripMenuItem.Click += new System.EventHandler(this.SpisakPasaPoRasiToolStripMenuItem_Click);
            // 
            // krajToolStripMenuItem
            // 
            this.krajToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izlazToolStripMenuItem});
            this.krajToolStripMenuItem.Name = "krajToolStripMenuItem";
            this.krajToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.krajToolStripMenuItem.Text = "Kraj";
            // 
            // izlazToolStripMenuItem
            // 
            this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            this.izlazToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.izlazToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.izlazToolStripMenuItem.Text = "Izlaz";
            this.izlazToolStripMenuItem.Click += new System.EventHandler(this.IzlazToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 248);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Izlozba_Pasa";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem prijaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prijavaPasaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spisakPasaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlozbeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spisakPasaPoRasiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem krajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
    }
}

