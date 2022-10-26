
namespace Aplikasi_Hitung_Diskon
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
            this.label_price = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.label_discount = new System.Windows.Forms.Label();
            this.txt_discount = new System.Windows.Forms.TextBox();
            this.btn_hitung = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_realprice = new System.Windows.Forms.Label();
            this.txt_realprice = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_clear);
            this.groupBox1.Controls.Add(this.btn_hitung);
            this.groupBox1.Controls.Add(this.txt_discount);
            this.groupBox1.Controls.Add(this.label_discount);
            this.groupBox1.Controls.Add(this.txt_price);
            this.groupBox1.Controls.Add(this.label_price);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 122);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Location = new System.Drawing.Point(19, 25);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(83, 13);
            this.label_price.TabIndex = 0;
            this.label_price.Text = "Masukan Harga";
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(112, 22);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(235, 20);
            this.txt_price.TabIndex = 1;
            // 
            // label_discount
            // 
            this.label_discount.AutoSize = true;
            this.label_discount.Location = new System.Drawing.Point(19, 74);
            this.label_discount.Name = "label_discount";
            this.label_discount.Size = new System.Drawing.Size(87, 13);
            this.label_discount.TabIndex = 2;
            this.label_discount.Text = "Masukan Diskon";
            // 
            // txt_discount
            // 
            this.txt_discount.Location = new System.Drawing.Point(112, 71);
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.Size = new System.Drawing.Size(235, 20);
            this.txt_discount.TabIndex = 3;
            // 
            // btn_hitung
            // 
            this.btn_hitung.Location = new System.Drawing.Point(438, 19);
            this.btn_hitung.Name = "btn_hitung";
            this.btn_hitung.Size = new System.Drawing.Size(128, 35);
            this.btn_hitung.TabIndex = 4;
            this.btn_hitung.Text = "Hitung";
            this.btn_hitung.UseVisualStyleBackColor = true;
            this.btn_hitung.Click += new System.EventHandler(this.btn_hitung_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(438, 63);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(128, 35);
            this.btn_clear.TabIndex = 5;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_realprice);
            this.groupBox2.Controls.Add(this.label_realprice);
            this.groupBox2.Location = new System.Drawing.Point(13, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(600, 72);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // label_realprice
            // 
            this.label_realprice.AutoSize = true;
            this.label_realprice.Location = new System.Drawing.Point(19, 16);
            this.label_realprice.Name = "label_realprice";
            this.label_realprice.Size = new System.Drawing.Size(134, 13);
            this.label_realprice.TabIndex = 0;
            this.label_realprice.Text = "Harga Yang Harus Dibayar";
            // 
            // txt_realprice
            // 
            this.txt_realprice.Enabled = false;
            this.txt_realprice.Location = new System.Drawing.Point(22, 33);
            this.txt_realprice.Name = "txt_realprice";
            this.txt_realprice.ReadOnly = true;
            this.txt_realprice.Size = new System.Drawing.Size(148, 20);
            this.txt_realprice.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 225);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Aplikasi Hitung Diskon";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_hitung;
        private System.Windows.Forms.TextBox txt_discount;
        private System.Windows.Forms.Label label_discount;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_realprice;
        private System.Windows.Forms.TextBox txt_realprice;
    }
}

