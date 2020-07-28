using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace ahru
{
    class Registration
    {
        SqlConnection MyConnection = new SqlConnection(@"Data Source=Usama;Initial Catalog=Travel;Integrated Security=True");
        SqlDataReader MyDataReader;
        SqlCommand cmd;
        DataTable dt = new DataTable();
        string cid;
        public void cust_regis(string fname, string lname, string cnic, string cell, string mail, string address)
        {
            cmd = new SqlCommand("[cust_insert]", MyConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cnic", cnic);
            cmd.Parameters.AddWithValue("@fname", fname);
            cmd.Parameters.AddWithValue("@lname", lname);
            cmd.Parameters.AddWithValue("@cell", cell);
            cmd.Parameters.AddWithValue("@mail", mail);
            cmd.Parameters.AddWithValue("@address", address);
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
                MessageBox.Show("Record Inserted");
                MyConnection.Close();
            }
        }
        public void cust_update(string cnic,string fname,string lname,string cell,string mail,string address )
        {
            cmd = new SqlCommand("[cust_update]", MyConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cnic", cnic);
            cmd.Parameters.AddWithValue("@fname", fname);
            cmd.Parameters.AddWithValue("@lname", lname);
            cmd.Parameters.AddWithValue("@cell", cell);
            cmd.Parameters.AddWithValue("@mail", mail);
            cmd.Parameters.AddWithValue("@address", address);
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
                MyConnection.Close();
            }
        }
        public void cust_delete(string cnic, string fname, string lname, string cell, string mail, string address)
        {
            string command1 = "select cust_id from Customers where cust_CNIC='" + cnic + "';";
            cmd = new SqlCommand(command1, MyConnection);
            MyConnection.Open();
            MyDataReader = cmd.ExecuteReader();
            if (MyDataReader.Read())
            {
                cid = MyDataReader[0].ToString();
                MyConnection.Close();
            }
            string cmd2 = "delete from Bookings where cust_id='" + cid + "';";
            cmd = new SqlCommand(cmd2, MyConnection);
            MyConnection.Open();
            MyDataReader = cmd.ExecuteReader();
            MyConnection.Close();
            cmd = new SqlCommand("[cust_delete]", MyConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cnic", cnic);
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
                MyConnection.Close();
            }
        }


        public void agent_regis(string cnic,string fname,string lname,string user,string pass, string email,string phone)
        {
            cmd = new SqlCommand("[agent_insert]", MyConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cnic", cnic);
            cmd.Parameters.AddWithValue("@fname", fname);
            cmd.Parameters.AddWithValue("@lname", lname);
            cmd.Parameters.AddWithValue("@username", user);
            cmd.Parameters.AddWithValue("@pass", pass);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@phone", phone);
            try
            {
                MyConnection.Open();
                MyDataReader = cmd.ExecuteReader();
                dt.Load(MyDataReader);
            }
            catch (Exception Ex)
            {
                MyConnection.Close();
                MessageBox.Show(Ex.Message, ToString());
            }
            finally
            {
                MessageBox.Show("Record Inserted");
                MyConnection.Close();
            }
        }
        public void agent_update(string cnic, string fname, string lname, string user, string pass, string email, string phone)
        {
            cmd = new SqlCommand("[agent_update]", MyConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cnic", cnic);
            cmd.Parameters.AddWithValue("@fname", fname);
            cmd.Parameters.AddWithValue("@lname", lname);
            cmd.Parameters.AddWithValue("@username", user);
            cmd.Parameters.AddWithValue("@pass", pass);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@phone", phone);
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
                MyConnection.Close();
            }
        }
        public void agent_delete(string cnic, string fname, string lname, string user, string pass, string email, string phone)
        {
            cmd = new SqlCommand("[agent_delete]", MyConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cnic", cnic);
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

                MyConnection.Close();
            }
        }


        public void admin_regis(string cnic, string fname, string lname, string user, string pass, string email, string phone)
        {
            cmd = new SqlCommand("[admin_insert]", MyConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cnic", cnic);
            cmd.Parameters.AddWithValue("@fname", fname);
            cmd.Parameters.AddWithValue("@lname", lname);
            cmd.Parameters.AddWithValue("@username", user);
            cmd.Parameters.AddWithValue("@pass", pass);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@phone", phone);
            try
            {
                MyConnection.Open();
                MyDataReader = cmd.ExecuteReader();
                dt.Load(MyDataReader);
            }
            catch (Exception Ex)
            {
                MyConnection.Close();
                MessageBox.Show(Ex.Message, ToString());
            }
            finally
            {
                MessageBox.Show("Record Inserted");
                MyConnection.Close();
            }
        }
        public void admin_update(string cnic, string fname, string lname, string user, string pass, string email, string phone)
        {
            cmd = new SqlCommand("[admin_update]", MyConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cnic", cnic);
            cmd.Parameters.AddWithValue("@fname", fname);
            cmd.Parameters.AddWithValue("@lname", lname);
            cmd.Parameters.AddWithValue("@username", user);
            cmd.Parameters.AddWithValue("@pass", pass);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@phone", phone);
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

                MyConnection.Close();
            }
        }
        public void admin_delete(string cnic, string fname, string lname, string user, string pass, string email, string phone)
        {
            cmd = new SqlCommand("[admin_delete]", MyConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cnic", cnic);
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
                MyConnection.Close();
            }
        }


        public void book_regis(string cust_id,string pakg_id)
        {
            cmd = new SqlCommand("[book_in]", MyConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@custid", cust_id);
            cmd.Parameters.AddWithValue("@pid", pakg_id);
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
                MessageBox.Show("Record inserted: ");
                MyConnection.Close();
            }
        }
        
    }
}
