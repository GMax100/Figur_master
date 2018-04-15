namespace Work_Figur
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
            this.btnRes = new System.Windows.Forms.Button();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbSum = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdBtnQud = new System.Windows.Forms.RadioButton();
            this.rdButLap = new System.Windows.Forms.RadioButton();
            this.rdButBall = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRes
            // 
            this.btnRes.Location = new System.Drawing.Point(175, 121);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(75, 23);
            this.btnRes.TabIndex = 0;
            this.btnRes.Text = "Result";
            this.btnRes.UseVisualStyleBackColor = true;
            this.btnRes.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(10, 19);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(100, 20);
            this.txtBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbSum);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Расчет площади";
            // 
            // lbSum
            // 
            this.lbSum.AutoSize = true;
            this.lbSum.Location = new System.Drawing.Point(111, 84);
            this.lbSum.Name = "lbSum";
            this.lbSum.Size = new System.Drawing.Size(0, 13);
            this.lbSum.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Сторона/Радиус";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ответ = ";
            // 
            // rdBtnQud
            // 
            this.rdBtnQud.AutoSize = true;
            this.rdBtnQud.Location = new System.Drawing.Point(2, 124);
            this.rdBtnQud.Name = "rdBtnQud";
            this.rdBtnQud.Size = new System.Drawing.Size(67, 17);
            this.rdBtnQud.TabIndex = 4;
            this.rdBtnQud.TabStop = true;
            this.rdBtnQud.Text = "Квадрат";
            this.rdBtnQud.UseVisualStyleBackColor = true;
            // 
            // rdButLap
            // 
            this.rdButLap.AutoSize = true;
            this.rdButLap.Location = new System.Drawing.Point(75, 124);
            this.rdButLap.Name = "rdButLap";
            this.rdButLap.Size = new System.Drawing.Size(48, 17);
            this.rdButLap.TabIndex = 5;
            this.rdButLap.TabStop = true;
            this.rdButLap.Text = "Круг";
            this.rdButLap.UseVisualStyleBackColor = true;
            // 
            // rdButBall
            // 
            this.rdButBall.AutoSize = true;
            this.rdButBall.Location = new System.Drawing.Point(123, 124);
            this.rdButBall.Name = "rdButBall";
            this.rdButBall.Size = new System.Drawing.Size(46, 17);
            this.rdButBall.TabIndex = 6;
            this.rdButBall.TabStop = true;
            this.rdButBall.Text = "Шар";
            this.rdButBall.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Сумма площадей =";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 159);
            this.Controls.Add(this.rdButBall);
            this.Controls.Add(this.rdButLap);
            this.Controls.Add(this.rdBtnQud);
            this.Controls.Add(this.btnRes);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRes;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdBtnQud;
        private System.Windows.Forms.RadioButton rdButLap;
        private System.Windows.Forms.RadioButton rdButBall;
        private System.Windows.Forms.Label lbSum;
        private System.Windows.Forms.Label label4;
    }
}

