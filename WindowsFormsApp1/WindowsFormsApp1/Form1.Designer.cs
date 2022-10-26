
namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_nama = new System.Windows.Forms.Label();
            this.form_nama = new System.Windows.Forms.TextBox();
            this.groupBox_form = new System.Windows.Forms.GroupBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.form_drink = new System.Windows.Forms.TextBox();
            this.label_drink = new System.Windows.Forms.Label();
            this.form_food = new System.Windows.Forms.TextBox();
            this.label_food = new System.Windows.Forms.Label();
            this.groupBox_kesimpulan = new System.Windows.Forms.GroupBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.label_kesimpulan = new System.Windows.Forms.Label();
            this.groupBox_form.SuspendLayout();
            this.groupBox_kesimpulan.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_nama
            // 
            resources.ApplyResources(this.label_nama, "label_nama");
            this.label_nama.Name = "label_nama";
            // 
            // form_nama
            // 
            resources.ApplyResources(this.form_nama, "form_nama");
            this.form_nama.Name = "form_nama";
            // 
            // groupBox_form
            // 
            this.groupBox_form.Controls.Add(this.btn_submit);
            this.groupBox_form.Controls.Add(this.form_drink);
            this.groupBox_form.Controls.Add(this.label_drink);
            this.groupBox_form.Controls.Add(this.form_food);
            this.groupBox_form.Controls.Add(this.label_food);
            this.groupBox_form.Controls.Add(this.label_nama);
            this.groupBox_form.Controls.Add(this.form_nama);
            resources.ApplyResources(this.groupBox_form, "groupBox_form");
            this.groupBox_form.Name = "groupBox_form";
            this.groupBox_form.TabStop = false;
            // 
            // btn_submit
            // 
            resources.ApplyResources(this.btn_submit, "btn_submit");
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // form_drink
            // 
            resources.ApplyResources(this.form_drink, "form_drink");
            this.form_drink.Name = "form_drink";
            // 
            // label_drink
            // 
            resources.ApplyResources(this.label_drink, "label_drink");
            this.label_drink.Name = "label_drink";
            // 
            // form_food
            // 
            resources.ApplyResources(this.form_food, "form_food");
            this.form_food.Name = "form_food";
            // 
            // label_food
            // 
            resources.ApplyResources(this.label_food, "label_food");
            this.label_food.Name = "label_food";
            // 
            // groupBox_kesimpulan
            // 
            this.groupBox_kesimpulan.Controls.Add(this.btn_clear);
            this.groupBox_kesimpulan.Controls.Add(this.label_kesimpulan);
            resources.ApplyResources(this.groupBox_kesimpulan, "groupBox_kesimpulan");
            this.groupBox_kesimpulan.Name = "groupBox_kesimpulan";
            this.groupBox_kesimpulan.TabStop = false;
            // 
            // btn_clear
            // 
            resources.ApplyResources(this.btn_clear, "btn_clear");
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label_kesimpulan
            // 
            resources.ApplyResources(this.label_kesimpulan, "label_kesimpulan");
            this.label_kesimpulan.Name = "label_kesimpulan";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.Controls.Add(this.groupBox_kesimpulan);
            this.Controls.Add(this.groupBox_form);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_form.ResumeLayout(false);
            this.groupBox_form.PerformLayout();
            this.groupBox_kesimpulan.ResumeLayout(false);
            this.groupBox_kesimpulan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_nama;
        private System.Windows.Forms.TextBox form_nama;
        private System.Windows.Forms.GroupBox groupBox_form;
        private System.Windows.Forms.Label label_food;
        private System.Windows.Forms.TextBox form_food;
        private System.Windows.Forms.TextBox form_drink;
        private System.Windows.Forms.Label label_drink;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.GroupBox groupBox_kesimpulan;
        private System.Windows.Forms.Label label_kesimpulan;
        private System.Windows.Forms.Button btn_clear;
    }
}

