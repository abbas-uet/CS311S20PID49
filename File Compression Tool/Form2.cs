using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        char [] charString;
        String sequence;
        String fileName_;
        string root;
        string subdir;
        string ansubdir;
        bool compressClick = false;
        bool getFiles = false;
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
            openFileDialog.Filter = "TXT|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog.FileName;
                fileName_ = openFileDialog.FileName;
                normalText = File.ReadAllText(openFileDialog.FileName);
                textOfFile.Text = normalText;
                getFiles = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            huffmanCodingEncoding.delete();
            huffmanCodingEncoding = null;
            this.Hide();
            new Form1().Show();
        }
        private int[] getFrequency(string str)
        {
            int [] frequecyArr = new int[str.Length];
            int i, j;

            //Converts given string into character array  
            charString = str.ToCharArray();

            for (i = 0; i < str.Length; i++)
            {
                frequecyArr[i] = 1;
                for (j = i + 1; j < str.Length; j++)
                {
                    if (charString[i] == charString[j])
                    {
                        frequecyArr[i]++;

                        //Set string[j] to 0 to avoid printing visited character  
                        charString[j] = '0';
                    }
                }
            }
            return frequecyArr;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (getFiles==false)
            {
                MessageBox.Show("Please Select a File First!");
            }
            else
            {
                compressClick = true;
                huffmanCodingEncoding.makeNodes(normalText, getFrequency(normalText), charString, normalText.Length);
                sequence = huffmanCodingEncoding.getSequence(huffmanCodingEncoding.nodearr);
                huffmanCodingEncoding.buildTree(huffmanCodingEncoding.nodearr);
                huffmanCodingEncoding.Encoding(huffmanCodingEncoding.top, codeofCharacter, 0);
                string coded = "";
                for (int i = 0; i < huffmanCodingEncoding.an; i++)
                {
                    char chara = huffmanCodingEncoding.huffcode[i].getchar();
                    string codee = "";
                    for (int j = 0; j < huffmanCodingEncoding.huffcode[i].getCode().Count; j++)
                    {
                        codee = codee + huffmanCodingEncoding.huffcode[i].getCode()[j];
                    };
                    coded = coded + chara + " " + codee;
                }
                MessageBox.Show("Compressed Succesfully!");
                root = fileName_.Remove(fileName_.Length - 4, 4);
                subdir = root + @"\Compressed File";
                ansubdir = root + @"\Coding Scheme File";
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


                Stream astream = new FileStream(ansubdir + @"\Coding Scheme.txt", FileMode.OpenOrCreate);

                StreamWriter abw = new StreamWriter(astream);
                for (int ab = 0; ab < sequence.Length; ab++)
                {

                    for (int i = 0; i < huffmanCodingEncoding.an; i++)
                    {
                        if (sequence[ab] == huffmanCodingEncoding.huffcode[i].getchar())
                        {
                            char a = huffmanCodingEncoding.huffcode[i].getchar();
                            if (a.Equals('\r'))
                                abw.Write("/r");
                            else if (a.Equals('\n'))
                                abw.Write("/n");
                            else
                                abw.Write(a);
                            abw.Write("::");
                            int f = huffmanCodingEncoding.huffcode[i].getFrequency();
                            abw.Write(f);
                            abw.Write("::");
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
                    }
                }
                abw.Flush();
                abw.Close();
                Stream stream = new FileStream(subdir + @"\compressed.txt", FileMode.OpenOrCreate);

                BinaryWriter bw = new BinaryWriter(stream);
                for (int i = 0; i < normalText.Length; ++i)
                {
                    int j;
                    for (j = 0; j < huffmanCodingEncoding.an; ++j)
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

        private void OpenFolder(string folderPath)
        {
            if (Directory.Exists(folderPath))
            {
                var psi = new ProcessStartInfo();
                psi.FileName = @"c:\windows\system32\explorer.exe";
                psi.Arguments = folderPath;
                Process.Start(psi);
            }
            else
            {
                MessageBox.Show(string.Format("{0} Directory does not exist!", folderPath));
            }
        }

        private void showINFolderLinkLb_Click(object sender, EventArgs e)
        {
            OpenFolder(root);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void mergeButton_Click(object sender, EventArgs e)
        {
            if (compressClick == true)
            {

                string aroot = fileName_.Remove(fileName_.Length - 4, 4);
                string aSubDir = aroot + @"\Bonus Task";
                // If directory does not exist, create it. 
                if (!Directory.Exists(aroot))
                {
                    Directory.CreateDirectory(aroot);
                }
                if (!Directory.Exists(aSubDir))
                {
                    Directory.CreateDirectory(aSubDir);
                }


                Stream astream = new FileStream(aSubDir + @"\Bonus Task.txt", FileMode.OpenOrCreate);

                StreamWriter abw = new StreamWriter(astream);
                for (int ab = 0; ab < sequence.Length; ab++)
                {

                    for (int i = 0; i < huffmanCodingEncoding.an; i++)
                    {
                        if (sequence[ab] == huffmanCodingEncoding.huffcode[i].getchar())
                        {
                            char a = huffmanCodingEncoding.huffcode[i].getchar();
                            if (a.Equals('\r'))
                                abw.Write("/r");
                            else if (a.Equals('\n'))
                                abw.Write("/n");
                            else
                                abw.Write(a);
                            abw.Write("::");
                            int f = huffmanCodingEncoding.huffcode[i].getFrequency();
                            abw.Write(f);
                            abw.Write("::");
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
                    }
                }

                abw.Write("----------------------------\n");
                for (int i = 0; i < normalText.Length; ++i)
                {
                    int j;
                    for (j = 0; j < huffmanCodingEncoding.an; ++j)
                    {
                        if (normalText[i] == huffmanCodingEncoding.huffcode[j].getchar())
                            break;
                    }
                    BitArray arr = huffmanCodingEncoding.huffcode[j].getCode();
                    foreach (bool b in arr)
                    {
                        if (b == true)
                            abw.Write('1');
                        else
                            abw.Write('0');
                    }
                }

                abw.Flush();
                abw.Close();
                OpenFolder(aroot);
            }
            else
            {
                MessageBox.Show("Please Compress the File First!");
            }
        }

    }

}

