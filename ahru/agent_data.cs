using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Threading;
using System.Text.RegularExpressions;


namespace ahru
{
    public partial class agent_data : Form
    {
        Thread th;
        private void admin_panel(object obj)
        {
            Application.Run(new admin_panel());
        }
        private void view_agent(object obj)
        {
            Application.Run(new view_agent());
        }

        SqlConnection MyConnection = new SqlConnection(@"Data Source=Usama;Initial Catalog=Travel;Integrated Security=True");
        SqlDataReader MyDataReader;
        SqlCommand cmd;
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        Registration rg = new Registration();
        public agent_data()
        {
            InitializeComponent();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (cnTxt.Text == "" || fnTxt.Text == "" || lnTxt.Text == "" || unTxt.Text == "" || paTxt.Text == "" || emTxt.Text == "" || coTxt.Text == "")
            {
                MessageBox.Show("FIll the fields first!");
            }
            else
            {
                cmd = new SqlCommand("select * from Agent where agent_cnic = '" + cnTxt.Text + "'", MyConnection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                int i = ds.Tables[0].Rows.Count;
                if (i > 0)
                {
                    MessageBox.Show("CNIC already exist");
                    cnTxt.Clear();
                    ds.Clear();
                }
                else
                {
                    try
                    {
                        rg.agent_regis(cnTxt.Text.ToString(), fnTxt.Text.ToString(), lnTxt.Text.ToString(), unTxt.Text.ToString(), paTxt.Text.ToString(), emTxt.Text.ToString(), coTxt.Text.ToString());
                        cnTxt.Clear();
                        fnTxt.Clear();
                        lnTxt.Clear();
                        unTxt.Clear();
                        paTxt.Clear();
                        emTxt.Clear();
                        coTxt.Clear();
                    }
                    catch (Exception Ex)
                    {
                        MyConnection.Close();
                        MessageBox.Show(Ex.Message.ToString());
                    }
                }
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(admin_panel);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(view_agent);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void agent_data_Load(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            if (cnTxt.Text == "")
            {
                MessageBox.Show("FIll CNIC field first!");
            }
            else
            {
                try
                {
                    cmd = new SqlCommand("[agent_search]", MyConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@cnic", cnTxt.Text);
                    try
                    {
                        MyConnection.Open();
                        MyDataReader = cmd.ExecuteReader();
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message, ToString());
                    }
                    finally
                    {
                        if (MyDataReader.Read())
                        {
                            cnTxt.Text = MyDataReader["agent_cnic"].ToString();
                            fnTxt.Text = MyDataReader["agent_Fn"].ToString();
                            lnTxt.Text = MyDataReader["agent_Ln"].ToString();
                            unTxt.Text = MyDataReader["agent_user"].ToString();
                            paTxt.Text = MyDataReader["agent_pass"].ToString();
                            emTxt.Text = MyDataReader["agnet_mail"].ToString();
                            coTxt.Text = MyDataReader["agent_cont"].ToString();
                            MyConnection.Close();
                        }
                        else
                        {
                            MessageBox.Show("Records not found!");
                            cnTxt.Clear();
                            fnTxt.Clear();
                            lnTxt.Clear();
                            unTxt.Clear();
                            paTxt.Clear();
                            emTxt.Clear();
                            coTxt.Clear();
                            MyConnection.Close();
                        }   
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message, ToString());
                }
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (cnTxt.Text == "" || fnTxt.Text == "" || lnTxt.Text == "" || unTxt.Text == "" || paTxt.Text == "" || emTxt.Text == "" || coTxt.Text == "")
            {
                MessageBox.Show("FIll the fields first!");
            }
            else
            {
                    try
                    {
                        rg.agent_update(cnTxt.Text.ToString(), fnTxt.Text.ToString(), lnTxt.Text.ToString(), unTxt.Text.ToString(), paTxt.Text.ToString(), emTxt.Text.ToString(), coTxt.Text.ToString());
                        cnTxt.Clear();
                        fnTxt.Clear();
                        lnTxt.Clear();
                        unTxt.Clear();
                        paTxt.Clear();
                        emTxt.Clear();
                        coTxt.Clear();
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message, ToString());
                    }
                }
            
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (cnTxt.Text == "" || fnTxt.Text == "" || lnTxt.Text == "" || unTxt.Text == "" || paTxt.Text == "" || emTxt.Text == "" || coTxt.Text == "")
            {
                MessageBox.Show("FIll the fields first!");
            }
            else
            {
                try
                {
                    rg.agent_delete(cnTxt.Text.ToString(), fnTxt.Text.ToString(), lnTxt.Text.ToString(), unTxt.Text.ToString(), paTxt.Text.ToString(), emTxt.Text.ToString(), coTxt.Text.ToString());
                    cnTxt.Clear();
                    fnTxt.Clear();
                    lnTxt.Clear();
                    unTxt.Clear();
                    paTxt.Clear();
                    emTxt.Clear();
                    coTxt.Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message, ToString());
                }
            }
        }

        private void cnTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '\b' || e.KeyChar == '-')
            {
                e.Handled = false;
                cnTxt.MaxLength = 15;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void fnTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar == '\b')
            {
                e.Handled = false;
                fnTxt.MaxLength = 50;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void lnTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar == '\b')
            {
                e.Handled = false;
                lnTxt.MaxLength = 50;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void unTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '\b' || e.KeyChar == '-' || e.KeyChar == '_')
            {
                e.Handled = false;
                unTxt.MaxLength = 50;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void paTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '\b')
            {
                e.Handled = false;
                paTxt.MaxLength = 50;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void emTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
                emTxt.MaxLength = 50;
        }

        private void coTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '\b' || e.KeyChar == '-')
            {
                e.Handled = false;
                coTxt.MaxLength = 11;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void cnTxt_Leave(object sender, EventArgs e)
        {
            Regex cnic = new System.Text.RegularExpressions.Regex(@"^[0-9]{5}-[0-9]{7}-[0-9]{1}$");
            if (!cnic.IsMatch(cnTxt.Text))
            {
                MessageBox.Show("CNIC format is not valid (e.g:xxxxx-xxxxxxx-x)!");
                cnTxt.Clear();
            }
        }

        private void unTxt_Leave(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from Admin where admin_user = '" + unTxt.Text + "'", MyConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            int i = ds.Tables[0].Rows.Count;

            if (i > 0)
            {
                MessageBox.Show("UserName already exist");
                unTxt.Clear();
                ds.Clear();
            }
        }

        private void paTxt_Leave(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from Agent where agent_pass = '" + paTxt.Text + "'", MyConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            int i = ds.Tables[0].Rows.Count;

            if (i > 0)
            {
                MessageBox.Show("Password already exist");
                paTxt.Clear();
                ds.Clear();
            }
        }

        private void emTxt_Leave(object sender, EventArgs e)
        {
            Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (!rEMail.IsMatch(emTxt.Text))
            {
                MessageBox.Show("Mail fromat is not valid (e.g: abcdef@gmail.com)!");
                emTxt.Clear();
            }

            cmd = new SqlCommand("select * from Agent where agnet_mail = '" + emTxt.Text + "'", MyConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            int i = ds.Tables[0].Rows.Count;

            if (i > 0)
            {
                MessageBox.Show("Mail already exist");
                emTxt.Clear();
                ds.Clear();
            }
        }

        private void coTxt_Leave(object sender, EventArgs e)
        {
            Regex rCont = new System.Text.RegularExpressions.Regex(@"^[0-9]{11}$");
            if (!rCont.IsMatch(coTxt.Text))
            {
                MessageBox.Show("Contact fromat is not valid (e.g: 00000000000)!");
                coTxt.Clear();
            }

            cmd = new SqlCommand("select * from Agent where agent_cont = '" + coTxt.Text + "'", MyConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            int i = ds.Tables[0].Rows.Count;

            if (i > 0)
            {
                MessageBox.Show("Contact already exist");
                coTxt.Clear();
                ds.Clear();
            }
        }
    }
}
