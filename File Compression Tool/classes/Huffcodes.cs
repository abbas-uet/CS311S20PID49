using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Compression_Tool.classes
{
    class Huffcodes
    {
		private char character;
		private BitArray code=new BitArray(256);
        private int frequency;
		public Huffcodes()
		{
			character = '`';
			code = null;
			frequency = 0;
		}
		public Huffcodes(char c, BitArray co, int fre,int s)
		{
			character = c;
			code = co;
			frequency = fre;
		}
		public BitArray getCode()
		{
			return code;
		}
		public char getchar()
		{
			return character;
		}
		public int getFrequency()
		{
			return frequency;
		}
	}
}
