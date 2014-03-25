using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Data_Dictionary
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        private string name_of_table;
        public Window2()
        {
            InitializeComponent();
        }
        public Window2(string selected_item) : this()
        {
            this.name_of_table = selected_item;
            table_data();
        }

        private void DataGrid_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }
        private void fill_textboxes(string TableName, string Table_description1, string Column_1, string column1_description, string Column_2, string column2_description, string Column_3, string column3_description, string Column_4, string column4_description, string Column_5, string column5_description, string Column_6, string column6_description, string Column_7, string column7_description)
        {
            Name_of_the_table.Text = TableName;
            Table_description.Text = Table_description1;

            //Column name goes here
            Column1.Text = Column_1;
            Column2.Text = Column_2;
            Column3.Text = Column_3;
            Column4.Text = Column_4;
            Column5.Text = Column_5;
            Column6.Text = Column_6;
            Column7.Text = Column_7;

            // Column Descriptions
            Description1.Text = column1_description;
            Description2.Text = column2_description;
            Description3.Text = column3_description;
            Description4.Text = column4_description;
            Description5.Text = column5_description;
            Description6.Text = column6_description;
            Description7.Text = column7_description;
        }
        private void table_data()
        {
            string table;
            string tabl_des;

            string colmn1;
            string colmn2;
            string colmn3;
            string colmn4;
            string colmn5;
            string colmn6;
            string colmn7;

            string colmn1_des;
            string colmn2_des;
            string colmn3_des;
            string colmn4_des;
            string colmn5_des;
            string colmn6_des;
            string colmn7_des;

           // Name_of_the_table.Text = name_of_table;
                if(name_of_table.Equals("System.Windows.Controls.ListBoxItem: MaximumDeviation"))
                {
                    // something here
                    table = "MaximumDeviation";
                    tabl_des = "Table Description";

                    colmn1 = "Column1";
                    colmn2 = "Column2";
                    colmn3 = "column3";
                    colmn4 = "column4";
                    colmn5 = "column5";
                    colmn6 = "column6";
                    colmn7 = "column7";

                    colmn1_des = "Column 1 Description";
                    colmn2_des = "Column 2 Description";
                    colmn3_des = "Column 3 Description";
                    colmn4_des = "Column 4 Description";
                    colmn5_des = "Column 5 Description";
                    colmn6_des = "Column 6 Description";
                    colmn7_des = "Column 7 Description";

                    fill_textboxes(table, tabl_des, colmn1, colmn2, colmn3, colmn4, colmn5, colmn6, colmn7, colmn1_des, colmn2_des, colmn3_des, colmn4_des, colmn5_des, colmn6_des, colmn7_des);
                }
                else if (name_of_table.Equals("System.Windows.Controls.ListBoxItem: ModelTypes"))
                {

                    //Fill_textboxes(string TableName, string Table_description, string Column1, string column1_description,  string Column2, string column2_description,  string Column3, string column3_description,  string Column4, string column4_description,  string Column5, string column5_description,  string Column6, string column6_description,  string Column7, string column7_description)
                    table = "ModelTypes";
                    tabl_des = "Table Description";

                    colmn1 = "Column1";
                    colmn2 = "Column2";
                    colmn3 = "column3";
                    colmn4 = "column4";
                    colmn5 = "column5";
                    colmn6 = "column6";
                    colmn7 = "column7";

                    colmn1_des = "Column 1 Description";
                    colmn2_des = "Column 2 Description";
                    colmn3_des = "Column 3 Description";
                    colmn4_des = "Column 4 Description";
                    colmn5_des = "Column 5 Description";
                    colmn6_des = "Column 6 Description";
                    colmn7_des = "Column 7 Description";

                    fill_textboxes(table, tabl_des, colmn1, colmn2, colmn3, colmn4, colmn5, colmn6, colmn7, colmn1_des, colmn2_des, colmn3_des, colmn4_des, colmn5_des, colmn6_des, colmn7_des);
                }
                else if (name_of_table.Equals("System.Windows.Controls.ListBoxItem: PublishedModels"))
                {
                    table = "PublishedModels";
                    tabl_des = "Table Description";

                    colmn1 = "Column1";
                    colmn2 = "Column2";
                    colmn3 = "column3";
                    colmn4 = "column4";
                    colmn5 = "column5";
                    colmn6 = "column6";
                    colmn7 = "column7";

                    colmn1_des = "Column 1 Description";
                    colmn2_des = "Column 2 Description";
                    colmn3_des = "Column 3 Description";
                    colmn4_des = "Column 4 Description";
                    colmn5_des = "Column 5 Description";
                    colmn6_des = "Column 6 Description";
                    colmn7_des = "Column 7 Description";

                    fill_textboxes(table, tabl_des, colmn1, colmn2, colmn3, colmn4, colmn5, colmn6, colmn7, colmn1_des, colmn2_des, colmn3_des, colmn4_des, colmn5_des, colmn6_des, colmn7_des);
                }
                else if (name_of_table.Equals("System.Windows.Controls.ListBoxItem: PublishedTables"))
                {
                    table = "PublishedTables";
                    tabl_des = "Table Description";

                    colmn1 = "Column1";
                    colmn2 = "Column2";
                    colmn3 = "column3";
                    colmn4 = "column4";
                    colmn5 = "column5";
                    colmn6 = "column6";
                    colmn7 = "column7";

                    colmn1_des = "Column 1 Description";
                    colmn2_des = "Column 2 Description";
                    colmn3_des = "Column 3 Description";
                    colmn4_des = "Column 4 Description";
                    colmn5_des = "Column 5 Description";
                    colmn6_des = "Column 6 Description";
                    colmn7_des = "Column 7 Description";

                    fill_textboxes(table, tabl_des, colmn1, colmn2, colmn3, colmn4, colmn5, colmn6, colmn7, colmn1_des, colmn2_des, colmn3_des, colmn4_des, colmn5_des, colmn6_des, colmn7_des);
                }
                else if (name_of_table.Equals("System.Windows.Controls.ListBoxItem: Raw5MtoSLRestrictions"))
                {
                    table = "Raw5MtoSLRestrictions";
                    tabl_des = "Table Description";

                    colmn1 = "Column1";
                    colmn2 = "Column2";
                    colmn3 = "column3";
                    colmn4 = "column4";
                    colmn5 = "column5";
                    colmn6 = "column6";
                    colmn7 = "column7";

                    colmn1_des = "Column 1 Description";
                    colmn2_des = "Column 2 Description";
                    colmn3_des = "Column 3 Description";
                    colmn4_des = "Column 4 Description";
                    colmn5_des = "Column 5 Description";
                    colmn6_des = "Column 6 Description";
                    colmn7_des = "Column 7 Description";

                    fill_textboxes(table, tabl_des, colmn1, colmn2, colmn3, colmn4, colmn5, colmn6, colmn7, colmn1_des, colmn2_des, colmn3_des, colmn4_des, colmn5_des, colmn6_des, colmn7_des);
                }
                else if (name_of_table.Equals("System.Windows.Controls.ListBoxItem: RawCleanSiloCapacity"))
                {
                    table = "RawCleanSiloCapacity";
                    tabl_des = "Table Description";

                    colmn1 = "Column1";
                    colmn2 = "Column2";
                    colmn3 = "column3";
                    colmn4 = "column4";
                    colmn5 = "column5";
                    colmn6 = "column6";
                    colmn7 = "column7";

                    colmn1_des = "Column 1 Description";
                    colmn2_des = "Column 2 Description";
                    colmn3_des = "Column 3 Description";
                    colmn4_des = "Column 4 Description";
                    colmn5_des = "Column 5 Description";
                    colmn6_des = "Column 6 Description";
                    colmn7_des = "Column 7 Description";

                    fill_textboxes(table, tabl_des, colmn1, colmn2, colmn3, colmn4, colmn5, colmn6, colmn7, colmn1_des, colmn2_des, colmn3_des, colmn4_des, colmn5_des, colmn6_des, colmn7_des);
                }
                else if (name_of_table.Equals("System.Windows.Controls.ListBoxItem: RawCleanSiloInventory"))
                {
                    table = "RawCleanSiloInventory";
                    tabl_des = "Table Description";

                    colmn1 = "Column1";
                    colmn2 = "Column2";
                    colmn3 = "column3";
                    colmn4 = "column4";
                    colmn5 = "column5";
                    colmn6 = "column6";
                    colmn7 = "column7";

                    colmn1_des = "Column 1 Description";
                    colmn2_des = "Column 2 Description";
                    colmn3_des = "Column 3 Description";
                    colmn4_des = "Column 4 Description";
                    colmn5_des = "Column 5 Description";
                    colmn6_des = "Column 6 Description";
                    colmn7_des = "Column 7 Description";

                    fill_textboxes(table, tabl_des, colmn1, colmn2, colmn3, colmn4, colmn5, colmn6, colmn7, colmn1_des, colmn2_des, colmn3_des, colmn4_des, colmn5_des, colmn6_des, colmn7_des);
                }
                else if (name_of_table.Equals("System.Windows.Controls.ListBoxItem: RawCleanSiloInventoryConstrainsts"))
                {
                    table = "RawCleanSiloInventoryConstrainsts";
                    tabl_des = "Table Description";

                    colmn1 = "Column1";
                    colmn2 = "Column2";
                    colmn3 = "column3";
                    colmn4 = "column4";
                    colmn5 = "column5";
                    colmn6 = "column6";
                    colmn7 = "column7";

                    colmn1_des = "Column 1 Description";
                    colmn2_des = "Column 2 Description";
                    colmn3_des = "Column 3 Description";
                    colmn4_des = "Column 4 Description";
                    colmn5_des = "Column 5 Description";
                    colmn6_des = "Column 6 Description";
                    colmn7_des = "Column 7 Description";

                    fill_textboxes(table, tabl_des, colmn1, colmn2, colmn3, colmn4, colmn5, colmn6, colmn7, colmn1_des, colmn2_des, colmn3_des, colmn4_des, colmn5_des, colmn6_des, colmn7_des);
                }
                else if (name_of_table.Equals("System.Windows.Controls.ListBoxItem: RawCMtoCSRestriction"))
                {
                    table = "RawCMtoCSRestriction";
                    tabl_des = "Table Description";

                    colmn1 = "Column1";
                    colmn2 = "Column2";
                    colmn3 = "column3";
                    colmn4 = "column4";
                    colmn5 = "column5";
                    colmn6 = "column6";
                    colmn7 = "column7";

                    colmn1_des = "Column 1 Description";
                    colmn2_des = "Column 2 Description";
                    colmn3_des = "Column 3 Description";
                    colmn4_des = "Column 4 Description";
                    colmn5_des = "Column 5 Description";
                    colmn6_des = "Column 6 Description";
                    colmn7_des = "Column 7 Description";

                    fill_textboxes(table, tabl_des, colmn1, colmn2, colmn3, colmn4, colmn5, colmn6, colmn7, colmn1_des, colmn2_des, colmn3_des, colmn4_des, colmn5_des, colmn6_des, colmn7_des);
                }
                else if (name_of_table.Equals("System.Windows.Controls.ListBoxItem: RawComponentThroughPut"))
                {
                    table = "RawComponentThroughPut";
                    tabl_des = "Table Description";

                    colmn1 = "Column1";
                    colmn2 = "Column2";
                    colmn3 = "column3";
                    colmn4 = "column4";
                    colmn5 = "column5";
                    colmn6 = "column6";
                    colmn7 = "column7";

                    colmn1_des = "Column 1 Description";
                    colmn2_des = "Column 2 Description";
                    colmn3_des = "Column 3 Description";
                    colmn4_des = "Column 4 Description";
                    colmn5_des = "Column 5 Description";
                    colmn6_des = "Column 6 Description";
                    colmn7_des = "Column 7 Description";

                    fill_textboxes(table, tabl_des, colmn1, colmn2, colmn3, colmn4, colmn5, colmn6, colmn7, colmn1_des, colmn2_des, colmn3_des, colmn4_des, colmn5_des, colmn6_des, colmn7_des);
                }
                else if (name_of_table.Equals("System.Windows.Controls.ListBoxItem: RawComponentYield"))
                {
                    table = "RawComponentYield";
                    tabl_des = "Table Description";

                    colmn1 = "Column1";
                    colmn2 = "Column2";
                    colmn3 = "column3";
                    colmn4 = "column4";
                    colmn5 = "column5";
                    colmn6 = "column6";
                    colmn7 = "column7";

                    colmn1_des = "Column 1 Description";
                    colmn2_des = "Column 2 Description";
                    colmn3_des = "Column 3 Description";
                    colmn4_des = "Column 4 Description";
                    colmn5_des = "Column 5 Description";
                    colmn6_des = "Column 6 Description";
                    colmn7_des = "Column 7 Description";

                    fill_textboxes(table, tabl_des, colmn1, colmn2, colmn3, colmn4, colmn5, colmn6, colmn7, colmn1_des, colmn2_des, colmn3_des, colmn4_des, colmn5_des, colmn6_des, colmn7_des);
                }
                else if (name_of_table.Equals("System.Windows.Controls.ListBoxItem: RawComponentYieldFormula"))
                {
                    table = "RawComponentYieldFormula";
                    tabl_des = "Table Description";

                    colmn1 = "Column1";
                    colmn2 = "Column2";
                    colmn3 = "column3";
                    colmn4 = "column4";
                    colmn5 = "column5";
                    colmn6 = "column6";
                    colmn7 = "column7";

                    colmn1_des = "Column 1 Description";
                    colmn2_des = "Column 2 Description";
                    colmn3_des = "Column 3 Description";
                    colmn4_des = "Column 4 Description";
                    colmn5_des = "Column 5 Description";
                    colmn6_des = "Column 6 Description";
                    colmn7_des = "Column 7 Description";

                    fill_textboxes(table, tabl_des, colmn1, colmn2, colmn3, colmn4, colmn5, colmn6, colmn7, colmn1_des, colmn2_des, colmn3_des, colmn4_des, colmn5_des, colmn6_des, colmn7_des);
                }
                else if (name_of_table.Equals("System.Windows.Controls.ListBoxItem: RawDemand"))
                {
                    table = "RawDemand";
                    tabl_des = "Table Description";

                    colmn1 = "Column1";
                    colmn2 = "Column2";
                    colmn3 = "column3";
                    colmn4 = "column4";
                    colmn5 = "column5";
                    colmn6 = "column6";
                    colmn7 = "column7";

                    colmn1_des = "Column 1 Description";
                    colmn2_des = "Column 2 Description";
                    colmn3_des = "Column 3 Description";
                    colmn4_des = "Column 4 Description";
                    colmn5_des = "Column 5 Description";
                    colmn6_des = "Column 6 Description";
                    colmn7_des = "Column 7 Description";

                    fill_textboxes(table, tabl_des, colmn1, colmn2, colmn3, colmn4, colmn5, colmn6, colmn7, colmn1_des, colmn2_des, colmn3_des, colmn4_des, colmn5_des, colmn6_des, colmn7_des);
                }
                else if (name_of_table.Equals("System.Windows.Controls.ListBoxItem: RawMasterComponents"))
                {
                    table = "RawMasterComponents";
                    tabl_des = "Table Description";

                    colmn1 = "Column1";
                    colmn2 = "Column2";
                    colmn3 = "column3";
                    colmn4 = "column4";
                    colmn5 = "column5";
                    colmn6 = "column6";
                    colmn7 = "column7";

                    colmn1_des = "Column 1 Description";
                    colmn2_des = "Column 2 Description";
                    colmn3_des = "Column 3 Description";
                    colmn4_des = "Column 4 Description";
                    colmn5_des = "Column 5 Description";
                    colmn6_des = "Column 6 Description";
                    colmn7_des = "Column 7 Description";

                    fill_textboxes(table, tabl_des, colmn1, colmn2, colmn3, colmn4, colmn5, colmn6, colmn7, colmn1_des, colmn2_des, colmn3_des, colmn4_des, colmn5_des, colmn6_des, colmn7_des);
                }
                else if (name_of_table.Equals("System.Windows.Controls.ListBoxItem: RawMasterPeriod"))
                {
                    table = "RawMasterPeriod";
                    tabl_des = "Table Description";

                    colmn1 = "Column1";
                    colmn2 = "Column2";
                    colmn3 = "column3";
                    colmn4 = "column4";
                    colmn5 = "column5";
                    colmn6 = "column6";
                    colmn7 = "column7";

                    colmn1_des = "Column 1 Description";
                    colmn2_des = "Column 2 Description";
                    colmn3_des = "Column 3 Description";
                    colmn4_des = "Column 4 Description";
                    colmn5_des = "Column 5 Description";
                    colmn6_des = "Column 6 Description";
                    colmn7_des = "Column 7 Description";

                    fill_textboxes(table, tabl_des, colmn1, colmn2, colmn3, colmn4, colmn5, colmn6, colmn7, colmn1_des, colmn2_des, colmn3_des, colmn4_des, colmn5_des, colmn6_des, colmn7_des);
                }
                else if (name_of_table.Equals("System.Windows.Controls.ListBoxItem: RawMasterQualities"))
                {
                    table = "RawMasterQualities";
                    tabl_des = "Table Description";

                    colmn1 = "Column1";
                    colmn2 = "Column2";
                    colmn3 = "column3";
                    colmn4 = "column4";
                    colmn5 = "column5";
                    colmn6 = "column6";
                    colmn7 = "column7";

                    colmn1_des = "Column 1 Description";
                    colmn2_des = "Column 2 Description";
                    colmn3_des = "Column 3 Description";
                    colmn4_des = "Column 4 Description";
                    colmn5_des = "Column 5 Description";
                    colmn6_des = "Column 6 Description";
                    colmn7_des = "Column 7 Description";

                    fill_textboxes(table, tabl_des, colmn1, colmn2, colmn3, colmn4, colmn5, colmn6, colmn7, colmn1_des, colmn2_des, colmn3_des, colmn4_des, colmn5_des, colmn6_des, colmn7_des);
                }
                else if (name_of_table.Equals("System.Windows.Controls.ListBoxItem: RawMasterRawSilos"))
                {
                    table = "RawMasterRawSilos";
                    tabl_des = "Table Description";

                    colmn1 = "Column1";
                    colmn2 = "Column2";
                    colmn3 = "column3";
                    colmn4 = "column4";
                    colmn5 = "column5";
                    colmn6 = "column6";
                    colmn7 = "column7";

                    colmn1_des = "Column 1 Description";
                    colmn2_des = "Column 2 Description";
                    colmn3_des = "Column 3 Description";
                    colmn4_des = "Column 4 Description";
                    colmn5_des = "Column 5 Description";
                    colmn6_des = "Column 6 Description";
                    colmn7_des = "Column 7 Description";

                    fill_textboxes(table, tabl_des, colmn1, colmn2, colmn3, colmn4, colmn5, colmn6, colmn7, colmn1_des, colmn2_des, colmn3_des, colmn4_des, colmn5_des, colmn6_des, colmn7_des);
                }
                else if (name_of_table.Equals("System.Windows.Controls.ListBoxItem: RawPlantOpHours"))
                {
                    table = "RawPlantOpHours";
                    tabl_des = "Table Description";

                    colmn1 = "Column1";
                    colmn2 = "Column2";
                    colmn3 = "column3";
                    colmn4 = "column4";
                    colmn5 = "column5";
                    colmn6 = "column6";
                    colmn7 = "column7";

                    colmn1_des = "Column 1 Description";
                    colmn2_des = "Column 2 Description";
                    colmn3_des = "Column 3 Description";
                    colmn4_des = "Column 4 Description";
                    colmn5_des = "Column 5 Description";
                    colmn6_des = "Column 6 Description";
                    colmn7_des = "Column 7 Description";

                    fill_textboxes(table, tabl_des, colmn1, colmn2, colmn3, colmn4, colmn5, colmn6, colmn7, colmn1_des, colmn2_des, colmn3_des, colmn4_des, colmn5_des, colmn6_des, colmn7_des);
                }
                else if (name_of_table.Equals("System.Windows.Controls.ListBoxItem: RawPublishedSupply"))
                {
                    table = "RawPublishedSupply";
                    tabl_des = "Table Description";

                    colmn1 = "Column1";
                    colmn2 = "Column2";
                    colmn3 = "column3";
                    colmn4 = "column4";
                    colmn5 = "column5";
                    colmn6 = "column6";
                    colmn7 = "column7";

                    colmn1_des = "Column 1 Description";
                    colmn2_des = "Column 2 Description";
                    colmn3_des = "Column 3 Description";
                    colmn4_des = "Column 4 Description";
                    colmn5_des = "Column 5 Description";
                    colmn6_des = "Column 6 Description";
                    colmn7_des = "Column 7 Description";

                    fill_textboxes(table, tabl_des, colmn1, colmn2, colmn3, colmn4, colmn5, colmn6, colmn7, colmn1_des, colmn2_des, colmn3_des, colmn4_des, colmn5_des, colmn6_des, colmn7_des);
                }
                else if (name_of_table.Equals("System.Windows.Controls.ListBoxItem: RawQualityRestriction"))
                {
                    table = "RawQualityRestriction";
                    tabl_des = "Table Description";

                    colmn1 = "Column1";
                    colmn2 = "Column2";
                    colmn3 = "column3";
                    colmn4 = "column4";
                    colmn5 = "column5";
                    colmn6 = "column6";
                    colmn7 = "column7";

                    colmn1_des = "Column 1 Description";
                    colmn2_des = "Column 2 Description";
                    colmn3_des = "Column 3 Description";
                    colmn4_des = "Column 4 Description";
                    colmn5_des = "Column 5 Description";
                    colmn6_des = "Column 6 Description";
                    colmn7_des = "Column 7 Description";

                    fill_textboxes(table, tabl_des, colmn1, colmn2, colmn3, colmn4, colmn5, colmn6, colmn7, colmn1_des, colmn2_des, colmn3_des, colmn4_des, colmn5_des, colmn6_des, colmn7_des);
                }
                else if (name_of_table.Equals("System.Windows.Controls.ListBoxItem: RawRawSiloCapacity"))
                {
                    table = "RawRawSiloCapacity";
                    tabl_des = "Table Description";

                    colmn1 = "Column1";
                    colmn2 = "Column2";
                    colmn3 = "column3";
                    colmn4 = "column4";
                    colmn5 = "column5";
                    colmn6 = "column6";
                    colmn7 = "column7";

                    colmn1_des = "Column 1 Description";
                    colmn2_des = "Column 2 Description";
                    colmn3_des = "Column 3 Description";
                    colmn4_des = "Column 4 Description";
                    colmn5_des = "Column 5 Description";
                    colmn6_des = "Column 6 Description";
                    colmn7_des = "Column 7 Description";

                    fill_textboxes(table, tabl_des, colmn1, colmn2, colmn3, colmn4, colmn5, colmn6, colmn7, colmn1_des, colmn2_des, colmn3_des, colmn4_des, colmn5_des, colmn6_des, colmn7_des);
                }
                else if (name_of_table.Equals("System.Windows.Controls.ListBoxItem: RawSeamQualities"))
                {
                    table = "RawSeamQualities";
                    tabl_des = "Table Description";

                    colmn1 = "Column1";
                    colmn2 = "Column2";
                    colmn3 = "column3";
                    colmn4 = "column4";
                    colmn5 = "column5";
                    colmn6 = "column6";
                    colmn7 = "column7";

                    colmn1_des = "Column 1 Description";
                    colmn2_des = "Column 2 Description";
                    colmn3_des = "Column 3 Description";
                    colmn4_des = "Column 4 Description";
                    colmn5_des = "Column 5 Description";
                    colmn6_des = "Column 6 Description";
                    colmn7_des = "Column 7 Description";

                    fill_textboxes(table, tabl_des, colmn1, colmn2, colmn3, colmn4, colmn5, colmn6, colmn7, colmn1_des, colmn2_des, colmn3_des, colmn4_des, colmn5_des, colmn6_des, colmn7_des);
                }
                else if (name_of_table.Equals("System.Windows.Controls.ListBoxItem: RawSeamQualities"))
                {
                    table = "RawSeamQualities";
                    tabl_des = "Table Description";

                    colmn1 = "Column1";
                    colmn2 = "Column2";
                    colmn3 = "column3";
                    colmn4 = "column4";
                    colmn5 = "column5";
                    colmn6 = "column6";
                    colmn7 = "column7";

                    colmn1_des = "Column 1 Description";
                    colmn2_des = "Column 2 Description";
                    colmn3_des = "Column 3 Description";
                    colmn4_des = "Column 4 Description";
                    colmn5_des = "Column 5 Description";
                    colmn6_des = "Column 6 Description";
                    colmn7_des = "Column 7 Description";

                    fill_textboxes(table, tabl_des, colmn1, colmn2, colmn3, colmn4, colmn5, colmn6, colmn7, colmn1_des, colmn2_des, colmn3_des, colmn4_des, colmn5_des, colmn6_des, colmn7_des);
                }
                else if (name_of_table.Equals("System.Windows.Controls.ListBoxItem: RawSeamRelease"))
                {
                    table = "RawSeamRelease";
                    tabl_des = "Table Description";

                    colmn1 = "Column1";
                    colmn2 = "Column2";
                    colmn3 = "column3";
                    colmn4 = "column4";
                    colmn5 = "column5";
                    colmn6 = "column6";
                    colmn7 = "column7";

                    colmn1_des = "Column 1 Description";
                    colmn2_des = "Column 2 Description";
                    colmn3_des = "Column 3 Description";
                    colmn4_des = "Column 4 Description";
                    colmn5_des = "Column 5 Description";
                    colmn6_des = "Column 6 Description";
                    colmn7_des = "Column 7 Description";

                    fill_textboxes(table, tabl_des, colmn1, colmn2, colmn3, colmn4, colmn5, colmn6, colmn7, colmn1_des, colmn2_des, colmn3_des, colmn4_des, colmn5_des, colmn6_des, colmn7_des);
                }
                else if (name_of_table.Equals("System.Windows.Controls.ListBoxItem: RawSiloInventory"))
                {
                    table = "RawSiloInventory";
                    tabl_des = "Table Description";

                    colmn1 = "Column1";
                    colmn2 = "Column2";
                    colmn3 = "column3";
                    colmn4 = "column4";
                    colmn5 = "column5";
                    colmn6 = "column6";
                    colmn7 = "column7";

                    colmn1_des = "Column 1 Description";
                    colmn2_des = "Column 2 Description";
                    colmn3_des = "Column 3 Description";
                    colmn4_des = "Column 4 Description";
                    colmn5_des = "Column 5 Description";
                    colmn6_des = "Column 6 Description";
                    colmn7_des = "Column 7 Description";

                    fill_textboxes(table, tabl_des, colmn1, colmn2, colmn3, colmn4, colmn5, colmn6, colmn7, colmn1_des, colmn2_des, colmn3_des, colmn4_des, colmn5_des, colmn6_des, colmn7_des);
                }
                else if (name_of_table.Equals("System.Windows.Controls.ListBoxItem: RawSiloInventoryConstraints"))
                {
                    table = "RawSiloInventoryConstraints";
                    tabl_des = "Table Description";

                    colmn1 = "Column1";
                    colmn2 = "Column2";
                    colmn3 = "column3";
                    colmn4 = "column4";
                    colmn5 = "column5";
                    colmn6 = "column6";
                    colmn7 = "column7";

                    colmn1_des = "Column 1 Description";
                    colmn2_des = "Column 2 Description";
                    colmn3_des = "Column 3 Description";
                    colmn4_des = "Column 4 Description";
                    colmn5_des = "Column 5 Description";
                    colmn6_des = "Column 6 Description";
                    colmn7_des = "Column 7 Description";

                    fill_textboxes(table, tabl_des, colmn1, colmn2, colmn3, colmn4, colmn5, colmn6, colmn7, colmn1_des, colmn2_des, colmn3_des, colmn4_des, colmn5_des, colmn6_des, colmn7_des);
                }
                else if (name_of_table.Equals("System.Windows.Controls.ListBoxItem: RawSiloToCmCorrection"))
                {
                    table = "RawSiloToCmCorrection";
                    tabl_des = "Table Description";

                    colmn1 = "Column1";
                    colmn2 = "Column2";
                    colmn3 = "column3";
                    colmn4 = "column4";
                    colmn5 = "column5";
                    colmn6 = "column6";
                    colmn7 = "column7";

                    colmn1_des = "Column 1 Description";
                    colmn2_des = "Column 2 Description";
                    colmn3_des = "Column 3 Description";
                    colmn4_des = "Column 4 Description";
                    colmn5_des = "Column 5 Description";
                    colmn6_des = "Column 6 Description";
                    colmn7_des = "Column 7 Description";

                    fill_textboxes(table, tabl_des, colmn1, colmn2, colmn3, colmn4, colmn5, colmn6, colmn7, colmn1_des, colmn2_des, colmn3_des, colmn4_des, colmn5_des, colmn6_des, colmn7_des);
                }
                else if (name_of_table.Equals("System.Windows.Controls.ListBoxItem: RawSites"))
                {
                    table = "RawSites";
                    tabl_des = "Table Description";

                    colmn1 = "Column1";
                    colmn2 = "Column2";
                    colmn3 = "column3";
                    colmn4 = "column4";
                    colmn5 = "column5";
                    colmn6 = "column6";
                    colmn7 = "column7";

                    colmn1_des = "Column 1 Description";
                    colmn2_des = "Column 2 Description";
                    colmn3_des = "Column 3 Description";
                    colmn4_des = "Column 4 Description";
                    colmn5_des = "Column 5 Description";
                    colmn6_des = "Column 6 Description";
                    colmn7_des = "Column 7 Description";

                    fill_textboxes(table, tabl_des, colmn1, colmn2, colmn3, colmn4, colmn5, colmn6, colmn7, colmn1_des, colmn2_des, colmn3_des, colmn4_des, colmn5_des, colmn6_des, colmn7_des);
                }
                else if (name_of_table.Equals("System.Windows.Controls.ListBoxItem: RawSitesModel"))
                {
                    table = "RawSitesModel";
                    tabl_des = "Table Description";

                    colmn1 = "Column1";
                    colmn2 = "Column2";
                    colmn3 = "column3";
                    colmn4 = "column4";
                    colmn5 = "column5";
                    colmn6 = "column6";
                    colmn7 = "column7";

                    colmn1_des = "Column 1 Description";
                    colmn2_des = "Column 2 Description";
                    colmn3_des = "Column 3 Description";
                    colmn4_des = "Column 4 Description";
                    colmn5_des = "Column 5 Description";
                    colmn6_des = "Column 6 Description";
                    colmn7_des = "Column 7 Description";

                    fill_textboxes(table, tabl_des, colmn1, colmn2, colmn3, colmn4, colmn5, colmn6, colmn7, colmn1_des, colmn2_des, colmn3_des, colmn4_des, colmn5_des, colmn6_des, colmn7_des);
                }
                else if (name_of_table.Equals("System.Windows.Controls.ListBoxItem: RawSitesModel"))
                {
                    table = "RawSitesModel";
                    tabl_des = "Table Description";

                    colmn1 = "Column1";
                    colmn2 = "Column2";
                    colmn3 = "column3";
                    colmn4 = "column4";
                    colmn5 = "column5";
                    colmn6 = "column6";
                    colmn7 = "column7";

                    colmn1_des = "Column 1 Description";
                    colmn2_des = "Column 2 Description";
                    colmn3_des = "Column 3 Description";
                    colmn4_des = "Column 4 Description";
                    colmn5_des = "Column 5 Description";
                    colmn6_des = "Column 6 Description";
                    colmn7_des = "Column 7 Description";

                    fill_textboxes(table, tabl_des, colmn1, colmn2, colmn3, colmn4, colmn5, colmn6, colmn7, colmn1_des, colmn2_des, colmn3_des, colmn4_des, colmn5_des, colmn6_des, colmn7_des);
                }
                else if (name_of_table.Equals("System.Windows.Controls.ListBoxItem: RawSLtoCMRestrictions"))
                {
                    table = "RawSLtoCMRestrictions";
                    tabl_des = "Table Description";

                    colmn1 = "Column1";
                    colmn2 = "Column2";
                    colmn3 = "column3";
                    colmn4 = "column4";
                    colmn5 = "column5";
                    colmn6 = "column6";
                    colmn7 = "column7";

                    colmn1_des = "Column 1 Description";
                    colmn2_des = "Column 2 Description";
                    colmn3_des = "Column 3 Description";
                    colmn4_des = "Column 4 Description";
                    colmn5_des = "Column 5 Description";
                    colmn6_des = "Column 6 Description";
                    colmn7_des = "Column 7 Description";

                    fill_textboxes(table, tabl_des, colmn1, colmn2, colmn3, colmn4, colmn5, colmn6, colmn7, colmn1_des, colmn2_des, colmn3_des, colmn4_des, colmn5_des, colmn6_des, colmn7_des);
                }
                else if (name_of_table.Equals("System.Windows.Controls.ListBoxItem: RawYieldMethod"))
                {
                    table = "RawYieldMethod";
                    tabl_des = "Table Description";

                    colmn1 = "Column1";
                    colmn2 = "Column2";
                    colmn3 = "column3";
                    colmn4 = "column4";
                    colmn5 = "column5";
                    colmn6 = "column6";
                    colmn7 = "column7";

                    colmn1_des = "Column 1 Description";
                    colmn2_des = "Column 2 Description";
                    colmn3_des = "Column 3 Description";
                    colmn4_des = "Column 4 Description";
                    colmn5_des = "Column 5 Description";
                    colmn6_des = "Column 6 Description";
                    colmn7_des = "Column 7 Description";

                    fill_textboxes(table, tabl_des, colmn1, colmn2, colmn3, colmn4, colmn5, colmn6, colmn7, colmn1_des, colmn2_des, colmn3_des, colmn4_des, colmn5_des, colmn6_des, colmn7_des);
                }
                else if (name_of_table.Equals("System.Windows.Controls.ListBoxItem: Roles"))
                {
                    table = "Roles";
                    tabl_des = "Table Description";

                    colmn1 = "Column1";
                    colmn2 = "Column2";
                    colmn3 = "column3";
                    colmn4 = "column4";
                    colmn5 = "column5";
                    colmn6 = "column6";
                    colmn7 = "column7";

                    colmn1_des = "Column 1 Description";
                    colmn2_des = "Column 2 Description";
                    colmn3_des = "Column 3 Description";
                    colmn4_des = "Column 4 Description";
                    colmn5_des = "Column 5 Description";
                    colmn6_des = "Column 6 Description";
                    colmn7_des = "Column 7 Description";

                    fill_textboxes(table, tabl_des, colmn1, colmn2, colmn3, colmn4, colmn5, colmn6, colmn7, colmn1_des, colmn2_des, colmn3_des, colmn4_des, colmn5_des, colmn6_des, colmn7_des);
                }
                else if (name_of_table.Equals("System.Windows.Controls.ListBoxItem: UserRawSites"))
                {
                    table = "UserRawSites";
                    tabl_des = "Table Description";

                    colmn1 = "Column1";
                    colmn2 = "Column2";
                    colmn3 = "column3";
                    colmn4 = "column4";
                    colmn5 = "column5";
                    colmn6 = "column6";
                    colmn7 = "column7";

                    colmn1_des = "Column 1 Description";
                    colmn2_des = "Column 2 Description";
                    colmn3_des = "Column 3 Description";
                    colmn4_des = "Column 4 Description";
                    colmn5_des = "Column 5 Description";
                    colmn6_des = "Column 6 Description";
                    colmn7_des = "Column 7 Description";

                    fill_textboxes(table, tabl_des, colmn1, colmn2, colmn3, colmn4, colmn5, colmn6, colmn7, colmn1_des, colmn2_des, colmn3_des, colmn4_des, colmn5_des, colmn6_des, colmn7_des);
                }
        }
    }
}
