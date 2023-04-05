using Ccall;

namespace BST_three
{
    internal class Node
    {
        private static int index = 0;
        public int idx;
        public string key;
        public CCall date;
        public Node left, right;
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
            left = right = null;
        }
    }

    class BST
    {
        private Node root;
        private short count;

        private bool is_empty() { return root == null; }

        private Node add_node(CCall call)
        {
            Node knot = new Node(call);
            count++;
            return knot;
        }
        private Node insert_hide(Node root, CCall call)
        {
            if (is_empty())
                root = add_node(call);
            else if (root.key.CompareTo(call.Numbers) > 0)
                root.left = insert_hide(root.left, call);
            else if (root.key.CompareTo(call.Numbers) <= 0)
                root.right = insert_hide(root.right, call);
            return root;

        }
        private Node delete_hide(Node root, CCall call)
        {
            if (is_empty())
                return null;
            else if (root.key.CompareTo(call.Numbers) > 0)
                root.left = delete_hide(root.left, call);
            else if (root.key.CompareTo(call.Numbers) <= 0)
                root.right = delete_hide(root.right, call);
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
                    root.right = delete_hide(root.right, temp.date);
                }
            }
            return root;
        }

        public BST()
        {
            root = null;
            count = 0;
        }

        public void insert(CCall call)
        {
            root = insert_hide(root, call);
        }
        public void delete_list(CCall call)
        {
            delete_hide(root, call);
        }

        private bool search_list(Node root, CCall call)
        {
            if (is_empty())
                return false;
            if (root.key == call.Numbers)
                return true;
            if (call.Numbers.CompareTo(root.key) < 0)
                return search_list(root.left, call);
            else if (root.key.CompareTo(call.Numbers) <= 0)
                return search_list(root.right, call);
            return false;
        }
        public bool search_list(CCall call)
        { return search_list(root, call); }
        public Node GetNode(Node root, string key)
        {
            if (is_empty())
                return null;
            else if (key.CompareTo(root.key) < 0)
                return GetNode(root.left, key);
            else if (key.CompareTo(root.key) > 0)
                return GetNode(root.right, key);
            return root;
        }

        public Node get_root()
        {
            return root;
        }
        public short size() 
        {
            return count;
        }
    }
}
