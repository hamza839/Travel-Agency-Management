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
    public partial class cus_reg : Form
    {
        Thread th;
        private void agent_panel(object obj)
        {
            Application.Run(new agent_panel());
        }
        private void view_customer_2(object obj)
        {
            Application.Run(new view_customer_2());
        }


        SqlConnection MyConnection = new SqlConnection(@"Data Source=Usama;Initial Catalog=Travel;Integrated Security=True");
        SqlDataReader MyDataReader;
        SqlCommand cmd;
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        public cus_reg()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (cnTxt.Text == "" || fnTxt.Text == "" || lnTxt.Text == "" || ceTxt.Text == "" || maTxt.Text == "" || adTxt.Text == "")
            {
                MessageBox.Show("FIll the fields first!");
            }
            else
            {
                cmd = new SqlCommand("select * from Customers where cust_CNIC = '" + cnTxt.Text + "'", MyConnection);
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
                        Registration rg = new Registration();
                        rg.cust_regis(fnTxt.Text.ToString(), lnTxt.Text.ToString(), cnTxt.Text.ToString(), ceTxt.Text.ToString(), maTxt.Text.ToString(), adTxt.Text.ToString());
                        cnTxt.Clear();
                        fnTxt.Clear();
                        lnTxt.Clear();
                        ceTxt.Clear();
                        maTxt.Clear();
                        adTxt.Clear();
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message, ToString());
                    }
                }
            }
        }

        private void lnTxt_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void cnTxt_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void ceTxt_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maTxt_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void fnTxt_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void adTxt_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(agent_panel);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
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
                    cmd = new SqlCommand("[cust_sear]", MyConnection);
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
                            fnTxt.Text = MyDataReader["cust_Fn"].ToString();
                            lnTxt.Text = MyDataReader["cust_Ln"].ToString();
                            ceTxt.Text = MyDataReader["cust_phone"].ToString();
                            maTxt.Text = MyDataReader["cust_mail"].ToString();
                            adTxt.Text = MyDataReader["cust_address"].ToString();
                            MyConnection.Close();
                        }
                        else
                        {
                            MessageBox.Show("Record not found!");
                            cnTxt.Clear();
                            fnTxt.Clear();
                            lnTxt.Clear();
                            ceTxt.Clear();
                            maTxt.Clear();
                            adTxt.Clear();
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

        private void delete_Click(object sender, EventArgs e)
        {
            if (cnTxt.Text == "" || fnTxt.Text == "" || lnTxt.Text == "" || ceTxt.Text == "" || maTxt.Text == "" || adTxt.Text == "")
            {
                MessageBox.Show("FIll the fields first!");
            }
            else
            {
                try
                {
                    Registration rg = new Registration();
                    rg.cust_delete(cnTxt.Text.ToString(), fnTxt.Text.ToString(), lnTxt.Text.ToString(), ceTxt.Text.ToString(), maTxt.Text.ToString(), adTxt.Text.ToString());
                    cnTxt.Clear();
                    fnTxt.Clear();
                    lnTxt.Clear();
                    ceTxt.Clear();
                    maTxt.Clear();
                    adTxt.Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message, ToString());
                }
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (cnTxt.Text == "" || fnTxt.Text == "" || lnTxt.Text == "" || ceTxt.Text == "" || maTxt.Text == "" || adTxt.Text == "")
            {
                MessageBox.Show("FIll the fields first!");
            }
            else
            {
                    try
                    {
                        Registration rg = new Registration();
                        rg.cust_update(cnTxt.Text.ToString(), fnTxt.Text.ToString(), lnTxt.Text.ToString(), ceTxt.Text.ToString(), maTxt.Text.ToString(), adTxt.Text.ToString());
                        cnTxt.Clear();
                        fnTxt.Clear();
                        lnTxt.Clear();
                        ceTxt.Clear();
                        maTxt.Clear();
                        adTxt.Clear();
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

        private void ceTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '\b' || e.KeyChar == '-')
            {
                e.Handled = false;
                ceTxt.MaxLength = 11;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void maTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                maTxt.MaxLength = 50;
            
        }

        private void adTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '\b' || e.KeyChar == '-' || e.KeyChar == '.' || e.KeyChar == ',')
            {
                e.Handled = false;
                adTxt.MaxLength = 50;
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
                MessageBox.Show("CNIC format is not valid!");
                cnTxt.Clear();
            }
        }

        private void maTxt_Leave(object sender, EventArgs e)
        {
            Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (!rEMail.IsMatch(maTxt.Text))
            {
                MessageBox.Show("Mail fromat is not valid (e.g: abcdef@gmail.com)!");
                maTxt.Clear();
            }

            cmd = new SqlCommand("select * from Customers where cust_mail = '" + maTxt.Text + "'", MyConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            int i = ds.Tables[0].Rows.Count;

            if (i > 0)
            {
                MessageBox.Show("Mail already exist");
                maTxt.Clear();
                ds.Clear();
            }
        }

        private void ceTxt_Leave(object sender, EventArgs e)
        {
            Regex rCont = new System.Text.RegularExpressions.Regex(@"^[0-9]{11}$");
            if (!rCont.IsMatch(ceTxt.Text))
            {
                MessageBox.Show("Contact fromat is not valid (e.g: 00000000000)!");
                ceTxt.Clear();
            }

            cmd = new SqlCommand("select * from Customers where cust_phone = '" + ceTxt.Text + "'", MyConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            int i = ds.Tables[0].Rows.Count;

            if (i > 0)
            {
                MessageBox.Show("Contact already exist");
                ceTxt.Clear();
                ds.Clear();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(view_customer_2);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
