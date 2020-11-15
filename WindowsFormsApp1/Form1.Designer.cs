namespace WindowsFormsApp1
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
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox5 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox6 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox7 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox8 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox9 = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Culture = new System.Globalization.CultureInfo("ru-RU");
            this.maskedTextBox1.Location = new System.Drawing.Point(509, 29);
            this.maskedTextBox1.Mask = "0.0";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.RejectInputOnFirstFailure = true;
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox1.TabIndex = 1;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Використання мови високого рівня";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Наявність обмежень на розміри модуля";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Наявність вимог до системи ідентифікації";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(370, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Наявність коментарів у точках входу і виходу програми";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 187);
            this.label5.MaximumSize = new System.Drawing.Size(400, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(398, 34);
            this.label5.TabIndex = 6;
            this.label5.Text = "Наявність коментарів-заголовків програми із зазначенням її структурних і функціон" +
    "альних характеристик";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 242);
            this.label6.MaximumSize = new System.Drawing.Size(400, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(296, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Відповідність коментарів прийнятим угодам";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 282);
            this.label7.MaximumSize = new System.Drawing.Size(400, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(375, 34);
            this.label7.TabIndex = 8;
            this.label7.Text = "Наявність вимог щодо використання основних логічних структур";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 339);
            this.label8.MaximumSize = new System.Drawing.Size(400, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(395, 34);
            this.label8.TabIndex = 9;
            this.label8.Text = "Використання при побудові програм методу структурного програмування";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 392);
            this.label9.MaximumSize = new System.Drawing.Size(400, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(400, 34);
            this.label9.TabIndex = 10;
            this.label9.Text = "Наявність коментарів обґрунтування декомпозиції програм при кодуванні";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Culture = new System.Globalization.CultureInfo("ru-RU");
            this.maskedTextBox2.Location = new System.Drawing.Point(509, 67);
            this.maskedTextBox2.Mask = "0.0";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox2.TabIndex = 11;
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Culture = new System.Globalization.CultureInfo("ru-RU");
            this.maskedTextBox3.Location = new System.Drawing.Point(509, 104);
            this.maskedTextBox3.Mask = "0.0";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox3.TabIndex = 12;
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.Culture = new System.Globalization.CultureInfo("ru-RU");
            this.maskedTextBox4.Location = new System.Drawing.Point(509, 144);
            this.maskedTextBox4.Mask = "0.0";
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox4.TabIndex = 13;
            // 
            // maskedTextBox5
            // 
            this.maskedTextBox5.Culture = new System.Globalization.CultureInfo("ru-RU");
            this.maskedTextBox5.Location = new System.Drawing.Point(509, 199);
            this.maskedTextBox5.Mask = "0.0";
            this.maskedTextBox5.Name = "maskedTextBox5";
            this.maskedTextBox5.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox5.TabIndex = 14;
            // 
            // maskedTextBox6
            // 
            this.maskedTextBox6.Culture = new System.Globalization.CultureInfo("ru-RU");
            this.maskedTextBox6.Location = new System.Drawing.Point(509, 237);
            this.maskedTextBox6.Mask = "0.0";
            this.maskedTextBox6.Name = "maskedTextBox6";
            this.maskedTextBox6.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox6.TabIndex = 15;
            // 
            // maskedTextBox7
            // 
            this.maskedTextBox7.Culture = new System.Globalization.CultureInfo("ru-RU");
            this.maskedTextBox7.Location = new System.Drawing.Point(509, 294);
            this.maskedTextBox7.Mask = "0.0";
            this.maskedTextBox7.Name = "maskedTextBox7";
            this.maskedTextBox7.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox7.TabIndex = 16;
            // 
            // maskedTextBox8
            // 
            this.maskedTextBox8.Culture = new System.Globalization.CultureInfo("ru-RU");
            this.maskedTextBox8.Location = new System.Drawing.Point(509, 351);
            this.maskedTextBox8.Mask = "0.0";
            this.maskedTextBox8.Name = "maskedTextBox8";
            this.maskedTextBox8.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox8.TabIndex = 17;
            // 
            // maskedTextBox9
            // 
            this.maskedTextBox9.Culture = new System.Globalization.CultureInfo("ru-RU");
            this.maskedTextBox9.Location = new System.Drawing.Point(509, 404);
            this.maskedTextBox9.Mask = "0.0";
            this.maskedTextBox9.Name = "maskedTextBox9";
            this.maskedTextBox9.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox9.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(475, 451);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 36);
            this.button1.TabIndex = 19;
            this.button1.Text = "ВІдправити";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(261, 451);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 36);
            this.button2.TabIndex = 20;
            this.button2.Text = "Тестові дані";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 499);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.maskedTextBox9);
            this.Controls.Add(this.maskedTextBox8);
            this.Controls.Add(this.maskedTextBox7);
            this.Controls.Add(this.maskedTextBox6);
            this.Controls.Add(this.maskedTextBox5);
            this.Controls.Add(this.maskedTextBox4);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox6;
        private System.Windows.Forms.MaskedTextBox maskedTextBox7;
        private System.Windows.Forms.MaskedTextBox maskedTextBox8;
        private System.Windows.Forms.MaskedTextBox maskedTextBox9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

