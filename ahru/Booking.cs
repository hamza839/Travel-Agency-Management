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
using System.Text.RegularExpressions;


namespace ahru
{
    public partial class Booking : Form
    {
        Thread th;
        string cid, pid;
        private void agent_panel(object obj)
        {
            Application.Run(new agent_panel());
        }
        private void view_packages(object obj)
        {
            Application.Run(new view_packages());
        }

        SqlConnection MyConnection = new SqlConnection(@"Data Source=USAMA;Initial Catalog=Travel;Integrated Security=True");
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds = new DataSet();
        SqlDataReader MyDataReader;
        DataTable dt = new DataTable();
        Registration rg = new Registration();


        public Booking()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(agent_panel);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {

        }

        private void Booking_Load(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("[pkg_view]", MyConnection);
                cmd.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    packNameBox.Items.Add("");
                    packNameBox.Items.Add(dr["pkg_name"].ToString());
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

        

        private void packIdBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string command = "select * from pakages where pkg_name = '" + packNameBox.SelectedItem.ToString() + "' ;";
                cmd = new SqlCommand(command, MyConnection);

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
                        deTxt.Text = MyDataReader["depart"].ToString();
                        dtTxt.Text = MyDataReader["dep_time"].ToString();
                        arTxt.Text = MyDataReader["arrival"].ToString();
                        atTxt.Text = MyDataReader["arr_time"].ToString();
                        hoTxt.Text = MyDataReader["hotel"].ToString();
                        toTxt.Text = MyDataReader["price"].ToString();
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
                        
                    }
                }
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
            if (custCnicTxt.Text == "" || custNameTxt.Text == "" || packNameBox.SelectedIndex == 0 || flightTxt.Text == "" || deTxt.Text == "" || dtTxt.Text == "" || arTxt.Text == "" || atTxt.Text == "" || toTxt.Text == "" || hoTxt.Text == "")
            {
                MessageBox.Show("FIll the fields first!");
            }
            else
            {
                try
                {
                    string command1 = "select cust_id from Customers where cust_CNIC='" + custCnicTxt.Text + "';";
                    cmd = new SqlCommand(command1, MyConnection);
                    MyConnection.Open();
                    MyDataReader = cmd.ExecuteReader();
                    if (MyDataReader.Read())
                    {
                        cid = MyDataReader[0].ToString();
                        MyConnection.Close();
                    }
                    string command = "select pkg_id from pakages where pkg_name='" + packNameBox.SelectedItem.ToString() + "' ;";
                    cmd = new SqlCommand(command, MyConnection);
                    MyConnection.Open();
                    MyDataReader = cmd.ExecuteReader();
                    if (MyDataReader.Read())
                    {
                        pid = MyDataReader[0].ToString();
                        MyConnection.Close();
                    }
                    
                    rg.book_regis(cid,pid);
                    custCnicTxt.Clear();
                    custNameTxt.Clear();
                    packNameBox.SelectedIndex = 0;
                    flightTxt.Clear();
                    deTxt.ResetText();
                    dtTxt.Clear();
                    arTxt.ResetText();
                    atTxt.Clear();
                    hoTxt.Clear();
                    toTxt.Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message, ToString());
                }


                string cnic = Convert.ToString(custCnicTxt.Text);
                string cname = Convert.ToString(custNameTxt.Text);
                string pname = Convert.ToString(packNameBox.Text);
                string fname = Convert.ToString(flightTxt.Text);
                string dep = Convert.ToString(deTxt.Text);
                string det = Convert.ToString(dtTxt.Text);
                string arr = Convert.ToString(arTxt.Text);
                string art = Convert.ToString(atTxt.Text);
                string hot = Convert.ToString(hoTxt.Text);
                string tot = Convert.ToString(toTxt.Text);
                string path;
                FolderBrowserDialog folderDlg = new FolderBrowserDialog();
                folderDlg.ShowNewFolderButton = true;
                DialogResult result = folderDlg.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Environment.SpecialFolder root = folderDlg.RootFolder;
                }
                string fileName = cname + "'s Booking.pdf";
                path = System.IO.Path.Combine(folderDlg.SelectedPath, fileName);
                iTextSharp.text.Document d = new iTextSharp.text.Document();
                FileStream file = File.Create(path);
                iTextSharp.text.pdf.PdfWriter.GetInstance(d, file);

                d.Open();
                d.Add(new iTextSharp.text.Paragraph("                                                               TICKET DETAILS"));
                d.Add(new iTextSharp.text.Paragraph("--------------------------------------------------------------------------------------------------------------------------------"));
                d.Add(new iTextSharp.text.Paragraph("                                          CNIC: " + cnic));
                d.Add(new iTextSharp.text.Paragraph("                                         NAME: " + cname));
                d.Add(new iTextSharp.text.Paragraph("                                    PACKAGE: " + pname));
                d.Add(new iTextSharp.text.Paragraph("                                       FLIGHT: " + fname));
                d.Add(new iTextSharp.text.Paragraph("                                DEPARTURE: " + dep + " at " + det));
                d.Add(new iTextSharp.text.Paragraph("                                     ARRIVAL: " + arr + " at " + art));
                d.Add(new iTextSharp.text.Paragraph("                                        HOTEL: " + hot));
                d.Add(new iTextSharp.text.Paragraph("--------------------------------------------------------------------------------------------------------------------------------"));
                d.Add(new iTextSharp.text.Paragraph("                                         PRICE: " + tot + " Rs"));
                d.Close();
            }
        }

        private void custCnicTxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void custNameTxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void custNameTxt_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void packNameBox_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void custCnicTxt_CursorChanged(object sender, EventArgs e)
        {
            
        }

        private void custCnicTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '\b' || e.KeyChar == '-')
            {
                e.Handled = false;
                custCnicTxt.MaxLength = 15;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void custNameTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar == '\b' || e.KeyChar == ' ')
            {
                e.Handled = false;
                custNameTxt.MaxLength = 50;
            }
            else
            {
                e.Handled = true;
            }
        }

        

        private void printPrev_Load(object sender, EventArgs e)
        {
            
        }

        private void custCnicTxt_Leave(object sender, EventArgs e)
        {
            Regex cnic = new System.Text.RegularExpressions.Regex(@"^[0-9]{5}-[0-9]{7}-[0-9]{1}$");
            if (!cnic.IsMatch(custCnicTxt.Text))
            {
                MessageBox.Show("CNIC format is not valid!");
                custCnicTxt.Clear();
                custNameTxt.Clear();
            }
            else
            {   
                    try
                    {
                        string command = "select * from Customers where cust_CNIC = '" + custCnicTxt.Text.ToString() + "' ;";
                        cmd = new SqlCommand(command, MyConnection);
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
                                custNameTxt.Text = Convert.ToString(MyDataReader["cust_Fn"].ToString() + " " + MyDataReader["cust_Ln"].ToString());
                                MyConnection.Close();
                            }
                            else
                            {
                                MessageBox.Show("Records not found!");
                                custCnicTxt.Clear();
                                custNameTxt.Clear();
                            }
                        }
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
}
