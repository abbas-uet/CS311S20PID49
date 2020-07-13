using System;
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

        public void makeNodes(string a, int[] fre, int size)
        {
            for (int i = 0; i < size; i++)
            {
                if (fre[a[i]] != 0)
                {
                    Node_Class node = new Node_Class(a[i], fre[a[i]]);
                    fre[a[i]] = 0;
                    nodearr.add(node);
                    node = null;
                }
                
            }
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
        Boolean[] getCorrectChar(Boolean[] c, int index)
        {
            Boolean[] a = new Boolean[index];
            for (int i = 0; i < index; i++)
            {
                a[i] = c[i];
            }
            return a;
        }
        public void Encoding(Node_Class ptr, Boolean[] code, int index)
        {
            if (ptr.left != null)
            {
                code[index] = false;
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
        public void Decoding(Node_Class ptr, Boolean[] X, int size)
        {
            for (int i = 0; i < size; i++)
            {
                if (X[i] == false)
                    ptr = ptr.left;
                else
                    ptr = ptr.right;

                if (ptr.left == null && ptr.right == null)
                {
                    ptr = top;
                }
            }
        }
    }
}
