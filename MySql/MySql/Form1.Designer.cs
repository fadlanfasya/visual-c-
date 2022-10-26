
namespace MySql
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnShowdata = new System.Windows.Forms.Button();
            this.listResult = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdditems = new System.Windows.Forms.Button();
            this.txtBerat = new System.Windows.Forms.TextBox();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEdititems = new System.Windows.Forms.Button();
            this.txtEditHarga = new System.Windows.Forms.TextBox();
            this.txtEditBerat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numidbarang = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numidbarang)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(24, 12);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(131, 35);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Cek Koneksi MySql";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnShowdata
            // 
            this.btnShowdata.Location = new System.Drawing.Point(191, 12);
            this.btnShowdata.Name = "btnShowdata";
            this.btnShowdata.Size = new System.Drawing.Size(131, 35);
            this.btnShowdata.TabIndex = 1;
            this.btnShowdata.Text = "Tampilkan Data";
            this.btnShowdata.UseVisualStyleBackColor = true;
            this.btnShowdata.Click += new System.EventHandler(this.btnShowdata_Click);
            // 
            // listResult
            // 
            this.listResult.FormattingEnabled = true;
            this.listResult.Location = new System.Drawing.Point(24, 72);
            this.listResult.Name = "listResult";
            this.listResult.Size = new System.Drawing.Size(690, 147);
            this.listResult.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdditems);
            this.groupBox1.Controls.Add(this.txtBerat);
            this.groupBox1.Controls.Add(this.txtHarga);
            this.groupBox1.Controls.Add(this.txtNama);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 236);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 116);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tambah Barang";
            // 
            // btnAdditems
            // 
            this.btnAdditems.Location = new System.Drawing.Point(221, 28);
            this.btnAdditems.Name = "btnAdditems";
            this.btnAdditems.Size = new System.Drawing.Size(107, 76);
            this.btnAdditems.TabIndex = 9;
            this.btnAdditems.Text = "Tambah";
            this.btnAdditems.UseVisualStyleBackColor = true;
            this.btnAdditems.Click += new System.EventHandler(this.btnAdditems_Click);
            // 
            // txtBerat
            // 
            this.txtBerat.Location = new System.Drawing.Point(87, 56);
            this.txtBerat.Name = "txtBerat";
            this.txtBerat.Size = new System.Drawing.Size(127, 20);
            this.txtBerat.TabIndex = 8;
            // 
            // txtHarga
            // 
            this.txtHarga.Location = new System.Drawing.Point(87, 84);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(127, 20);
            this.txtHarga.TabIndex = 7;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(87, 28);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(127, 20);
            this.txtNama.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Berat Barang";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Harga Barang";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Barang";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEdititems);
            this.groupBox2.Controls.Add(this.txtEditHarga);
            this.groupBox2.Controls.Add(this.txtEditBerat);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.numidbarang);
            this.groupBox2.Location = new System.Drawing.Point(369, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 112);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edit Barang";
            // 
            // btnEdititems
            // 
            this.btnEdititems.Location = new System.Drawing.Point(224, 30);
            this.btnEdititems.Name = "btnEdititems";
            this.btnEdititems.Size = new System.Drawing.Size(107, 76);
            this.btnEdititems.TabIndex = 10;
            this.btnEdititems.Text = "Edit";
            this.btnEdititems.UseVisualStyleBackColor = true;
            this.btnEdititems.Click += new System.EventHandler(this.btnEdititems_Click);
            // 
            // txtEditHarga
            // 
            this.txtEditHarga.Location = new System.Drawing.Point(84, 86);
            this.txtEditHarga.Name = "txtEditHarga";
            this.txtEditHarga.Size = new System.Drawing.Size(127, 20);
            this.txtEditHarga.TabIndex = 11;
            // 
            // txtEditBerat
            // 
            this.txtEditBerat.Location = new System.Drawing.Point(84, 54);
            this.txtEditBerat.Name = "txtEditBerat";
            this.txtEditBerat.Size = new System.Drawing.Size(127, 20);
            this.txtEditBerat.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Harga Barang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Berat Barang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Id Barang";
            // 
            // numidbarang
            // 
            this.numidbarang.Location = new System.Drawing.Point(65, 22);
            this.numidbarang.Name = "numidbarang";
            this.numidbarang.Size = new System.Drawing.Size(71, 20);
            this.numidbarang.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 361);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listResult);
            this.Controls.Add(this.btnShowdata);
            this.Controls.Add(this.btnConnect);
            this.Name = "Form1";
            this.Text = "MySql";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numidbarang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnShowdata;
        private System.Windows.Forms.ListBox listResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdditems;
        private System.Windows.Forms.TextBox txtBerat;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEdititems;
        private System.Windows.Forms.TextBox txtEditHarga;
        private System.Windows.Forms.TextBox txtEditBerat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numidbarang;
    }
}

