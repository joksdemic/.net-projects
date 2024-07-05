using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekat1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fontBoldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Bold);
        }

        private void fontItalicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Italic);
        }

        private void fontColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = richTextBox1.ForeColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }

        private void selectFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = new Font(fontDialog1.Font.Name, fontDialog1.Font.Size);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOtvori_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
                try
                {
                    openFileDialog1.Filter = "Text files (*.txt)|*.txt|RTF files (*.rtf)|*.rtf";
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        if (Path.GetExtension(openFileDialog1.FileName) == ".rtf")
                        {
                            richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
                        }
                        else if (Path.GetExtension(openFileDialog1.FileName) == ".txt")
                        {
                            richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                        }
                    }
                    else
                    {
                        return;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("GRESKA!");
                }
        }

        private void btnPronadji_Click(object sender, EventArgs e)
        {
            try
            {
                if (richTextBox1.Text.Trim() == "")
                {
                    MessageBox.Show("Morate uneti tekst");
                    richTextBox1.Focus();
                    return;
                }

                if( txtPronadji.Text.Trim() == "")
                {
                    MessageBox.Show("Unesite teskt koji se pretrazuje:");
                    txtPronadji.Focus();
                    return;
                }
                if(txtZameni.Text.Trim() == "")
                {
                    MessageBox.Show("Unesite tekst kojim zamenjujemo");
                    txtZameni.Focus();
                    return;
                }

                string sadrzajFajla;
                sadrzajFajla = richTextBox1.Text;

                sadrzajFajla = sadrzajFajla.Replace(txtPronadji.Text, txtZameni.Text);
                richTextBox1.Text = sadrzajFajla;
            }
            catch (Exception)
            {
                MessageBox.Show("GRESKA!");
            }
        }

        private void txtPronadji_TextChanged(object sender, EventArgs e)
        {

        }

        private void txZameni_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPronadji_Click(object sender, EventArgs e)
        {

        }

        private void lblZameni_Click(object sender, EventArgs e)
        {

        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.Title = "Save";
                saveFileDialog1.Filter = "RTF|*.rtf|Text files|*.txt";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SaveFile(saveFileDialog1.FileName);
                }
                else
                {
                    return;
                }
            }
            catch
            {
                MessageBox.Show("GRESKA!");
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Escape))
            {
                Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }


            private void btnZavrsi_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
            
        }
    }
}
              

