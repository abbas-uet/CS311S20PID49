using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Compression_Tool
{
    class NodePriorityQue
    {
        private Node_Class top, tail;
        public NodePriorityQue()
        {
            top = tail = null;
        }
        public NodePriorityQue add(Node_Class ptr)
        {
			if (top == null)
			{
				if (tail != null)
				{
					tail.next = ptr;
					tail = tail.next;
				}
				else
				{
					ptr.next = null;
					tail = top = ptr;
					ptr = null;
				}
				return this;
			}
			else if (top.getfrequency() < ptr.getfrequency())
			{
				ptr.next = top;
				top = ptr;
				ptr = null;
			}else if(tail.getfrequency()>=ptr.getfrequency()){
				tail.next = ptr;
				tail.next = null;
				ptr = null;
			}
			else
			{
				Node_Class rptr = new Node_Class();
				Node_Class bptr = new Node_Class();
				rptr = bptr = top;
				while (rptr.getfrequency() >= ptr.getfrequency())
				{
					if (rptr.next == null)
					{
						bptr = rptr;
						rptr = rptr.next;
						break;
					}
					else
					{
						bptr = rptr;
						rptr = rptr.next;
					}
				}
				ptr.next = rptr;
				bptr.next = ptr;
				if (rptr == null) tail = ptr;
				ptr = null;
				rptr = bptr = null;
				return this;
			}
			return this;
        }
		public Node_Class getTop()
		{
			return top;
		}
		public Node_Class getTail()
		{
			return tail;
		}
		public Node_Class getmin()
		{
			if (top == tail)
			{
				Node_Class ptr = top;
				top = tail = null;
				return ptr;
			}
			else
			{
				Node_Class rptr = top;
				while (rptr.next != tail)
				{
					rptr = rptr.next;
				}
				Node_Class ptr = tail;
				tail = rptr;
				tail.next = null;
				ptr.next = null;
				rptr = null;
				return ptr;
			}
		}
		public void printArr()
		{
			Node_Class ptr = top;
			while (ptr!=null)
			{
				ptr.getfrequency();
				ptr = ptr.next;
			}
		}
	}
}
