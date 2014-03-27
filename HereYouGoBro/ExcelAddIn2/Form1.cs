using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExcelAddIn2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
     
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
  
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
     
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
        }


        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string text = e.Node.Text;
            if (text.Equals("Administer Users"))
            {               
                panel1.Visible = true;
                panel2.Visible = false; 

            }
            if (text.Equals("Select a Model"))
            {
                panel2.Visible = true;
                panel1.Visible = false;
            }
            else
            {
                panel2.Visible = false;
                panel1.Visible = false;
            }            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
  
        }
        
        
   
    
    }

}
