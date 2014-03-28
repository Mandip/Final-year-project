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
            splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            
        }

        private void Get_PlantOperatingHoursData()
        {
            int row = 1;
            int col = 1;

            int col1;
            int col2;
            float col3;
            string col4;
            string col5;
            string col6;
            string col7;
            string col8;

            var sheet1 = Globals.ThisAddIn.Application.ActiveWorkbook.Worksheets["Sheet1"];
            col = 44;
            row = 3;
            string value = Convert.ToString(sheet1.cells[row, col].value2);
            connection();
            connection_open();
            while (value != null)
            {
                //Get values from excel cells and convert them to appropriate type (should match with column type in database)
                col1 = Convert.ToInt32(value);
                col2 = Convert.ToInt32(sheet1.cells[row, col + 1].value2);
                col3 = Convert.ToSingle(sheet1.cells[row, col + 2].value2);
                col4 = Convert.ToString(sheet1.cells[row, col + 3].value2);
                col5 = Convert.ToString(sheet1.cells[row, col + 4].value2);
                col6 = Convert.ToString(sheet1.cells[row, col + 5].value2);
                col7 = Convert.ToString(sheet1.cells[row, col + 6].value2);
                col8 = Convert.ToString(sheet1.cells[row, col + 7].value2);

                // Insert rows to Database
                PlantOperatingHours(col1, col2, col3, col4, col5, col6, col7, col8);
                row++;
                value = Convert.ToString(sheet1.cells[row, col].value2);
            }
            connection_close();
        }

        private void PlantOperatingHours(int PlantOperatingHoursID, int PeriodId,float Value,string created, string modified, string deleted)
        {
            // in Excel ID , siloid, componentid, periodid, value, created, modified, deleted
            // In database RawCleanSiloInventoryID, userid, modelid, componentid, periodid, value, created, modified, deleted, timestamp
            cmd = new MySqlCommand("INSERT into creat932_scratch.PlantOperatingHours(PlantOperatingHoursId,PeriodId,Value,Created, Modified, Deleted) VALUES(" + PlantOperatingHoursID + "," + PeriodId + "," + Value + ","  + created + "','" + modified + "','" + deleted + ")", conn);
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

        private void Get_RawDemandData()
        {
            int row = 1;
            int col = 1;

            int col1;
            int col2;
            int col3;
            float col4;
            string col5;
            string col6;
            string col7;
            string col8;

            var sheet1 = Globals.ThisAddIn.Application.ActiveWorkbook.Worksheets["Sheet1"];
            col = 35;
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
                col4 = Convert.ToSingle(sheet1.cells[row, col + 3].value2);
                col5 = Convert.ToString(sheet1.cells[row, col + 4].value2);
                col6 = Convert.ToString(sheet1.cells[row, col + 5].value2);
                col7 = Convert.ToString(sheet1.cells[row, col + 6].value2);
                col8 = Convert.ToString(sheet1.cells[row, col + 7].value2);

                // Insert rows to Database
                RawDemand(col1,col3, col4, col5, col6, col7,col8);
                row++;
                value = Convert.ToString(sheet1.cells[row, col].value2);
            }
            connection_close();
        }

        private void RawDemand(int RawDemandID, int ComponentId, int PeriodId,float Value , string created, string modified, string deleted)
        {
            // in Excel ID , siloid, componentid, periodid, value, created, modified, deleted
            // In database RawCleanSiloInventoryID, userid, modelid, componentid, periodid, value, created, modified, deleted, timestamp
            cmd = new MySqlCommand("INSERT into creat932_scratch.RawDemand(RawDemandId,ComponentId,PeriodId,Value,Created, Modified, Deleted) VALUES(" + RawDemandID + "," + ComponentId + "," + PeriodId + ","+ Value+ "," + created + "','" + modified + "','" + deleted + ")", conn);
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
        private void Get_Raw5MToSLRestrictionData()
        {
            int row = 1;
            int col = 1;

            int col1;
            int col2;
            int col3;
            float col4;
            float col5;
            string col6;
            string col7;
            string col8;

            var sheet1 = Globals.ThisAddIn.Application.ActiveWorkbook.Worksheets["Sheet1"];
            col = 26;
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
                col4 = Convert.ToSingle(sheet1.cells[row, col + 3].value2);
                col5 = Convert.ToSingle(sheet1.cells[row, col + 4].value2);
                col6 = Convert.ToString(sheet1.cells[row, col + 5].value2);
                col7 = Convert.ToString(sheet1.cells[row, col + 6].value2);
                col8 = Convert.ToString(sheet1.cells[row, col + 7].value2);

                // Insert rows to Database
                Raw5MToSLRestriction(col1,col2, col3, col4, col5, col6, col7, col8);
                row++;
                value = Convert.ToString(sheet1.cells[row, col].value2);
            }
            connection_close();
        }

        private void Raw5MToSLRestriction(int Raw5MToSLRestrictionID,int SeamId ,int SiloId, float Minimum, float Maximum, string created, string modified, string deleted)
        {
            // in Excel ID , siloid, componentid, periodid, value, created, modified, deleted
            // In database RawCleanSiloInventoryID, userid, modelid, componentid, periodid, value, created, modified, deleted, timestamp
            cmd = new MySqlCommand("INSERT into creat932_scratch.Raw5MToSLRestriction(Raw5MToSLRestrictionId,SeamId,SiloId,Minimum,Maximum,Created, Modified, Deleted) VALUES(" + Raw5MToSLRestrictionID + ","+ SeamId + "," + SiloId + ","  + Minimum + ",'" + Maximum + "','" + created + "','" + modified + "','" + deleted + ")", conn);
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


        private void Get_RawCMToCSRestrictionData()
        {
            int row = 1;
            int col = 1;

            int col1;
            int col2;
            int col3;
            float col4;
            float col5;
            string col6;
            string col7;
            string col8;

            var sheet1 = Globals.ThisAddIn.Application.ActiveWorkbook.Worksheets["Sheet1"];
            col = 17;
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
                col4 = Convert.ToSingle(sheet1.cells[row, col + 3].value2);
                col5 = Convert.ToSingle(sheet1.cells[row, col + 4].value2);
                col6 = Convert.ToString(sheet1.cells[row, col + 5].value2);
                col7 = Convert.ToString(sheet1.cells[row, col + 6].value2);
                col8 = Convert.ToString(sheet1.cells[row, col + 7].value2);

                // Insert rows to Database
                RawCMToCSRestriction(col1, col3, col4, col5, col6, col7, col8);
                row++;
                value = Convert.ToString(sheet1.cells[row, col].value2);
            }
            connection_close();
        }

        private void RawCMToCSRestriction(int RawCMToCSRestrictionID, int SiloId, int componentID, float Minimum, float Maximum, string created, string modified, string deleted)
        {
            // in Excel ID , siloid, componentid, periodid, value, created, modified, deleted
            // In database RawCleanSiloInventoryID, userid, modelid, componentid, periodid, value, created, modified, deleted, timestamp
            cmd = new MySqlCommand("INSERT into creat932_scratch.RawCMToCSRestriction(RawCMToCSRestrictionId,SiloId,ComponentId,Minimum,Maximum,Created, Modified, Deleted) VALUES(" + RawCMToCSRestrictionID + "," + SiloId + "," + componentID + "," + Minimum + ",'" + Maximum + "','" + created + "','" + modified + "','" + deleted + ")", conn);
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
          //  MessageBox.Show("Connection closed");
        }
        private void connection_open()
        {
            conn.Open();
           // MessageBox.Show("Connection opened");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Get_RawCleanSiloInventoryData();
            Get_RawCMToCSRestrictionData();
            Get_Raw5MToSLRestrictionData();
            Get_RawDemandData();
            Get_PlantOperatingHoursData();

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
                panel2.Visible = false;
                
            }

        }

        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string text = e.Node.Text;
            if(loggedin == true)
            {
                if (text.Equals("Select a Model")) 
                {
                    panel6.Visible = false;
                    panel5.Visible = false;
                    panel4.Visible = false;
                    panel3.Visible = true;
                    panel2.Visible = false;
                    panel1.Visible = false;
                }
                else if(text.Equals("Clone an Existing Model"))
                {
                    panel6.Visible = false;
                    panel5.Visible = false;
                    panel4.Visible = true;
                    panel3.Visible = false;
                    panel2.Visible = false;
                    panel1.Visible = false;
                }
                else if (text.Equals("Administer Models"))
                {
                    panel6.Visible = false;
                    panel5.Visible = true;
                    panel4.Visible = false;
                    panel3.Visible = false;
                    panel2.Visible = false;
                    panel1.Visible = false;
                }
                else if (text.Equals("Updates from XPAC")) 
                {
                    panel6.Visible = true;
                    panel5.Visible = false;
                    panel4.Visible = false;
                    panel3.Visible = false;
                    panel2.Visible = false;
                    panel1.Visible = false;
                
                }
                else
                {
                    panel6.Visible = false;
                    panel5.Visible = false;
                    panel4.Visible = false;
                    panel3.Visible = false;
                    panel2.Visible = false;
                    panel1.Visible = false;

                }
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
