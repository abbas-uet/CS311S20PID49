﻿using System;
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
    public partial class Form3 : Form
    {
        classes.Huffcodes huffcodes = new classes.Huffcodes();
        classes.HuffmanCodingEncoding huffman = new classes.HuffmanCodingEncoding();
        private String filename_;
        String Alltext;
        String root ;
        String subdir;
        private String compressed_file_text;
        private String[] strings_code = new String[256];
        BitArray bitArray;
        String deCompressedText;
        bool gotboth = false;
        bool gotone = false;
        bool decompressClick=false;
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
                gotone = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "TXT|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = openFileDialog.FileName;
                Alltext = File.ReadAllText(openFileDialog.FileName);
                strings_code = File.ReadAllLines(openFileDialog.FileName);
                textCodingSchemeFile.Text = Alltext;
            }
             gotboth = true;
        }

        private void extractCodes(string[] str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                char[] chr = { ':',':' };
                String[] splited = str[i].Split(chr, 3, StringSplitOptions.RemoveEmptyEntries);
                if (splited[0].Equals("/r")) 
                    splited[0] = "\r" ;
                else if(splited[0].Equals("/n")) 
                    splited[0] = "\n";
                huffman.makeNodes(splited[0][0], int.Parse(splited[1]));
            }
        }

        private void deCompress_Click(object sender, EventArgs e)
        {
            if (gotone==false || gotboth==false)
            {
                MessageBox.Show("Please Select the Files First!");
            }
            else
            {
                decompressClick = true;
                extractCodes(strings_code);
                huffman.buildTree(huffman.nodearr);
                deCompressedText = huffman.Decoding(huffman.nodearr.getTop(), bitArray, bitArray.Length);
                MessageBox.Show("Decompressed Successfully!");
                root = (filename_.Remove(filename_.Length - 30, 30));
                subdir = root + @"Decompressed File";
                if (!Directory.Exists(root))
                {
                    Directory.CreateDirectory(root);
                }
                if (!Directory.Exists(subdir))
                {
                    Directory.CreateDirectory(subdir);
                }
                Stream astream = new FileStream(subdir + @"\Decompressed Text.txt", FileMode.OpenOrCreate);
                StreamWriter abw = new StreamWriter(astream);
                foreach (char i in deCompressedText)
                {
                    abw.Write(i);
                }
                abw.Flush();
                abw.Close();
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


private void show_In_Folder_link_lb_Click(object sender, EventArgs e)
        {
   
            OpenFolder(subdir);
        }

        private void merge_Click(object sender, EventArgs e)
        {
            if (decompressClick == true)
            {

                string asubdir = subdir + @"\Bonus Task";
                // If directory does not exist, create it. 
                if (!Directory.Exists(subdir))
                {
                    Directory.CreateDirectory(subdir);
                }
                if (!Directory.Exists(asubdir))
                {
                    Directory.CreateDirectory(asubdir);
                }


                Stream astream = new FileStream(asubdir + @"\Bonus Task.txt", FileMode.OpenOrCreate);

                StreamWriter abw = new StreamWriter(astream);
                abw.Write(Alltext);

                abw.Write("----------------------------\n");
                abw.Write(compressed_file_text);

                abw.Flush();
                abw.Close();
                OpenFolder(subdir);
            }
            else
            {
                MessageBox.Show("Please Decompress it First!");
            }
        }
            
    }
    }

