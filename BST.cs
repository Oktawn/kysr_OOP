using Ccall;
using System;
using System.Collections;
using System.Windows.Input;

namespace BST
{


    class Node
    {
        private static int index = 0;
        public int idx;
        public string key;
        public CCall date;
        public Node left;
        public Node right;
        public Node()
        {
            left = right = null;
            idx = index; index++;
        }
        public Node(CCall date)
        {
            left = right = null;
            idx = index; index++;
            key = date.Numbers;
            this.date = date;
        }
    }

    class BST
    {
        private Node root;
        private int count;

        private bool is_empty() { return root == null; }

        private Node add_node(CCall call)
        {
            Node knot = new Node(call);
            count++;
            return knot;
        }
        private Node insert_node_hide(Node root, CCall call)
        {
            if (is_empty())
                root = add_node(call);
            else if (root.key.CompareTo(call.Numbers) > 0)
                root.left = insert_node_hide(root.left, call);
            else if (root.key.CompareTo(call.Numbers) <= 0)
                root.right = insert_node_hide(root.right, call);
            return root;

        }
        private Node delete_node_hide(Node root, CCall call)
        {
            if (is_empty())
                return null;
            else if (root.key.CompareTo(call.Numbers) > 0)
                root.left = delete_node_hide(root.left, call);
            else if (root.key.CompareTo(call.Numbers) <= 0)
                root.right = delete_node_hide(root.right, call);
            else
            {
                if (root.left.right == null)
                    root = null;
                else if (root.left == null)
                    root = root.right;
                else if (root.right == null)
                    root = root.left;
                else
                {
                    Node temp = root.right;
                    while (temp.left != null)
                        temp = temp.left;
                    root.key = temp.key;
                    root.right = delete_node_hide(root.right, temp.date);
                }
            }
            return root;
        }

        public BST()
        {
            root = null;
            count = 0;
        }
        public BST(CCall call)
        {
            root.date = call;
            count = 1;
        }


        public void insert(CCall call)
        {
            insert_node_hide(root, call);
        }
        public void delete_list(CCall call)
        {
            delete_node_hide(root, call);
        }

        public bool search_list(CCall call)
        {
            if (is_empty())
                return false;
            while (root != null && call.Numbers != root.key)
            {
                if (root.key.CompareTo(call.Numbers) > 0)
                    root = root.left;
                else
                    root = root.right;
            }
            if (root == null)
                return false;
            else
                return true;
        }

    }
}
