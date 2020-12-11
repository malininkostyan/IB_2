using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace laba2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonOpenInputFile_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = null;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxInputFile.Text = openFileDialog.FileName;
            }
        }

        private void buttonOpenEncryptedFile_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = null;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxEncryptFile.Text = saveFileDialog.FileName;
            }
        }

        private void buttonOpenDecryptedFyle_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = null;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxDecryptFile.Text = saveFileDialog.FileName;
            }
        }

        private void buttonOpenPasswordFile_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = null;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxPasswordFile.Text = openFileDialog.FileName;
            }
        }

        private void radioButtonPassword_CheckedChanged(object sender, EventArgs e)
        {
            updateTextBoxesPassword();
        }

        private void radioButtonPasswordFile_CheckedChanged(object sender, EventArgs e)
        {
            updateTextBoxesPassword();
        }

        private void updateTextBoxesPassword()
        {
            buttonOpenPasswordFile.Enabled = radioButtonPasswordFile.Checked;
            textBoxPassword.Enabled = radioButtonPassword.Checked;
            textBoxPassword.ReadOnly = !radioButtonPassword.Checked;
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            string sourceFile = textBoxInputFile.Text;
            if (sourceFile == null || sourceFile == "")
            {
                MessageBox.Show(this, "Не выбран исходный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string encodedFile = textBoxEncryptFile.Text;
            if (encodedFile == null || encodedFile == "")
            {
                MessageBox.Show(this, "Не выбран зашифрованный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string password = ExtractPassword();
            if (password == null)
            {
                return;
            }
            try
            {
                ECB ecb = new ECB();
                ecb.Encrypt(sourceFile, encodedFile, password);

                Process.Start(encodedFile);

                MessageBox.Show(this, "Файл зашифрован", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            string encodedFile = textBoxEncryptFile.Text;
            if (encodedFile == null || encodedFile == "")
            {
                MessageBox.Show(this, "Не выбран зашифрованный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string decodedFile = textBoxDecryptFile.Text;
            if (decodedFile == null || decodedFile == "")
            {
                MessageBox.Show(this, "Не выбран расшифрованный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string password = ExtractPassword();
            if (password == null)
            {
                return;
            }
            try
            {
                ECB ecb = new ECB();
                ecb.Decrypt(encodedFile, decodedFile, password);
            
                Process.Start(decodedFile);

                MessageBox.Show(this, "Файл расшифрован", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ExtractPassword()
        {
            string password;
            if (radioButtonPassword.Checked)
            {
                password = textBoxPassword.Text;
                if (password == null || password == "")
                {
                    MessageBox.Show(this, "Не указан пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
            else
            {
                string passwordFile = textBoxPasswordFile.Text;
                if (passwordFile == null || passwordFile == "")
                {
                    MessageBox.Show(this, "Не выбран файл с паролем", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                try
                {
                    password = File.ReadAllText(passwordFile, Encoding.UTF8);
                }
                catch (Exception e)
                {
                    MessageBox.Show(this, "Ошибка загрузки пароля из файла:\n" + e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                if (password == null || password == "")
                {
                    MessageBox.Show(this, "В файле не указан пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
            return password;
        }
    }
}
