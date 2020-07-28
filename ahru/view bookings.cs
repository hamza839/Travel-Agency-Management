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
    public partial class view_bookings : Form
    {
        Thread th;
        private void admin_panel(object obj)
        {
            Application.Run(new admin_panel());
        }

        SqlConnection MyConnection = new SqlConnection(@"Data Source=Usama;Initial Catalog=Travel;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataAdapter da1;
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        
        public view_bookings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(admin_panel);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void IDTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {

        }

        private void view_bookings_Load(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from Bookings", MyConnection);
                dt = new DataTable();
                da.Fill(dt);
                int row = dt.Rows.Count;
                for (int i = 0; i < row; i++)
                {
                    da1 = new SqlDataAdapter("select Customers.cust_Fn,Customers.cust_Ln,Customers.cust_CNIC,pakages.pkg_name,pakages.flight,pakages.depart,pakages.dep_time,pakages.arrival,pakages.arr_time,pakages.price,pakages.hotel from Customers,pakages where pakages.pkg_id='" + dt.Rows[i]["pkg_id"] + "' and Customers.cust_id='" + dt.Rows[i]["cust_id"] + "'", MyConnection);
                    da1.Fill(dt1);
                    boData.DataSource = dt1;
                    foreach (DataGridViewRow ro in boData.Rows)
                    {
                        ro.Height = 100;
                    }
                    da.Dispose();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message.ToString());
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
        }
    }
}
