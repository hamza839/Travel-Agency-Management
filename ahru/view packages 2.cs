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
using System.IO;
using System.Threading;

namespace ahru
{
    public partial class view_packages_2 : Form
    {
        public view_packages_2()
        {
            InitializeComponent();
        }

        private void agent_panel(object obj)
        {
            Application.Run(new agent_panel());
        }

        Thread th;
        SqlConnection MyConnection = new SqlConnection(@"Data Source=Usama;Initial Catalog=Travel;Integrated Security=True");
        SqlDataAdapter da;
        SqlCommand cmd;
        DataTable dt;


        private void view_packages_2_Load(object sender, EventArgs e)
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

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(agent_panel);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
