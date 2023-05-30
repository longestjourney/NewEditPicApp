namespace NewPicEditApp
{
    partial class Maski
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panAndZoomPictureBox1 = new Emgu.CV.UI.PanAndZoomPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bMask3 = new System.Windows.Forms.Button();
            this.bMask2 = new System.Windows.Forms.Button();
            this.bMask1 = new System.Windows.Forms.Button();
            this.num31 = new System.Windows.Forms.NumericUpDown();
            this.num32 = new System.Windows.Forms.NumericUpDown();
            this.num33 = new System.Windows.Forms.NumericUpDown();
            this.num22 = new System.Windows.Forms.NumericUpDown();
            this.num23 = new System.Windows.Forms.NumericUpDown();
            this.num21 = new System.Windows.Forms.NumericUpDown();
            this.num12 = new System.Windows.Forms.NumericUpDown();
            this.num13 = new System.Windows.Forms.NumericUpDown();
            this.num11 = new System.Windows.Forms.NumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.średniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pokażToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rozciąToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equalizacjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liniaProfiluToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyostrzRozmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maskiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panAndZoomPictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num11)).BeginInit();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panAndZoomPictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(348, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 369);
            this.panel1.TabIndex = 0;
            // 
            // panAndZoomPictureBox1
            // 
            this.panAndZoomPictureBox1.Location = new System.Drawing.Point(8, 12);
            this.panAndZoomPictureBox1.Name = "panAndZoomPictureBox1";
            this.panAndZoomPictureBox1.Size = new System.Drawing.Size(407, 345);
            this.panAndZoomPictureBox1.TabIndex = 0;
            this.panAndZoomPictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bMask3);
            this.panel2.Controls.Add(this.bMask2);
            this.panel2.Controls.Add(this.bMask1);
            this.panel2.Controls.Add(this.num31);
            this.panel2.Controls.Add(this.num32);
            this.panel2.Controls.Add(this.num33);
            this.panel2.Controls.Add(this.num22);
            this.panel2.Controls.Add(this.num23);
            this.panel2.Controls.Add(this.num21);
            this.panel2.Controls.Add(this.num12);
            this.panel2.Controls.Add(this.num13);
            this.panel2.Controls.Add(this.num11);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(119, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(229, 369);
            this.panel2.TabIndex = 1;
            // 
            // bMask3
            // 
            this.bMask3.Location = new System.Drawing.Point(13, 234);
            this.bMask3.Name = "bMask3";
            this.bMask3.Size = new System.Drawing.Size(117, 23);
            this.bMask3.TabIndex = 11;
            this.bMask3.Text = "Gotowa maska -2 5";
            this.bMask3.UseVisualStyleBackColor = true;
            this.bMask3.Click += new System.EventHandler(this.bMask3_Click);
            // 
            // bMask2
            // 
            this.bMask2.Location = new System.Drawing.Point(13, 205);
            this.bMask2.Name = "bMask2";
            this.bMask2.Size = new System.Drawing.Size(117, 23);
            this.bMask2.TabIndex = 10;
            this.bMask2.Text = "Gotowa maska -1 9";
            this.bMask2.UseVisualStyleBackColor = true;
            this.bMask2.Click += new System.EventHandler(this.bMask2_Click);
            // 
            // bMask1
            // 
            this.bMask1.Location = new System.Drawing.Point(13, 176);
            this.bMask1.Name = "bMask1";
            this.bMask1.Size = new System.Drawing.Size(117, 23);
            this.bMask1.TabIndex = 9;
            this.bMask1.Text = "Gotowa maska -1 5";
            this.bMask1.UseVisualStyleBackColor = true;
            this.bMask1.Click += new System.EventHandler(this.bMask1_Click);
            // 
            // num31
            // 
            this.num31.Location = new System.Drawing.Point(12, 96);
            this.num31.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.num31.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            -2147483648});
            this.num31.Name = "num31";
            this.num31.Size = new System.Drawing.Size(56, 20);
            this.num31.TabIndex = 8;
            // 
            // num32
            // 
            this.num32.Location = new System.Drawing.Point(74, 96);
            this.num32.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.num32.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            -2147483648});
            this.num32.Name = "num32";
            this.num32.Size = new System.Drawing.Size(56, 20);
            this.num32.TabIndex = 7;
            // 
            // num33
            // 
            this.num33.Location = new System.Drawing.Point(136, 96);
            this.num33.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.num33.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            -2147483648});
            this.num33.Name = "num33";
            this.num33.Size = new System.Drawing.Size(56, 20);
            this.num33.TabIndex = 6;
            // 
            // num22
            // 
            this.num22.Location = new System.Drawing.Point(74, 70);
            this.num22.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.num22.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            -2147483648});
            this.num22.Name = "num22";
            this.num22.Size = new System.Drawing.Size(56, 20);
            this.num22.TabIndex = 5;
            // 
            // num23
            // 
            this.num23.Location = new System.Drawing.Point(136, 70);
            this.num23.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.num23.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            -2147483648});
            this.num23.Name = "num23";
            this.num23.Size = new System.Drawing.Size(56, 20);
            this.num23.TabIndex = 4;
            // 
            // num21
            // 
            this.num21.Location = new System.Drawing.Point(12, 70);
            this.num21.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.num21.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            -2147483648});
            this.num21.Name = "num21";
            this.num21.Size = new System.Drawing.Size(56, 20);
            this.num21.TabIndex = 3;
            // 
            // num12
            // 
            this.num12.Location = new System.Drawing.Point(74, 44);
            this.num12.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.num12.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            -2147483648});
            this.num12.Name = "num12";
            this.num12.Size = new System.Drawing.Size(56, 20);
            this.num12.TabIndex = 2;
            // 
            // num13
            // 
            this.num13.Location = new System.Drawing.Point(136, 44);
            this.num13.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.num13.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            -2147483648});
            this.num13.Name = "num13";
            this.num13.Size = new System.Drawing.Size(56, 20);
            this.num13.TabIndex = 1;
            // 
            // num11
            // 
            this.num11.Location = new System.Drawing.Point(12, 44);
            this.num11.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.num11.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            -2147483648});
            this.num11.Name = "num11";
            this.num11.Size = new System.Drawing.Size(56, 20);
            this.num11.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.menuStrip1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(125, 369);
            this.panel3.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOpen,
            this.histogramToolStripMenuItem,
            this.wyostrzRozmToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(108, 369);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuOpen
            // 
            this.menuOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.convertToolStripMenuItem});
            this.menuOpen.Name = "menuOpen";
            this.menuOpen.Size = new System.Drawing.Size(95, 19);
            this.menuOpen.Text = "Plik";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // convertToolStripMenuItem
            // 
            this.convertToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byRToolStripMenuItem,
            this.byGToolStripMenuItem,
            this.byBToolStripMenuItem,
            this.średniaToolStripMenuItem});
            this.convertToolStripMenuItem.Name = "convertToolStripMenuItem";
            this.convertToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.convertToolStripMenuItem.Text = "Convert to Grayscale";
            // 
            // byRToolStripMenuItem
            // 
            this.byRToolStripMenuItem.Name = "byRToolStripMenuItem";
            this.byRToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.byRToolStripMenuItem.Text = "by R";
            // 
            // byGToolStripMenuItem
            // 
            this.byGToolStripMenuItem.Name = "byGToolStripMenuItem";
            this.byGToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.byGToolStripMenuItem.Text = "by G";
            // 
            // byBToolStripMenuItem
            // 
            this.byBToolStripMenuItem.Name = "byBToolStripMenuItem";
            this.byBToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.byBToolStripMenuItem.Text = "by B";
            // 
            // średniaToolStripMenuItem
            // 
            this.średniaToolStripMenuItem.Name = "średniaToolStripMenuItem";
            this.średniaToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.średniaToolStripMenuItem.Text = "Średnia";
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pokażToolStripMenuItem,
            this.rozciąToolStripMenuItem,
            this.equalizacjaToolStripMenuItem,
            this.liniaProfiluToolStripMenuItem});
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            this.histogramToolStripMenuItem.Size = new System.Drawing.Size(95, 19);
            this.histogramToolStripMenuItem.Text = "Histogram";
            // 
            // pokażToolStripMenuItem
            // 
            this.pokażToolStripMenuItem.Name = "pokażToolStripMenuItem";
            this.pokażToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.pokażToolStripMenuItem.Text = "Pokaż";
            // 
            // rozciąToolStripMenuItem
            // 
            this.rozciąToolStripMenuItem.Name = "rozciąToolStripMenuItem";
            this.rozciąToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.rozciąToolStripMenuItem.Text = "Rozciągnij";
            // 
            // equalizacjaToolStripMenuItem
            // 
            this.equalizacjaToolStripMenuItem.Name = "equalizacjaToolStripMenuItem";
            this.equalizacjaToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.equalizacjaToolStripMenuItem.Text = "Equalizacja";
            // 
            // liniaProfiluToolStripMenuItem
            // 
            this.liniaProfiluToolStripMenuItem.Name = "liniaProfiluToolStripMenuItem";
            this.liniaProfiluToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.liniaProfiluToolStripMenuItem.Text = "Linia profilu";
            // 
            // wyostrzRozmToolStripMenuItem
            // 
            this.wyostrzRozmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maskiToolStripMenuItem});
            this.wyostrzRozmToolStripMenuItem.Name = "wyostrzRozmToolStripMenuItem";
            this.wyostrzRozmToolStripMenuItem.Size = new System.Drawing.Size(95, 19);
            this.wyostrzRozmToolStripMenuItem.Text = "Wyostrz./Rozm.";
            // 
            // maskiToolStripMenuItem
            // 
            this.maskiToolStripMenuItem.Name = "maskiToolStripMenuItem";
            this.maskiToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.maskiToolStripMenuItem.Text = "Maski";
            // 
            // Maski
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 369);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Maski";
            this.Text = "Maski";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panAndZoomPictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num11)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Emgu.CV.UI.PanAndZoomPictureBox panAndZoomPictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bMask3;
        private System.Windows.Forms.Button bMask2;
        private System.Windows.Forms.Button bMask1;
        private System.Windows.Forms.NumericUpDown num31;
        private System.Windows.Forms.NumericUpDown num32;
        private System.Windows.Forms.NumericUpDown num33;
        private System.Windows.Forms.NumericUpDown num22;
        private System.Windows.Forms.NumericUpDown num23;
        private System.Windows.Forms.NumericUpDown num21;
        private System.Windows.Forms.NumericUpDown num12;
        private System.Windows.Forms.NumericUpDown num13;
        private System.Windows.Forms.NumericUpDown num11;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuOpen;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem średniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pokażToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rozciąToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equalizacjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liniaProfiluToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyostrzRozmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maskiToolStripMenuItem;
    }
}