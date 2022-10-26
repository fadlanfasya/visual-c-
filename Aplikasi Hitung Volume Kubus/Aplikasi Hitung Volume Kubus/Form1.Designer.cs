
namespace Aplikasi_Hitung_Volume_Kubus
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_sisi = new System.Windows.Forms.Label();
            this.label_volume = new System.Windows.Forms.Label();
            this.txt_volume = new System.Windows.Forms.TextBox();
            this.txt_sisi = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_hitung = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_hitung);
            this.groupBox1.Controls.Add(this.btn_clear);
            this.groupBox1.Controls.Add(this.txt_sisi);
            this.groupBox1.Controls.Add(this.txt_volume);
            this.groupBox1.Controls.Add(this.label_volume);
            this.groupBox1.Controls.Add(this.label_sisi);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(569, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label_sisi
            // 
            this.label_sisi.AutoSize = true;
            this.label_sisi.Location = new System.Drawing.Point(23, 26);
            this.label_sisi.Name = "label_sisi";
            this.label_sisi.Size = new System.Drawing.Size(56, 13);
            this.label_sisi.TabIndex = 0;
            this.label_sisi.Text = "Sisi Kubus";
            // 
            // label_volume
            // 
            this.label_volume.AutoSize = true;
            this.label_volume.Location = new System.Drawing.Point(23, 87);
            this.label_volume.Name = "label_volume";
            this.label_volume.Size = new System.Drawing.Size(75, 13);
            this.label_volume.TabIndex = 1;
            this.label_volume.Text = "Volume Kubus";
            this.label_volume.Visible = false;
            this.label_volume.Click += new System.EventHandler(this.label_volume_Click);
            // 
            // txt_volume
            // 
            this.txt_volume.Location = new System.Drawing.Point(104, 84);
            this.txt_volume.Name = "txt_volume";
            this.txt_volume.Size = new System.Drawing.Size(223, 20);
            this.txt_volume.TabIndex = 2;
            this.txt_volume.Visible = false;
            this.txt_volume.TextChanged += new System.EventHandler(this.txt_volume_TextChanged);
            // 
            // txt_sisi
            // 
            this.txt_sisi.Location = new System.Drawing.Point(104, 23);
            this.txt_sisi.Name = "txt_sisi";
            this.txt_sisi.Size = new System.Drawing.Size(223, 20);
            this.txt_sisi.TabIndex = 3;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(370, 84);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(182, 46);
            this.btn_clear.TabIndex = 5;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_hitung
            // 
            this.btn_hitung.Location = new System.Drawing.Point(370, 23);
            this.btn_hitung.Name = "btn_hitung";
            this.btn_hitung.Size = new System.Drawing.Size(182, 46);
            this.btn_hitung.TabIndex = 6;
            this.btn_hitung.Text = "Hitung";
            this.btn_hitung.UseVisualStyleBackColor = true;
            this.btn_hitung.Click += new System.EventHandler(this.btn_hitung_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 190);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Aplikasi Hitung Volume Kubus";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox txt_sisi;
        private System.Windows.Forms.TextBox txt_volume;
        private System.Windows.Forms.Label label_volume;
        private System.Windows.Forms.Label label_sisi;
        private System.Windows.Forms.Button btn_hitung;
    }
}

