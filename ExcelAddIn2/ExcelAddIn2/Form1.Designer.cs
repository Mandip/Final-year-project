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
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.menuStrip3.SuspendLayout();
            this.menuStrip4.SuspendLayout();
            this.menuStrip5.SuspendLayout();
            this.menuStrip6.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip6);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip5);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip4);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip3);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip2);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(797, 567);
            this.splitContainer1.SplitterDistance = 265;
            this.splitContainer1.TabIndex = 1;
            // 
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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(797, 567);
            this.Controls.Add(this.splitContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.SplitContainer splitContainer1;
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

    }
}