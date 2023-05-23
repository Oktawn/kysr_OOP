using Ccall;
using System.IO;

namespace test_K
{


    public class Node<K, V> where V : CCall
    {
        public int Id = 0;
        public K key;
        public V value;
        public Node<K, V> left, right;
        public Node()
        {
            Id++;
            left = right = null;
        }
        public Node(K key, V value)
        {
            Id++;
            left = right = null;
            this.key = key;
            this.value = value;
        }
    }

    public class BST_bad<K, V> where V : CCall
    {
        private Node<K, V> root;
        private short count;

        private bool Is_Empty(Node<K, V> node) { return node == null; }

        private Node<K, V> Add_Node(K key, V value)
        {
            Node<K, V> knot = new Node<K, V>(key, value);
            count++;
            return knot;
        }
        private Node<K, V> Insert_Node(Node<K, V> root, K key, V value)
        {
            if (Is_Empty(root))
                root = Add_Node(key, value);
            else if (root.key.ToString().CompareTo(key.ToString()) < 0)
                root.left = Insert_Node(root.left, key, value);
            else
                root.right = Insert_Node(root.right, key, value);
            return root;
        }

        public void Insert(K key, V value)
        {
            root = Insert_Node(root, key, value);
        }

        private Node<K, V> GetMin(Node<K, V> node)
        {
            while (node.left != null)
                node = node.left;
            return node;
        }
        private Node<K, V> GetMax(Node<K, V> node)
        {
            if (Is_Empty(node)) return null;
            if (node.right == null) return node;
            return GetMax(node.right);
        }


        private Node<K, V> Remove_Hide(Node<K, V> root, K key)
        {
            if (Is_Empty(root))
                return null;
            else if (root.key.ToString().CompareTo(key.ToString()) < 0)
                root.left = Remove_Hide(root.left, key);
            else if (root.key.ToString().CompareTo(key.ToString()) >= 0)
                root.right = Remove_Hide(root.right, key);
            //else
            //{
            //    if (root.left == null)
            //        return root.right;
            //    else if (root.right == null)
            //        return root.left;
            //    Node<K, V> temp = Find_Min(root.right);
            //    root.key = temp.key;
            //    root.right = Remove_Hide(root.right, key);
            //}

            else
            {
                if (root.left == null || root.right == null)
                    root = root.left ?? root.right;
                else
                {
                    Node<K, V> maxLeft = GetMax(root.left);
                    root.key = maxLeft.key;
                    root.value = maxLeft.value;
                    root.right = Remove_Hide(root.right, key);
                }
            }
            return root;
        }
        public void Remove(K key)
        {
            root = Remove_Hide(root, key);
        }

        private bool Search_list(Node<K, V> root, K key)
        {
            if (root == null)
                return false;
            if (root.key.Equals(key))
                return true;
            if (root.key.ToString().CompareTo(key) < 0)
                return Search_list(root.left, key);
            else
                return Search_list(root.right, key);
        }
        public bool Search_list(K key)
        {
            return Search_list(root, key);
        }

        private Node<K, V> GetNode(Node<K, V> root, string key)
        {
            /*if (Is_Empty(root))
            //    return null;
            //else if (key.CompareTo(root.key) < 0)
            //    return GetNode(root.left, key);
            //else if (key.CompareTo(root.key) > 0)
            //    return GetNode(root.right, key);
            return root;*/
            if (Is_Empty(root)) return null;
            if (root.key.Equals(key)) return root;
            return (key.CompareTo(root.key) < 0) ? GetNode(root.left, key)
                : GetNode(root.right, key);
        }
        public Node<K, V> GetNode(string key)
        {
            return GetNode(root, key);
        }

        public Node<K, V> Get_root()
        { return root; }
        public short Size()
        {
            return count;
        }


        private readonly string path = "store.txt";

        public void Read_BST()
        {
            using (StreamWriter writer = new StreamWriter(path))
                Read_BST(root, writer);
        }

        private void Read_BST(Node<K, V> root, StreamWriter writer)
        {
            if (root != null)
            {
                Read_BST(root.left, writer);
                foreach (var item in root.value.Get_all())
                    writer.Write(item);
                Read_BST(root.right, writer);
            }
        }
    }
}
