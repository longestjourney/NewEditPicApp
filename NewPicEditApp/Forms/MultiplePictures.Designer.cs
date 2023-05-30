namespace NewPicEditApp
{
    partial class MultiplePictures
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ChoosePic1 = new System.Windows.Forms.ComboBox();
            this.ChoosePic2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(121, 134);
            this.listBox1.TabIndex = 0;
            // 
            // ChoosePic1
            // 
            this.ChoosePic1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChoosePic1.FormattingEnabled = true;
            this.ChoosePic1.Location = new System.Drawing.Point(161, 12);
            this.ChoosePic1.Name = "ChoosePic1";
            this.ChoosePic1.Size = new System.Drawing.Size(121, 21);
            this.ChoosePic1.TabIndex = 1;
            // 
            // ChoosePic2
            // 
            this.ChoosePic2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChoosePic2.FormattingEnabled = true;
            this.ChoosePic2.Location = new System.Drawing.Point(161, 52);
            this.ChoosePic2.Name = "ChoosePic2";
            this.ChoosePic2.Size = new System.Drawing.Size(121, 21);
            this.ChoosePic2.TabIndex = 2;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(161, 125);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 3;
            // 
            // MultiplePictures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 242);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.ChoosePic2);
            this.Controls.Add(this.ChoosePic1);
            this.Controls.Add(this.listBox1);
            this.Name = "MultiplePictures";
            this.Text = "MultiplePictures";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox ChoosePic1;
        private System.Windows.Forms.ComboBox ChoosePic2;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}