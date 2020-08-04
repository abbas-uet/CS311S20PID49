using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Compression_Tool.classes
{
    class HuffmanCodingEncoding
    {
        //
        //All Indexes......
        public int an;//Index for huffcode array....

        //
        public Node_Class top=new Node_Class();
        public NodePriorityQue nodearr=new NodePriorityQue();
        public Huffcodes[] huffcode = new Huffcodes[128];

       
        public void makeNodes(string a, int[] fre,char[] charStr, int size)
        {
            for (int i = 0; i < size; i++)
            {
                if (charStr[i] != '0')
                {
                    Node_Class node = new Node_Class(a[i], fre[i]);
                    nodearr.add(node);
                    node = null;
                }
                
            }
        }
        public void makeNodes(char c, int fre)
        {
            Node_Class node = new Node_Class(c, fre);
            nodearr.add(node);
            node = null;
        }
        public void buildTree(NodePriorityQue nodearr)
        {
            if (nodearr.getTop() == nodearr.getTail())
            {
                top = nodearr.getTop();
                return;
            }
            else
            {
                Node_Class newnode = new Node_Class();
                newnode.left = nodearr.getmin();
                newnode.right = nodearr.getmin();
                newnode.setfrequency(newnode.left.getfrequency() + newnode.right.getfrequency());
                nodearr.add(newnode);
                buildTree(nodearr);
            }
        }
        BitArray getCorrectChar(BitArray c, int index)
        {
            BitArray a = new BitArray(index);
            for (int i = 0; i < index; i++)
            {
                a[i] = c[i];
            }
            return a;
        }
        public void Encoding(Node_Class ptr, BitArray code, int index)
        {
            if (ptr.left != null)
            {
                code[index] =false ;
                Encoding(ptr.left, code, index + 1);
            }
            if (ptr.right != null)
            {
                code[index] = true;
                Encoding(ptr.right, code, index + 1);
            }
            if (ptr.left == null && ptr.right == null)
            {
                Huffcodes newHuffcode = new Huffcodes(ptr.getcharacter(), getCorrectChar(code, index), ptr.getfrequency(),index);
                huffcode[an] = newHuffcode;
                an++;
            }
        }
        public String Decoding(Node_Class ptr, BitArray X, int size)
        {
            String decoded = "" ;
            for (int i = 0; i < size; i++)
            {
                if (ptr != null)
                {
                    if (X[i] == false)
                        ptr = ptr.left;
                    else
                        ptr = ptr.right;

                    if (ptr.left == null && ptr.right == null)
                    {
                        decoded = decoded + ptr.getcharacter();
                        ptr = top;
                    }
                }
            }
            return decoded;
        }
        public void delete()
        {
            Node_Class node = new Node_Class();
            node = nodearr.getTop();
            while (node != null)
            {
                node = top.next;
                top = null;
                top=node;
            }
        }
    }
}
