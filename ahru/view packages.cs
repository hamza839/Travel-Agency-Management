using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace ahru
{
    public partial class view_packages : Form
    {
        Thread th;
        SqlConnection MyConnection = new SqlConnection(@"Data Source=Usama;Initial Catalog=Travel;Integrated Security=True");
        SqlDataAdapter da;
        SqlCommand cmd;
        DataTable dt;

        private void Packages(object obj)
        {
            Application.Run(new Packages());
        }

        public view_packages()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(Packages);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        

        private void view_packages_Load(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("select pkg_name, flight,depart,dep_time,arrival,arr_time,price,hotel,imag from pakages", MyConnection);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                pkgData.DataSource = dt;
                foreach (DataGridViewRow row in pkgData.Rows)
                {
                    row.Height = 150;
                }
                foreach (DataGridViewColumn col in pkgData.Columns)
                {
                    col.Width = 150;
                }
                DataGridViewImageColumn image = new DataGridViewImageColumn();
                image = (DataGridViewImageColumn)pkgData.Columns[8];
                image.ImageLayout = DataGridViewImageCellLayout.Stretch;
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

        private void pkgData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("select pkg_name, flight,depart,dep_time,arrival,arr_time,price,hotel,imag from pakages where pkg_name like '%" + pkgName.Text + "%' or flight like '%" + pkgName.Text + "%' or depart like '%" + pkgName.Text + "%' or dep_time like '%" + pkgName.Text + "%' or arrival like '%" + pkgName.Text + "%' or arr_time like '%" + pkgName.Text + "%' or price like '%" + pkgName.Text + "%' or hotel like '%" + pkgName.Text + "%'", MyConnection);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                pkgData.DataSource = dt;
                foreach (DataGridViewRow row in pkgData.Rows)
                {
                    row.Height = 150;
                }
                foreach (DataGridViewColumn col in pkgData.Columns)
                {
                    col.Width = 150;
                }
                DataGridViewImageColumn image = new DataGridViewImageColumn();
                image = (DataGridViewImageColumn)pkgData.Columns[8];
                image.ImageLayout = DataGridViewImageCellLayout.Stretch;
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
