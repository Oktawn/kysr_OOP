using Ccall;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace test_K
{
    public partial class Form1 : MaterialForm
    {
        string key;
        int coll = 0;
        readonly string path = "store.txt";
        readonly string path_end = "end_call.txt";
        BST_bad<string, CCall> bad = new BST_bad<string, CCall>();


        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey600, Primary.BlueGrey900,
                Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Name_abonent_TextChanged(object sender, EventArgs e)
        {

            foreach (var item in name_abonent.Text)
                if (!char.IsLetter(item))
                {
                    MessageBox.Show("lox");
                    name_abonent.Text = "";
                    break;
                }
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            if (key_visible.Text == "")
            {
                MessageBox.Show("Choose a key");
                return;
            }

            CCall temp = new CCall();
            temp.Priority = temp.Set_priority(comboBox1.Text);
            temp.Thems = (temp.Set_string(abonent_thems.Text)) ? abonent_thems.Text : temp.Thems;
            temp.Abonent = (temp.Set_string(name_abonent.Text)) ? name_abonent.Text : temp.Abonent;
            temp.Numbers = (temp.Set_number(abonent_number.Text)) ? abonent_number.Text : temp.Numbers;


            switch (key)
            {
                case "Priority":
                    //if (!bad.Search_list(temp.Priority.ToString()))
                    if (bad.Search_list(temp.Priority.ToString()))
                    {
                        bad.Insert(temp.Priority.ToString(), temp);
                        Change_DCV(temp);
                    }
                    else
                    {
                        bad.Insert(temp.Priority.ToString(), temp);
                        Write_DGV(temp);
                    }
                    break;
                case "Thems":
                    if (bad.Search_list(temp.Thems))
                    {
                        bad.Insert(temp.Thems, temp);
                        Change_DCV(temp);
                    }
                    else
                    {
                        bad.Insert(temp.Thems, temp);
                        Write_DGV(temp);
                    }
                    break;
                case "Numbers":
                    if (!bad.Search_list(temp.Numbers))
                    {
                        bad.Insert(temp.Numbers, temp);
                        Write_DGV(temp);
                    }
                    else
                        MessageBox.Show("this abonent already calling");
                    break;
                case "Abonent":
                    if (!bad.Search_list(temp.Abonent))
                    {
                        bad.Insert(temp.Abonent, temp);
                        Write_DGV(temp);
                    }
                    else
                        MessageBox.Show("this abonent already calling");
                    break;
            }
        }

        private void Abonent_number_Enter(object sender, EventArgs e)
        {
            if (abonent_number.Text == "+79XXXXXXXXX")
                abonent_number.Text = "+";
        }
        private void Abonent_number_Leave(object sender, EventArgs e)
        {
            if (abonent_number.Text == "+" || abonent_number.Text.Length != 12)
                abonent_number.Text = "+79XXXXXXXXX";
        }
        private void Abonent_number_TextChanged(object sender, EventArgs e)
        {
            if (abonent_number.Text == "+79XXXXXXXXX") return;
            if (abonent_number.Text[0] == '+')
                foreach (var item in abonent_number.Text.Skip(1))
                {
                    if (!char.IsDigit(item))
                    {
                        MessageBox.Show("no-no");
                        abonent_number.Text = "+";
                        break;
                    }
                }
            else
            {
                MessageBox.Show("lox");
                abonent_number.Text = "+";
            }
        }

        private void Name_abonent_Enter(object sender, EventArgs e)
        {
            if (name_abonent.Text == "chel")
                name_abonent.Text = "";
        }
        private void Name_abonent_Leave(object sender, EventArgs e)
        {
            if (name_abonent.Text == "")
                name_abonent.Text = "chel";
        }

        private void Abonent_thems_Enter(object sender, EventArgs e)
        {
            if (abonent_thems.Text == "programming")
                abonent_thems.Text = "";
        }
        private void abonent_thems_Leave(object sender, EventArgs e)
        {
            if (abonent_thems.Text == "")
                abonent_thems.Text = "programming";
        }



        private void End_call_materialFlatButton2_Click(object sender, EventArgs e)
        {
            string remove = end_call_textbox.Text;
            if (bad.Search_list(remove))
            {
                Node<string, CCall> temp = bad.GetNode(remove);
                bad.Read_BST_end(path_end, temp);
                bad.Remove(remove);
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (remove == dataGridView1.Rows[i].Cells[coll].Value.ToString())
                    {
                        dataGridView1.Rows.RemoveAt(i);
                        dataGridView1.Refresh();
                        break;
                    }
                }
            }
            else
                MessageBox.Show($"not found call by {key}, {remove}");
        }

        private void materialFlatButton3_upload_Click(object sender, EventArgs e)
        {

            if (key_visible.Text == "")
            {
                MessageBox.Show("Choose a key");
                return;
            }
            dataGridView1.Rows.Clear();

            bad.Clear();


            if (File.Exists(path))
            {
                CCall temp = new CCall();
                int line_file = File.ReadLines(path).Count(), count = line_file / 5;
                if (line_file > 0)
                {
                    /*dataGridView1.Rows.Add(count);
                    using (StreamReader reader = File.OpenText(path))
                        for (int i = 0, j = 0; i < count; j++)
                        {
                            //j = (j == 4) ? (0, i++) : j;

                            if (j == 5)
                            {
                                j = 0;
                                i++;
                            }
                            dataGridView1.Rows[i].Cells[j].Value = reader.ReadLine();
                        }
                    */

                    using (StreamReader reader = File.OpenText(path))
                        for (int i = 0; i < count; i++)
                        {
                            //call.Priority = Convert.ToBoolean(reader.ReadLine());
                            temp.Priority = temp.Set_priority(reader.ReadLine());
                            temp.Numbers = reader.ReadLine();
                            temp.Abonent = reader.ReadLine();
                            temp.Thems = reader.ReadLine();
                            temp.StartCall = Convert.ToDateTime(reader.ReadLine());
                            switch (key)
                            {
                                case "Priority":
                                    if (bad.Search_list(temp.Priority.ToString()))
                                    {
                                        bad.Insert(temp.Priority.ToString(), temp);
                                        Change_DCV(temp);
                                    }
                                    else
                                    {
                                        bad.Insert(temp.Priority.ToString(), temp);
                                        Write_DGV(temp);
                                    }
                                    break;
                                case "Thems":
                                    if (bad.Search_list(temp.Thems))
                                    {
                                        bad.Insert(temp.Thems, temp);
                                        Change_DCV(temp);
                                    }
                                    else
                                    {
                                        bad.Insert(temp.Thems, temp);
                                        Write_DGV(temp);
                                    }
                                    break;
                                case "Abonent":
                                    if (!bad.Search_list(temp.Abonent))
                                    {
                                        bad.Insert(temp.Abonent, temp);
                                        Write_DGV(temp);
                                    }
                                    break;
                                case "Numbers":
                                    if (!bad.Search_list(temp.Numbers))
                                    {
                                        bad.Insert(temp.Numbers, temp);
                                        Write_DGV(temp);
                                    }
                                    break;
                            }
                        }
                }

                else MessageBox.Show("store empty");
            }
            else
                MessageBox.Show("file not found");
        }

        private void materialFlatButton2_save_Click(object sender, EventArgs e)
        {
            bad.Read_BST(path);
        }

        private void SelectKey_materialFlatButton2_Click(object sender, EventArgs e)
        {
            if (Key_comboBox2.Text == "")
            {
                MessageBox.Show("Choose a key");
                return;
            }
            Key_comboBox2.Visible = false;
            key_visible.Visible = true;
            key_visible.Text = Key_comboBox2.Text;
            key_visible.ReadOnly = true;
            Key_materialLabel5.Visible = true;
            key = Key_comboBox2.Text;

            foreach (DataGridViewColumn col in dataGridView1.Columns)
                if (col.HeaderText.ToUpper().Trim() == key.ToUpper().Trim())
                {
                    coll = col.Index;
                    break;
                }
        }

        public void Write_DGV(CCall C)
        {

            int n = dataGridView1.Rows.Add();
            int i = 0;
            switch (i)
            {
                case 0: { dataGridView1.Rows[n].Cells[i].Value = C.Priority; i++; goto case 1; }
                case 1: { dataGridView1.Rows[n].Cells[i].Value = C.Numbers; i++; goto case 2; }
                case 2: { dataGridView1.Rows[n].Cells[i].Value = C.Abonent; i++; goto case 3; }
                case 3: { dataGridView1.Rows[n].Cells[i].Value = C.Thems; i++; goto case 4; }
                case 4: { dataGridView1.Rows[n].Cells[i].Value = C.StartCall.ToString(); break; }
            }
        }

        public void Change_DCV(CCall C)
        {
            int n = 0;
            for (int j = 0; j < dataGridView1.RowCount; j++)
            {
                if (dataGridView1.Rows[j].Cells[coll].Value.ToString() == bad.GetKey())
                {
                    n = j; break;
                }
            }
            int i = 0;
            switch (i)
            {
                case 0: { dataGridView1.Rows[n].Cells[i].Value = C.Priority; i++; goto case 1; }
                case 1: { dataGridView1.Rows[n].Cells[i].Value = C.Numbers; i++; goto case 2; }
                case 2: { dataGridView1.Rows[n].Cells[i].Value = C.Abonent; i++; goto case 3; }
                case 3: { dataGridView1.Rows[n].Cells[i].Value = C.Thems; i++; goto case 4; }
                case 4: { dataGridView1.Rows[n].Cells[i].Value = C.StartCall.ToString(); break; }
            }
        }

    }
}
