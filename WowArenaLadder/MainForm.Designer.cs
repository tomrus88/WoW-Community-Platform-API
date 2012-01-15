namespace WowArenaLadder
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.v2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.v3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.v5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.battlegroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ladderView = new WowArenaLadder.ListViewEx();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(678, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teamSizeToolStripMenuItem,
            this.battlegroupToolStripMenuItem,
            this.regionToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // teamSizeToolStripMenuItem
            // 
            this.teamSizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.v2ToolStripMenuItem,
            this.v3ToolStripMenuItem,
            this.v5ToolStripMenuItem});
            this.teamSizeToolStripMenuItem.Name = "teamSizeToolStripMenuItem";
            this.teamSizeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.teamSizeToolStripMenuItem.Text = "Team Size";
            // 
            // v2ToolStripMenuItem
            // 
            this.v2ToolStripMenuItem.Checked = true;
            this.v2ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.v2ToolStripMenuItem.Name = "v2ToolStripMenuItem";
            this.v2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.v2ToolStripMenuItem.Text = "2v2";
            this.v2ToolStripMenuItem.Click += new System.EventHandler(this.teamSizeToolStripMenuItem_Click);
            // 
            // v3ToolStripMenuItem
            // 
            this.v3ToolStripMenuItem.Name = "v3ToolStripMenuItem";
            this.v3ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.v3ToolStripMenuItem.Text = "3v3";
            this.v3ToolStripMenuItem.Click += new System.EventHandler(this.teamSizeToolStripMenuItem_Click);
            // 
            // v5ToolStripMenuItem
            // 
            this.v5ToolStripMenuItem.Name = "v5ToolStripMenuItem";
            this.v5ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.v5ToolStripMenuItem.Text = "5v5";
            this.v5ToolStripMenuItem.Click += new System.EventHandler(this.teamSizeToolStripMenuItem_Click);
            // 
            // battlegroupToolStripMenuItem
            // 
            this.battlegroupToolStripMenuItem.Name = "battlegroupToolStripMenuItem";
            this.battlegroupToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.battlegroupToolStripMenuItem.Text = "Battlegroup";
            // 
            // regionToolStripMenuItem
            // 
            this.regionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eUToolStripMenuItem,
            this.uSToolStripMenuItem,
            this.tWToolStripMenuItem,
            this.kRToolStripMenuItem});
            this.regionToolStripMenuItem.Name = "regionToolStripMenuItem";
            this.regionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.regionToolStripMenuItem.Text = "Region";
            // 
            // eUToolStripMenuItem
            // 
            this.eUToolStripMenuItem.Checked = true;
            this.eUToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.eUToolStripMenuItem.Name = "eUToolStripMenuItem";
            this.eUToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.eUToolStripMenuItem.Tag = "eu";
            this.eUToolStripMenuItem.Text = "EU";
            this.eUToolStripMenuItem.Click += new System.EventHandler(this.regionToolStripMenuItem_Click);
            // 
            // uSToolStripMenuItem
            // 
            this.uSToolStripMenuItem.Name = "uSToolStripMenuItem";
            this.uSToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.uSToolStripMenuItem.Tag = "us";
            this.uSToolStripMenuItem.Text = "US";
            this.uSToolStripMenuItem.Click += new System.EventHandler(this.regionToolStripMenuItem_Click);
            // 
            // tWToolStripMenuItem
            // 
            this.tWToolStripMenuItem.Name = "tWToolStripMenuItem";
            this.tWToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tWToolStripMenuItem.Tag = "tw";
            this.tWToolStripMenuItem.Text = "TW";
            this.tWToolStripMenuItem.Click += new System.EventHandler(this.regionToolStripMenuItem_Click);
            // 
            // kRToolStripMenuItem
            // 
            this.kRToolStripMenuItem.Name = "kRToolStripMenuItem";
            this.kRToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kRToolStripMenuItem.Tag = "kr";
            this.kRToolStripMenuItem.Text = "KR";
            this.kRToolStripMenuItem.Click += new System.EventHandler(this.regionToolStripMenuItem_Click);
            // 
            // ladderView
            // 
            this.ladderView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ladderView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.ladderView.FullRowSelect = true;
            this.ladderView.GridLines = true;
            this.ladderView.Location = new System.Drawing.Point(12, 27);
            this.ladderView.Name = "ladderView";
            this.ladderView.OwnerDraw = true;
            this.ladderView.Size = new System.Drawing.Size(654, 494);
            this.ladderView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.ladderView.TabIndex = 0;
            this.ladderView.UseCompatibleStateImageBehavior = false;
            this.ladderView.View = System.Windows.Forms.View.Details;
            this.ladderView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            this.ladderView.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.ladderView_DrawColumnHeader);
            this.ladderView.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.ladderView_DrawSubItem);
            this.ladderView.SizeChanged += new System.EventHandler(this.ladderView_SizeChanged);
            this.ladderView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ladderView_MouseDoubleClick);
            this.ladderView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ladderView_MouseMove);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "#";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Team";
            this.columnHeader2.Width = 250;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Realm";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Faction";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Wins";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Losses";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Rating";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 533);
            this.Controls.Add(this.ladderView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "WoW Arena Ladder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListViewEx ladderView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teamSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem v2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem v3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem v5ToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ToolStripMenuItem battlegroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kRToolStripMenuItem;
    }
}

