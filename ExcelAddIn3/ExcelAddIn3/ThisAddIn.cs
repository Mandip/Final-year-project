using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;
using System.Windows.Forms;

namespace ExcelAddIn3
{
    public partial class ThisAddIn
    {
        private Microsoft.Office.Tools.CustomTaskPane CustomPane;
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            ShowTaskPane();
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }
        private void ShowTaskPane()
        {
            var usrcrl = new UserControl1();
            CustomPane = this.CustomTaskPanes.Add(usrcrl, "Upload Data");
            CustomPane.Width = 700;
      //      MessageBox.Show("Width is : "+ usrcrl.Width);
            CustomPane.Visible = true;
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
