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
using System.IO;


namespace ahru
{
    public partial class Packages : Form
    {
        Thread th;
        string imgLoc = "";
        string pid;
        private void admin_panel(object obj)
        {
            Application.Run(new admin_panel());
        }
        private void view_packages(object obj)
        {
            Application.Run(new view_packages());
        }

        SqlConnection MyConnection = new SqlConnection(@"Data Source=Usama;Initial Catalog=Travel;Integrated Security=True");
        SqlDataReader MyDataReader;
        SqlCommand cmd;
        DataTable dt = new DataTable();

        public Packages()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (paTxt.Text == "" || flightTxt.Text == "" || depDate.Text == "" || depTime.SelectedIndex == 0 || arrDate.Text == "" || arrTime.SelectedIndex == 0 || prTxt.Text == "" || hoTxt.Text == "")
            {
                MessageBox.Show("FIll the fields first!");
            }
            else
            {
                try
                {
                    byte[] img = null;
                    FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);

                    cmd = new SqlCommand("[inPack]", MyConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pname", paTxt.Text);
                    cmd.Parameters.AddWithValue("@flt", flightTxt.Text);
                    cmd.Parameters.AddWithValue("@dep", depDate.Value.ToString());
                    cmd.Parameters.AddWithValue("@dTime", depTime.Text);
                    cmd.Parameters.AddWithValue("@arr", arrDate.Value.ToString());
                    cmd.Parameters.AddWithValue("@aTime", arrTime.Text);
                    cmd.Parameters.AddWithValue("@pr", prTxt.Text);
                    cmd.Parameters.AddWithValue("@hot", hoTxt.Text);
                    cmd.Parameters.AddWithValue("@im", img);

                    try
                    {
                        MyConnection.Open();
                        MyDataReader = cmd.ExecuteReader();
                        dt.Load(MyDataReader);
                    }
                    catch (Exception Ex)
                    {
                        MyConnection.Close();
                        MessageBox.Show(Ex.Message.ToString());
                    }
                    finally
                    {
                        MessageBox.Show("Record Inserted!");
                        paTxt.Clear();
                        flightTxt.Clear();
                        depDate.ResetText();
                        depTime.SelectedIndex = 0;
                        arrDate.ResetText();
                        arrTime.SelectedIndex = 0;
                        prTxt.Clear();
                        hoTxt.Clear();
                        picBox.Image = null;
                        MyConnection.Close();
                    }
                }
                catch (Exception Ex)
                {
                    MyConnection.Close();
                    MessageBox.Show(Ex.Message.ToString());
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Packages_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(admin_panel);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(view_packages);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void brBtn_Click(object sender, EventArgs e)
        {
            
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|JPEG Files(*.jpeg)|*.jpeg|All Files (*.*)|*.*";
                dlg.Title = "Select Package Picture";
                if(dlg.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = dlg.FileName.ToString();
                    picBox.ImageLocation = imgLoc;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (paTxt.Text == "")
            {
                MessageBox.Show("FIll Package field first!");
            }
            else
            {
                try
                {
                    cmd = new SqlCommand("[pkg_search]", MyConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pname", paTxt.Text);
                    try
                    {
                        MyConnection.Open();
                        MyDataReader = cmd.ExecuteReader();
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message, ToString());
                    }
                    finally
                    {
                        if (MyDataReader.Read())
                        {
                            flightTxt.Text = MyDataReader["flight"].ToString();
                            depDate.Text = MyDataReader["depart"].ToString();
                            depTime.Text = MyDataReader["dep_time"].ToString();
                            arrDate.Text = MyDataReader["arrival"].ToString();
                            arrTime.Text = MyDataReader["arr_time"].ToString();
                            prTxt.Text = MyDataReader["price"].ToString();
                            hoTxt.Text = MyDataReader["hotel"].ToString();
                            byte[] img = (byte[])(MyDataReader["imag"]);
                            if (img == null)
                            {
                                picBox.Image = null;
                            }
                            else
                            {
                                MemoryStream ms = new MemoryStream(img);
                                picBox.Image = Image.FromStream(ms);
                            }
                            MyConnection.Close();
                        }
                        else
                        {
                            MessageBox.Show("Records not found!");
                            paTxt.Clear();
                            flightTxt.Clear();
                            depDate.ResetText();
                            depTime.SelectedIndex = 0;
                            arrDate.ResetText();
                            arrTime.SelectedIndex = 0;
                            prTxt.Clear();
                            hoTxt.Clear();
                            picBox.Image = null;
                            MyConnection.Close();
                        }
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message, ToString());
                }
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (paTxt.Text == "" || flightTxt.Text == "" || depDate.Text == "" || depTime.SelectedIndex == 0 || arrDate.Text == "" || arrTime.SelectedIndex == 0 || prTxt.Text == "" || hoTxt.Text == "")
            {
                MessageBox.Show("FIll the fields first!");
            }
            else
            {
                try
                {
                    byte[] img = null;
                    FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);

                    cmd = new SqlCommand("[pkgs_update]", MyConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pname", paTxt.Text);
                    cmd.Parameters.AddWithValue("@flt", flightTxt.Text);
                    cmd.Parameters.AddWithValue("@dep", depDate.Value.ToString());
                    cmd.Parameters.AddWithValue("@dTime", depTime.Text);
                    cmd.Parameters.AddWithValue("@arr", arrDate.Value.ToString());
                    cmd.Parameters.AddWithValue("@aTime", arrTime.Text);
                    cmd.Parameters.AddWithValue("@pr", prTxt.Text);
                    cmd.Parameters.AddWithValue("@hot", hoTxt.Text);
                    cmd.Parameters.AddWithValue("@im", img);
                    try
                    {
                        MyConnection.Open();
                        MyDataReader = cmd.ExecuteReader();
                        dt.Load(MyDataReader);
                    }
                    catch (Exception Ex)
                    {

                        MessageBox.Show(Ex.Message, ToString());
                    }
                    finally
                    {
                        MessageBox.Show("Record Updated!");
                        paTxt.Clear();
                        flightTxt.Clear();
                        depDate.ResetText();
                        depTime.SelectedIndex = 0;
                        arrDate.ResetText();
                        arrTime.SelectedIndex = 0;
                        prTxt.Clear();
                        hoTxt.Clear();
                        picBox.Image = null;
                        MyConnection.Close();
                    }
                }
                catch (Exception Ex)
                {
                    MyConnection.Close();
                    MessageBox.Show(Ex.Message, ToString());
                }
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (paTxt.Text == "" || flightTxt.Text == "" || depDate.Text == "" || depTime.Text == "" || arrDate.Text == "" || arrTime.Text == "" || prTxt.Text == "" || hoTxt.Text == "")
            {
                MessageBox.Show("FIll the fields first!");
            }
            else
            {
                try
                {
                    string command1 = "select pkg_id from pakages where pkg_name='" + paTxt.Text + "';";
                    cmd = new SqlCommand(command1, MyConnection);
                    MyConnection.Open();
                    MyDataReader = cmd.ExecuteReader();
                    if (MyDataReader.Read())
                    {
                        pid = MyDataReader[0].ToString();
                        MyConnection.Close();
                    }
                    string cmd2 = "delete from Bookings where pkg_id='" + pid + "';";
                    cmd = new SqlCommand(cmd2, MyConnection);
                    MyConnection.Open();
                    MyDataReader = cmd.ExecuteReader();
                    MyConnection.Close();
                    cmd = new SqlCommand("[pkg_delete]", MyConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pname", paTxt.Text);
                    try
                    {
                        MyConnection.Open();
                        MyDataReader = cmd.ExecuteReader();
                        dt.Load(MyDataReader);
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message, ToString());
                    }
                    finally
                    {
                        MessageBox.Show("Record Deleted!");
                        paTxt.Clear();
                        flightTxt.Clear();
                        depTime.Text = string.Empty;
                        arrTime.Text = string.Empty;
                        prTxt.Clear();
                        hoTxt.Clear();
                        picBox.Image = null;
                        MyConnection.Close();
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message, ToString());
                }
            }
        }

        private void paTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void paTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar == '\b' || e.KeyChar == ' ')
            {
                e.Handled = false;
                paTxt.MaxLength = 50;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void flightTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '\b' || e.KeyChar == ' ')
            {
                e.Handled = false;
                flightTxt.MaxLength = 50;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void prTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '\b')
            {
                e.Handled = false;
                prTxt.MaxLength = 25;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void hoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar == '\b' || e.KeyChar == ' ')
            {
                e.Handled = false;
                hoTxt.MaxLength = 50;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void depTime_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void depTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void arrTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
