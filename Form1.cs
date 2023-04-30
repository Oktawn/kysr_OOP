using Ccall;
using System;
using BST_three;
using System.Linq;
using MaterialSkin;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace test_K
{
    public partial class Form1 : MaterialForm
    {
        string key;
        BST_bad<string, CCall> bad = new BST_bad<string, CCall>();
        BST<CCall> thee = new BST<CCall>();
        File_work<CCall> file_Work = new File_work<CCall>();

        public Form1()
        {
            InitializeComponent();

            file_Work.Write_in_BST(thee);
            //Write_DGV(thee);


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
            key = (Key_comboBox2.Text == " ") ? Key_comboBox2.Text : "Numbers";
            CCall temp = new CCall();
            temp.Priority = temp.Set_priority(comboBox1.Text);
            temp.Thems = (temp.Set_string(abonent_thems.Text)) ? abonent_thems.Text : temp.Thems;
            temp.Abonent = (temp.Set_string(name_abonent.Text)) ? name_abonent.Text : temp.Abonent;
            temp.Numbers = (temp.Set_number(abonent_number.Text)) ? abonent_number.Text : temp.Numbers;
            /*if (!thee.Search_list(temp))
            {
                thee.Insert(temp);
                thee.Read_BST();
                Write_DGV(temp);
            }
            else
                MessageBox.Show("this abonent already calling");*/

            switch (key)
            {
                case "Priority":
                    if (!bad.Search_list(temp.Priority.ToString()))
                    {
                        bad.Insert(temp.Priority.ToString(), temp);
                        bad.Read_BST();
                        Write_DGV(temp);
                    }
                    else
                        MessageBox.Show("this abonent already calling");
                    break;
                case "Thems":
                    if (!bad.Search_list(temp.Thems))
                    {
                        bad.Insert(temp.Thems, temp);
                        bad.Read_BST();
                        Write_DGV(temp);
                    }
                    else
                        MessageBox.Show("this abonent already calling");
                    break;
                case "Numbers":
                    if (!bad.Search_list(temp.Numbers))
                    {
                        bad.Insert(temp.Numbers, temp);
                        bad.Read_BST();
                        Write_DGV(temp);
                    }
                    else
                        MessageBox.Show("this abonent already calling");
                    break;
                case "Abonent":
                    if (!bad.Search_list(temp.Abonent))
                    {
                        bad.Insert(temp.Abonent, temp);
                        bad.Read_BST();
                        Write_DGV(temp);
                    }
                    else
                        MessageBox.Show("this abonent already calling");
                    break;
            }


            Key_comboBox2.Visible = false;
            key_visible.Visible = true;
            key_visible.Text = (Key_comboBox2.Text == " ") ? Key_comboBox2.Text : "Numbers";
            key_visible.ReadOnly = true;
            Key_materialLabel5.Visible = true;
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
                        MessageBox.Show("lox");
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

        private void End_call_materialFlatButton2_Click(object sender, EventArgs e)
        {
            int row;
            string remove = end_call_textbox.Text;
            if (bad.Search_list(remove))
            {
                row = bad.GetNode(remove).Id;
                bad.Remove(remove); 
                dataGridView1.Rows.RemoveAt(row - 1);
                dataGridView1.Refresh();
            }

        }
    }
}
