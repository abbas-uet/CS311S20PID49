File Compression Tool

Pseudo Code:
The Pseudo code of File Compression Tool consists of Three Parts.

•	Huffman Tree Build
•	Encoding of the String of character
•	Decoding of the string of bits

Huffman Tree Build

The Huffman Tree Build Pseudo code is as given as:

It takes an NodesArray A Priority Que having minimum at the top and maximum at the end of the Priority Que as Input of Nodes having Frequency ,Character and data and returns the Pointer to top of the Array.


 HuffmanTree(nodearr) 
 
		if (nodearr.First == nodearr.Tail) 
			
			top = nodearr.getTop
			
			return
			
		else 
			node = new HeapNode
			
			newnode->left = nodearr.getmin()
			
			newnode->right = nodearr.getmin()
			
                        newnode->setfrequency(newnode->left->getfrequency() + newnode->right->getfrequency())
			
			nodearr.add(newnode)
			
			HuffmanTree(nodearr)



Encoding

The Encoding of the String Pseudo Code is given as:

It takes two Input from top of the tree and string X and Index and give an array of node containing information of coding scheme file


Encode(root,X,index ) 

if (root->left) 

     X[index] = '0'
     
     Encode(root->left, X, index + 1)

if (root->right)

     X[index] = '1'
     
     Encode(root->right, X, index + 1)

if (!root->left && !root->right)

newHuffNode = new Huffcodes(root->getcharacter(),code, root->getfrequency())       //new node containg information of character.

huffcode[codeindex] = newHuffcode;                    // array containing info of coding scheme information of characters.

codeIndex++;                                         //index of array containg coding scheme information of character.

//Decoding

//It will take a root node of Huffman tree and String of Binary Bits as an Input and gives the Original String (Decoded String) as an Output.

Decode(root,X) 

for (i = 0 to X.size)
	
	if (X[i] == '0')
	
		root = root->left;
	
	else
		root = root->right;

	if (root->left == NULL and root->right == NULL)
	
		cout<<root->getcharacter();
		
		root= top;
