using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTree
    {
        public Node root;
        public BinarySearchTree()
        {
            root = null;
        }


        public void Add(int numberToBeInserted)
        {
            Node newNode = new Node(numberToBeInserted);


            if (root == null)
            {
                root = newNode;
            }
            else
            {
                Node currentNode = root;
                Node parentNode;
                while (currentNode.next != null)
                {
                    parentNode = currentNode;
                    if (numberToBeInserted < currentNode.data)
                    {
                        currentNode = currentNode.left;
                        if (currentNode == null)
                        {
                            parentNode.left = newNode;
                            break;
                        }
                        else
                        {
                            currentNode = currentNode.right;
                            if (currentNode == null)
                            {
                                parentNode.right = newNode;
                            }
                            else
                            {
                                parentNode.right = newNode;
                                break;
                            }
                        }
                    }
                }
            }

        }
        public void Search()
        {

        }
    }
}
