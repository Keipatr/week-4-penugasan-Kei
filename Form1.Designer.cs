namespace week_4_penugasan
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNama = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.buttonLihatData = new System.Windows.Forms.Button();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.textBoxAlamat = new System.Windows.Forms.TextBox();
            this.textBoxTelp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Location = new System.Drawing.Point(29, 38);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(48, 15);
            this.labelNama.TabIndex = 0;
            this.labelNama.Text = "Nama : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alamat : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telp : ";
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.Location = new System.Drawing.Point(55, 157);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(75, 23);
            this.buttonSimpan.TabIndex = 3;
            this.buttonSimpan.Text = "Simpan";
            this.buttonSimpan.UseVisualStyleBackColor = true;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // buttonLihatData
            // 
            this.buttonLihatData.Location = new System.Drawing.Point(164, 157);
            this.buttonLihatData.Name = "buttonLihatData";
            this.buttonLihatData.Size = new System.Drawing.Size(75, 23);
            this.buttonLihatData.TabIndex = 4;
            this.buttonLihatData.Text = "Lihat Data";
            this.buttonLihatData.UseVisualStyleBackColor = true;
            this.buttonLihatData.Click += new System.EventHandler(this.buttonLihatData_Click);
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(83, 35);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(329, 23);
            this.textBoxNama.TabIndex = 5;
            // 
            // textBoxAlamat
            // 
            this.textBoxAlamat.Location = new System.Drawing.Point(83, 69);
            this.textBoxAlamat.Name = "textBoxAlamat";
            this.textBoxAlamat.Size = new System.Drawing.Size(443, 23);
            this.textBoxAlamat.TabIndex = 6;
            // 
            // textBoxTelp
            // 
            this.textBoxTelp.Location = new System.Drawing.Point(83, 101);
            this.textBoxTelp.Name = "textBoxTelp";
            this.textBoxTelp.Size = new System.Drawing.Size(156, 23);
            this.textBoxTelp.TabIndex = 7;
            this.textBoxTelp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxTelp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 199);
            this.Controls.Add(this.textBoxTelp);
            this.Controls.Add(this.textBoxAlamat);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.buttonLihatData);
            this.Controls.Add(this.buttonSimpan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelNama);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Penambahan Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelNama;
        private Label label2;
        private Label label3;
        private Button buttonSimpan;
        private Button buttonLihatData;
        private TextBox textBoxNama;
        private TextBox textBoxAlamat;
        private TextBox textBoxTelp;
        private Label label1;
    }
}