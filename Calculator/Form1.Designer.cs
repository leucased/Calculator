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
            this.lblKQ = new System.Windows.Forms.Label();
            this.txt_a = new System.Windows.Forms.TextBox();
            this.txt_b = new System.Windows.Forms.TextBox();
            this.txt_kq = new System.Windows.Forms.TextBox();
            this.btn_cong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSoA
            // 
            this.lblSoA.AutoSize = true;
            this.lblSoA.Location = new System.Drawing.Point(227, 105);
            this.lblSoA.Name = "lblSoA";
            this.lblSoA.Size = new System.Drawing.Size(39, 16);
            this.lblSoA.TabIndex = 0;
            this.lblSoA.Text = "Số A:";
            // 
            // lblSoB
            // 
            this.lblSoB.AutoSize = true;
            this.lblSoB.Location = new System.Drawing.Point(227, 136);
            this.lblSoB.Name = "lblSoB";
            this.lblSoB.Size = new System.Drawing.Size(39, 16);
            this.lblSoB.TabIndex = 0;
            this.lblSoB.Text = "Số B:";
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.Location = new System.Drawing.Point(227, 169);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(55, 16);
            this.lblKQ.TabIndex = 0;
            this.lblKQ.Text = "Kết quả:";
            // 
            // txt_a
            // 
            this.txt_a.Location = new System.Drawing.Point(331, 99);
            this.txt_a.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(139, 22);
            this.txt_a.TabIndex = 1;
            // 
            // txt_b
            // 
            this.txt_b.Location = new System.Drawing.Point(331, 133);
            this.txt_b.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_b.Name = "txt_b";
            this.txt_b.Size = new System.Drawing.Size(139, 22);
            this.txt_b.TabIndex = 1;
            // 
            // txt_kq
            // 
            this.txt_kq.Enabled = false;
            this.txt_kq.Location = new System.Drawing.Point(331, 165);
            this.txt_kq.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_kq.Name = "txt_kq";
            this.txt_kq.Size = new System.Drawing.Size(139, 22);
            this.txt_kq.TabIndex = 1;
            this.txt_kq.TextChanged += new System.EventHandler(this.txt_kq_TextChanged);
            // 
            // btn_cong
            // 
            this.btn_cong.Location = new System.Drawing.Point(265, 233);
            this.btn_cong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cong.Name = "btn_cong";
            this.btn_cong.Size = new System.Drawing.Size(195, 60);
            this.btn_cong.TabIndex = 2;
            this.btn_cong.Text = "Tính";
            this.btn_cong.UseVisualStyleBackColor = true;
            this.btn_cong.Click += new System.EventHandler(this.btn_cong_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_cong);
            this.Controls.Add(this.txt_kq);
            this.Controls.Add(this.txt_b);
            this.Controls.Add(this.txt_a);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.lblSoB);
            this.Controls.Add(this.lblSoA);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSoA;
        private System.Windows.Forms.Label lblSoB;
        private System.Windows.Forms.Label lblKQ;
        private System.Windows.Forms.TextBox txt_a;
        private System.Windows.Forms.TextBox txt_b;
        private System.Windows.Forms.TextBox txt_kq;
        private System.Windows.Forms.Button btn_cong;
    }
}

