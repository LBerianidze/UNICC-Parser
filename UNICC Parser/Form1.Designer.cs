namespace UNICC_Parser
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.richTextBox2 = new System.Windows.Forms.RichTextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.accountsRichTextBox = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.rucaptchaApiKeyTextBox = new System.Windows.Forms.TextBox();
			this.start = new System.Windows.Forms.Button();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.richTextBox3 = new System.Windows.Forms.RichTextBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.richTextBox4 = new System.Windows.Forms.RichTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.showInExplorerButton = new System.Windows.Forms.Button();
			this.parseForLastNDaysRadio = new System.Windows.Forms.RadioButton();
			this.parseFromRadio = new System.Windows.Forms.RadioButton();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.parseAllRadio = new System.Windows.Forms.RadioButton();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.groupBox1.Controls.Add(this.groupBox3);
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.groupBox1.Location = new System.Drawing.Point(1, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(478, 422);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Исходные данные";
			// 
			// groupBox3
			// 
			this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.groupBox3.Controls.Add(this.richTextBox2);
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.groupBox3.Location = new System.Drawing.Point(240, 18);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(232, 402);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Прокси";
			// 
			// richTextBox2
			// 
			this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBox2.Location = new System.Drawing.Point(3, 19);
			this.richTextBox2.Name = "richTextBox2";
			this.richTextBox2.Size = new System.Drawing.Size(226, 380);
			this.richTextBox2.TabIndex = 0;
			this.richTextBox2.Text = "103.77.23.149:59311\n103.77.23.149:59311\n103.77.23.149:59311\n103.77.23.149:59311";
			this.richTextBox2.WordWrap = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.groupBox2.Controls.Add(this.accountsRichTextBox);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.groupBox2.Location = new System.Drawing.Point(4, 18);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(232, 402);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Аккаунты";
			// 
			// accountsRichTextBox
			// 
			this.accountsRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.accountsRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.accountsRichTextBox.Location = new System.Drawing.Point(3, 19);
			this.accountsRichTextBox.Name = "accountsRichTextBox";
			this.accountsRichTextBox.Size = new System.Drawing.Size(226, 380);
			this.accountsRichTextBox.TabIndex = 0;
			this.accountsRichTextBox.Text = "mengmage:lh149zlm581";
			this.accountsRichTextBox.WordWrap = false;
			this.accountsRichTextBox.TextChanged += new System.EventHandler(this.accountsRichTextBox_TextChanged);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.label1.Location = new System.Drawing.Point(1, 429);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 18);
			this.label1.TabIndex = 1;
			this.label1.Text = "Ключ API:";
			// 
			// rucaptchaApiKeyTextBox
			// 
			this.rucaptchaApiKeyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.rucaptchaApiKeyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.rucaptchaApiKeyTextBox.Location = new System.Drawing.Point(79, 427);
			this.rucaptchaApiKeyTextBox.Name = "rucaptchaApiKeyTextBox";
			this.rucaptchaApiKeyTextBox.Size = new System.Drawing.Size(399, 23);
			this.rucaptchaApiKeyTextBox.TabIndex = 2;
			this.rucaptchaApiKeyTextBox.Text = "eed3b729d0e4dab7b9068c4325399557";
			this.rucaptchaApiKeyTextBox.TextChanged += new System.EventHandler(this.rucaptchaApiKeyTextBox_TextChanged);
			// 
			// start
			// 
			this.start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.start.AutoSize = true;
			this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.start.Location = new System.Drawing.Point(8, 536);
			this.start.Name = "start";
			this.start.Size = new System.Drawing.Size(471, 27);
			this.start.TabIndex = 3;
			this.start.Text = "Начать парсинг";
			this.start.UseVisualStyleBackColor = true;
			this.start.Click += new System.EventHandler(this.start_Click);
			// 
			// groupBox4
			// 
			this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.groupBox4.Controls.Add(this.richTextBox3);
			this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.groupBox4.Location = new System.Drawing.Point(485, 2);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(260, 647);
			this.groupBox4.TabIndex = 4;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Успешно обработано";
			// 
			// richTextBox3
			// 
			this.richTextBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBox3.Location = new System.Drawing.Point(3, 19);
			this.richTextBox3.Name = "richTextBox3";
			this.richTextBox3.Size = new System.Drawing.Size(254, 625);
			this.richTextBox3.TabIndex = 1;
			this.richTextBox3.Text = "";
			this.richTextBox3.WordWrap = false;
			// 
			// groupBox5
			// 
			this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.groupBox5.Controls.Add(this.richTextBox4);
			this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.groupBox5.Location = new System.Drawing.Point(748, 2);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(260, 647);
			this.groupBox5.TabIndex = 5;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Не удалось обработать";
			// 
			// richTextBox4
			// 
			this.richTextBox4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBox4.Location = new System.Drawing.Point(3, 19);
			this.richTextBox4.Name = "richTextBox4";
			this.richTextBox4.Size = new System.Drawing.Size(254, 625);
			this.richTextBox4.TabIndex = 1;
			this.richTextBox4.Text = "";
			this.richTextBox4.WordWrap = false;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.label2.Location = new System.Drawing.Point(1, 565);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(128, 18);
			this.label2.TabIndex = 6;
			this.label2.Text = "Всего аккаунтов:";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.label3.Location = new System.Drawing.Point(127, 565);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(16, 18);
			this.label3.TabIndex = 7;
			this.label3.Text = "0";
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.label4.Location = new System.Drawing.Point(127, 583);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(16, 18);
			this.label4.TabIndex = 9;
			this.label4.Text = "0";
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.label5.Location = new System.Drawing.Point(1, 583);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(99, 18);
			this.label5.TabIndex = 8;
			this.label5.Text = "Обработано:";
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.label6.Location = new System.Drawing.Point(435, 583);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(16, 18);
			this.label6.TabIndex = 13;
			this.label6.Text = "0";
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.label7.Location = new System.Drawing.Point(250, 584);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(179, 18);
			this.label7.TabIndex = 12;
			this.label7.Text = "Не удалось обработать:";
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.label8.Location = new System.Drawing.Point(435, 565);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(16, 18);
			this.label8.TabIndex = 11;
			this.label8.Text = "0";
			// 
			// label9
			// 
			this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.label9.Location = new System.Drawing.Point(267, 566);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(162, 18);
			this.label9.TabIndex = 10;
			this.label9.Text = "Успешно обработано:";
			// 
			// label10
			// 
			this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.label10.Location = new System.Drawing.Point(175, 601);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(16, 18);
			this.label10.TabIndex = 15;
			this.label10.Text = "0";
			// 
			// label11
			// 
			this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.label11.Location = new System.Drawing.Point(1, 601);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(173, 18);
			this.label11.TabIndex = 14;
			this.label11.Text = "Всего скачано файлов:";
			// 
			// showInExplorerButton
			// 
			this.showInExplorerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.showInExplorerButton.AutoSize = true;
			this.showInExplorerButton.Enabled = false;
			this.showInExplorerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.showInExplorerButton.Location = new System.Drawing.Point(3, 622);
			this.showInExplorerButton.Name = "showInExplorerButton";
			this.showInExplorerButton.Size = new System.Drawing.Size(187, 27);
			this.showInExplorerButton.TabIndex = 16;
			this.showInExplorerButton.Text = "Показать файл";
			this.showInExplorerButton.UseVisualStyleBackColor = true;
			this.showInExplorerButton.Click += new System.EventHandler(this.showInExplorerButton_Click);
			// 
			// parseForLastNDaysRadio
			// 
			this.parseForLastNDaysRadio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.parseForLastNDaysRadio.AutoSize = true;
			this.parseForLastNDaysRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.parseForLastNDaysRadio.Location = new System.Drawing.Point(3, 483);
			this.parseForLastNDaysRadio.Name = "parseForLastNDaysRadio";
			this.parseForLastNDaysRadio.Size = new System.Drawing.Size(247, 22);
			this.parseForLastNDaysRadio.TabIndex = 17;
			this.parseForLastNDaysRadio.Text = "Спарсить за последние N дней:";
			this.parseForLastNDaysRadio.UseVisualStyleBackColor = true;
			// 
			// parseFromRadio
			// 
			this.parseFromRadio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.parseFromRadio.AutoSize = true;
			this.parseFromRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.parseFromRadio.Location = new System.Drawing.Point(3, 508);
			this.parseFromRadio.Name = "parseFromRadio";
			this.parseFromRadio.Size = new System.Drawing.Size(168, 22);
			this.parseFromRadio.TabIndex = 18;
			this.parseFromRadio.Text = "Спарсить начиная с:";
			this.parseFromRadio.UseVisualStyleBackColor = true;
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.numericUpDown1.Location = new System.Drawing.Point(251, 485);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(44, 24);
			this.numericUpDown1.TabIndex = 19;
			this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.dateTimePicker1.Location = new System.Drawing.Point(251, 510);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 24);
			this.dateTimePicker1.TabIndex = 20;
			// 
			// parseAllRadio
			// 
			this.parseAllRadio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.parseAllRadio.AutoSize = true;
			this.parseAllRadio.Checked = true;
			this.parseAllRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.parseAllRadio.Location = new System.Drawing.Point(4, 457);
			this.parseAllRadio.Name = "parseAllRadio";
			this.parseAllRadio.Size = new System.Drawing.Size(120, 22);
			this.parseAllRadio.TabIndex = 21;
			this.parseAllRadio.TabStop = true;
			this.parseAllRadio.Text = "Спарсить все";
			this.parseAllRadio.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(1012, 651);
			this.Controls.Add(this.parseAllRadio);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.parseFromRadio);
			this.Controls.Add(this.parseForLastNDaysRadio);
			this.Controls.Add(this.showInExplorerButton);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.start);
			this.Controls.Add(this.rucaptchaApiKeyTextBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(1920, 1080);
			this.MinimumSize = new System.Drawing.Size(1028, 250);
			this.Name = "Form1";
			this.Text = "UNICC Parser";
			this.groupBox1.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox accountsRichTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rucaptchaApiKeyTextBox;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox richTextBox3;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.RichTextBox richTextBox4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Button showInExplorerButton;
		private System.Windows.Forms.RadioButton parseForLastNDaysRadio;
		private System.Windows.Forms.RadioButton parseFromRadio;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.RadioButton parseAllRadio;
	}
}

