namespace NewPicEditApp
{
    partial class MultiplePicturesMode
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
            this.components = new System.ComponentModel.Container();
            this.imageBR = new Emgu.CV.UI.ImageBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pokażToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rozciąToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equalizacjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liniaProfiluToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacjeLogiczneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obraz11ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obraz12ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obraz1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sUBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obraz22ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obraz21ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obraz2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nOTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aNDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnOp1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.imageBS1 = new Emgu.CV.UI.PanAndZoomPictureBox();
            this.imageBS2 = new Emgu.CV.UI.PanAndZoomPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageBR)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBS2)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBR
            // 
            this.imageBR.Location = new System.Drawing.Point(314, 34);
            this.imageBR.Name = "imageBR";
            this.imageBR.Size = new System.Drawing.Size(387, 379);
            this.imageBR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBR.TabIndex = 2;
            this.imageBR.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOpen,
            this.histogramToolStripMenuItem,
            this.operacjeLogiczneToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuOpen
            // 
            this.menuOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
            this.menuOpen.Name = "menuOpen";
            this.menuOpen.Size = new System.Drawing.Size(38, 20);
            this.menuOpen.Text = "Plik";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Zapisz wynik";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pokażToolStripMenuItem,
            this.rozciąToolStripMenuItem,
            this.equalizacjaToolStripMenuItem,
            this.liniaProfiluToolStripMenuItem});
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            this.histogramToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.histogramToolStripMenuItem.Text = "Histogram";
            // 
            // pokażToolStripMenuItem
            // 
            this.pokażToolStripMenuItem.Name = "pokażToolStripMenuItem";
            this.pokażToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pokażToolStripMenuItem.Text = "Pokaż";
            // 
            // rozciąToolStripMenuItem
            // 
            this.rozciąToolStripMenuItem.Name = "rozciąToolStripMenuItem";
            this.rozciąToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rozciąToolStripMenuItem.Text = "Rozciągnij";
            // 
            // equalizacjaToolStripMenuItem
            // 
            this.equalizacjaToolStripMenuItem.Name = "equalizacjaToolStripMenuItem";
            this.equalizacjaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.equalizacjaToolStripMenuItem.Text = "Equalizacja";
            // 
            // liniaProfiluToolStripMenuItem
            // 
            this.liniaProfiluToolStripMenuItem.Name = "liniaProfiluToolStripMenuItem";
            this.liniaProfiluToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.liniaProfiluToolStripMenuItem.Text = "Linia profilu";
            // 
            // operacjeLogiczneToolStripMenuItem
            // 
            this.operacjeLogiczneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDDToolStripMenuItem,
            this.sUBToolStripMenuItem,
            this.nOTToolStripMenuItem,
            this.aNDToolStripMenuItem,
            this.oRToolStripMenuItem,
            this.xORToolStripMenuItem});
            this.operacjeLogiczneToolStripMenuItem.Name = "operacjeLogiczneToolStripMenuItem";
            this.operacjeLogiczneToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.operacjeLogiczneToolStripMenuItem.Text = "Operacje Logiczne";
            // 
            // aDDToolStripMenuItem
            // 
            this.aDDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.obraz11ToolStripMenuItem,
            this.obraz12ToolStripMenuItem,
            this.obraz1ToolStripMenuItem});
            this.aDDToolStripMenuItem.Name = "aDDToolStripMenuItem";
            this.aDDToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aDDToolStripMenuItem.Text = "ADD";
            // 
            // obraz11ToolStripMenuItem
            // 
            this.obraz11ToolStripMenuItem.Name = "obraz11ToolStripMenuItem";
            this.obraz11ToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.obraz11ToolStripMenuItem.Text = "Obraz 1+1";
            this.obraz11ToolStripMenuItem.Click += new System.EventHandler(this.obraz11ToolStripMenuItem_Click);
            // 
            // obraz12ToolStripMenuItem
            // 
            this.obraz12ToolStripMenuItem.Name = "obraz12ToolStripMenuItem";
            this.obraz12ToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.obraz12ToolStripMenuItem.Text = "Obraz 1+2";
            this.obraz12ToolStripMenuItem.Click += new System.EventHandler(this.obraz12ToolStripMenuItem_Click);
            // 
            // obraz1ToolStripMenuItem
            // 
            this.obraz1ToolStripMenuItem.Name = "obraz1ToolStripMenuItem";
            this.obraz1ToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.obraz1ToolStripMenuItem.Text = "Obraz 1 + ?";
            // 
            // sUBToolStripMenuItem
            // 
            this.sUBToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.obraz22ToolStripMenuItem,
            this.obraz21ToolStripMenuItem,
            this.obraz2ToolStripMenuItem});
            this.sUBToolStripMenuItem.Name = "sUBToolStripMenuItem";
            this.sUBToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sUBToolStripMenuItem.Text = "SUB";
            // 
            // obraz22ToolStripMenuItem
            // 
            this.obraz22ToolStripMenuItem.Name = "obraz22ToolStripMenuItem";
            this.obraz22ToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.obraz22ToolStripMenuItem.Text = "Obraz 1-1";
            this.obraz22ToolStripMenuItem.Click += new System.EventHandler(this.obraz22ToolStripMenuItem_Click);
            // 
            // obraz21ToolStripMenuItem
            // 
            this.obraz21ToolStripMenuItem.Name = "obraz21ToolStripMenuItem";
            this.obraz21ToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.obraz21ToolStripMenuItem.Text = "Obraz 1-2";
            this.obraz21ToolStripMenuItem.Click += new System.EventHandler(this.obraz21ToolStripMenuItem_Click);
            // 
            // obraz2ToolStripMenuItem
            // 
            this.obraz2ToolStripMenuItem.Name = "obraz2ToolStripMenuItem";
            this.obraz2ToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.obraz2ToolStripMenuItem.Text = "Obraz 1-?";
            // 
            // nOTToolStripMenuItem
            // 
            this.nOTToolStripMenuItem.Name = "nOTToolStripMenuItem";
            this.nOTToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nOTToolStripMenuItem.Text = "NOT";
            this.nOTToolStripMenuItem.Click += new System.EventHandler(this.nOTToolStripMenuItem_Click);
            // 
            // aNDToolStripMenuItem
            // 
            this.aNDToolStripMenuItem.Name = "aNDToolStripMenuItem";
            this.aNDToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aNDToolStripMenuItem.Text = "AND";
            this.aNDToolStripMenuItem.Click += new System.EventHandler(this.aNDToolStripMenuItem_Click);
            // 
            // oRToolStripMenuItem
            // 
            this.oRToolStripMenuItem.Name = "oRToolStripMenuItem";
            this.oRToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.oRToolStripMenuItem.Text = "OR";
            this.oRToolStripMenuItem.Click += new System.EventHandler(this.oRToolStripMenuItem_Click);
            // 
            // xORToolStripMenuItem
            // 
            this.xORToolStripMenuItem.Name = "xORToolStripMenuItem";
            this.xORToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.xORToolStripMenuItem.Text = "XOR";
            this.xORToolStripMenuItem.Click += new System.EventHandler(this.xORToolStripMenuItem_Click);
            // 
            // BtnOp1
            // 
            this.BtnOp1.Location = new System.Drawing.Point(12, 183);
            this.BtnOp1.Name = "BtnOp1";
            this.BtnOp1.Size = new System.Drawing.Size(75, 23);
            this.BtnOp1.TabIndex = 9;
            this.BtnOp1.Text = "Obraz 1";
            this.BtnOp1.UseVisualStyleBackColor = true;
            this.BtnOp1.Click += new System.EventHandler(this.BtnOp1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(169, 183);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Obraz 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // imageBS1
            // 
            this.imageBS1.Location = new System.Drawing.Point(12, 59);
            this.imageBS1.Name = "imageBS1";
            this.imageBS1.Size = new System.Drawing.Size(118, 118);
            this.imageBS1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBS1.TabIndex = 11;
            this.imageBS1.TabStop = false;
            // 
            // imageBS2
            // 
            this.imageBS2.Location = new System.Drawing.Point(169, 59);
            this.imageBS2.Name = "imageBS2";
            this.imageBS2.Size = new System.Drawing.Size(118, 118);
            this.imageBS2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBS2.TabIndex = 12;
            this.imageBS2.TabStop = false;
            // 
            // MultiplePicturesMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imageBS2);
            this.Controls.Add(this.imageBS1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnOp1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.imageBR);
            this.Name = "MultiplePicturesMode";
            this.Text = "MultiplePictures";
            ((System.ComponentModel.ISupportInitialize)(this.imageBR)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBS2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Emgu.CV.UI.ImageBox imageBR;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuOpen;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pokażToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rozciąToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equalizacjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liniaProfiluToolStripMenuItem;
        private System.Windows.Forms.Button BtnOp1;
        private System.Windows.Forms.Button button2;
        private Emgu.CV.UI.PanAndZoomPictureBox imageBS1;
        private Emgu.CV.UI.PanAndZoomPictureBox imageBS2;
        private System.Windows.Forms.ToolStripMenuItem operacjeLogiczneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sUBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nOTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aNDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xORToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obraz11ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obraz12ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obraz1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obraz22ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obraz21ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obraz2ToolStripMenuItem;
    }
}