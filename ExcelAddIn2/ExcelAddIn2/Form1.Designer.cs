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
<<<<<<< HEAD
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip4 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip5 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip6 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.constraintsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sourcesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rawStorageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.componentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qualitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.periodsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sourcesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.componentsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rawStorageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.qualitiesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.periodsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.supplyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.demandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sourceInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rawStorageInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.breakerLossToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yieldsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
=======
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
>>>>>>> origin/Robin
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
<<<<<<< HEAD
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.menuStrip3.SuspendLayout();
            this.menuStrip4.SuspendLayout();
            this.menuStrip5.SuspendLayout();
            this.menuStrip6.SuspendLayout();
=======
>>>>>>> origin/Robin
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
<<<<<<< HEAD
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip6);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip5);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip4);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip3);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip2);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
=======
            this.splitContainer1.Panel1.Controls.Add(this.treeView2);
>>>>>>> origin/Robin
            this.splitContainer1.Size = new System.Drawing.Size(797, 567);
            this.splitContainer1.SplitterDistance = 265;
            this.splitContainer1.TabIndex = 1;
            // 
<<<<<<< HEAD
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(265, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administrationToolStripMenuItem
            // 
            this.administrationToolStripMenuItem.Name = "administrationToolStripMenuItem";
            this.administrationToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.administrationToolStripMenuItem.Text = "Administration";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 24);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(265, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.constraintsToolStripMenuItem,
            this.sourcesToolStripMenuItem,
            this.rawStorageToolStripMenuItem,
            this.componentsToolStripMenuItem,
            this.qualitiesToolStripMenuItem,
            this.periodsToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(62, 20);
            this.toolStripMenuItem1.Text = "Filtering";
            // 
            // menuStrip3
            // 
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.menuStrip3.Location = new System.Drawing.Point(0, 48);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(265, 24);
            this.menuStrip3.TabIndex = 2;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sourcesToolStripMenuItem1,
            this.componentsToolStripMenuItem1,
            this.rawStorageToolStripMenuItem1,
            this.qualitiesToolStripMenuItem1,
            this.periodsToolStripMenuItem1});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(159, 20);
            this.toolStripMenuItem2.Text = "Master Data Configuration";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // menuStrip4
            // 
            this.menuStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3});
            this.menuStrip4.Location = new System.Drawing.Point(0, 72);
            this.menuStrip4.Name = "menuStrip4";
            this.menuStrip4.Size = new System.Drawing.Size(265, 24);
            this.menuStrip4.TabIndex = 3;
            this.menuStrip4.Text = "menuStrip4";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supplyToolStripMenuItem,
            this.demandToolStripMenuItem,
            this.sourceInventoryToolStripMenuItem,
            this.rawStorageInventoryToolStripMenuItem,
            this.breakerLossToolStripMenuItem,
            this.yieldsToolStripMenuItem});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(151, 20);
            this.toolStripMenuItem3.Text = "Input Data Configuration";
            // 
            // menuStrip5
            // 
            this.menuStrip5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4});
            this.menuStrip5.Location = new System.Drawing.Point(0, 96);
            this.menuStrip5.Name = "menuStrip5";
            this.menuStrip5.Size = new System.Drawing.Size(265, 24);
            this.menuStrip5.TabIndex = 4;
            this.menuStrip5.Text = "menuStrip5";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(125, 20);
            this.toolStripMenuItem4.Text = "Delivery Restrictions";
            // 
            // menuStrip6
            // 
            this.menuStrip6.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5});
            this.menuStrip6.Location = new System.Drawing.Point(0, 120);
            this.menuStrip6.Name = "menuStrip6";
            this.menuStrip6.Size = new System.Drawing.Size(265, 24);
            this.menuStrip6.TabIndex = 5;
            this.menuStrip6.Text = "menuStrip6";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(123, 20);
            this.toolStripMenuItem5.Text = "Plant Configuration";
            // 
            // constraintsToolStripMenuItem
            // 
            this.constraintsToolStripMenuItem.Name = "constraintsToolStripMenuItem";
            this.constraintsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.constraintsToolStripMenuItem.Text = "Constraints";
            // 
            // sourcesToolStripMenuItem
            // 
            this.sourcesToolStripMenuItem.Name = "sourcesToolStripMenuItem";
            this.sourcesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sourcesToolStripMenuItem.Text = "Sources";
            // 
            // rawStorageToolStripMenuItem
            // 
            this.rawStorageToolStripMenuItem.Name = "rawStorageToolStripMenuItem";
            this.rawStorageToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rawStorageToolStripMenuItem.Text = "Raw Storage";
            // 
            // componentsToolStripMenuItem
            // 
            this.componentsToolStripMenuItem.Name = "componentsToolStripMenuItem";
            this.componentsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.componentsToolStripMenuItem.Text = "Components";
            // 
            // qualitiesToolStripMenuItem
            // 
            this.qualitiesToolStripMenuItem.Name = "qualitiesToolStripMenuItem";
            this.qualitiesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.qualitiesToolStripMenuItem.Text = "Qualities";
            // 
            // periodsToolStripMenuItem
            // 
            this.periodsToolStripMenuItem.Name = "periodsToolStripMenuItem";
            this.periodsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.periodsToolStripMenuItem.Text = "Periods";
            // 
            // sourcesToolStripMenuItem1
            // 
            this.sourcesToolStripMenuItem1.Name = "sourcesToolStripMenuItem1";
            this.sourcesToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.sourcesToolStripMenuItem1.Text = "Sources";
            // 
            // componentsToolStripMenuItem1
            // 
            this.componentsToolStripMenuItem1.Name = "componentsToolStripMenuItem1";
            this.componentsToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.componentsToolStripMenuItem1.Text = "Components";
            // 
            // rawStorageToolStripMenuItem1
            // 
            this.rawStorageToolStripMenuItem1.Name = "rawStorageToolStripMenuItem1";
            this.rawStorageToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.rawStorageToolStripMenuItem1.Text = "Raw Storage";
            // 
            // qualitiesToolStripMenuItem1
            // 
            this.qualitiesToolStripMenuItem1.Name = "qualitiesToolStripMenuItem1";
            this.qualitiesToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.qualitiesToolStripMenuItem1.Text = "Qualities";
            // 
            // periodsToolStripMenuItem1
            // 
            this.periodsToolStripMenuItem1.Name = "periodsToolStripMenuItem1";
            this.periodsToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.periodsToolStripMenuItem1.Text = "Periods";
            // 
            // supplyToolStripMenuItem
            // 
            this.supplyToolStripMenuItem.Name = "supplyToolStripMenuItem";
            this.supplyToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.supplyToolStripMenuItem.Text = "Supply";
            // 
            // demandToolStripMenuItem
            // 
            this.demandToolStripMenuItem.Name = "demandToolStripMenuItem";
            this.demandToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.demandToolStripMenuItem.Text = "Demand";
            // 
            // sourceInventoryToolStripMenuItem
            // 
            this.sourceInventoryToolStripMenuItem.Name = "sourceInventoryToolStripMenuItem";
            this.sourceInventoryToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.sourceInventoryToolStripMenuItem.Text = "Source Inventory";
            // 
            // rawStorageInventoryToolStripMenuItem
            // 
            this.rawStorageInventoryToolStripMenuItem.Name = "rawStorageInventoryToolStripMenuItem";
            this.rawStorageInventoryToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.rawStorageInventoryToolStripMenuItem.Text = "Raw Storage Inventory";
            // 
            // breakerLossToolStripMenuItem
            // 
            this.breakerLossToolStripMenuItem.Name = "breakerLossToolStripMenuItem";
            this.breakerLossToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.breakerLossToolStripMenuItem.Text = "Breaker Loss";
            // 
            // yieldsToolStripMenuItem
            // 
            this.yieldsToolStripMenuItem.Name = "yieldsToolStripMenuItem";
            this.yieldsToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.yieldsToolStripMenuItem.Text = "Yields";
=======
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
>>>>>>> origin/Robin
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(797, 567);
            this.Controls.Add(this.splitContainer1);
<<<<<<< HEAD
            this.MainMenuStrip = this.menuStrip1;
=======
>>>>>>> origin/Robin
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
<<<<<<< HEAD
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.menuStrip4.ResumeLayout(false);
            this.menuStrip4.PerformLayout();
            this.menuStrip5.ResumeLayout(false);
            this.menuStrip5.PerformLayout();
            this.menuStrip6.ResumeLayout(false);
            this.menuStrip6.PerformLayout();
=======
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
>>>>>>> origin/Robin
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.SplitContainer splitContainer1;
<<<<<<< HEAD
        private System.Windows.Forms.MenuStrip menuStrip6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.MenuStrip menuStrip5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.MenuStrip menuStrip4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sourcesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem constraintsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sourcesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rawStorageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem componentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qualitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem periodsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem demandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sourceInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rawStorageInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem breakerLossToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yieldsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem componentsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rawStorageToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem qualitiesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem periodsToolStripMenuItem1;
=======
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.NotifyIcon notifyIcon2;
        private System.Windows.Forms.TreeView treeView2;
>>>>>>> origin/Robin

    }
}