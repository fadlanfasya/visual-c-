
namespace AplikasiPerhitungan
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
            this.label_plus = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.value_a = new System.Windows.Forms.TextBox();
            this.value_b = new System.Windows.Forms.TextBox();
            this.value_plus = new System.Windows.Forms.TextBox();
            this.btn_hasil = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_a
            // 
            this.label_a.AutoSize = true;
            this.label_a.Location = new System.Drawing.Point(9, 25);
            this.label_a.Name = "label_a";
            this.label_a.Size = new System.Drawing.Size(84, 13);
            this.label_a.TabIndex = 0;
            this.label_a.Text = "Masukan Nilai A";
            // 
            // label_b
            // 
            this.label_b.AutoSize = true;
            this.label_b.Location = new System.Drawing.Point(9, 79);
            this.label_b.Name = "label_b";
            this.label_b.Size = new System.Drawing.Size(84, 13);
            this.label_b.TabIndex = 1;
            this.label_b.Text = "Masukan Nilai B";
            // 
            // label_plus
            // 
            this.label_plus.AutoSize = true;
            this.label_plus.Location = new System.Drawing.Point(9, 141);
            this.label_plus.Name = "label_plus";
            this.label_plus.Size = new System.Drawing.Size(56, 13);
            this.label_plus.TabIndex = 2;
            this.label_plus.Text = "Nilai A + B";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_clear);
            this.groupBox1.Controls.Add(this.btn_hasil);
            this.groupBox1.Controls.Add(this.value_plus);
            this.groupBox1.Controls.Add(this.value_b);
            this.groupBox1.Controls.Add(this.value_a);
            this.groupBox1.Controls.Add(this.label_a);
            this.groupBox1.Controls.Add(this.label_plus);
            this.groupBox1.Controls.Add(this.label_b);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 185);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // value_a
            // 
            this.value_a.Location = new System.Drawing.Point(114, 22);
            this.value_a.Name = "value_a";
            this.value_a.Size = new System.Drawing.Size(210, 20);
            this.value_a.TabIndex = 3;
            // 
            // value_b
            // 
            this.value_b.Location = new System.Drawing.Point(114, 76);
            this.value_b.Name = "value_b";
            this.value_b.Size = new System.Drawing.Size(210, 20);
            this.value_b.TabIndex = 4;
            // 
            // value_plus
            // 
            this.value_plus.Location = new System.Drawing.Point(114, 138);
            this.value_plus.Name = "value_plus";
            this.value_plus.ReadOnly = true;
            this.value_plus.Size = new System.Drawing.Size(210, 20);
            this.value_plus.TabIndex = 5;
            // 
            // btn_hasil
            // 
            this.btn_hasil.Location = new System.Drawing.Point(358, 18);
            this.btn_hasil.Name = "btn_hasil";
            this.btn_hasil.Size = new System.Drawing.Size(160, 55);
            this.btn_hasil.TabIndex = 6;
            this.btn_hasil.Text = "Hasil";
            this.btn_hasil.UseVisualStyleBackColor = true;
            this.btn_hasil.Click += new System.EventHandler(this.btn_hasil_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(358, 97);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(160, 57);
            this.btn_clear.TabIndex = 7;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 202);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Aplikasi Perhitungan";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_a;
        private System.Windows.Forms.Label label_b;
        private System.Windows.Forms.Label label_plus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox value_plus;
        private System.Windows.Forms.TextBox value_b;
        private System.Windows.Forms.TextBox value_a;
        private System.Windows.Forms.Button btn_hasil;
        private System.Windows.Forms.Button btn_clear;
    }
}

