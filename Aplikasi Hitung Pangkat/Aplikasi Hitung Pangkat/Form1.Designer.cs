
namespace Aplikasi_Hitung_Pangkat
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
            this.label_a = new System.Windows.Forms.Label();
            this.label_b = new System.Windows.Forms.Label();
            this.label_c = new System.Windows.Forms.Label();
            this.txt_a = new System.Windows.Forms.TextBox();
            this.txt_c = new System.Windows.Forms.TextBox();
            this.txt_b = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_hitung = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_hasil = new System.Windows.Forms.Label();
            this.txt_hasil = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_a
            // 
            this.label_a.AutoSize = true;
            this.label_a.Location = new System.Drawing.Point(15, 29);
            this.label_a.Name = "label_a";
            this.label_a.Size = new System.Drawing.Size(61, 13);
            this.label_a.TabIndex = 0;
            this.label_a.Text = "Masukan A";
            // 
            // label_b
            // 
            this.label_b.AutoSize = true;
            this.label_b.Location = new System.Drawing.Point(15, 81);
            this.label_b.Name = "label_b";
            this.label_b.Size = new System.Drawing.Size(61, 13);
            this.label_b.TabIndex = 1;
            this.label_b.Text = "Masukan B";
            // 
            // label_c
            // 
            this.label_c.AutoSize = true;
            this.label_c.Location = new System.Drawing.Point(15, 136);
            this.label_c.Name = "label_c";
            this.label_c.Size = new System.Drawing.Size(61, 13);
            this.label_c.TabIndex = 2;
            this.label_c.Text = "Masukan C";
            // 
            // txt_a
            // 
            this.txt_a.Location = new System.Drawing.Point(110, 26);
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(181, 20);
            this.txt_a.TabIndex = 3;
            // 
            // txt_c
            // 
            this.txt_c.Location = new System.Drawing.Point(110, 133);
            this.txt_c.Name = "txt_c";
            this.txt_c.Size = new System.Drawing.Size(181, 20);
            this.txt_c.TabIndex = 4;
            // 
            // txt_b
            // 
            this.txt_b.Location = new System.Drawing.Point(110, 78);
            this.txt_b.Name = "txt_b";
            this.txt_b.Size = new System.Drawing.Size(181, 20);
            this.txt_b.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_clear);
            this.groupBox1.Controls.Add(this.btn_hitung);
            this.groupBox1.Controls.Add(this.txt_b);
            this.groupBox1.Controls.Add(this.label_a);
            this.groupBox1.Controls.Add(this.txt_c);
            this.groupBox1.Controls.Add(this.label_b);
            this.groupBox1.Controls.Add(this.txt_a);
            this.groupBox1.Controls.Add(this.label_c);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 178);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // btn_hitung
            // 
            this.btn_hitung.Location = new System.Drawing.Point(346, 26);
            this.btn_hitung.Name = "btn_hitung";
            this.btn_hitung.Size = new System.Drawing.Size(154, 47);
            this.btn_hitung.TabIndex = 7;
            this.btn_hitung.Text = "Hitung";
            this.btn_hitung.UseVisualStyleBackColor = true;
            this.btn_hitung.Click += new System.EventHandler(this.btn_hitung_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(346, 106);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(154, 47);
            this.btn_clear.TabIndex = 8;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_hasil);
            this.groupBox2.Controls.Add(this.label_hasil);
            this.groupBox2.Location = new System.Drawing.Point(12, 197);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(542, 159);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // label_hasil
            // 
            this.label_hasil.AutoSize = true;
            this.label_hasil.Location = new System.Drawing.Point(16, 24);
            this.label_hasil.Name = "label_hasil";
            this.label_hasil.Size = new System.Drawing.Size(90, 13);
            this.label_hasil.TabIndex = 9;
            this.label_hasil.Text = "Hasil Perhitungan";
            // 
            // txt_hasil
            // 
            this.txt_hasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_hasil.ForeColor = System.Drawing.Color.ForestGreen;
            this.txt_hasil.Location = new System.Drawing.Point(18, 49);
            this.txt_hasil.Name = "txt_hasil";
            this.txt_hasil.ReadOnly = true;
            this.txt_hasil.Size = new System.Drawing.Size(342, 33);
            this.txt_hasil.TabIndex = 10;
            this.txt_hasil.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 368);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Aplikasi Hitung Pangkat";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_a;
        private System.Windows.Forms.Label label_b;
        private System.Windows.Forms.Label label_c;
        private System.Windows.Forms.TextBox txt_a;
        private System.Windows.Forms.TextBox txt_c;
        private System.Windows.Forms.TextBox txt_b;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_hitung;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox txt_hasil;
        private System.Windows.Forms.Label label_hasil;
    }
}

