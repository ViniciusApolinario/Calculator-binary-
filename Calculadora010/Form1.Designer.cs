namespace Calculadora010
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
            this.textBoxDecimal = new System.Windows.Forms.TextBox();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.btSum = new System.Windows.Forms.Button();
            this.btSub = new System.Windows.Forms.Button();
            this.btMult = new System.Windows.Forms.Button();
            this.btDiv = new System.Windows.Forms.Button();
            this.btConv = new System.Windows.Forms.Button();
            this.BinaryLabel = new System.Windows.Forms.Label();
            this.btResult = new System.Windows.Forms.Button();
            this.textBoxBinary = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxOperation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxBinary2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btClear = new System.Windows.Forms.Button();
            this.textBoxDecimal2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxResult2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxDecimal
            // 
            this.textBoxDecimal.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxDecimal.Location = new System.Drawing.Point(33, 29);
            this.textBoxDecimal.Name = "textBoxDecimal";
            this.textBoxDecimal.Size = new System.Drawing.Size(90, 20);
            this.textBoxDecimal.TabIndex = 0;
            this.textBoxDecimal.TextChanged += new System.EventHandler(this.textBoxDecimal_TextChanged_1);
            this.textBoxDecimal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoPressed);
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(166, 70);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(37, 23);
            this.bt1.TabIndex = 1;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt0
            // 
            this.bt0.Location = new System.Drawing.Point(232, 70);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(36, 23);
            this.bt0.TabIndex = 10;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = true;
            this.bt0.Click += new System.EventHandler(this.bt0_Click);
            // 
            // btSum
            // 
            this.btSum.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btSum.Location = new System.Drawing.Point(166, 99);
            this.btSum.Name = "btSum";
            this.btSum.Size = new System.Drawing.Size(26, 23);
            this.btSum.TabIndex = 11;
            this.btSum.Text = "+";
            this.btSum.UseVisualStyleBackColor = true;
            this.btSum.Click += new System.EventHandler(this.btSum_Click);
            // 
            // btSub
            // 
            this.btSub.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btSub.Location = new System.Drawing.Point(206, 128);
            this.btSub.Name = "btSub";
            this.btSub.Size = new System.Drawing.Size(26, 23);
            this.btSub.TabIndex = 12;
            this.btSub.Text = "-";
            this.btSub.UseVisualStyleBackColor = true;
            this.btSub.Click += new System.EventHandler(this.btSub_Click);
            // 
            // btMult
            // 
            this.btMult.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btMult.Location = new System.Drawing.Point(242, 99);
            this.btMult.Name = "btMult";
            this.btMult.Size = new System.Drawing.Size(26, 23);
            this.btMult.TabIndex = 13;
            this.btMult.Text = "x";
            this.btMult.UseVisualStyleBackColor = true;
            this.btMult.Click += new System.EventHandler(this.btMult_Click);
            // 
            // btDiv
            // 
            this.btDiv.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btDiv.Location = new System.Drawing.Point(206, 99);
            this.btDiv.Name = "btDiv";
            this.btDiv.Size = new System.Drawing.Size(26, 23);
            this.btDiv.TabIndex = 14;
            this.btDiv.Text = "÷";
            this.btDiv.UseVisualStyleBackColor = true;
            this.btDiv.Click += new System.EventHandler(this.btDiv_Click);
            // 
            // btConv
            // 
            this.btConv.ForeColor = System.Drawing.Color.Black;
            this.btConv.Location = new System.Drawing.Point(186, 186);
            this.btConv.Name = "btConv";
            this.btConv.Size = new System.Drawing.Size(72, 23);
            this.btConv.TabIndex = 15;
            this.btConv.Text = "Converter";
            this.btConv.UseVisualStyleBackColor = true;
            this.btConv.Click += new System.EventHandler(this.btConv_Click);
            // 
            // BinaryLabel
            // 
            this.BinaryLabel.AutoSize = true;
            this.BinaryLabel.Location = new System.Drawing.Point(30, 52);
            this.BinaryLabel.Name = "BinaryLabel";
            this.BinaryLabel.Size = new System.Drawing.Size(81, 13);
            this.BinaryLabel.TabIndex = 17;
            this.BinaryLabel.Text = "Valor 1 (Binario)";
            // 
            // btResult
            // 
            this.btResult.ForeColor = System.Drawing.Color.Black;
            this.btResult.Location = new System.Drawing.Point(306, 182);
            this.btResult.Name = "btResult";
            this.btResult.Size = new System.Drawing.Size(72, 23);
            this.btResult.TabIndex = 21;
            this.btResult.Text = "=";
            this.btResult.UseVisualStyleBackColor = true;
            this.btResult.Click += new System.EventHandler(this.btResult_Click);
            // 
            // textBoxBinary
            // 
            this.textBoxBinary.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxBinary.Location = new System.Drawing.Point(33, 70);
            this.textBoxBinary.Name = "textBoxBinary";
            this.textBoxBinary.Size = new System.Drawing.Size(90, 20);
            this.textBoxBinary.TabIndex = 22;
            this.textBoxBinary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Decimal:";
            // 
            // textBoxResult
            // 
            this.textBoxResult.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxResult.Location = new System.Drawing.Point(51, 231);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(129, 20);
            this.textBoxResult.TabIndex = 25;
            this.textBoxResult.TextChanged += new System.EventHandler(this.textBoxResult_TextChanged);
            this.textBoxResult.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoPressed);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Resultado :";
            // 
            // textBoxOperation
            // 
            this.textBoxOperation.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxOperation.Location = new System.Drawing.Point(205, 29);
            this.textBoxOperation.Name = "textBoxOperation";
            this.textBoxOperation.Size = new System.Drawing.Size(27, 20);
            this.textBoxOperation.TabIndex = 27;
            this.textBoxOperation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoPressed);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Operação:";
            // 
            // textBoxBinary2
            // 
            this.textBoxBinary2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxBinary2.Location = new System.Drawing.Point(306, 70);
            this.textBoxBinary2.Name = "textBoxBinary2";
            this.textBoxBinary2.Size = new System.Drawing.Size(90, 20);
            this.textBoxBinary2.TabIndex = 29;
            this.textBoxBinary2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(315, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Valor 2 (Binario)";
            // 
            // btClear
            // 
            this.btClear.ForeColor = System.Drawing.Color.Blue;
            this.btClear.Location = new System.Drawing.Point(51, 186);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(72, 23);
            this.btClear.TabIndex = 31;
            this.btClear.Text = "C";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // textBoxDecimal2
            // 
            this.textBoxDecimal2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxDecimal2.Location = new System.Drawing.Point(306, 29);
            this.textBoxDecimal2.Name = "textBoxDecimal2";
            this.textBoxDecimal2.Size = new System.Drawing.Size(90, 20);
            this.textBoxDecimal2.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Decimal:";
            // 
            // textBoxResult2
            // 
            this.textBoxResult2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxResult2.Location = new System.Drawing.Point(263, 231);
            this.textBoxResult2.Name = "textBoxResult2";
            this.textBoxResult2.Size = new System.Drawing.Size(115, 20);
            this.textBoxResult2.TabIndex = 34;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(431, 263);
            this.Controls.Add(this.textBoxResult2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDecimal2);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxBinary2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxOperation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxBinary);
            this.Controls.Add(this.btResult);
            this.Controls.Add(this.BinaryLabel);
            this.Controls.Add(this.btConv);
            this.Controls.Add(this.btDiv);
            this.Controls.Add(this.btMult);
            this.Controls.Add(this.btSub);
            this.Controls.Add(this.btSum);
            this.Controls.Add(this.bt0);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.textBoxDecimal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Cauculadora Binaria";
            this.TransparencyKey = System.Drawing.Color.White;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDecimal;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button btSum;
        private System.Windows.Forms.Button btSub;
        private System.Windows.Forms.Button btMult;
        private System.Windows.Forms.Button btDiv;
        private System.Windows.Forms.Button btConv;
        private System.Windows.Forms.Label BinaryLabel;
        private System.Windows.Forms.Button btResult;
        private System.Windows.Forms.TextBox textBoxBinary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxOperation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxBinary2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.TextBox textBoxDecimal2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxResult2;
    }
}

