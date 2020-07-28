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
    public partial class view_admin : Form
    {
        Thread th;
        private void admin_data(object obj)
        {
            Application.Run(new admin_data());
        }
        
        public view_admin()
        {
            InitializeComponent();
        }
        SqlConnection MyConnection = new SqlConnection(@"Data Source=Usama;Initial Catalog=Travel;Integrated Security=True");
        SqlDataReader MyDataReader;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataTable dt = new DataTable();
        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(admin_data);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void view_admin_Load(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("select admin_cnic, admin_Fn,admin_Ln,admin_user,admin_pass,admin_mail,admin_cont from Admin", MyConnection);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                adData.DataSource = dt;
                foreach (DataGridViewRow row in adData.Rows)
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

        private void confirmBtn_Click(object sender, EventArgs e)
        {
        }

        private void adData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("select admin_cnic, admin_Fn,admin_Ln,admin_user,admin_pass,admin_mail,admin_cont from Admin where admin_cnic like '%" + adName.Text + "%' or admin_Fn like '%" + adName.Text + "%' or admin_Ln like '%" + adName.Text + "%' or admin_user like '%" + adName.Text + "%' or admin_pass like '%" + adName.Text + "%' or admin_mail like '%" + adName.Text + "%' or admin_cont like '%" + adName.Text + "%'", MyConnection);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                adData.DataSource = dt;
                foreach (DataGridViewRow row in adData.Rows)
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
