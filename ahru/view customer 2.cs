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
using System.Threading;

namespace ahru
{
    public partial class view_customer_2 : Form
    {
        public view_customer_2()
        {
            InitializeComponent();
        }
        private void cus_reg(object obj)
        {
            Application.Run(new cus_reg());
        }

        Thread th;
        SqlConnection MyConnection = new SqlConnection(@"Data Source=Usama;Initial Catalog=Travel;Integrated Security=True");
        SqlDataAdapter da;
        SqlCommand cmd;
        DataTable dt = new DataTable();

        private void cuData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void view_customer_2_Load(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("select cust_Fn, cust_Ln,cust_phone,cust_CNIC,cust_mail,cust_address from Customers", MyConnection);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                cuData.DataSource = dt;
                foreach (DataGridViewRow row in cuData.Rows)
                {
                    row.Height = 100;
                }
                da.Dispose();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message.ToString());
            }
            finally
            {
                MyConnection.Close();
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("select cust_Fn, cust_Ln,cust_phone,cust_CNIC,cust_mail,cust_address from Customers where cust_Fn like '%" + custName.Text + "%' or cust_Ln like '%" + custName.Text + "%' or cust_phone like '%" + custName.Text + "%' or cust_CNIC like '%" + custName.Text + "%' or cust_mail like '%" + custName.Text + "%' or cust_address like '%" + custName.Text + "%'", MyConnection);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                cuData.DataSource = dt;
                foreach (DataGridViewRow row in cuData.Rows)
                {
                    row.Height = 100;
                }
                da.Dispose();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message.ToString());
            }
            finally
            {
                MyConnection.Close();
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(cus_reg);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
