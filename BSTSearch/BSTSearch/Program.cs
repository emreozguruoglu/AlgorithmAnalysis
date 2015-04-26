using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class BST
    {
        //BST node sınıfı yaratılıyor.
        class Node
        {
            public int data;
            public Node left;
            public Node right;
            public Node(int value)
            {
                this.data = value;
                left = null;
                right = null;
            }
        }
        class BinarySearchTree
        {
            public Node root;
            static int count;
            public BinarySearchTree()
            {
                root = null;
            }

            // BST Node'u yaratma ve geri döndürme
            public Node addNode(int data)
            {
                Node temp = new Node(data);
                if (root == null)
                    root = temp;
                count++;
                return temp;
            }

            public void insert(Node root, Node newNode)
            {
                while (root != null)
                {
                    if (newNode.data > root.data)
                    {
                        if (root.right == null)
                        {
                            root.right = newNode;
                            break;
                        }
                        root = root.right;
                    }
                    else
                    {
                        if (root.left == null)
                        {
                            root.left = newNode;
                            break;
                        }
                        root = root.left;
                    }
                }
            }
            
            public void inorder(Node root)
            {
                if (root != null)
                {
                    inorder(root.left);
                    Console.Write(root.data + " ");
                    inorder(root.right);
                }
            }
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            BinarySearchTree bst = new BinarySearchTree();
           
            // Node'ları ağaç yapımıza ekliyoruz.Random değerler alınmaktadır.
            bst.insert(bst.root, bst.addNode(rnd.Next(100)));
            bst.insert(bst.root, bst.addNode(rnd.Next(100)));
            bst.insert(bst.root, bst.addNode(rnd.Next(100)));
            bst.insert(bst.root, bst.addNode(rnd.Next(100)));
            bst.insert(bst.root, bst.addNode(rnd.Next(100)));
            bst.insert(bst.root, bst.addNode(rnd.Next(100)));
            bst.insert(bst.root, bst.addNode(rnd.Next(100)));
            bst.insert(bst.root, bst.addNode(rnd.Next(100)));
            bst.insert(bst.root, bst.addNode(rnd.Next(100)));
            bst.insert(bst.root, bst.addNode(rnd.Next(100)));

            // Düzenli şekle getirme
            bst.inorder(bst.root);

            Console.ReadKey();
        }
    }
}