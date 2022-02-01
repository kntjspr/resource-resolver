namespace ResourceResolver
{
	partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.miLoadResource = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAllImagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnSaveAll = new System.Windows.Forms.Button();
            this.btnLoadResources = new System.Windows.Forms.Button();
            this.cbResourceTypes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbResources = new System.Windows.Forms.ComboBox();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.lbItems = new System.Windows.Forms.ListBox();
            this.contextMenuSave = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.contextMenuSave.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(774, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miOpen,
            this.miLoadResource,
            this.saveAllImagesToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // miOpen
            // 
            this.miOpen.Image = global::ResourceResolver.Properties.Resources.select;
            this.miOpen.Name = "miOpen";
            this.miOpen.Size = new System.Drawing.Size(156, 22);
            this.miOpen.Text = "Open File";
            this.miOpen.Click += new System.EventHandler(this.miOpen_Click);
            // 
            // miLoadResource
            // 
            this.miLoadResource.Image = global::ResourceResolver.Properties.Resources.reload_16x16;
            this.miLoadResource.Name = "miLoadResource";
            this.miLoadResource.Size = new System.Drawing.Size(156, 22);
            this.miLoadResource.Text = "Load Resource";
            this.miLoadResource.Click += new System.EventHandler(this.miLoadResource_Click);
            // 
            // saveAllImagesToolStripMenuItem
            // 
            this.saveAllImagesToolStripMenuItem.Image = global::ResourceResolver.Properties.Resources.save;
            this.saveAllImagesToolStripMenuItem.Name = "saveAllImagesToolStripMenuItem";
            this.saveAllImagesToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.saveAllImagesToolStripMenuItem.Text = "Save All Images";
            this.saveAllImagesToolStripMenuItem.Click += new System.EventHandler(this.saveAllImagesToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Image = global::ResourceResolver.Properties.Resources.export16;
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblMessage);
            this.panel1.Controls.Add(this.btnSaveAll);
            this.panel1.Controls.Add(this.btnLoadResources);
            this.panel1.Controls.Add(this.cbResourceTypes);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbResources);
            this.panel1.Controls.Add(this.btnSelectFile);
            this.panel1.Controls.Add(this.txtFileName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 91);
            this.panel1.TabIndex = 2;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(226, 59);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(57, 20);
            this.lblMessage.TabIndex = 8;
            this.lblMessage.Text = "label1";
            this.lblMessage.Visible = false;
            // 
            // btnSaveAll
            // 
            this.btnSaveAll.Image = global::ResourceResolver.Properties.Resources.save;
            this.btnSaveAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveAll.Location = new System.Drawing.Point(629, 57);
            this.btnSaveAll.Name = "btnSaveAll";
            this.btnSaveAll.Size = new System.Drawing.Size(125, 23);
            this.btnSaveAll.TabIndex = 7;
            this.btnSaveAll.Text = "Save All Images";
            this.btnSaveAll.UseVisualStyleBackColor = true;
            this.btnSaveAll.Click += new System.EventHandler(this.btnSaveAll_Click);
            // 
            // btnLoadResources
            // 
            this.btnLoadResources.Image = global::ResourceResolver.Properties.Resources.reload_16x16;
            this.btnLoadResources.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadResources.Location = new System.Drawing.Point(629, 31);
            this.btnLoadResources.Name = "btnLoadResources";
            this.btnLoadResources.Size = new System.Drawing.Size(124, 23);
            this.btnLoadResources.TabIndex = 6;
            this.btnLoadResources.Text = "Load Resources";
            this.btnLoadResources.UseVisualStyleBackColor = true;
            this.btnLoadResources.Click += new System.EventHandler(this.btnLoadResources_Click);
            // 
            // cbResourceTypes
            // 
            this.cbResourceTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbResourceTypes.FormattingEnabled = true;
            this.cbResourceTypes.Location = new System.Drawing.Point(98, 57);
            this.cbResourceTypes.Name = "cbResourceTypes";
            this.cbResourceTypes.Size = new System.Drawing.Size(121, 21);
            this.cbResourceTypes.TabIndex = 5;
            this.cbResourceTypes.SelectedIndexChanged += new System.EventHandler(this.cbResourceTypes_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Resource Type";
            // 
            // cbResources
            // 
            this.cbResources.FormattingEnabled = true;
            this.cbResources.Location = new System.Drawing.Point(13, 31);
            this.cbResources.Name = "cbResources";
            this.cbResources.Size = new System.Drawing.Size(610, 21);
            this.cbResources.TabIndex = 2;
            this.cbResources.SelectedIndexChanged += new System.EventHandler(this.cbResources_SelectedIndexChanged);
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Image = global::ResourceResolver.Properties.Resources.select;
            this.btnSelectFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectFile.Location = new System.Drawing.Point(629, 4);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(125, 23);
            this.btnSelectFile.TabIndex = 1;
            this.btnSelectFile.Text = "Select File";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(13, 4);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(610, 20);
            this.txtFileName.TabIndex = 0;
            // 
            // lbItems
            // 
            this.lbItems.ContextMenuStrip = this.contextMenuSave;
            this.lbItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbItems.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbItems.FormattingEnabled = true;
            this.lbItems.Location = new System.Drawing.Point(0, 115);
            this.lbItems.Name = "lbItems";
            this.lbItems.Size = new System.Drawing.Size(774, 470);
            this.lbItems.TabIndex = 3;
            this.lbItems.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbItems_DrawItem);
            this.lbItems.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.lbItems_MeasureItem);
            // 
            // contextMenuSave
            // 
            this.contextMenuSave.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
            this.contextMenuSave.Name = "contextMenuSave";
            this.contextMenuSave.Size = new System.Drawing.Size(99, 26);
            this.contextMenuSave.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuSave_Opening);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::ResourceResolver.Properties.Resources.save;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 585);
            this.Controls.Add(this.lbItems);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Resource Resolver";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuSave.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem miOpen;
		private System.Windows.Forms.ToolStripMenuItem miLoadResource;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnSelectFile;
		private System.Windows.Forms.TextBox txtFileName;
		private System.Windows.Forms.ComboBox cbResources;
		private System.Windows.Forms.ComboBox cbResourceTypes;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnLoadResources;
		private System.Windows.Forms.ListBox lbItems;
		private System.Windows.Forms.ContextMenuStrip contextMenuSave;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.Button btnSaveAll;
		private System.Windows.Forms.ToolStripMenuItem saveAllImagesToolStripMenuItem;
		private System.Windows.Forms.Label lblMessage;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
	}
}

