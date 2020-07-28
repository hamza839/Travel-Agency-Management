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
    public partial class admin_panel : Form
    {
        Thread th;
        private void admin_login(object obj)
        {
            Application.Run(new admin_login());
        }
        private void Packages(object obj)
        {
            Application.Run(new Packages());
        }
        private void admin_data(object obj)
        {
            Application.Run(new admin_data());
        }
        private void agent_data(object obj)
        {
            Application.Run(new agent_data());
        }
        private void view_customer(object obj)
        {
            Application.Run(new view_customer());
        }
        private void view_bookings(object obj)
        {
            Application.Run(new view_bookings());
        }

        public admin_panel()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void additemBtn_Click(object sender, EventArgs e)
        {

        }

        private void waste_Click(object sender, EventArgs e)
        {

        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(admin_login);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void pkgBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(Packages);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void adBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(admin_data);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void agBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(agent_data);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void custBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(view_customer);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void bookBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(view_bookings);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void admin_panel_Load(object sender, EventArgs e)
        {

        }
    }
}
