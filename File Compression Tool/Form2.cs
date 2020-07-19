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
    public partial class Form2 : Form
    {
        classes.HuffmanCodingEncoding huffmanCodingEncoding=new classes.HuffmanCodingEncoding();
        public BitArray codeofCharacter = new BitArray(256);
        string normalText;
        static int SIZE = 256;
        String fileName_;
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
            if (openFileDialog.ShowDialog() == DialogResult.OK){ 
                fileName_ = openFileDialog.FileName;
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
                for (int j = 0; j < huffmanCodingEncoding.huffcode[i].getCode().Count; j++) {
                    codee = codee + huffmanCodingEncoding.huffcode[i].getCode()[j];
                };
                coded = coded + chara + " " + codee;
            }
            textOfFile.Text = coded;
        }

        private void showINFolderLinkLb_Click(object sender, EventArgs e)
        {
            string root = fileName_.Remove(fileName_.Length-4,4);
            string subdir = root+ @"\Compressed File";
            string ansubdir = root+ @"\Coding Scheme File";
            // If directory does not exist, create it. 
            if (!Directory.Exists(root))
            {
                Directory.CreateDirectory(root);
            }
            if (!Directory.Exists(subdir))
            {
                Directory.CreateDirectory(subdir);
            }
            if (!Directory.Exists(ansubdir))
            {
                Directory.CreateDirectory(ansubdir);
            }
            
            
            Stream astream = new FileStream(ansubdir+@"\Coding Scheme.txt", FileMode.OpenOrCreate);

            StreamWriter abw = new StreamWriter(astream);
            StreamWriter abw = new (astream);
            for(int i=0;i< huffmanCodingEncoding.an; i++)
            {
                char a = huffmanCodingEncoding.huffcode[i].getchar();
                abw.Write(a);
                abw.Write(" : ");
                BitArray arr = huffmanCodingEncoding.huffcode[i].getCode();
                foreach (bool b in arr)
                {
                    if (b == true)
                        abw.Write('1');
                    else
                        abw.Write('0');
                }
                abw.Write('\n');
            }
            abw.Flush();
            abw.Close();
            Stream stream = new FileStream(subdir + @"\compressed.txt", FileMode.OpenOrCreate);

            BinaryWriter bw = new BinaryWriter(stream);
            for (int i = 0; i < normalText.Length; ++i)
            {
                int j;
                for (j=0; j < huffmanCodingEncoding.an; ++j)
                {
                    if (normalText[i] == huffmanCodingEncoding.huffcode[j].getchar()) 
                        break;
                }
                BitArray arr = huffmanCodingEncoding.huffcode[j].getCode();
                foreach (bool b in arr)
                {
                    if (b == true)
                        bw.Write('1');
                    else
                        bw.Write('0'); 
                }
            }
            bw.Flush();
            bw.Close();
        }
    }
}

