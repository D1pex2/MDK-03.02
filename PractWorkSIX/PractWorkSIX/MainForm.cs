using PractWorkV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PractWorkSIX
{
    public partial class MainForm : Form
    {
        private Cryptograph cryptograph = new Cryptograph();
        public MainForm()
        {
            InitializeComponent();
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog ofd = new FolderBrowserDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pathTextBox.Text = ofd.SelectedPath;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            keyTextBox.Text = cryptograph.PublicKey.ToString() + ", " + cryptograph.n;
        }

        private void UpdateKeyButton_Click(object sender, EventArgs e)
        {
            cryptograph.GenerateCryptoKeys();
            keyTextBox.Text = cryptograph.PublicKey.ToString() + ", " + cryptograph.n;
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(pathTextBox.Text))
            {
                MessageBox.Show("Указанного файла не существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FolderBrowserDialog saveFileDialog = new FolderBrowserDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    foreach (var item in Directory.GetFiles(pathTextBox.Text, "*.*", SearchOption.AllDirectories))
                    {
                        var newPath = $@"{item.Replace(pathTextBox.Text, saveFileDialog.SelectedPath)}";
                        var dir = Path.GetDirectoryName(newPath);
                        if (!Directory.Exists(dir))
                        {
                            Directory.CreateDirectory(dir);
                        }
                        cryptograph.EncryptFile(item, newPath);
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(pathTextBox.Text))
            {
                MessageBox.Show("Указанного файла не существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FolderBrowserDialog saveFileDialog = new FolderBrowserDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    foreach (var item in Directory.GetFiles(pathTextBox.Text, "*.*", SearchOption.AllDirectories))
                    {
                        var newPath = $@"{item.Replace(pathTextBox.Text, saveFileDialog.SelectedPath)}";
                        var dir = Path.GetDirectoryName(newPath);
                        if (!Directory.Exists(dir))
                        {
                            Directory.CreateDirectory(dir);
                        }
                        cryptograph.DecryptFile(item, newPath);
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}
