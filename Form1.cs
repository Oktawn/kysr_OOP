using Ccall;
using System;
using BST_three;
using System.Linq;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Windows.Forms;

namespace test_K
{
    public partial class Form1 : MaterialForm
    {
        BST<CCall> thee = new BST<CCall>();
        readonly File_work<CCall> file_Work = new File_work<CCall>();
        public Form1()
        {
            InitializeComponent();
            file_Work.Write_in_BST(thee);
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey600, Primary.BlueGrey900,
                Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }
        //name abonent
        private void name_abonent_TextChanged(object sender, EventArgs e)
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
            CCall temp = new CCall();
            temp.Priority = temp.set_priority(comboBox1.Text);
            temp.Thems = (temp.set_string(abonent_thems.Text)) ? abonent_thems.Text : temp.Thems;
            temp.Abonent = (temp.set_string(name_abonent.Text)) ? name_abonent.Text : temp.Abonent;
            temp.Numbers = (temp.set_number(abonent_number.Text)) ? abonent_number.Text : temp.Numbers;
            if (!thee.Search_list(temp))
            {
                thee.Insert(temp);
                file_Work.Read_BST(thee);
                Write_DGV(temp);
            }
            else
                MessageBox.Show("this abonent already calling");
        }

        private void abonent_number_Enter(object sender, EventArgs e)
        {
            if (abonent_number.Text == "+79XXXXXXXXX")
                abonent_number.Text = "+";
        }
        private void abonent_number_Leave(object sender, EventArgs e)
        {
            if (abonent_number.Text == "+" || abonent_number.Text.Length != 12)
                abonent_number.Text = "+79XXXXXXXXX";
        }
        private void abonent_number_TextChanged(object sender, EventArgs e)
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

        private void name_abonent_Enter(object sender, EventArgs e)
        {
            if (name_abonent.Text == "chel")
                name_abonent.Text = "";
        }
        private void name_abonent_Leave(object sender, EventArgs e)
        {
            if (name_abonent.Text == "")
                name_abonent.Text = "chel";
        }

        private void abonent_thems_Enter(object sender, EventArgs e)
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
                case 0: { dataGridView1.Rows[n].Cells[i].Value = C.Id; i++; goto case 1; }
                case 1: { dataGridView1.Rows[n].Cells[i].Value = C.Priority; i++; goto case 2; }
                case 2: { dataGridView1.Rows[n].Cells[i].Value = C.Numbers; i++; goto case 3; }
                case 3: { dataGridView1.Rows[n].Cells[i].Value = C.Abonent; i++; goto case 4; }
                case 4: { dataGridView1.Rows[n].Cells[i].Value = C.Thems; i++; goto case 5; }
                case 5: { dataGridView1.Rows[n].Cells[i].Value = C.StartCall.ToString(); i++; break; }
            }
        }
    }
}
