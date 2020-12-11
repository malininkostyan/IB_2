namespace laba2
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxInputFile = new System.Windows.Forms.TextBox();
            this.textBoxEncryptFile = new System.Windows.Forms.TextBox();
            this.textBoxDecryptFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonOpenInputFile = new System.Windows.Forms.Button();
            this.buttonOpenEncryptedFile = new System.Windows.Forms.Button();
            this.buttonOpenDecryptedFyle = new System.Windows.Forms.Button();
            this.radioButtonPassword = new System.Windows.Forms.RadioButton();
            this.radioButtonPasswordFile = new System.Windows.Forms.RadioButton();
            this.buttonOpenPasswordFile = new System.Windows.Forms.Button();
            this.textBoxPasswordFile = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(16, 15);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(676, 242);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // textBoxInputFile
            // 
            this.textBoxInputFile.Enabled = false;
            this.textBoxInputFile.Location = new System.Drawing.Point(202, 283);
            this.textBoxInputFile.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxInputFile.Name = "textBoxInputFile";
            this.textBoxInputFile.ReadOnly = true;
            this.textBoxInputFile.Size = new System.Drawing.Size(379, 22);
            this.textBoxInputFile.TabIndex = 1;
            // 
            // textBoxEncryptFile
            // 
            this.textBoxEncryptFile.Enabled = false;
            this.textBoxEncryptFile.Location = new System.Drawing.Point(202, 315);
            this.textBoxEncryptFile.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEncryptFile.Name = "textBoxEncryptFile";
            this.textBoxEncryptFile.ReadOnly = true;
            this.textBoxEncryptFile.Size = new System.Drawing.Size(379, 22);
            this.textBoxEncryptFile.TabIndex = 2;
            // 
            // textBoxDecryptFile
            // 
            this.textBoxDecryptFile.Enabled = false;
            this.textBoxDecryptFile.Location = new System.Drawing.Point(202, 347);
            this.textBoxDecryptFile.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDecryptFile.Name = "textBoxDecryptFile";
            this.textBoxDecryptFile.ReadOnly = true;
            this.textBoxDecryptFile.Size = new System.Drawing.Size(379, 22);
            this.textBoxDecryptFile.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 286);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Исходный файл";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 318);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Зашифрованный файл";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 350);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Расшифорванный файл";
            // 
            // buttonOpenInputFile
            // 
            this.buttonOpenInputFile.Location = new System.Drawing.Point(590, 279);
            this.buttonOpenInputFile.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOpenInputFile.Name = "buttonOpenInputFile";
            this.buttonOpenInputFile.Size = new System.Drawing.Size(100, 28);
            this.buttonOpenInputFile.TabIndex = 7;
            this.buttonOpenInputFile.Text = "Открыть";
            this.buttonOpenInputFile.UseVisualStyleBackColor = true;
            this.buttonOpenInputFile.Click += new System.EventHandler(this.buttonOpenInputFile_Click);
            // 
            // buttonOpenEncryptedFile
            // 
            this.buttonOpenEncryptedFile.Location = new System.Drawing.Point(590, 312);
            this.buttonOpenEncryptedFile.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOpenEncryptedFile.Name = "buttonOpenEncryptedFile";
            this.buttonOpenEncryptedFile.Size = new System.Drawing.Size(100, 28);
            this.buttonOpenEncryptedFile.TabIndex = 8;
            this.buttonOpenEncryptedFile.Text = "Открыть";
            this.buttonOpenEncryptedFile.UseVisualStyleBackColor = true;
            this.buttonOpenEncryptedFile.Click += new System.EventHandler(this.buttonOpenEncryptedFile_Click);
            // 
            // buttonOpenDecryptedFyle
            // 
            this.buttonOpenDecryptedFyle.Location = new System.Drawing.Point(590, 344);
            this.buttonOpenDecryptedFyle.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOpenDecryptedFyle.Name = "buttonOpenDecryptedFyle";
            this.buttonOpenDecryptedFyle.Size = new System.Drawing.Size(100, 28);
            this.buttonOpenDecryptedFyle.TabIndex = 9;
            this.buttonOpenDecryptedFyle.Text = "Открыть";
            this.buttonOpenDecryptedFyle.UseVisualStyleBackColor = true;
            this.buttonOpenDecryptedFyle.Click += new System.EventHandler(this.buttonOpenDecryptedFyle_Click);
            // 
            // radioButtonPassword
            // 
            this.radioButtonPassword.AutoSize = true;
            this.radioButtonPassword.Checked = true;
            this.radioButtonPassword.Location = new System.Drawing.Point(17, 416);
            this.radioButtonPassword.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonPassword.Name = "radioButtonPassword";
            this.radioButtonPassword.Size = new System.Drawing.Size(78, 21);
            this.radioButtonPassword.TabIndex = 10;
            this.radioButtonPassword.TabStop = true;
            this.radioButtonPassword.Text = "Пароль";
            this.radioButtonPassword.UseVisualStyleBackColor = true;
            this.radioButtonPassword.CheckedChanged += new System.EventHandler(this.radioButtonPassword_CheckedChanged);
            // 
            // radioButtonPasswordFile
            // 
            this.radioButtonPasswordFile.AutoSize = true;
            this.radioButtonPasswordFile.Location = new System.Drawing.Point(17, 448);
            this.radioButtonPasswordFile.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonPasswordFile.Name = "radioButtonPasswordFile";
            this.radioButtonPasswordFile.Size = new System.Drawing.Size(138, 21);
            this.radioButtonPasswordFile.TabIndex = 11;
            this.radioButtonPasswordFile.Text = "Файл с паролем";
            this.radioButtonPasswordFile.UseVisualStyleBackColor = true;
            this.radioButtonPasswordFile.CheckedChanged += new System.EventHandler(this.radioButtonPasswordFile_CheckedChanged);
            // 
            // buttonOpenPasswordFile
            // 
            this.buttonOpenPasswordFile.Enabled = false;
            this.buttonOpenPasswordFile.Location = new System.Drawing.Point(590, 444);
            this.buttonOpenPasswordFile.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOpenPasswordFile.Name = "buttonOpenPasswordFile";
            this.buttonOpenPasswordFile.Size = new System.Drawing.Size(100, 28);
            this.buttonOpenPasswordFile.TabIndex = 15;
            this.buttonOpenPasswordFile.Text = "Открыть";
            this.buttonOpenPasswordFile.UseVisualStyleBackColor = true;
            this.buttonOpenPasswordFile.Click += new System.EventHandler(this.buttonOpenPasswordFile_Click);
            // 
            // textBoxPasswordFile
            // 
            this.textBoxPasswordFile.Enabled = false;
            this.textBoxPasswordFile.Location = new System.Drawing.Point(202, 446);
            this.textBoxPasswordFile.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPasswordFile.Name = "textBoxPasswordFile";
            this.textBoxPasswordFile.ReadOnly = true;
            this.textBoxPasswordFile.Size = new System.Drawing.Size(379, 22);
            this.textBoxPasswordFile.TabIndex = 13;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(202, 414);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(488, 22);
            this.textBoxPassword.TabIndex = 12;
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(16, 511);
            this.buttonEncrypt.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(164, 28);
            this.buttonEncrypt.TabIndex = 16;
            this.buttonEncrypt.Text = "Зашифровать";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(529, 511);
            this.buttonDecrypt.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(164, 28);
            this.buttonDecrypt.TabIndex = 17;
            this.buttonDecrypt.Text = "Расшифровать";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.OverwritePrompt = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 554);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.buttonOpenPasswordFile);
            this.Controls.Add(this.textBoxPasswordFile);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.radioButtonPasswordFile);
            this.Controls.Add(this.radioButtonPassword);
            this.Controls.Add(this.buttonOpenDecryptedFyle);
            this.Controls.Add(this.buttonOpenEncryptedFile);
            this.Controls.Add(this.buttonOpenInputFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDecryptFile);
            this.Controls.Add(this.textBoxEncryptFile);
            this.Controls.Add(this.textBoxInputFile);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxInputFile;
        private System.Windows.Forms.TextBox textBoxEncryptFile;
        private System.Windows.Forms.TextBox textBoxDecryptFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonOpenInputFile;
        private System.Windows.Forms.Button buttonOpenEncryptedFile;
        private System.Windows.Forms.Button buttonOpenDecryptedFyle;
        private System.Windows.Forms.RadioButton radioButtonPassword;
        private System.Windows.Forms.RadioButton radioButtonPasswordFile;
        private System.Windows.Forms.Button buttonOpenPasswordFile;
        private System.Windows.Forms.TextBox textBoxPasswordFile;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

