namespace Tip_Calculator
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.Bill_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Tip_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Minus_btn = new System.Windows.Forms.Button();
            this.Plus_btn = new System.Windows.Forms.Button();
            this.Pplminus_btn = new System.Windows.Forms.Button();
            this.People_text = new System.Windows.Forms.TextBox();
            this.pplplus_btn = new System.Windows.Forms.Button();
            this.Totalperperson = new System.Windows.Forms.TextBox();
            this.Tipperperson = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.LightGray;
            this.splitContainer1.Panel1.Controls.Add(this.pplplus_btn);
            this.splitContainer1.Panel1.Controls.Add(this.People_text);
            this.splitContainer1.Panel1.Controls.Add(this.Pplminus_btn);
            this.splitContainer1.Panel1.Controls.Add(this.Plus_btn);
            this.splitContainer1.Panel1.Controls.Add(this.Minus_btn);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.Tip_text);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.Bill_text);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.splitContainer1.Panel2.Controls.Add(this.Totalperperson);
            this.splitContainer1.Panel2.Controls.Add(this.Tipperperson);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(849, 358);
            this.splitContainer1.SplitterDistance = 341;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bill";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Bill_text
            // 
            this.Bill_text.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bill_text.Location = new System.Drawing.Point(19, 62);
            this.Bill_text.Multiline = true;
            this.Bill_text.Name = "Bill_text";
            this.Bill_text.Size = new System.Drawing.Size(213, 39);
            this.Bill_text.TabIndex = 0;
            this.Bill_text.Text = "0.00";
            this.Bill_text.TextChanged += new System.EventHandler(this.Bill_text_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tip %";
            // 
            // Tip_text
            // 
            this.Tip_text.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tip_text.Location = new System.Drawing.Point(62, 172);
            this.Tip_text.Margin = new System.Windows.Forms.Padding(4);
            this.Tip_text.Multiline = true;
            this.Tip_text.Name = "Tip_text";
            this.Tip_text.Size = new System.Drawing.Size(138, 39);
            this.Tip_text.TabIndex = 2;
            this.Tip_text.Text = "0";
            this.Tip_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Tip_text.TextChanged += new System.EventHandler(this.Tip_text_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 39);
            this.label3.TabIndex = 3;
            this.label3.Text = "Number of people";
            // 
            // Minus_btn
            // 
            this.Minus_btn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minus_btn.Location = new System.Drawing.Point(19, 172);
            this.Minus_btn.Name = "Minus_btn";
            this.Minus_btn.Size = new System.Drawing.Size(48, 39);
            this.Minus_btn.TabIndex = 4;
            this.Minus_btn.Text = "-";
            this.Minus_btn.UseVisualStyleBackColor = true;
            this.Minus_btn.Click += new System.EventHandler(this.Minus_btn_Click);
            // 
            // Plus_btn
            // 
            this.Plus_btn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plus_btn.Location = new System.Drawing.Point(184, 172);
            this.Plus_btn.Name = "Plus_btn";
            this.Plus_btn.Size = new System.Drawing.Size(48, 39);
            this.Plus_btn.TabIndex = 5;
            this.Plus_btn.Text = "+";
            this.Plus_btn.UseVisualStyleBackColor = true;
            this.Plus_btn.Click += new System.EventHandler(this.Plus_btn_Click);
            // 
            // Pplminus_btn
            // 
            this.Pplminus_btn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pplminus_btn.Location = new System.Drawing.Point(19, 288);
            this.Pplminus_btn.Name = "Pplminus_btn";
            this.Pplminus_btn.Size = new System.Drawing.Size(48, 39);
            this.Pplminus_btn.TabIndex = 6;
            this.Pplminus_btn.Text = "-";
            this.Pplminus_btn.UseVisualStyleBackColor = true;
            this.Pplminus_btn.Click += new System.EventHandler(this.Pplminus_btn_Click);
            // 
            // People_text
            // 
            this.People_text.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.People_text.Location = new System.Drawing.Point(62, 288);
            this.People_text.Multiline = true;
            this.People_text.Name = "People_text";
            this.People_text.Size = new System.Drawing.Size(138, 39);
            this.People_text.TabIndex = 7;
            this.People_text.Text = "1";
            this.People_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.People_text.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // pplplus_btn
            // 
            this.pplplus_btn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pplplus_btn.Location = new System.Drawing.Point(184, 288);
            this.pplplus_btn.Name = "pplplus_btn";
            this.pplplus_btn.Size = new System.Drawing.Size(48, 39);
            this.pplplus_btn.TabIndex = 8;
            this.pplplus_btn.Text = "+";
            this.pplplus_btn.UseVisualStyleBackColor = true;
            this.pplplus_btn.Click += new System.EventHandler(this.pplplus_btn_Click);
            // 
            // Totalperperson
            // 
            this.Totalperperson.Enabled = false;
            this.Totalperperson.Font = new System.Drawing.Font("Times New Roman", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Totalperperson.Location = new System.Drawing.Point(228, 189);
            this.Totalperperson.Margin = new System.Windows.Forms.Padding(4);
            this.Totalperperson.Multiline = true;
            this.Totalperperson.Name = "Totalperperson";
            this.Totalperperson.Size = new System.Drawing.Size(237, 56);
            this.Totalperperson.TabIndex = 15;
            this.Totalperperson.Text = "0.00";
            // 
            // Tipperperson
            // 
            this.Tipperperson.Enabled = false;
            this.Tipperperson.Font = new System.Drawing.Font("Times New Roman", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tipperperson.Location = new System.Drawing.Point(228, 84);
            this.Tipperperson.Margin = new System.Windows.Forms.Padding(4);
            this.Tipperperson.Multiline = true;
            this.Tipperperson.Name = "Tipperperson";
            this.Tipperperson.Size = new System.Drawing.Size(237, 56);
            this.Tipperperson.TabIndex = 14;
            this.Tipperperson.Text = "0.00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(191, 191);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 49);
            this.label10.TabIndex = 13;
            this.label10.Text = "$";
            this.label10.Click += new System.EventHandler(this.label7_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(191, 84);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 49);
            this.label9.TabIndex = 12;
            this.label9.Text = "$";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(29, 218);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 27);
            this.label8.TabIndex = 11;
            this.label8.Text = "per person";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 179);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 39);
            this.label7.TabIndex = 10;
            this.label7.Text = "Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(29, 113);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 27);
            this.label6.TabIndex = 9;
            this.label6.Text = "per person";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 74);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 39);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tip";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 358);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Bill_text;
        private System.Windows.Forms.Button pplplus_btn;
        private System.Windows.Forms.TextBox People_text;
        private System.Windows.Forms.Button Pplminus_btn;
        private System.Windows.Forms.Button Plus_btn;
        private System.Windows.Forms.Button Minus_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Tip_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Totalperperson;
        private System.Windows.Forms.TextBox Tipperperson;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

