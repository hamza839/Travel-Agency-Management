using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace ahru
{
    public partial class admin_login : Form
    {
        Thread th;

        public void Regexp(string re, TextBox tb)
        {
            Regex regex = new Regex(re);
            if(regex.IsMatch(tb.Text))
            {
                MessageBox.Show("Valid Format");
            }
            else
            {
                MessageBox.Show("Invalid Format");
            }
        }

        private void adpanel(object obj)
        {
            Application.Run(new admin_panel());
        }
        private void st(object obj)
        {
            Application.Run(new start());
        }
        public admin_login()
        {
            InitializeComponent();
        }

        private void admin_Load(object sender, EventArgs e)
        {
            passTxt.UseSystemPasswordChar = true;
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(st);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (usernameTxt.Text == "" || passTxt.Text == "")
            {
                MessageBox.Show("Fill fields first!");
            }
            else
            {
                try
                {
                    SqlConnection MyConnection = new SqlConnection(@"Data Source=Usama;Initial Catalog=Travel;Integrated Security=True");
                    MyConnection.Open();
                    SqlCommand cm = new SqlCommand("select * from Admin where admin_user = '" + usernameTxt.Text + "' and admin_pass = '" + passTxt.Text + "'", MyConnection);
                    SqlDataReader MyReader;
                    MyReader = cm.ExecuteReader();
                    int count = 0;
                    while (MyReader.Read())
                    {
                        count += 1;
                    }
                    if (count == 1)
                    {
                        this.Close();
                        th = new Thread(adpanel);
                        th.SetApartmentState(ApartmentState.STA);
                        th.Start();
                    }
                    else
                    {
                        MessageBox.Show("Invalid UserName or Password");
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message, ToString());
                }
            }
        }

        private void usernameTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '\b' || e.KeyChar == '-' || e.KeyChar == '_')
            {
                e.Handled = false;
                usernameTxt.MaxLength = 50;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void passTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '\b')
            {
                e.Handled = false;
                passTxt.MaxLength = 50;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void usernameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void passShow_CheckedChanged(object sender, EventArgs e)
        {
            if(passShow.Checked)
            {
                passTxt.UseSystemPasswordChar = false;
            }
            else
            {
                passTxt.UseSystemPasswordChar = true;
            }
        }
    }
}
