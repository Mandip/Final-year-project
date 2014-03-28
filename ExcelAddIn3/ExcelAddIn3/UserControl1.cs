using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace ExcelAddIn3
{
    public partial class UserControl1 : UserControl
    {
        private MySqlConnectionStringBuilder connectionstring;
        private MySqlConnection conn;
        private MySqlCommand cmd;
        private MySqlDataAdapter DataAd;
        private DataTable dt;
        private bool loggedin = false;
        public UserControl1()
        {
            InitializeComponent();
            
        }
        private void Get_RawCleanSiloInventoryData()
        {
            int row = 1;
            int col = 1;
            int col1;
            int col2;
            int col3;
            int col4;
            float col5;
            string col6;
            string col7;
            string col8;

            var sheet1 = Globals.ThisAddIn.Application.ActiveWorkbook.Worksheets["Sheet1"];
            col = 8;
            row = 3;
            string value = Convert.ToString(sheet1.cells[row, col].value2);
            connection();
            connection_open();
            while (value != null)
            {
                //Get values from excel cells and convert them to appropriate type (should match with column type in database)
                col1 = Convert.ToInt32(value);
                col2 = Convert.ToInt32(sheet1.cells[row, col + 1].value2);
                col3 = Convert.ToInt32(sheet1.cells[row, col + 2].value2);
                col4 = Convert.ToInt32(sheet1.cells[row, col + 3].value2);
                col5 = Convert.ToSingle(sheet1.cells[row, col + 4].value2);
                col6 = Convert.ToString(sheet1.cells[row, col + 5].value2);
                col7 = Convert.ToString(sheet1.cells[row, col + 6].value2);
                col8 = Convert.ToString(sheet1.cells[row, col + 7].value2);

                // Insert rows to Database
                RawCleanSiloInventory(col1, col3, col4, col5, col6, col7, col8);
                row++;
                value = Convert.ToString(sheet1.cells[row, col].value2);
            }
            connection_close();
        }

        private void RawCleanSiloInventory(int RawCleanSiloInventoryID, int componentID, int periodId, float value, string created, string modified, string deleted )
        {
            // in Excel ID , siloid, componentid, periodid, value, created, modified, deleted
            // In database RawCleanSiloInventoryID, userid, modelid, componentid, periodid, value, created, modified, deleted, timestamp
            cmd = new MySqlCommand("INSERT into creat932_scratch.RawCleanSiloInventory(RawCleanSiloInventoryId,ComponentId, PeriodId, Value, Created, Modified, Deleted) VALUES("+RawCleanSiloInventoryID+","+componentID+","+periodId+","+value+",'"+created+"','"+modified+"','"+deleted+"')", conn);
       //     cmd.Connection = conn;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection_close();
            }


        }

        private void connection()
        {
            connectionstring = new MySqlConnectionStringBuilder();
            connectionstring.Server = "65.39.128.48";
            connectionstring.Database = "creat932_scratch";
            connectionstring.UserID = "creat932_mandip";
            connectionstring.Password = "]pq!&hSHb4yB";
            connectionstring.ConnectionTimeout = 60;
            connectionstring.Port = 3306;
            connectionstring.AllowZeroDateTime = true;
            conn = new MySqlConnection(connectionstring.ConnectionString);
           
        }

        private void connection_close()
        {
            conn.Close();
            MessageBox.Show("Connection closed");
        }
        private void connection_open()
        {
            conn.Open();
            MessageBox.Show("Connection opened");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Get_RawCleanSiloInventoryData();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            int UserId =0;
            connection();
            connection_open();
            cmd = new MySqlCommand("SELECT UserId FROM creat932_scratch.UserRawSites WHERE UserName = '"+username+"' and Password ='"+password+"'");
            cmd.Connection = conn;
            DataAd = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            DataAd.Fill(dt);
            UserId = Convert.ToInt32(dt.Rows[0]["UserId"]);
            connection_close();
            if (UserId == 0)
            {
                MessageBox.Show("Login Failed, Please try again");
            }
            else
            {
                loggedin = true;
                MessageBox.Show("Congratularions, you are now loggedin");
            }

        }
    }
}
