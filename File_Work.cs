using BST_three;
using Ccall;
using System.IO;

namespace test_K
{
    class File_work
    {
        readonly string path = "store.bin";
        public void Read_BST(BST three)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
            {
                foreach (var item in three.get_root().date.get_all())
                {
                    writer.Write(item);
                }
            }
        }


    }
}
