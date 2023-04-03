using Ccall;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Linq;
using System.Runtime.InteropServices;
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
            CCall temp = new CCall();
            bool flag = true;
            foreach (var item in name_abonent.Text)
                if (!char.IsLetter(item))
                {
                    MessageBox.Show("lox");
                    name_abonent.Text = "";
                    flag = false;
                    break;
                }
            if (flag) { temp.Abonent = name_abonent.Text; }
        }

        private void abonent_number_TextChanged(object sender, EventArgs e)
        {
            CCall temp = new CCall();
            bool flag = true;

            foreach (var item in abonent_number.Text.Skip(1))
            {
                if (!char.IsDigit(item))
                {
                    MessageBox.Show("lox");
                    abonent_number.Text = "";
                    flag = false;
                    break;
                }
            }


            if (flag)
                temp.Numbers = abonent_number.Text;

        }
    }
}
