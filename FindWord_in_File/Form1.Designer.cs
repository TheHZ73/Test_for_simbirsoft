namespace FindWord_in_File
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CreateDocButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.OpenDict = new System.Windows.Forms.Button();
            this.PuthDictionary = new System.Windows.Forms.Label();
            this.OpenProvFail = new System.Windows.Forms.Button();
            this.PuthTestFile = new System.Windows.Forms.Label();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.KolStrokHtml = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.ProcessBigFile = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.KolStrokHtml)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateDocButton
            // 
            this.CreateDocButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateDocButton.Location = new System.Drawing.Point(25, 282);
            this.CreateDocButton.Name = "CreateDocButton";
            this.CreateDocButton.Size = new System.Drawing.Size(480, 23);
            this.CreateDocButton.TabIndex = 0;
            this.CreateDocButton.Text = "Сформировать HTML-документ";
            this.CreateDocButton.UseVisualStyleBackColor = true;
            this.CreateDocButton.Click += new System.EventHandler(this.CreateDocButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // OpenDict
            // 
            this.OpenDict.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenDict.Location = new System.Drawing.Point(20, 109);
            this.OpenDict.Name = "OpenDict";
            this.OpenDict.Size = new System.Drawing.Size(166, 42);
            this.OpenDict.TabIndex = 1;
            this.OpenDict.Text = "Выбрать словарь";
            this.OpenDict.UseVisualStyleBackColor = true;
            this.OpenDict.Click += new System.EventHandler(this.OpenDict_Click);
            // 
            // PuthDictionary
            // 
            this.PuthDictionary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PuthDictionary.AutoSize = true;
            this.PuthDictionary.Location = new System.Drawing.Point(22, 166);
            this.PuthDictionary.Name = "PuthDictionary";
            this.PuthDictionary.Size = new System.Drawing.Size(0, 13);
            this.PuthDictionary.TabIndex = 2;
            // 
            // OpenProvFail
            // 
            this.OpenProvFail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenProvFail.Location = new System.Drawing.Point(20, 12);
            this.OpenProvFail.Name = "OpenProvFail";
            this.OpenProvFail.Size = new System.Drawing.Size(166, 42);
            this.OpenProvFail.TabIndex = 3;
            this.OpenProvFail.Text = "Выбрать проверяемый файл";
            this.OpenProvFail.UseVisualStyleBackColor = true;
            this.OpenProvFail.Click += new System.EventHandler(this.PutProvFail_Click);
            // 
            // PuthTestFile
            // 
            this.PuthTestFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PuthTestFile.AutoSize = true;
            this.PuthTestFile.Location = new System.Drawing.Point(22, 69);
            this.PuthTestFile.Name = "PuthTestFile";
            this.PuthTestFile.Size = new System.Drawing.Size(0, 13);
            this.PuthTestFile.TabIndex = 4;
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // KolStrokHtml
            // 
            this.KolStrokHtml.Location = new System.Drawing.Point(25, 241);
            this.KolStrokHtml.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.KolStrokHtml.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.KolStrokHtml.Name = "KolStrokHtml";
            this.KolStrokHtml.Size = new System.Drawing.Size(129, 20);
            this.KolStrokHtml.TabIndex = 5;
            this.KolStrokHtml.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Количество строк в формируемых html файлах";
            // 
            // ProcessBigFile
            // 
            this.ProcessBigFile.AutoSize = true;
            this.ProcessBigFile.Checked = true;
            this.ProcessBigFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ProcessBigFile.Location = new System.Drawing.Point(253, 55);
            this.ProcessBigFile.Name = "ProcessBigFile";
            this.ProcessBigFile.Size = new System.Drawing.Size(184, 17);
            this.ProcessBigFile.TabIndex = 8;
            this.ProcessBigFile.Text = "Обрабатывать большие файлы";
            this.ProcessBigFile.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 338);
            this.Controls.Add(this.ProcessBigFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KolStrokHtml);
            this.Controls.Add(this.PuthTestFile);
            this.Controls.Add(this.OpenProvFail);
            this.Controls.Add(this.PuthDictionary);
            this.Controls.Add(this.OpenDict);
            this.Controls.Add(this.CreateDocButton);
            this.MinimumSize = new System.Drawing.Size(533, 376);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.KolStrokHtml)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateDocButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button OpenDict;
        private System.Windows.Forms.Label PuthDictionary;
        private System.Windows.Forms.Button OpenProvFail;
        private System.Windows.Forms.Label PuthTestFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.NumericUpDown KolStrokHtml;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ProcessBigFile;
    }
}

