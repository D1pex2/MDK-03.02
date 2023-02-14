namespace PractWorkSIX
{
    partial class MainForm
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
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.encryptButton = new System.Windows.Forms.Button();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.updateKeyButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pathTextBox
            // 
            this.pathTextBox.BackColor = System.Drawing.Color.MintCream;
            this.pathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pathTextBox.Location = new System.Drawing.Point(12, 12);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(391, 20);
            this.pathTextBox.TabIndex = 0;
            this.pathTextBox.Text = "C:\\";
            // 
            // browseButton
            // 
            this.browseButton.BackColor = System.Drawing.Color.MintCream;
            this.browseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseButton.Location = new System.Drawing.Point(409, 11);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(77, 23);
            this.browseButton.TabIndex = 1;
            this.browseButton.Text = "Обзор...";
            this.browseButton.UseVisualStyleBackColor = false;
            this.browseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // encryptButton
            // 
            this.encryptButton.BackColor = System.Drawing.Color.MintCream;
            this.encryptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.encryptButton.Location = new System.Drawing.Point(12, 72);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(94, 23);
            this.encryptButton.TabIndex = 1;
            this.encryptButton.Text = "Зашифровать";
            this.encryptButton.UseVisualStyleBackColor = false;
            this.encryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // keyTextBox
            // 
            this.keyTextBox.BackColor = System.Drawing.Color.MintCream;
            this.keyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keyTextBox.Location = new System.Drawing.Point(280, 75);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(123, 20);
            this.keyTextBox.TabIndex = 0;
            // 
            // updateKeyButton
            // 
            this.updateKeyButton.BackColor = System.Drawing.Color.MintCream;
            this.updateKeyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateKeyButton.Location = new System.Drawing.Point(409, 73);
            this.updateKeyButton.Name = "updateKeyButton";
            this.updateKeyButton.Size = new System.Drawing.Size(77, 23);
            this.updateKeyButton.TabIndex = 1;
            this.updateKeyButton.Text = "Обновить";
            this.updateKeyButton.UseVisualStyleBackColor = false;
            this.updateKeyButton.Click += new System.EventHandler(this.UpdateKeyButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Пара открытого ключа:";
            // 
            // DecryptButton
            // 
            this.DecryptButton.BackColor = System.Drawing.Color.MintCream;
            this.DecryptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DecryptButton.Location = new System.Drawing.Point(112, 72);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(94, 23);
            this.DecryptButton.TabIndex = 3;
            this.DecryptButton.Text = "Расшифровать";
            this.DecryptButton.UseVisualStyleBackColor = false;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(498, 108);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updateKeyButton);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.pathTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "ENIGMA";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Button updateKeyButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DecryptButton;
    }
}

