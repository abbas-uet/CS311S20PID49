using OfficeOpenXml.FormulaParsing.Excel.Functions.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Compression_Tool
{
    class Node_Class
    {
        private int frequency;
        private char character;
		public Node_Class left, right, next;
	    public char getcharacter() { return this.character; }
		public int getfrequency() { return this.frequency; }
		public void setfrequency(int f) { this.frequency = f; }
		public Node_Class()
		{
			frequency = 0;
			character = '`';
			left = null;
			right = null;
			next = null;
		}
		public Node_Class(char c, int f)
		{
			frequency = f;
			character = c;
		}

	}
}
