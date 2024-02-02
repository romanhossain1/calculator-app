namespace CalculatorApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtTotal = new TextBox();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn0 = new Button();
            btn9 = new Button();
            btnequal = new Button();
            btnadd = new Button();
            btnsub = new Button();
            bt = new Button();
            btndiv = new Button();
            btnclear = new Button();
            SuspendLayout();
            // 
            // txtTotal
            // 
            txtTotal.BackColor = SystemColors.Info;
            txtTotal.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTotal.Location = new Point(19, 25);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(480, 57);
            txtTotal.TabIndex = 0;
            txtTotal.TextChanged += textBox1_TextChanged;
            // 
            // btn1
            // 
            btn1.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.Location = new Point(19, 112);
            btn1.Name = "btn1";
            btn1.Size = new Size(73, 62);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn2.Location = new Point(129, 112);
            btn2.Name = "btn2";
            btn2.Size = new Size(73, 62);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn3.Location = new Point(228, 112);
            btn3.Name = "btn3";
            btn3.Size = new Size(73, 62);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn4.Location = new Point(326, 112);
            btn4.Name = "btn4";
            btn4.Size = new Size(73, 62);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn8.Location = new Point(228, 200);
            btn8.Name = "btn8";
            btn8.Size = new Size(73, 62);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn7.Location = new Point(129, 200);
            btn7.Name = "btn7";
            btn7.Size = new Size(73, 62);
            btn7.TabIndex = 7;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn6.Location = new Point(19, 200);
            btn6.Name = "btn6";
            btn6.Size = new Size(73, 62);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn5.Location = new Point(424, 112);
            btn5.Name = "btn5";
            btn5.Size = new Size(73, 62);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn0.Location = new Point(424, 200);
            btn0.Name = "btn0";
            btn0.Size = new Size(73, 62);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn9.Location = new Point(326, 200);
            btn9.Name = "btn9";
            btn9.Size = new Size(73, 62);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btnequal
            // 
            btnequal.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnequal.Location = new Point(49, 385);
            btnequal.Name = "btnequal";
            btnequal.Size = new Size(398, 62);
            btnequal.TabIndex = 11;
            btnequal.Text = "=";
            btnequal.UseVisualStyleBackColor = true;
            btnequal.Click += btnequal_Click;
            // 
            // btnadd
            // 
            btnadd.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnadd.Location = new Point(19, 293);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(73, 62);
            btnadd.TabIndex = 12;
            btnadd.Text = "+";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // btnsub
            // 
            btnsub.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsub.Location = new Point(129, 293);
            btnsub.Name = "btnsub";
            btnsub.Size = new Size(73, 62);
            btnsub.TabIndex = 13;
            btnsub.Text = "-";
            btnsub.UseVisualStyleBackColor = true;
            btnsub.Click += button1_Click;
            // 
            // bt
            // 
            bt.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt.Location = new Point(228, 293);
            bt.Name = "bt";
            bt.Size = new Size(73, 62);
            bt.TabIndex = 14;
            bt.Text = "*";
            bt.UseVisualStyleBackColor = true;
            bt.Click += bt_Click;
            // 
            // btndiv
            // 
            btndiv.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndiv.Location = new Point(326, 293);
            btndiv.Name = "btndiv";
            btndiv.Size = new Size(73, 62);
            btndiv.TabIndex = 15;
            btndiv.Text = "/";
            btndiv.UseVisualStyleBackColor = true;
            btndiv.Click += btndiv_Click;
            // 
            // btnclear
            // 
            btnclear.Font = new Font("Arial Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnclear.ForeColor = SystemColors.ActiveCaptionText;
            btnclear.Location = new Point(424, 293);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(73, 62);
            btnclear.TabIndex = 16;
            btnclear.Text = "Clear";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 485);
            Controls.Add(btnclear);
            Controls.Add(btndiv);
            Controls.Add(bt);
            Controls.Add(btnsub);
            Controls.Add(btnadd);
            Controls.Add(btnequal);
            Controls.Add(btn0);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(txtTotal);
            Name = "Form1";
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTotal;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn8;
        private Button btn7;
        private Button btn6;
        private Button btn5;
        private Button btn0;
        private Button btn9;
        private Button btnequal;
        private Button btnadd;
        private Button btnsub;
        private Button bt;
        private Button btndiv;
        private Button btnclear;
    }
}
