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

namespace File_Compression_Tool
{
    public partial class Form2 : Form
    {
        classes.HuffmanCodingEncoding huffmanCodingEncoding=new classes.HuffmanCodingEncoding();
        public Boolean[] codeofCharacter = new Boolean[256];
        string normalText;
        static int SIZE = 128;
        public Form2()
        {
            InitializeComponent();
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            showINFolderLinkLb.ForeColor = Color.Red;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            showINFolderLinkLb.ForeColor = Color.White;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel2.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel3.BackColor = Color.FromArgb(100, 0, 0, 0);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                normalText = File.ReadAllText(openFileDialog.FileName);
                textOfFile.Text = normalText;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }
        private int[] getFrequency(string str)
        {
            int[] frequecyArr = new int[SIZE];
            int n = str.Length;
            for(int i = 0; i < n; i++)
            {
                frequecyArr[str[i]]++;
            }
            return frequecyArr;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            huffmanCodingEncoding.makeNodes(normalText, getFrequency(normalText), normalText.Length);
            huffmanCodingEncoding.buildTree(huffmanCodingEncoding.nodearr);
            huffmanCodingEncoding.Encoding(huffmanCodingEncoding.top, codeofCharacter, 0);
            string coded="";
            for(int i = 0; i < huffmanCodingEncoding.an; i++)
            {
                char chara = huffmanCodingEncoding.huffcode[i].getchar();
                string codee="";
                for (int j = 0; j < huffmanCodingEncoding.huffcode[i].getSize(); j++) {
                    codee = codee + huffmanCodingEncoding.huffcode[i].getCode()[j];
                };
                coded = coded + chara + " " + codee;
            }
            textOfFile.Text = coded;
        }
    }
}
