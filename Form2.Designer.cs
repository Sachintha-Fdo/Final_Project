namespace Final_Project
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.recordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receivedPackagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.packageSentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receiverDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowDrop = true;
            this.menuStrip1.BackColor = System.Drawing.Color.Blue;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recordsToolStripMenuItem,
            this.receiverDetailsToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(795, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.TabStop = true;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // recordsToolStripMenuItem
            // 
            this.recordsToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.recordsToolStripMenuItem.AutoSize = false;
            this.recordsToolStripMenuItem.BackColor = System.Drawing.Color.Blue;
            this.recordsToolStripMenuItem.Checked = true;
            this.recordsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.recordsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.receivedPackagesToolStripMenuItem,
            this.packageSentToolStripMenuItem});
            this.recordsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.recordsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.recordsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.recordsToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.recordsToolStripMenuItem.MergeIndex = 1;
            this.recordsToolStripMenuItem.Name = "recordsToolStripMenuItem";
            this.recordsToolStripMenuItem.Size = new System.Drawing.Size(190, 29);
            this.recordsToolStripMenuItem.Text = "Manual Data Entry";
            this.recordsToolStripMenuItem.Click += new System.EventHandler(this.recordsToolStripMenuItem_Click);
            // 
            // receivedPackagesToolStripMenuItem
            // 
            this.receivedPackagesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.receivedPackagesToolStripMenuItem.Name = "receivedPackagesToolStripMenuItem";
            this.receivedPackagesToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.receivedPackagesToolStripMenuItem.Text = "Packages Received ";
            this.receivedPackagesToolStripMenuItem.Click += new System.EventHandler(this.receivedPackagesToolStripMenuItem_Click);
            // 
            // packageSentToolStripMenuItem
            // 
            this.packageSentToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.packageSentToolStripMenuItem.Name = "packageSentToolStripMenuItem";
            this.packageSentToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.packageSentToolStripMenuItem.Text = "Package sent";
            this.packageSentToolStripMenuItem.Click += new System.EventHandler(this.packageSentToolStripMenuItem_Click);
            // 
            // receiverDetailsToolStripMenuItem
            // 
            this.receiverDetailsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.receiverDetailsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.receiverDetailsToolStripMenuItem.Name = "receiverDetailsToolStripMenuItem";
            this.receiverDetailsToolStripMenuItem.Size = new System.Drawing.Size(162, 29);
            this.receiverDetailsToolStripMenuItem.Text = "Receiver Details";
            this.receiverDetailsToolStripMenuItem.Click += new System.EventHandler(this.receiverDetailsToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.searchToolStripMenuItem.Text = "Search ";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(795, 450);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomePage";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ToolStripMenuItem recordsToolStripMenuItem;
        private ToolStripMenuItem receiverDetailsToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
        public MenuStrip menuStrip1;
        private ToolStripMenuItem receivedPackagesToolStripMenuItem;
        private ToolStripMenuItem packageSentToolStripMenuItem;
    }
}