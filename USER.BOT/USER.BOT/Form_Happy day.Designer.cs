﻿namespace USER.BOT
{
    partial class Form_Happy_day
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
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 11);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(704, 384);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Имя";
            this.columnHeader1.Width = 111;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "id";
            this.columnHeader2.Width = 92;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Пол";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Дата рождения";
            this.columnHeader4.Width = 102;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Можно ли отправлять пост?";
            this.columnHeader5.Width = 161;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(720, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(395, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Проверка праздника и поздравление с праздником";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(720, 84);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(395, 47);
            this.button2.TabIndex = 2;
            this.button2.Text = "Напиши текст ниже и нажми для отправки всем друзьям";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(716, 138);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(435, 256);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Сегодня был(и) поздравлен(ы): ";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(8, 100);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(95, 21);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "по кнопке";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(8, 129);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(129, 21);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.Text = "автоматически";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            this.radioButton2.Click += new System.EventHandler(this.radioButton2_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Как поздравлять?";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(7, 190);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(404, 107);
            this.textBox3.TabIndex = 11;
            this.textBox3.Text = "С Днём Рождения!!!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Текст поздравения с Днём рождения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(435, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Текст поздравения с 8 марта";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(437, 28);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(404, 107);
            this.textBox2.TabIndex = 13;
            this.textBox2.Text = "С 8 марта!!!";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(7, 16);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 47);
            this.button3.TabIndex = 15;
            this.button3.Text = "Скрыть";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(435, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Текст поздравения с 23 февраля";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(437, 209);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(404, 107);
            this.textBox4.TabIndex = 16;
            this.textBox4.Text = "С 23 февраля!!!";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.textBox9);
            this.panel1.Controls.Add(this.textBox8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(12, 401);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1270, 382);
            this.panel1.TabIndex = 18;
            this.panel1.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(435, 319);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(280, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "ссылка на фото(если надо; только из вк)";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(437, 338);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(401, 22);
            this.textBox7.TabIndex = 22;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(439, 156);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(401, 22);
            this.textBox6.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(435, 139);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(280, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "ссылка на фото(если надо; только из вк)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 319);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(280, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "ссылка на фото(если надо; только из вк)";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(8, 338);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(401, 22);
            this.textBox5.TabIndex = 18;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1169, 12);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(139, 46);
            this.button4.TabIndex = 19;
            this.button4.Text = "НАСТРОЙКИ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1169, 71);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(139, 46);
            this.button5.TabIndex = 20;
            this.button5.Text = "Как пользоваться?";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(911, 405);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 19);
            this.label8.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(860, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(243, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Текст поздравления с новым годом";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(863, 28);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(403, 107);
            this.textBox8.TabIndex = 25;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(863, 156);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(403, 22);
            this.textBox9.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(860, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(280, 17);
            this.label10.TabIndex = 27;
            this.label10.Text = "ссылка на фото(если надо; только из вк)";
            // 
            // Form_Happy_day
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1460, 818);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Happy_day";
            this.Text = "Form_Happy_day";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_Happy_day_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button5;
        public System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label9;
    }
}