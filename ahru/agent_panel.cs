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

namespace ahru
{
    public partial class agent_panel : Form
    {
        Thread th;
        private void Booking(object obj)
        {
            Application.Run(new Booking());
        }
        private void cus_reg(object obj)
        {
            Application.Run(new cus_reg());
        }
        private void user_login(object obj)
        {
            Application.Run(new user_login());
        }
        private void view_packages_2(object obj)
        {
            Application.Run(new view_packages_2());
        }

        public agent_panel()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(Booking);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void custBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(cus_reg);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void agent_panel_Load(object sender, EventArgs e)
        {

        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(user_login);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        
        private void pakBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(view_packages_2);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
