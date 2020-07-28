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
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();
        }
        Thread th;
        private void userlog(object obj)
        {
            Application.Run(new user_login());
        }
        private void adminlog(object obj)
        {
            Application.Run(new admin_login());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(userlog);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(adminlog);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        

        private void start_Load(object sender, EventArgs e)
        {

        }
    }
}
