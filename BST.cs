using Ccall;

namespace BST_three
{
    public class Node<T> where T : CCall
    {
        public string key;
        public T date;
        public Node<T> left, right;
        public Node()
        {
            left = right = null;
        }
        public Node(T date)
        {
            left = right = null;
            key = date.Numbers;
            this.date = date;
            left = right = null;
        }
    }

    public class BST<T> where T : CCall
    {
        private Node<T> root;
        private short count;

        private bool is_empty(Node<T> root) { return root == null; }

        private Node<T> Add_node(T call)
        {
            Node<T> knot = new Node<T>(call);
            count++;
            return knot;
        }
        private Node<T> Insert_hide(Node<T> root, T call)
        {
            if (is_empty(root))
                root = Add_node(call);
            else if (root.key.CompareTo(call.Numbers) < 0)
                root.left = Insert_hide(root.left, call);
            else if (root.key.CompareTo(call.Numbers) >= 0)
                root.right = Insert_hide(root.right, call);
            return root;

        }
        private Node<T> Delete_hide(Node<T> root, T call)
        {
            if (is_empty(root))
                return null;
            else if (root.key.CompareTo(call) < 0)
                root.left = Delete_hide(root.left, call);
            else if (root.key.CompareTo(call) >= 0)
                root.right = Delete_hide(root.right, call);
            else
            {
                if (root.left == null)
                    return root.right;
                else if (root.right == null)
                    return root.left;

                Node<T> temp = Find_min(root.right);
                root.key = temp.key;
                root.right = Delete_hide(root.right, temp.date);
            }
            return root;
        }
        private Node<T> Find_min(Node<T> node)
        {
            while (node.left != null)
                node = node.left;
            return node;
        }

        public BST()
        {
            root = null;
            count = 0;
        }

        public void Insert(T call)
        {
            root = Insert_hide(root, call);
        }
        public void Delete_list(T call)
        {
            Delete_hide(root, call);
        }

        private bool Search_list(Node<T> root, T call)
        {
            if (root == null)
                return false;
            if (root.key.Equals(call.Numbers))
                return true;
            if (root.key.CompareTo(call.Numbers) < 0)
                return Search_list(root.left, call);
            else
                return Search_list(root.right, call);
        }
        public bool Search_list(T call)
        { return Search_list(root, call); }
        public Node<T> GetNode(Node<T> root, string key)
        {
            if (is_empty(root))
                return null;
            else if (key.CompareTo(root.key) < 0)
                return GetNode(root.left, key);
            else if (key.CompareTo(root.key) > 0)
                return GetNode(root.right, key);
            return root;
        }

        public Node<T> Get_root()
        {
            return root;
        }
        public short Size()
        {
            return count;
        }
    }
}
