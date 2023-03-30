namespace Calculator
{
    partial class Calculator
    {
        
        private System.ComponentModel.IContainer components = null;

        
        
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
            this.Disp2 = new System.Windows.Forms.TextBox();
            this.All_Disp = new System.Windows.Forms.Panel();
            this.Disp1 = new System.Windows.Forms.TextBox();
            this.All_Number = new System.Windows.Forms.Panel();
            this.btn_CE = new System.Windows.Forms.Button();
            this.amount = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.All_Disp.SuspendLayout();
            this.All_Number.SuspendLayout();
            this.SuspendLayout();
            // 
            // Disp2
            // 
            this.Disp2.BackColor = System.Drawing.Color.MistyRose;
            this.Disp2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Disp2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Disp2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Disp2.Location = new System.Drawing.Point(16, 53);
            this.Disp2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Disp2.Name = "Disp2";
            this.Disp2.ReadOnly = true;
            this.Disp2.Size = new System.Drawing.Size(374, 29);
            this.Disp2.TabIndex = 0;
            this.Disp2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // All_Disp
            // 
            this.All_Disp.BackColor = System.Drawing.Color.MistyRose;
            this.All_Disp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.All_Disp.Controls.Add(this.Disp1);
            this.All_Disp.Controls.Add(this.Disp2);
            this.All_Disp.Location = new System.Drawing.Point(10, 21);
            this.All_Disp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.All_Disp.Name = "All_Disp";
            this.All_Disp.Size = new System.Drawing.Size(401, 86);
            this.All_Disp.TabIndex = 1;
            // 
            // Disp1
            // 
            this.Disp1.BackColor = System.Drawing.Color.MistyRose;
            this.Disp1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Disp1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Disp1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Disp1.Location = new System.Drawing.Point(16, 9);
            this.Disp1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Disp1.Name = "Disp1";
            this.Disp1.ReadOnly = true;
            this.Disp1.Size = new System.Drawing.Size(374, 29);
            this.Disp1.TabIndex = 1;
            this.Disp1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // All_Number
            // 
            this.All_Number.BackColor = System.Drawing.Color.MistyRose;
            this.All_Number.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.All_Number.Controls.Add(this.btn_CE);
            this.All_Number.Controls.Add(this.amount);
            this.All_Number.Controls.Add(this.divide);
            this.All_Number.Controls.Add(this.plus);
            this.All_Number.Controls.Add(this.delete);
            this.All_Number.Controls.Add(this.multiply);
            this.All_Number.Controls.Add(this.btnclear);
            this.All_Number.Controls.Add(this.dot);
            this.All_Number.Controls.Add(this.btn0);
            this.All_Number.Controls.Add(this.btn9);
            this.All_Number.Controls.Add(this.btn8);
            this.All_Number.Controls.Add(this.btn7);
            this.All_Number.Controls.Add(this.btn6);
            this.All_Number.Controls.Add(this.btn5);
            this.All_Number.Controls.Add(this.btn4);
            this.All_Number.Controls.Add(this.btn3);
            this.All_Number.Controls.Add(this.btn2);
            this.All_Number.Controls.Add(this.btn1);
            this.All_Number.Location = new System.Drawing.Point(10, 111);
            this.All_Number.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.All_Number.Name = "All_Number";
            this.All_Number.Size = new System.Drawing.Size(401, 445);
            this.All_Number.TabIndex = 2;
            // 
            // btn_CE
            // 
            this.btn_CE.BackColor = System.Drawing.Color.IndianRed;
            this.btn_CE.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_CE.ForeColor = System.Drawing.Color.White;
            this.btn_CE.Location = new System.Drawing.Point(27, 347);
            this.btn_CE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_CE.Name = "btn_CE";
            this.btn_CE.Size = new System.Drawing.Size(74, 57);
            this.btn_CE.TabIndex = 17;
            this.btn_CE.Text = "CE";
            this.btn_CE.UseVisualStyleBackColor = false;
            this.btn_CE.Click += new System.EventHandler(this.ClearController);
            // 
            // amount
            // 
            this.amount.BackColor = System.Drawing.Color.IndianRed;
            this.amount.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.amount.ForeColor = System.Drawing.Color.White;
            this.amount.Location = new System.Drawing.Point(116, 347);
            this.amount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(252, 57);
            this.amount.TabIndex = 16;
            this.amount.Text = "=";
            this.amount.UseVisualStyleBackColor = false;
            this.amount.Click += new System.EventHandler(this.OperationContoller);
            // 
            // divide
            // 
            this.divide.BackColor = System.Drawing.Color.IndianRed;
            this.divide.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.divide.ForeColor = System.Drawing.Color.White;
            this.divide.Location = new System.Drawing.Point(295, 271);
            this.divide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(74, 57);
            this.divide.TabIndex = 15;
            this.divide.Text = "/";
            this.divide.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.divide.UseVisualStyleBackColor = false;
            this.divide.Click += new System.EventHandler(this.OperationContoller);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.Color.IndianRed;
            this.plus.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.plus.ForeColor = System.Drawing.Color.White;
            this.plus.Location = new System.Drawing.Point(295, 39);
            this.plus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(74, 57);
            this.plus.TabIndex = 14;
            this.plus.Text = "+";
            this.plus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.OperationContoller);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.IndianRed;
            this.delete.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.Location = new System.Drawing.Point(295, 115);
            this.delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(74, 57);
            this.delete.TabIndex = 13;
            this.delete.Text = "-";
            this.delete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.OperationContoller);
            // 
            // multiply
            // 
            this.multiply.BackColor = System.Drawing.Color.IndianRed;
            this.multiply.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.multiply.ForeColor = System.Drawing.Color.White;
            this.multiply.Location = new System.Drawing.Point(295, 192);
            this.multiply.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(74, 57);
            this.multiply.TabIndex = 12;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = false;
            this.multiply.Click += new System.EventHandler(this.OperationContoller);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.IndianRed;
            this.btnclear.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnclear.ForeColor = System.Drawing.Color.White;
            this.btnclear.Location = new System.Drawing.Point(27, 271);
            this.btnclear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(74, 57);
            this.btnclear.TabIndex = 11;
            this.btnclear.Text = "C";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.ClearController);
            // 
            // dot
            // 
            this.dot.BackColor = System.Drawing.Color.Coral;
            this.dot.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dot.ForeColor = System.Drawing.Color.White;
            this.dot.Location = new System.Drawing.Point(206, 271);
            this.dot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(74, 57);
            this.dot.TabIndex = 10;
            this.dot.Text = ".";
            this.dot.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.dot.UseVisualStyleBackColor = false;
            this.dot.Click += new System.EventHandler(this.btnNumberController);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.Coral;
            this.btn0.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn0.ForeColor = System.Drawing.Color.White;
            this.btn0.Location = new System.Drawing.Point(116, 271);
            this.btn0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(74, 57);
            this.btn0.TabIndex = 9;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btnNumberController);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.Coral;
            this.btn9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn9.ForeColor = System.Drawing.Color.White;
            this.btn9.Location = new System.Drawing.Point(206, 39);
            this.btn9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(74, 57);
            this.btn9.TabIndex = 8;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btnNumberController);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Coral;
            this.btn8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn8.ForeColor = System.Drawing.Color.White;
            this.btn8.Location = new System.Drawing.Point(116, 39);
            this.btn8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(74, 57);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btnNumberController);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Coral;
            this.btn7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn7.ForeColor = System.Drawing.Color.White;
            this.btn7.Location = new System.Drawing.Point(27, 39);
            this.btn7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(74, 57);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btnNumberController);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Coral;
            this.btn6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn6.ForeColor = System.Drawing.Color.White;
            this.btn6.Location = new System.Drawing.Point(206, 115);
            this.btn6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(74, 57);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btnNumberController);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Coral;
            this.btn5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn5.ForeColor = System.Drawing.Color.White;
            this.btn5.Location = new System.Drawing.Point(116, 115);
            this.btn5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(74, 57);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btnNumberController);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Coral;
            this.btn4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn4.ForeColor = System.Drawing.Color.White;
            this.btn4.Location = new System.Drawing.Point(27, 115);
            this.btn4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(74, 57);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btnNumberController);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Coral;
            this.btn3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn3.ForeColor = System.Drawing.Color.White;
            this.btn3.Location = new System.Drawing.Point(206, 192);
            this.btn3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(74, 57);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btnNumberController);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Coral;
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn2.ForeColor = System.Drawing.Color.White;
            this.btn2.Location = new System.Drawing.Point(116, 192);
            this.btn2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(74, 57);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btnNumberController);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Coral;
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn1.ForeColor = System.Drawing.Color.White;
            this.btn1.Location = new System.Drawing.Point(27, 192);
            this.btn1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(74, 57);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btnNumberController);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(422, 565);
            this.Controls.Add(this.All_Number);
            this.Controls.Add(this.All_Disp);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.All_Disp.ResumeLayout(false);
            this.All_Disp.PerformLayout();
            this.All_Number.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox Disp2;
        private Panel All_Disp;
        private TextBox Disp1;
        private Panel All_Number;
        private Button amount;
        private Button divide;
        private Button plus;
        private Button delete;
        private Button multiply;
        private Button btnclear;
        private Button dot;
        private Button btn0;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btn_CE;
    }
}