using BST_three;
using Ccall;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace test_K
{
    public partial class Form1 : MaterialForm
    {

        public Form1()
        {

            InitializeComponent();

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
        //number abonent
        private void abonent_number_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in abonent_number.Text.Skip(1))
                if (!char.IsDigit(item))
                {
                    MessageBox.Show("lox");
                    abonent_number.Text = "+";
                    break;
                }

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            CCall temp = new CCall();
            temp.Thems = (temp.set_string(abonent_thems.Text)) ? abonent_thems.Text : temp.Thems;
            temp.Abonent = (temp.set_string(name_abonent.Text)) ? name_abonent.Text : temp.Abonent;
            temp.Numbers = (temp.set_number(abonent_number.Text)) ? abonent_number.Text : temp.Numbers;


        }
    }
}
