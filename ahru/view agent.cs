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
    public partial class view_agent : Form
    {
        Thread th;
        private void agent_data(object obj)
        {
            Application.Run(new agent_data());
        }
        

        public view_agent()
        {
            InitializeComponent();
        }

        SqlConnection MyConnection = new SqlConnection(@"Data Source=Usama;Initial Catalog=Travel;Integrated Security=True");
        SqlDataAdapter da;
        SqlCommand cmd;
        DataTable dt = new DataTable();
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(agent_data);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void view_agent_Load(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("select agent_cnic, agent_Fn,agent_Ln,agent_user,agent_pass,agnet_mail,agent_cont from Agent", MyConnection);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                agData.DataSource = dt;
                foreach (DataGridViewRow row in agData.Rows)
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

        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("select agent_cnic, agent_Fn,agent_Ln,agent_user,agent_pass,agnet_mail,agent_cont from Agent where agent_cnic like '%" + agName.Text + "%' or agent_Fn like '%" + agName.Text + "%' or agent_Ln like '%" + agName.Text + "%' or agent_user like '%" + agName.Text + "%' or agent_pass like '%" + agName.Text + "%' or agnet_mail like '%" + agName.Text + "%' or agent_cont like '%" + agName.Text + "%'", MyConnection);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                agData.DataSource = dt;
                foreach (DataGridViewRow row in agData.Rows)
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
