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

namespace ahru
{
    public partial class view_customer : Form
    {
        Thread th;
        private void admin_panel(object obj)
        {
            Application.Run(new admin_panel());
        }
        SqlConnection MyConnection = new SqlConnection(@"Data Source=Usama;Initial Catalog=Travel;Integrated Security=True");
        SqlDataAdapter da;
        SqlCommand cmd;
        DataTable dt = new DataTable();

        public view_customer()
        {
            InitializeComponent();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void view_customer_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(admin_panel);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void cuData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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
    }
}
