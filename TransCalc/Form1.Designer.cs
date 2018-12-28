namespace TransCalc
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
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.buttonCount = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
            this.textBoxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textBoxInput.Location = new System.Drawing.Point(12, 25);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(536, 35);
            this.textBoxInput.TabIndex = 1;
            this.textBoxInput.Text = "(((1+2)*(34-5))/6)+7";
            // 
            // buttonCount
            // 
            this.buttonCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.buttonCount.Location = new System.Drawing.Point(12, 80);
            this.buttonCount.Name = "buttonCount";
            this.buttonCount.Size = new System.Drawing.Size(151, 36);
            this.buttonCount.TabIndex = 3;
            this.buttonCount.Text = "Calculate";
            this.buttonCount.UseVisualStyleBackColor = true;
            this.buttonCount.Click += new System.EventHandler(this.buttonCount_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textBoxResult.Location = new System.Drawing.Point(168, 80);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(380, 35);
            this.textBoxResult.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Expression in infix notation:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Result:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 126);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonCount);
            this.Controls.Add(this.textBoxInput);
            this.Name = "Form1";
            this.Text = "TransCalc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button buttonCount;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}

