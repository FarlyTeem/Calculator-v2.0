﻿namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Sum = new System.Windows.Forms.Button();
            this.Min = new System.Windows.Forms.Button();
            this.Mult = new System.Windows.Forms.Button();
            this.Div = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Sinus = new System.Windows.Forms.Button();
            this.Cosine = new System.Windows.Forms.Button();
            this.Logarithm3 = new System.Windows.Forms.Button();
            this.Exponentiation3 = new System.Windows.Forms.Button();
            this.Exhibitor = new System.Windows.Forms.Button();
            this.Tangent = new System.Windows.Forms.Button();
            this.Cotangent = new System.Windows.Forms.Button();
            this.Logarithm10 = new System.Windows.Forms.Button();
            this.Exponentiation10 = new System.Windows.Forms.Button();
            this.Denial = new System.Windows.Forms.Button();
            this.CosG = new System.Windows.Forms.Button();
            this.Negative = new System.Windows.Forms.Button();
            this.SinG = new System.Windows.Forms.Button();
            this.Absolute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Sum
            // 
            this.Sum.Location = new System.Drawing.Point(336, 12);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(75, 23);
            this.Sum.TabIndex = 0;
            this.Sum.Text = "+";
            this.Sum.UseVisualStyleBackColor = true;
            this.Sum.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Min
            // 
            this.Min.Location = new System.Drawing.Point(336, 41);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(75, 23);
            this.Min.TabIndex = 1;
            this.Min.Text = "-";
            this.Min.UseVisualStyleBackColor = true;
            this.Min.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Mult
            // 
            this.Mult.Location = new System.Drawing.Point(336, 70);
            this.Mult.Name = "Mult";
            this.Mult.Size = new System.Drawing.Size(75, 23);
            this.Mult.TabIndex = 2;
            this.Mult.Text = "*";
            this.Mult.UseVisualStyleBackColor = true;
            this.Mult.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Div
            // 
            this.Div.Location = new System.Drawing.Point(336, 99);
            this.Div.Name = "Div";
            this.Div.Size = new System.Drawing.Size(75, 23);
            this.Div.TabIndex = 3;
            this.Div.Text = "/";
            this.Div.UseVisualStyleBackColor = true;
            this.Div.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 29);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBox2.Location = new System.Drawing.Point(174, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 29);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox3.Location = new System.Drawing.Point(12, 47);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(318, 38);
            this.textBox3.TabIndex = 6;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.Click += new System.EventHandler(this.CalculateOne_Click);
            // 
            // Sinus
            // 
            this.Sinus.Location = new System.Drawing.Point(12, 99);
            this.Sinus.Name = "Sinus";
            this.Sinus.Size = new System.Drawing.Size(75, 23);
            this.Sinus.TabIndex = 14;
            this.Sinus.Text = "sin";
            this.Sinus.UseVisualStyleBackColor = true;
            this.Sinus.Click += new System.EventHandler(this.CalculateOne_Click);
            // 
            // Cosine
            // 
            this.Cosine.Location = new System.Drawing.Point(93, 99);
            this.Cosine.Name = "Cosine";
            this.Cosine.Size = new System.Drawing.Size(75, 23);
            this.Cosine.TabIndex = 15;
            this.Cosine.Text = "cos";
            this.Cosine.UseVisualStyleBackColor = true;
            this.Cosine.Click += new System.EventHandler(this.CalculateOne_Click);
            // 
            // Logarithm3
            // 
            this.Logarithm3.Location = new System.Drawing.Point(255, 128);
            this.Logarithm3.Name = "Logarithm3";
            this.Logarithm3.Size = new System.Drawing.Size(75, 23);
            this.Logarithm3.TabIndex = 17;
            this.Logarithm3.Text = "ln(x) от 3";
            this.Logarithm3.UseVisualStyleBackColor = true;
            this.Logarithm3.Click += new System.EventHandler(this.CalculateOne_Click);
            // 
            // Exponentiation3
            // 
            this.Exponentiation3.Location = new System.Drawing.Point(12, 128);
            this.Exponentiation3.Name = "Exponentiation3";
            this.Exponentiation3.Size = new System.Drawing.Size(75, 23);
            this.Exponentiation3.TabIndex = 19;
            this.Exponentiation3.Text = "square 3";
            this.Exponentiation3.UseVisualStyleBackColor = true;
            this.Exponentiation3.Click += new System.EventHandler(this.CalculateOne_Click);
            // 
            // Exhibitor
            // 
            this.Exhibitor.Location = new System.Drawing.Point(174, 128);
            this.Exhibitor.Name = "Exhibitor";
            this.Exhibitor.Size = new System.Drawing.Size(75, 23);
            this.Exhibitor.TabIndex = 21;
            this.Exhibitor.Text = "e^x";
            this.Exhibitor.UseVisualStyleBackColor = true;
            this.Exhibitor.Click += new System.EventHandler(this.CalculateOne_Click);
            // 
            // Tangent
            // 
            this.Tangent.Location = new System.Drawing.Point(174, 99);
            this.Tangent.Name = "Tangent";
            this.Tangent.Size = new System.Drawing.Size(75, 23);
            this.Tangent.TabIndex = 22;
            this.Tangent.Text = "tg";
            this.Tangent.UseVisualStyleBackColor = true;
            this.Tangent.Click += new System.EventHandler(this.CalculateOne_Click);
            // 
            // Cotangent
            // 
            this.Cotangent.Location = new System.Drawing.Point(255, 99);
            this.Cotangent.Name = "Cotangent";
            this.Cotangent.Size = new System.Drawing.Size(75, 23);
            this.Cotangent.TabIndex = 23;
            this.Cotangent.Text = "ctg";
            this.Cotangent.UseVisualStyleBackColor = true;
            this.Cotangent.Click += new System.EventHandler(this.CalculateOne_Click);
            // 
            // Logarithm10
            // 
            this.Logarithm10.Location = new System.Drawing.Point(174, 157);
            this.Logarithm10.Name = "Logarithm10";
            this.Logarithm10.Size = new System.Drawing.Size(75, 23);
            this.Logarithm10.TabIndex = 24;
            this.Logarithm10.Text = "log10";
            this.Logarithm10.UseVisualStyleBackColor = true;
            this.Logarithm10.Click += new System.EventHandler(this.CalculateOne_Click);
            // 
            // Exponentiation10
            // 
            this.Exponentiation10.Location = new System.Drawing.Point(93, 128);
            this.Exponentiation10.Name = "Exponentiation10";
            this.Exponentiation10.Size = new System.Drawing.Size(75, 23);
            this.Exponentiation10.TabIndex = 25;
            this.Exponentiation10.Text = "x10";
            this.Exponentiation10.UseVisualStyleBackColor = true;
            this.Exponentiation10.Click += new System.EventHandler(this.CalculateOne_Click);
            // 
            // Denial
            // 
            this.Denial.Location = new System.Drawing.Point(255, 157);
            this.Denial.Name = "Denial";
            this.Denial.Size = new System.Drawing.Size(75, 23);
            this.Denial.TabIndex = 26;
            this.Denial.Text = "min_x";
            this.Denial.UseVisualStyleBackColor = true;
            this.Denial.Click += new System.EventHandler(this.CalculateOne_Click);
            // 
            // CosG
            // 
            this.CosG.Location = new System.Drawing.Point(93, 157);
            this.CosG.Name = "CosG";
            this.CosG.Size = new System.Drawing.Size(75, 23);
            this.CosG.TabIndex = 36;
            this.CosG.Text = "cos\'( a )";
            this.CosG.UseVisualStyleBackColor = true;
            this.CosG.Click += new System.EventHandler(this.CalculateOne_Click);
            // 
            // Negative
            // 
            this.Negative.Location = new System.Drawing.Point(336, 157);
            this.Negative.Name = "Negative";
            this.Negative.Size = new System.Drawing.Size(75, 23);
            this.Negative.TabIndex = 35;
            this.Negative.Text = "1/a";
            this.Negative.UseVisualStyleBackColor = true;
            this.Negative.Click += new System.EventHandler(this.CalculateOne_Click);
            // 
            // SinG
            // 
            this.SinG.Location = new System.Drawing.Point(12, 157);
            this.SinG.Name = "SinG";
            this.SinG.Size = new System.Drawing.Size(75, 23);
            this.SinG.TabIndex = 34;
            this.SinG.Text = "sin\'( a )";
            this.SinG.UseVisualStyleBackColor = true;
            this.SinG.Click += new System.EventHandler(this.CalculateOne_Click);
            // 
            // Absolute
            // 
            this.Absolute.Location = new System.Drawing.Point(336, 128);
            this.Absolute.Name = "Absolute";
            this.Absolute.Size = new System.Drawing.Size(75, 23);
            this.Absolute.TabIndex = 33;
            this.Absolute.Text = "| a |";
            this.Absolute.UseVisualStyleBackColor = true;
            this.Absolute.Click += new System.EventHandler(this.CalculateOne_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 187);
            this.Controls.Add(this.CosG);
            this.Controls.Add(this.Negative);
            this.Controls.Add(this.SinG);
            this.Controls.Add(this.Absolute);
            this.Controls.Add(this.Denial);
            this.Controls.Add(this.Exponentiation10);
            this.Controls.Add(this.Logarithm10);
            this.Controls.Add(this.Cotangent);
            this.Controls.Add(this.Tangent);
            this.Controls.Add(this.Exhibitor);
            this.Controls.Add(this.Exponentiation3);
            this.Controls.Add(this.Logarithm3);
            this.Controls.Add(this.Cosine);
            this.Controls.Add(this.Sinus);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Div);
            this.Controls.Add(this.Mult);
            this.Controls.Add(this.Min);
            this.Controls.Add(this.Sum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Sum;
        private System.Windows.Forms.Button Min;
        private System.Windows.Forms.Button Mult;
        private System.Windows.Forms.Button Div;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Sinus;
        private System.Windows.Forms.Button Cosine;
        private System.Windows.Forms.Button Logarithm3;
        private System.Windows.Forms.Button Exponentiation3;
        private System.Windows.Forms.Button Exhibitor;
        private System.Windows.Forms.Button Tangent;
        private System.Windows.Forms.Button Cotangent;
        private System.Windows.Forms.Button Logarithm10;
        private System.Windows.Forms.Button Exponentiation10;
        private System.Windows.Forms.Button Denial;
        private System.Windows.Forms.Button CosG;
        private System.Windows.Forms.Button Negative;
        private System.Windows.Forms.Button SinG;
        private System.Windows.Forms.Button Absolute;
    }
}

