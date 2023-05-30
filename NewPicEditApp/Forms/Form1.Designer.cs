namespace NewPicEditApp
{
    partial class PicForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PicForm));
            this.picbox = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duplicateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.miOperacjeJednop = new System.Windows.Forms.ToolStripMenuItem();
            this.miInvert = new System.Windows.Forms.ToolStripMenuItem();
            this.posteryzacjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rozciąganieSelektywneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.morfologiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stałeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wybierzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dylacjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erozjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szkieletyzacjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacjeNaWieluObrazachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaWszystkichOkienekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twoPicturesModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyostrzRozmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maskiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaptacyjneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otsuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zPoziomamiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rozciąganieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equalizacjaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picbox
            // 
            this.picbox.Image = ((System.Drawing.Image)(resources.GetObject("picbox.Image")));
            this.picbox.Location = new System.Drawing.Point(12, 61);
            this.picbox.Name = "picbox";
            this.picbox.Size = new System.Drawing.Size(465, 323);
            this.picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox.TabIndex = 1;
            this.picbox.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOpen,
            this.histogramToolStripMenuItem,
            this.miOperacjeJednop,
            this.morfologiaToolStripMenuItem,
            this.operacjeNaWieluObrazachToolStripMenuItem,
            this.wyostrzRozmToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(618, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuOpen
            // 
            this.menuOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.convertToolStripMenuItem});
            this.menuOpen.Name = "menuOpen";
            this.menuOpen.Size = new System.Drawing.Size(38, 20);
            this.menuOpen.Text = "Plik";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.replaceToolStripMenuItem,
            this.duplicateToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Otwórz";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // replaceToolStripMenuItem
            // 
            this.replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
            this.replaceToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.replaceToolStripMenuItem.Text = "Replace";
            this.replaceToolStripMenuItem.Click += new System.EventHandler(this.replaceToolStripMenuItem_Click);
            // 
            // duplicateToolStripMenuItem
            // 
            this.duplicateToolStripMenuItem.Name = "duplicateToolStripMenuItem";
            this.duplicateToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.duplicateToolStripMenuItem.Text = "Duplicate";
            this.duplicateToolStripMenuItem.Click += new System.EventHandler(this.duplicateToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Zapisz";
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
            this.convertToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.convertToolStripMenuItem.Text = "Szaroodcieniowy...";
            // 
            // byRToolStripMenuItem
            // 
            this.byRToolStripMenuItem.Name = "byRToolStripMenuItem";
            this.byRToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.byRToolStripMenuItem.Text = "przez R";
            this.byRToolStripMenuItem.Click += new System.EventHandler(this.byRToolStripMenuItem_Click);
            // 
            // byGToolStripMenuItem
            // 
            this.byGToolStripMenuItem.Name = "byGToolStripMenuItem";
            this.byGToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.byGToolStripMenuItem.Text = "przez G";
            this.byGToolStripMenuItem.Click += new System.EventHandler(this.byGToolStripMenuItem_Click);
            // 
            // byBToolStripMenuItem
            // 
            this.byBToolStripMenuItem.Name = "byBToolStripMenuItem";
            this.byBToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.byBToolStripMenuItem.Text = "przez B";
            this.byBToolStripMenuItem.Click += new System.EventHandler(this.byBToolStripMenuItem_Click);
            // 
            // średniaToolStripMenuItem
            // 
            this.średniaToolStripMenuItem.Name = "średniaToolStripMenuItem";
            this.średniaToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.średniaToolStripMenuItem.Text = "Średnia";
            this.średniaToolStripMenuItem.Click += new System.EventHandler(this.średniaToolStripMenuItem_Click);
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pokażToolStripMenuItem,
            this.rozciąToolStripMenuItem,
            this.equalizacjaToolStripMenuItem,
            this.liniaProfiluToolStripMenuItem});
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            this.histogramToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.histogramToolStripMenuItem.Text = "Statystyki";
            // 
            // pokażToolStripMenuItem
            // 
            this.pokażToolStripMenuItem.Name = "pokażToolStripMenuItem";
            this.pokażToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.pokażToolStripMenuItem.Text = "Pokaż";
            this.pokażToolStripMenuItem.Click += new System.EventHandler(this.pokażToolStripMenuItem_Click);
            // 
            // rozciąToolStripMenuItem
            // 
            this.rozciąToolStripMenuItem.Name = "rozciąToolStripMenuItem";
            this.rozciąToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.rozciąToolStripMenuItem.Text = "Rozciągnij";
            this.rozciąToolStripMenuItem.Click += new System.EventHandler(this.rozciąToolStripMenuItem_Click);
            // 
            // equalizacjaToolStripMenuItem
            // 
            this.equalizacjaToolStripMenuItem.Name = "equalizacjaToolStripMenuItem";
            this.equalizacjaToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.equalizacjaToolStripMenuItem.Text = "Equalizacja";
            this.equalizacjaToolStripMenuItem.Click += new System.EventHandler(this.equalizacjaToolStripMenuItem_Click);
            // 
            // liniaProfiluToolStripMenuItem
            // 
            this.liniaProfiluToolStripMenuItem.Name = "liniaProfiluToolStripMenuItem";
            this.liniaProfiluToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.liniaProfiluToolStripMenuItem.Text = "Linia profilu";
            this.liniaProfiluToolStripMenuItem.Click += new System.EventHandler(this.liniaProfiluToolStripMenuItem_Click);
            // 
            // miOperacjeJednop
            // 
            this.miOperacjeJednop.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miInvert,
            this.posteryzacjaToolStripMenuItem,
            this.rozciąganieSelektywneToolStripMenuItem,
            this.rozciąganieToolStripMenuItem,
            this.equalizacjaToolStripMenuItem1});
            this.miOperacjeJednop.Name = "miOperacjeJednop";
            this.miOperacjeJednop.Size = new System.Drawing.Size(136, 20);
            this.miOperacjeJednop.Text = "Operacje podstawowe";
            // 
            // miInvert
            // 
            this.miInvert.Name = "miInvert";
            this.miInvert.Size = new System.Drawing.Size(198, 22);
            this.miInvert.Text = "Negatyw";
            this.miInvert.Click += new System.EventHandler(this.miInvert_Click);
            // 
            // posteryzacjaToolStripMenuItem
            // 
            this.posteryzacjaToolStripMenuItem.Name = "posteryzacjaToolStripMenuItem";
            this.posteryzacjaToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.posteryzacjaToolStripMenuItem.Text = "Posteryzacja";
            this.posteryzacjaToolStripMenuItem.Click += new System.EventHandler(this.posteryzacjaToolStripMenuItem_Click);
            // 
            // rozciąganieSelektywneToolStripMenuItem
            // 
            this.rozciąganieSelektywneToolStripMenuItem.Name = "rozciąganieSelektywneToolStripMenuItem";
            this.rozciąganieSelektywneToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.rozciąganieSelektywneToolStripMenuItem.Text = "Rozciąganie selektywne";
            this.rozciąganieSelektywneToolStripMenuItem.Click += new System.EventHandler(this.rozciąganieSelektywneToolStripMenuItem_Click);
            // 
            // morfologiaToolStripMenuItem
            // 
            this.morfologiaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binaryToolStripMenuItem,
            this.dylacjaToolStripMenuItem,
            this.erozjaToolStripMenuItem,
            this.szkieletyzacjaToolStripMenuItem});
            this.morfologiaToolStripMenuItem.Name = "morfologiaToolStripMenuItem";
            this.morfologiaToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.morfologiaToolStripMenuItem.Text = "Morfologia";
            // 
            // binaryToolStripMenuItem
            // 
            this.binaryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stałeToolStripMenuItem,
            this.wybierzToolStripMenuItem,
            this.adaptacyjneToolStripMenuItem,
            this.otsuToolStripMenuItem,
            this.zPoziomamiToolStripMenuItem1});
            this.binaryToolStripMenuItem.Name = "binaryToolStripMenuItem";
            this.binaryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.binaryToolStripMenuItem.Text = "Progowanie";
            this.binaryToolStripMenuItem.Click += new System.EventHandler(this.binaryToolStripMenuItem_Click);
            // 
            // stałeToolStripMenuItem
            // 
            this.stałeToolStripMenuItem.Name = "stałeToolStripMenuItem";
            this.stałeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stałeToolStripMenuItem.Text = "Stałe";
            this.stałeToolStripMenuItem.Click += new System.EventHandler(this.stałeToolStripMenuItem_Click);
            // 
            // wybierzToolStripMenuItem
            // 
            this.wybierzToolStripMenuItem.Name = "wybierzToolStripMenuItem";
            this.wybierzToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.wybierzToolStripMenuItem.Text = "Wybierz...";
            this.wybierzToolStripMenuItem.Click += new System.EventHandler(this.wybierzToolStripMenuItem_Click);
            // 
            // dylacjaToolStripMenuItem
            // 
            this.dylacjaToolStripMenuItem.Name = "dylacjaToolStripMenuItem";
            this.dylacjaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dylacjaToolStripMenuItem.Text = "Dylacja";
            this.dylacjaToolStripMenuItem.Click += new System.EventHandler(this.dylacjaToolStripMenuItem_Click);
            // 
            // erozjaToolStripMenuItem
            // 
            this.erozjaToolStripMenuItem.Name = "erozjaToolStripMenuItem";
            this.erozjaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.erozjaToolStripMenuItem.Text = "Erozja";
            this.erozjaToolStripMenuItem.Click += new System.EventHandler(this.erozjaToolStripMenuItem_Click);
            // 
            // szkieletyzacjaToolStripMenuItem
            // 
            this.szkieletyzacjaToolStripMenuItem.Name = "szkieletyzacjaToolStripMenuItem";
            this.szkieletyzacjaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.szkieletyzacjaToolStripMenuItem.Text = "Szkieletyzacja";
            this.szkieletyzacjaToolStripMenuItem.Click += new System.EventHandler(this.szkieletyzacjaToolStripMenuItem_Click);
            // 
            // operacjeNaWieluObrazachToolStripMenuItem
            // 
            this.operacjeNaWieluObrazachToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaWszystkichOkienekToolStripMenuItem,
            this.twoPicturesModeToolStripMenuItem});
            this.operacjeNaWieluObrazachToolStripMenuItem.Name = "operacjeNaWieluObrazachToolStripMenuItem";
            this.operacjeNaWieluObrazachToolStripMenuItem.Size = new System.Drawing.Size(164, 20);
            this.operacjeNaWieluObrazachToolStripMenuItem.Text = "Operacje na wielu obrazach";
            // 
            // listaWszystkichOkienekToolStripMenuItem
            // 
            this.listaWszystkichOkienekToolStripMenuItem.Name = "listaWszystkichOkienekToolStripMenuItem";
            this.listaWszystkichOkienekToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.listaWszystkichOkienekToolStripMenuItem.Text = "Lista wszystkich okienek";
            this.listaWszystkichOkienekToolStripMenuItem.Click += new System.EventHandler(this.listaWszystkichOkienekToolStripMenuItem_Click);
            // 
            // twoPicturesModeToolStripMenuItem
            // 
            this.twoPicturesModeToolStripMenuItem.Name = "twoPicturesModeToolStripMenuItem";
            this.twoPicturesModeToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.twoPicturesModeToolStripMenuItem.Text = "Two pictures mode";
            this.twoPicturesModeToolStripMenuItem.Click += new System.EventHandler(this.twoPicturesModeToolStripMenuItem_Click);
            // 
            // wyostrzRozmToolStripMenuItem
            // 
            this.wyostrzRozmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maskiToolStripMenuItem});
            this.wyostrzRozmToolStripMenuItem.Name = "wyostrzRozmToolStripMenuItem";
            this.wyostrzRozmToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.wyostrzRozmToolStripMenuItem.Text = "Wyostrz./Rozm.";
            // 
            // maskiToolStripMenuItem
            // 
            this.maskiToolStripMenuItem.Name = "maskiToolStripMenuItem";
            this.maskiToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.maskiToolStripMenuItem.Text = "Maski";
            this.maskiToolStripMenuItem.Click += new System.EventHandler(this.maskiToolStripMenuItem_Click);
            // 
            // adaptacyjneToolStripMenuItem
            // 
            this.adaptacyjneToolStripMenuItem.Name = "adaptacyjneToolStripMenuItem";
            this.adaptacyjneToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.adaptacyjneToolStripMenuItem.Text = "Adaptacyjne";
            this.adaptacyjneToolStripMenuItem.Click += new System.EventHandler(this.adaptacyjneToolStripMenuItem_Click);
            // 
            // otsuToolStripMenuItem
            // 
            this.otsuToolStripMenuItem.Name = "otsuToolStripMenuItem";
            this.otsuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.otsuToolStripMenuItem.Text = "Otsu";
            this.otsuToolStripMenuItem.Click += new System.EventHandler(this.otsuToolStripMenuItem_Click);
            // 
            // zPoziomamiToolStripMenuItem1
            // 
            this.zPoziomamiToolStripMenuItem1.Name = "zPoziomamiToolStripMenuItem1";
            this.zPoziomamiToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.zPoziomamiToolStripMenuItem1.Text = "Z poziomami";
            this.zPoziomamiToolStripMenuItem1.Click += new System.EventHandler(this.zPoziomamiToolStripMenuItem1_Click);
            // 
            // rozciąganieToolStripMenuItem
            // 
            this.rozciąganieToolStripMenuItem.Name = "rozciąganieToolStripMenuItem";
            this.rozciąganieToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.rozciąganieToolStripMenuItem.Text = "Rozciąganie";
            this.rozciąganieToolStripMenuItem.Click += new System.EventHandler(this.rozciąganieToolStripMenuItem_Click);
            // 
            // equalizacjaToolStripMenuItem1
            // 
            this.equalizacjaToolStripMenuItem1.Name = "equalizacjaToolStripMenuItem1";
            this.equalizacjaToolStripMenuItem1.Size = new System.Drawing.Size(198, 22);
            this.equalizacjaToolStripMenuItem1.Text = "Equalizacja";
            this.equalizacjaToolStripMenuItem1.Click += new System.EventHandler(this.equalizacjaToolStripMenuItem1_Click);
            // 
            // PicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 450);
            this.Controls.Add(this.picbox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PicForm";
            this.Text = "PicEditApp";
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.PictureBox picbox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuOpen;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miOperacjeJednop;
        private System.Windows.Forms.ToolStripMenuItem miInvert;
        private System.Windows.Forms.ToolStripMenuItem posteryzacjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rozciąganieSelektywneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pokażToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rozciąToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equalizacjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem średniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liniaProfiluToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacjeNaWieluObrazachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaWszystkichOkienekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duplicateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem twoPicturesModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyostrzRozmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maskiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem morfologiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dylacjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem erozjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szkieletyzacjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stałeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wybierzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaptacyjneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otsuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zPoziomamiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rozciąganieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equalizacjaToolStripMenuItem1;
    }
}

