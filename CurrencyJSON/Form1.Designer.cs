﻿namespace CurrencyJSON
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
            this.Refresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.url = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtIn = new System.Windows.Forms.TextBox();
            this.listFromTo = new System.Windows.Forms.ComboBox();
            this.listInTo = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(510, 18);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(84, 26);
            this.Refresh.TabIndex = 0;
            this.Refresh.TabStop = false;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "The exchange rate is taken from";
            // 
            // url
            // 
            this.url.AutoSize = true;
            this.url.Location = new System.Drawing.Point(304, 31);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(200, 13);
            this.url.TabIndex = 2;
            this.url.Text = "https://www.cbr-xml-daily.ru/daily_json.js";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listInTo);
            this.groupBox1.Controls.Add(this.listFromTo);
            this.groupBox1.Controls.Add(this.txtIn);
            this.groupBox1.Controls.Add(this.txtFrom);
            this.groupBox1.Location = new System.Drawing.Point(38, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 154);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Converter";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(6, 72);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(111, 20);
            this.txtFrom.TabIndex = 5;
            // 
            // txtIn
            // 
            this.txtIn.Location = new System.Drawing.Point(214, 72);
            this.txtIn.Name = "txtIn";
            this.txtIn.Size = new System.Drawing.Size(119, 20);
            this.txtIn.TabIndex = 6;
            // 
            // listFromTo
            // 
            this.listFromTo.FormattingEnabled = true;
            this.listFromTo.Location = new System.Drawing.Point(6, 19);
            this.listFromTo.Name = "listFromTo";
            this.listFromTo.Size = new System.Drawing.Size(181, 21);
            this.listFromTo.TabIndex = 7;
            // 
            // listInTo
            // 
            this.listInTo.FormattingEnabled = true;
            this.listInTo.Location = new System.Drawing.Point(214, 19);
            this.listInTo.Name = "listInTo";
            this.listInTo.Size = new System.Drawing.Size(180, 21);
            this.listInTo.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.url);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Refresh);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private new System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label url;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtIn;
        private System.Windows.Forms.ComboBox listFromTo;
        private System.Windows.Forms.ComboBox listInTo;
    }
}

