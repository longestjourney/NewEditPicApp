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
            this.bOpen = new System.Windows.Forms.Button();
            this.picbox = new System.Windows.Forms.PictureBox();
            this.co_histogram_operations = new System.Windows.Forms.ComboBox();
            this.co_onepoint_operations = new System.Windows.Forms.ComboBox();
            this.comboBoxsz = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.bOpen2 = new System.Windows.Forms.Button();
            this.picturebox2 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bOpen
            // 
            this.bOpen.Location = new System.Drawing.Point(15, 41);
            this.bOpen.Name = "bOpen";
            this.bOpen.Size = new System.Drawing.Size(75, 23);
            this.bOpen.TabIndex = 0;
            this.bOpen.Text = "Otwórz";
            this.bOpen.UseVisualStyleBackColor = true;
            this.bOpen.Click += new System.EventHandler(this.bOpen_Click);
            // 
            // picbox
            // 
            this.picbox.Location = new System.Drawing.Point(15, 83);
            this.picbox.Name = "picbox";
            this.picbox.Size = new System.Drawing.Size(331, 323);
            this.picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox.TabIndex = 1;
            this.picbox.TabStop = false;
            // 
            // co_histogram_operations
            // 
            this.co_histogram_operations.FormattingEnabled = true;
            this.co_histogram_operations.Items.AddRange(new object[] {
            "Pokaż",
            "Rozciaganie",
            "Equalizacja"});
            this.co_histogram_operations.Location = new System.Drawing.Point(15, 12);
            this.co_histogram_operations.Name = "co_histogram_operations";
            this.co_histogram_operations.Size = new System.Drawing.Size(72, 21);
            this.co_histogram_operations.TabIndex = 2;
            this.co_histogram_operations.Text = "Histogram";
            this.co_histogram_operations.SelectedIndexChanged += new System.EventHandler(this.co_histogram_operations_SelectedIndexChanged);
            // 
            // co_onepoint_operations
            // 
            this.co_onepoint_operations.FormattingEnabled = true;
            this.co_onepoint_operations.Items.AddRange(new object[] {
            "Negatyw",
            "Progowanie",
            "Progowanie z poziomami",
            "Posteryzacja",
            "Rozciąganie selektywne"});
            this.co_onepoint_operations.Location = new System.Drawing.Point(93, 12);
            this.co_onepoint_operations.Name = "co_onepoint_operations";
            this.co_onepoint_operations.Size = new System.Drawing.Size(142, 21);
            this.co_onepoint_operations.TabIndex = 4;
            this.co_onepoint_operations.Text = "Operacje jednopunktowe";
            this.co_onepoint_operations.SelectedIndexChanged += new System.EventHandler(this.co_onepoint_operations_SelectedIndexChanged);
            // 
            // comboBoxsz
            // 
            this.comboBoxsz.FormattingEnabled = true;
            this.comboBoxsz.Items.AddRange(new object[] {
            "Szkieletyzacja"});
            this.comboBoxsz.Location = new System.Drawing.Point(241, 12);
            this.comboBoxsz.Name = "comboBoxsz";
            this.comboBoxsz.Size = new System.Drawing.Size(95, 21);
            this.comboBoxsz.TabIndex = 5;
            this.comboBoxsz.Text = "Szkieletyzacja";
            this.comboBoxsz.SelectedIndexChanged += new System.EventHandler(this.comboBoxsz_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Dodawanie",
            "Odejmowanie",
            "NOT",
            "AND",
            "OR",
            "XOR"});
            this.comboBox2.Location = new System.Drawing.Point(342, 12);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(114, 21);
            this.comboBox2.TabIndex = 6;
            this.comboBox2.Text = "Operacje Logiczne";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // bOpen2
            // 
            this.bOpen2.Location = new System.Drawing.Point(96, 41);
            this.bOpen2.Name = "bOpen2";
            this.bOpen2.Size = new System.Drawing.Size(75, 23);
            this.bOpen2.TabIndex = 7;
            this.bOpen2.Text = "Otwórz 2";
            this.bOpen2.UseVisualStyleBackColor = true;
            this.bOpen2.Click += new System.EventHandler(this.bOpen2_Click);
            // 
            // picturebox2
            // 
            this.picturebox2.Location = new System.Drawing.Point(364, 83);
            this.picturebox2.Name = "picturebox2";
            this.picturebox2.Size = new System.Drawing.Size(326, 323);
            this.picturebox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturebox2.TabIndex = 8;
            this.picturebox2.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Wygładzanie - blur",
            "Wygładzanie - GaussianBlur"});
            this.comboBox1.Location = new System.Drawing.Point(548, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Text = "Operacje Sąsiedztwa";
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(177, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Zapisz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 531);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.picturebox2);
            this.Controls.Add(this.bOpen2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBoxsz);
            this.Controls.Add(this.co_onepoint_operations);
            this.Controls.Add(this.co_histogram_operations);
            this.Controls.Add(this.picbox);
            this.Controls.Add(this.bOpen);
            this.Name = "PicForm";
            this.Text = "PicEditApp";
            this.Load += new System.EventHandler(this.PicForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bOpen;
        internal System.Windows.Forms.PictureBox picbox;
        private System.Windows.Forms.ComboBox co_histogram_operations;
        private System.Windows.Forms.ComboBox co_onepoint_operations;
        private System.Windows.Forms.ComboBox comboBoxsz;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button bOpen2;
        internal System.Windows.Forms.PictureBox picturebox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}

