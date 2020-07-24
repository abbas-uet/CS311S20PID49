using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Compression_Tool
{
    public partial class Form3 : Form
    {
        classes.Huffcodes huffcodes = new classes.Huffcodes();
        classes.HuffmanCodingEncoding huffman = new classes.HuffmanCodingEncoding();
        private String filename_;
        private String compressed_file_text;
        private String[] strings_code = new String[256];
        BitArray bitArray;
        public Form3()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            show_In_Folder_link_lb.ForeColor = Color.Red;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            show_In_Folder_link_lb.ForeColor = Color.White;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            panel3.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel2.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "TXT|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog.FileName;
                filename_ = openFileDialog.FileName;
                compressed_file_text = File.ReadAllText(openFileDialog.FileName);
                textCompresssedFile.Text = compressed_file_text;
                bitArray = new BitArray(compressed_file_text.Length);
                for (int i = 0; i < compressed_file_text.Length; i++)
                {
                    char c = compressed_file_text[i];
                    if (c == '1')
                        bitArray[i] = true;
                    else if (c == '0')
                        bitArray[i] = false;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "TXT|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = openFileDialog.FileName;
                String text = File.ReadAllText(openFileDialog.FileName);
                strings_code = File.ReadAllLines(openFileDialog.FileName);
                textCodingSchemeFile.Text = text;
            }
        }

        private void extractCodes(string[] str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                char[] chr = { ' ', ':', ' ' };
                String[] splited = str[i].Trim().Split(chr, 3, StringSplitOptions.RemoveEmptyEntries);
                huffman.makeNodes(splited[0][0], int.Parse(splited[1]));
            }
        }

        private void deCompress_Click(object sender, EventArgs e)
        {

            extractCodes(strings_code);
            huffman.buildTree(huffman.nodearr);
            huffman.Decoding(huffman.nodearr.getTop(), bitArray, bitArray.Length);
        }

        private void show_In_Folder_link_lb_Click(object sender, EventArgs e)
        {
            _ = Directory.GetDirectories(filename_.Remove(filename_.Length - 4, 4));
        }
    }
}
