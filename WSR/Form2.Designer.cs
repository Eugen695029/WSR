namespace WSR
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Back = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxKarta = new System.Windows.Forms.TextBox();
            this.textBoxKartaNumber = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBoxCVC = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonPay = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.Back);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 90);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(235, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(345, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Москва, Россия 20 июня 2017";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(271, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kart Skills 2017";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Location = new System.Drawing.Point(1, 397);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(799, 53);
            this.panel2.TabIndex = 3;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(27, 22);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(103, 43);
            this.Back.TabIndex = 4;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(273, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Споснор гонщика";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(58, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Информация о спонсоре";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(46, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ваше имя:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(76, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Гощик:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(76, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Карта:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(16, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Номер карты:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(0, 310);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Срок действия:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(92, 341);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "CVC:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(149, 193);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(168, 22);
            this.textBoxName.TabIndex = 15;
            this.textBoxName.Text = "Ваше имя";
            // 
            // textBoxKarta
            // 
            this.textBoxKarta.Location = new System.Drawing.Point(149, 251);
            this.textBoxKarta.Name = "textBoxKarta";
            this.textBoxKarta.Size = new System.Drawing.Size(168, 22);
            this.textBoxKarta.TabIndex = 16;
            this.textBoxKarta.Text = "Владелец карты";
            // 
            // textBoxKartaNumber
            // 
            this.textBoxKartaNumber.Location = new System.Drawing.Point(149, 280);
            this.textBoxKartaNumber.Name = "textBoxKartaNumber";
            this.textBoxKartaNumber.Size = new System.Drawing.Size(168, 22);
            this.textBoxKartaNumber.TabIndex = 17;
            this.textBoxKartaNumber.Text = "1234 1234 1234 1234";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(149, 310);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(22, 22);
            this.textBox4.TabIndex = 18;
            this.textBox4.Text = "01";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(177, 310);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(72, 22);
            this.textBox5.TabIndex = 19;
            this.textBox5.Text = "2017";
            // 
            // textBoxCVC
            // 
            this.textBoxCVC.Location = new System.Drawing.Point(147, 341);
            this.textBoxCVC.Name = "textBoxCVC";
            this.textBoxCVC.Size = new System.Drawing.Size(62, 22);
            this.textBoxCVC.TabIndex = 20;
            this.textBoxCVC.Text = "123";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(149, 222);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 24);
            this.comboBox1.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(509, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(203, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "Благо творительность";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(556, 193);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 20);
            this.label12.TabIndex = 23;
            this.label12.Text = "Фонд Собак";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(512, 222);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(200, 20);
            this.label13.TabIndex = 24;
            this.label13.Text = "Сумма пожертвования";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price.Location = new System.Drawing.Point(569, 254);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(86, 46);
            this.price.TabIndex = 25;
            this.price.Text = "$50";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(577, 319);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(62, 22);
            this.textBoxPrice.TabIndex = 26;
            this.textBoxPrice.Text = "50";
            this.textBoxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRemove.Location = new System.Drawing.Point(532, 314);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(39, 32);
            this.buttonRemove.TabIndex = 27;
            this.buttonRemove.Text = "-";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(645, 314);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(39, 32);
            this.buttonAdd.TabIndex = 28;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonPay
            // 
            this.buttonPay.Location = new System.Drawing.Point(493, 352);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(103, 39);
            this.buttonPay.TabIndex = 29;
            this.buttonPay.Text = "Заплатить";
            this.buttonPay.UseVisualStyleBackColor = true;
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(609, 352);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(103, 39);
            this.buttonStop.TabIndex = 30;
            this.buttonStop.Text = "Отмена";
            this.buttonStop.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonPay);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBoxCVC);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBoxKartaNumber);
            this.Controls.Add(this.textBoxKarta);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Kart Skills 2017";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxKarta;
        private System.Windows.Forms.TextBox textBoxKartaNumber;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBoxCVC;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.Button buttonStop;
    }
}