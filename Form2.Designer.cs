namespace week_4_penugasan
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonKembali = new System.Windows.Forms.Button();
            this.buttonPrevData = new System.Windows.Forms.Button();
            this.buttonNextData = new System.Windows.Forms.Button();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.textBoxAlamat = new System.Windows.Forms.TextBox();
            this.textBoxTelp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alamat : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telp : ";
            // 
            // buttonKembali
            // 
            this.buttonKembali.Location = new System.Drawing.Point(41, 154);
            this.buttonKembali.Name = "buttonKembali";
            this.buttonKembali.Size = new System.Drawing.Size(75, 23);
            this.buttonKembali.TabIndex = 3;
            this.buttonKembali.Text = "Kembali";
            this.buttonKembali.UseVisualStyleBackColor = true;
            this.buttonKembali.Click += new System.EventHandler(this.buttonKembali_Click);
            // 
            // buttonPrevData
            // 
            this.buttonPrevData.Location = new System.Drawing.Point(134, 154);
            this.buttonPrevData.Name = "buttonPrevData";
            this.buttonPrevData.Size = new System.Drawing.Size(75, 23);
            this.buttonPrevData.TabIndex = 4;
            this.buttonPrevData.Text = "Prev Data";
            this.buttonPrevData.UseVisualStyleBackColor = true;
            this.buttonPrevData.Click += new System.EventHandler(this.buttonPrevData_Click);
            // 
            // buttonNextData
            // 
            this.buttonNextData.Location = new System.Drawing.Point(228, 154);
            this.buttonNextData.Name = "buttonNextData";
            this.buttonNextData.Size = new System.Drawing.Size(75, 23);
            this.buttonNextData.TabIndex = 5;
            this.buttonNextData.Text = "Next Data";
            this.buttonNextData.UseVisualStyleBackColor = true;
            this.buttonNextData.Click += new System.EventHandler(this.buttonNextData_Click);
            // 
            // textBoxNama
            // 
            this.textBoxNama.Enabled = false;
            this.textBoxNama.Location = new System.Drawing.Point(83, 30);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(348, 23);
            this.textBoxNama.TabIndex = 6;
            // 
            // textBoxAlamat
            // 
            this.textBoxAlamat.Enabled = false;
            this.textBoxAlamat.Location = new System.Drawing.Point(83, 68);
            this.textBoxAlamat.Name = "textBoxAlamat";
            this.textBoxAlamat.Size = new System.Drawing.Size(470, 23);
            this.textBoxAlamat.TabIndex = 7;
            // 
            // textBoxTelp
            // 
            this.textBoxTelp.Enabled = false;
            this.textBoxTelp.Location = new System.Drawing.Point(83, 107);
            this.textBoxTelp.Name = "textBoxTelp";
            this.textBoxTelp.Size = new System.Drawing.Size(148, 23);
            this.textBoxTelp.TabIndex = 8;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 197);
            this.Controls.Add(this.textBoxTelp);
            this.Controls.Add(this.textBoxAlamat);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.buttonNextData);
            this.Controls.Add(this.buttonPrevData);
            this.Controls.Add(this.buttonKembali);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Tampilan Data";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonKembali;
        private Button buttonPrevData;
        private Button buttonNextData;
        private TextBox textBoxNama;
        private TextBox textBoxAlamat;
        private TextBox textBoxTelp;
        private Label label4;
    }
}