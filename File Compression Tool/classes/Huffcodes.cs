using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Compression_Tool.classes
{
    class Huffcodes
    {
        private char character;
		private int size;
        private Boolean[] code=new Boolean[256];
        private int frequency;
		public Huffcodes()
		{
			size = 0;
			character = '`';
			code = null;
			frequency = 0;
		}
		public Huffcodes(char c, Boolean[] co, int fre,int s)
		{
			size = s;
			character = c;
			code = co;
			frequency = fre;
		}
		public Boolean[] getCode()
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
		public int getSize()
		{
			return size;
		}
	}
}
