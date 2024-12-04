using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace lab03_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (FontFamily font in FontFamily.Families)
            {
                tool_font.Items.Add(font.Name);
            }
            tool_font.SelectedIndex = 0;

            tool_size.Items.AddRange(new object[] { "8", "10", "12", "14", "16", "18", "20", "24", "28", "32", "36" });
            tool_size.SelectedIndex = 2; 
        }

        private void tạoVănBảnMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn tạo văn bản mới? Mọi nội dung chưa lưu sẽ bị mất!", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                richTextBox1.Clear();
            }
        }

        private void mởTậpTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string content = File.ReadAllText(openFileDialog.FileName);
                    richTextBox1.Text = content;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi mở tệp: " + ex.Message);
                }
            }
        }

        private void lưuNộiDungVănBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(saveFileDialog.FileName, richTextBox1.Text);
                    MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu tệp: " + ex.Message);
                }
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            string selectedFont = tool_font.SelectedItem.ToString();
            Font currentFont = richTextBox1.SelectionFont;
            if (currentFont != null)
            {
                richTextBox1.SelectionFont = new Font(selectedFont, currentFont.Size, currentFont.Style);
            }
        }

        private void toolStripComboBox2_Click(object sender, EventArgs e)
        {
            float selectedSize = float.Parse(tool_size.SelectedItem.ToString());
            Font currentFont = richTextBox1.SelectionFont;
            if (currentFont != null)
            {
                richTextBox1.SelectionFont = new Font(currentFont.FontFamily, selectedSize, currentFont.Style);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Font currentFont = richTextBox1.SelectionFont;
            if (currentFont != null)
            {
                FontStyle newFontStyle = currentFont.Bold ? FontStyle.Regular : FontStyle.Bold;
                richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Font currentFont = richTextBox1.SelectionFont;
            if (currentFont != null)
            {
                FontStyle newFontStyle = currentFont.Italic ? FontStyle.Regular : FontStyle.Italic;
                richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Font currentFont = richTextBox1.SelectionFont;
            if (currentFont != null)
            {
                FontStyle newFontStyle = currentFont.Underline ? FontStyle.Regular : FontStyle.Underline;
                richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            }
        }

        private void menu_edit_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowColor = true; 

            fontDialog.Font = richTextBox1.SelectionFont ?? richTextBox1.Font;
            fontDialog.Color = richTextBox1.SelectionColor;

          
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
               
                if (richTextBox1.SelectionLength > 0) 
                {
                    richTextBox1.SelectionFont = fontDialog.Font;
                    richTextBox1.SelectionColor = fontDialog.Color;
                }
                else 
                {
                    richTextBox1.Font = fontDialog.Font;
                    richTextBox1.ForeColor = fontDialog.Color;
                }
            }
        }
    }
}
