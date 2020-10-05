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
                while (root != null)
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
                            parentNode.next = currentNode;
                        }                        
                    }
                    else if (numberToBeInserted>currentNode.data)
                    {
                        currentNode = parentNode.right;
                        if (currentNode == null)
                        {
                            parentNode.right = newNode;
                            break;
                        }
                        else
                        {
                            parentNode.next = currentNode;
                        }
                    }
                }
            }
        }
        public void Search(int numberToSearch)
        {
            Node currentNode = root;
            bool isFound = false;   
            while (isFound == false)
            {
                if (currentNode == null)
                {
                    Console.WriteLine(numberToSearch + " was not found");
                    isFound = true;
                }
                else if (numberToSearch == currentNode.data)
                {
                    Console.WriteLine(numberToSearch + " was found");
                    isFound = true;                    
                }
                else if (numberToSearch < currentNode.data)
                {
                    currentNode = currentNode.left;
                    isFound = false;
                }
                else if (numberToSearch > currentNode.data)
                {
                    currentNode = currentNode.right;
                    isFound = false;
                } 
            }
        }
    }
}
