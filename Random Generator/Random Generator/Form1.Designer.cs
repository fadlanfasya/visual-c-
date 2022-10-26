
namespace Random_Generator
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
            this.label_min = new System.Windows.Forms.Label();
            this.label_max = new System.Windows.Forms.Label();
            this.label_random = new System.Windows.Forms.Label();
            this.value_min = new System.Windows.Forms.TextBox();
            this.value_rand = new System.Windows.Forms.TextBox();
            this.value_max = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_pick = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_min
            // 
            this.label_min.AutoSize = true;
            this.label_min.Location = new System.Drawing.Point(10, 18);
            this.label_min.Name = "label_min";
            this.label_min.Size = new System.Drawing.Size(82, 13);
            this.label_min.TabIndex = 0;
            this.label_min.Text = "Minimal Number";
            this.label_min.Click += new System.EventHandler(this.label_min_Click);
            // 
            // label_max
            // 
            this.label_max.AutoSize = true;
            this.label_max.Location = new System.Drawing.Point(10, 54);
            this.label_max.Name = "label_max";
            this.label_max.Size = new System.Drawing.Size(91, 13);
            this.label_max.TabIndex = 1;
            this.label_max.Text = "Maksimal Number";
            // 
            // label_random
            // 
            this.label_random.AutoSize = true;
            this.label_random.Location = new System.Drawing.Point(10, 93);
            this.label_random.Name = "label_random";
            this.label_random.Size = new System.Drawing.Size(87, 13);
            this.label_random.TabIndex = 2;
            this.label_random.Text = "Random Number";
            this.label_random.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // value_min
            // 
            this.value_min.Location = new System.Drawing.Point(131, 15);
            this.value_min.Name = "value_min";
            this.value_min.Size = new System.Drawing.Size(232, 20);
            this.value_min.TabIndex = 3;
            // 
            // value_rand
            // 
            this.value_rand.Location = new System.Drawing.Point(131, 93);
            this.value_rand.Name = "value_rand";
            this.value_rand.Size = new System.Drawing.Size(232, 20);
            this.value_rand.TabIndex = 4;
            // 
            // value_max
            // 
            this.value_max.Location = new System.Drawing.Point(131, 54);
            this.value_max.Name = "value_max";
            this.value_max.Size = new System.Drawing.Size(232, 20);
            this.value_max.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_clear);
            this.groupBox1.Controls.Add(this.btn_pick);
            this.groupBox1.Controls.Add(this.value_max);
            this.groupBox1.Controls.Add(this.label_min);
            this.groupBox1.Controls.Add(this.value_rand);
            this.groupBox1.Controls.Add(this.label_max);
            this.groupBox1.Controls.Add(this.value_min);
            this.groupBox1.Controls.Add(this.label_random);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 127);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // btn_pick
            // 
            this.btn_pick.Location = new System.Drawing.Point(380, 15);
            this.btn_pick.Name = "btn_pick";
            this.btn_pick.Size = new System.Drawing.Size(116, 40);
            this.btn_pick.TabIndex = 6;
            this.btn_pick.Text = "Pick";
            this.btn_pick.UseVisualStyleBackColor = true;
            this.btn_pick.Click += new System.EventHandler(this.btn_pick_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(380, 73);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(116, 40);
            this.btn_clear.TabIndex = 7;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 150);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Random Generator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_min;
        private System.Windows.Forms.Label label_max;
        private System.Windows.Forms.Label label_random;
        private System.Windows.Forms.TextBox value_min;
        private System.Windows.Forms.TextBox value_rand;
        private System.Windows.Forms.TextBox value_max;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_pick;
    }
}

