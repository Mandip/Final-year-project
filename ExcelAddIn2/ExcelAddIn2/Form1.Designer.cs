namespace ExcelAddIn2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Administer Users");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Users", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Select a Model");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Clone an Existing Model");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Administer Models");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Models", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Published Models");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Modify Component Qualities");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Published Models", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Administer Sites");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Sites", new System.Windows.Forms.TreeNode[] {
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Administration", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode6,
            treeNode9,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Updates from XPAC");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("System Updates", new System.Windows.Forms.TreeNode[] {
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Constraints");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Sources");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Raw Storage");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Components");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Qualities");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Periods");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Filtering", new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode19,
            treeNode20});
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Sources");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Components");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Raw Storage");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Quallities");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Master Data Configuration", new System.Windows.Forms.TreeNode[] {
            treeNode22,
            treeNode23,
            treeNode24,
            treeNode25});
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Supply");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Demand");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Source Inventory");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Raw Storage Inventory");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Yields");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Input Data Configuration", new System.Windows.Forms.TreeNode[] {
            treeNode27,
            treeNode28,
            treeNode29,
            treeNode30,
            treeNode31});
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Source to Raw Storage");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Source to Plant");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Raw Storage to Plant");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("Delivery Restrictions", new System.Windows.Forms.TreeNode[] {
            treeNode33,
            treeNode34,
            treeNode35});
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("Plant Operating Hours");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("Plant Configuration", new System.Windows.Forms.TreeNode[] {
            treeNode37});
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("Raw", new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode21,
            treeNode26,
            treeNode32,
            treeNode36,
            treeNode38});
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIcon2 = new System.Windows.Forms.NotifyIcon(this.components);
            this.treeView2 = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView2);
            this.splitContainer1.Size = new System.Drawing.Size(797, 567);
            this.splitContainer1.SplitterDistance = 265;
            this.splitContainer1.TabIndex = 1;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // notifyIcon2
            // 
            this.notifyIcon2.Text = "notifyIcon2";
            this.notifyIcon2.Visible = true;
            // 
            // treeView2
            // 
            this.treeView2.Location = new System.Drawing.Point(0, 38);
            this.treeView2.Name = "treeView2";
            treeNode1.Name = "Node2";
            treeNode1.Text = "Administer Users";
            treeNode2.Name = "Node1";
            treeNode2.Text = "Users";
            treeNode3.Name = "Node26";
            treeNode3.Text = "Select a Model";
            treeNode4.Name = "Node27";
            treeNode4.Text = "Clone an Existing Model";
            treeNode5.Name = "Node29";
            treeNode5.Text = "Administer Models";
            treeNode6.Name = "Node25";
            treeNode6.Text = "Models";
            treeNode7.Name = "Node36";
            treeNode7.Text = "Published Models";
            treeNode8.Name = "Node37";
            treeNode8.Text = "Modify Component Qualities";
            treeNode9.Name = "Node34";
            treeNode9.Text = "Published Models";
            treeNode10.Name = "Node38";
            treeNode10.Text = "Administer Sites";
            treeNode11.Name = "Node35";
            treeNode11.Text = "Sites";
            treeNode12.Name = "Node0";
            treeNode12.Text = "Administration";
            treeNode13.Name = "Node47";
            treeNode13.Text = "Updates from XPAC";
            treeNode14.Name = "Node46";
            treeNode14.Text = "System Updates";
            treeNode15.Name = "Node49";
            treeNode15.Text = "Constraints";
            treeNode16.Name = "Node50";
            treeNode16.Text = "Sources";
            treeNode17.Name = "Node51";
            treeNode17.Text = "Raw Storage";
            treeNode18.Name = "Node52";
            treeNode18.Text = "Components";
            treeNode19.Name = "Node53";
            treeNode19.Text = "Qualities";
            treeNode20.Name = "Node54";
            treeNode20.Text = "Periods";
            treeNode21.Name = "Node48";
            treeNode21.Text = "Filtering";
            treeNode22.Name = "Node56";
            treeNode22.Text = "Sources";
            treeNode23.Name = "Node57";
            treeNode23.Text = "Components";
            treeNode24.Name = "Node58";
            treeNode24.Text = "Raw Storage";
            treeNode25.Name = "Node59";
            treeNode25.Text = "Quallities";
            treeNode26.Name = "Node55";
            treeNode26.Text = "Master Data Configuration";
            treeNode27.Name = "Supply";
            treeNode27.Text = "Supply";
            treeNode28.Name = "Node62";
            treeNode28.Text = "Demand";
            treeNode29.Name = "Node63";
            treeNode29.Text = "Source Inventory";
            treeNode30.Name = "Node64";
            treeNode30.Text = "Raw Storage Inventory";
            treeNode31.Name = "Node65";
            treeNode31.Text = "Yields";
            treeNode32.Name = "Node56";
            treeNode32.Text = "Input Data Configuration";
            treeNode33.Name = "Node68";
            treeNode33.Text = "Source to Raw Storage";
            treeNode34.Name = "Node69";
            treeNode34.Text = "Source to Plant";
            treeNode35.Name = "Node70";
            treeNode35.Text = "Raw Storage to Plant";
            treeNode36.Name = "Node67";
            treeNode36.Text = "Delivery Restrictions";
            treeNode37.Name = "Node71";
            treeNode37.Text = "Plant Operating Hours";
            treeNode38.Name = "Node24";
            treeNode38.Text = "Plant Configuration";
            treeNode39.Name = "Node23";
            treeNode39.Text = "Raw";
            this.treeView2.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode39});
            this.treeView2.Size = new System.Drawing.Size(262, 526);
            this.treeView2.TabIndex = 8;
            this.treeView2.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView2_AfterSelect);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(797, 567);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.NotifyIcon notifyIcon2;
        private System.Windows.Forms.TreeView treeView2;

    }
}