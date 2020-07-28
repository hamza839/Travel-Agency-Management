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
namespace ahru
{
    public partial class user_login : Form
    {
        Thread th;
        private void agpanel(object obj)
        {
            Application.Run(new agent_panel());
        }
        private void st(object obj)
        {
            Application.Run(new start());
        }
        public user_login()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(st);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            agent_panel ap = new agent_panel();
            ap.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
        }

        private void user_login_Load(object sender, EventArgs e)
        {
            passTxt.UseSystemPasswordChar = true;
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

        private void cnfrmBtn_Click(object sender, EventArgs e)
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
                    SqlCommand cm = new SqlCommand("select * from Agent where agent_user = '" + usernameTxt.Text + "' and agent_pass = '" + passTxt.Text + "'", MyConnection);
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
                        th = new Thread(agpanel);
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

        private void passShow_CheckedChanged(object sender, EventArgs e)
        {
            if (passShow.Checked)
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
