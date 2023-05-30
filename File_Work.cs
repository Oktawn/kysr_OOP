﻿using Ccall;
using System;
using BST_three;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace test_K
{
    class File_work<T> where T : CCall
    {
        readonly string path = "store.txt";

        public void Write_in_BST(BST<CCall> three)
        {
            if (File.Exists(path))
            {
                int line_file = File.ReadLines(path).Count();
                if (line_file > 0)
                    using (StreamReader reader = File.OpenText(path))
                    {
                        for (int i = 0; i < line_file / 5; i++)
                        {
                            CCall call = new CCall();
                            //call.Priority = Convert.ToBoolean(reader.ReadLine());
                            call.Priority = (call.Set_priority(reader.ReadLine()));
                            call.Numbers = reader.ReadLine();
                            call.Abonent = reader.ReadLine();
                            call.Thems = reader.ReadLine();
                            call.StartCall = Convert.ToDateTime(reader.ReadLine());
                            three.Insert(call);
                        }
                    }
                else MessageBox.Show("store empty");
            }
            else
                MessageBox.Show("file not found");
            /* int line_file = File.ReadLines(path).Count();
                         using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
                         {
                             if (line_file > 0)
                                 for (int i = 0; i < line_file; i++)
                                 {
                                     CCall call = new CCall();
                                     call.Priority = reader.ReadBoolean();
                                     call.Numbers = reader.ReadString();
                                     call.Abonent = reader.ReadString();
                                     call.Thems = reader.ReadString();
                                     call.StartCall = Convert.ToDateTime(reader.ReadString());
                                     three.insert(call);
                                 }
                             else MessageBox.Show("store empty");
                             reader.Close();
                         }*/
        }

        
    }

}
