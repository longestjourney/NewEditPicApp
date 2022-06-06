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
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).BeginInit();
            this.SuspendLayout();
            // 
            // bOpen
            // 
            this.bOpen.Location = new System.Drawing.Point(12, 12);
            this.bOpen.Name = "bOpen";
            this.bOpen.Size = new System.Drawing.Size(75, 23);
            this.bOpen.TabIndex = 0;
            this.bOpen.Text = "Open";
            this.bOpen.UseVisualStyleBackColor = true;
            this.bOpen.Click += new System.EventHandler(this.bOpen_Click);
            // 
            // picbox
            // 
            this.picbox.Location = new System.Drawing.Point(12, 41);
            this.picbox.Name = "picbox";
            this.picbox.Size = new System.Drawing.Size(465, 323);
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
            this.co_histogram_operations.Location = new System.Drawing.Point(93, 14);
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
            this.co_onepoint_operations.Location = new System.Drawing.Point(171, 14);
            this.co_onepoint_operations.Name = "co_onepoint_operations";
            this.co_onepoint_operations.Size = new System.Drawing.Size(142, 21);
            this.co_onepoint_operations.TabIndex = 4;
            this.co_onepoint_operations.Text = "Operacje jednopunktowe";
            this.co_onepoint_operations.SelectedIndexChanged += new System.EventHandler(this.co_onepoint_operations_SelectedIndexChanged);
            // 
            // PicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 450);
            this.Controls.Add(this.co_onepoint_operations);
            this.Controls.Add(this.co_histogram_operations);
            this.Controls.Add(this.picbox);
            this.Controls.Add(this.bOpen);
            this.Name = "PicForm";
            this.Text = "PicEditApp";
            this.Load += new System.EventHandler(this.PicForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bOpen;
        internal System.Windows.Forms.PictureBox picbox;
        private System.Windows.Forms.ComboBox co_histogram_operations;
        private System.Windows.Forms.ComboBox co_onepoint_operations;
    }
}

