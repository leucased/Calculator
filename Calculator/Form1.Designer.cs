namespace Calculator
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
            this.lblSoA = new System.Windows.Forms.Label();
            this.lblSoB = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_a = new System.Windows.Forms.TextBox();
            this.txt_b = new System.Windows.Forms.TextBox();
            this.txt_kq = new System.Windows.Forms.TextBox();
            this.btn_cong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSoA
            // 
            this.lblSoA.AutoSize = true;
            this.lblSoA.Location = new System.Drawing.Point(97, 67);
            this.lblSoA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoA.Name = "lblSoA";
            this.lblSoA.Size = new System.Drawing.Size(33, 13);
            this.lblSoA.TabIndex = 0;
            this.lblSoA.Text = "Số A:";
            // 
            // lblSoB
            // 
            this.lblSoB.AutoSize = true;
            this.lblSoB.Location = new System.Drawing.Point(97, 92);
            this.lblSoB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoB.Name = "lblSoB";
            this.lblSoB.Size = new System.Drawing.Size(33, 13);
            this.lblSoB.TabIndex = 0;
            this.lblSoB.Text = "Số B:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "label1";
            // 
            // txt_a
            // 
            this.txt_a.Location = new System.Drawing.Point(175, 62);
            this.txt_a.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(105, 20);
            this.txt_a.TabIndex = 1;
            // 
            // txt_b
            // 
            this.txt_b.Location = new System.Drawing.Point(175, 89);
            this.txt_b.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_b.Name = "txt_b";
            this.txt_b.Size = new System.Drawing.Size(105, 20);
            this.txt_b.TabIndex = 1;
            // 
            // txt_kq
            // 
            this.txt_kq.Location = new System.Drawing.Point(175, 115);
            this.txt_kq.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_kq.Name = "txt_kq";
            this.txt_kq.Size = new System.Drawing.Size(105, 20);
            this.txt_kq.TabIndex = 1;
            // 
            // btn_cong
            // 
            this.btn_cong.Location = new System.Drawing.Point(178, 198);
            this.btn_cong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_cong.Name = "btn_cong";
            this.btn_cong.Size = new System.Drawing.Size(146, 49);
            this.btn_cong.TabIndex = 2;
            this.btn_cong.Text = "button1";
            this.btn_cong.UseVisualStyleBackColor = true;
            this.btn_cong.Click += new System.EventHandler(this.btn_cong_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btn_cong);
            this.Controls.Add(this.txt_kq);
            this.Controls.Add(this.txt_b);
            this.Controls.Add(this.txt_a);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSoB);
            this.Controls.Add(this.lblSoA);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSoA;
        private System.Windows.Forms.Label lblSoB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_a;
        private System.Windows.Forms.TextBox txt_b;
        private System.Windows.Forms.TextBox txt_kq;
        private System.Windows.Forms.Button btn_cong;
    }
}

