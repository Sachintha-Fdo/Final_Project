namespace Final_Project
{
    partial class Form8
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
            this.recordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receivedPackagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.packageSentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receiverDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receivedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Search = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 56;
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
            // 
            // receivedPackagesToolStripMenuItem
            // 
            this.receivedPackagesToolStripMenuItem.BackColor = System.Drawing.Color.CornflowerBlue;
            this.receivedPackagesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.receivedPackagesToolStripMenuItem.Name = "receivedPackagesToolStripMenuItem";
            this.receivedPackagesToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.receivedPackagesToolStripMenuItem.Text = "Packages Received ";
            // 
            // packageSentToolStripMenuItem
            // 
            this.packageSentToolStripMenuItem.BackColor = System.Drawing.Color.CornflowerBlue;
            this.packageSentToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.packageSentToolStripMenuItem.Name = "packageSentToolStripMenuItem";
            this.packageSentToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.packageSentToolStripMenuItem.Text = "Package sent";
            // 
            // receiverDetailsToolStripMenuItem
            // 
            this.receiverDetailsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.receiverDetailsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.receiverDetailsToolStripMenuItem.Name = "receiverDetailsToolStripMenuItem";
            this.receiverDetailsToolStripMenuItem.Size = new System.Drawing.Size(162, 29);
            this.receiverDetailsToolStripMenuItem.Text = "Receiver Details";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.receivedToolStripMenuItem,
            this.sentToolStripMenuItem});
            this.searchToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.searchToolStripMenuItem.Text = "Search ";
            // 
            // receivedToolStripMenuItem
            // 
            this.receivedToolStripMenuItem.Name = "receivedToolStripMenuItem";
            this.receivedToolStripMenuItem.Size = new System.Drawing.Size(162, 30);
            this.receivedToolStripMenuItem.Text = "Received";
            // 
            // sentToolStripMenuItem
            // 
            this.sentToolStripMenuItem.Name = "sentToolStripMenuItem";
            this.sentToolStripMenuItem.Size = new System.Drawing.Size(162, 30);
            this.sentToolStripMenuItem.Text = "Sent";
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(325, 55);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 60;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(-3, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(293, 23);
            this.textBox1.TabIndex = 59;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-3, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(803, 330);
            this.dataGridView1.TabIndex = 58;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form8";
            this.Text = "Search Sent Packages";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MenuStrip menuStrip1;
        private ToolStripMenuItem recordsToolStripMenuItem;
        private ToolStripMenuItem receivedPackagesToolStripMenuItem;
        private ToolStripMenuItem packageSentToolStripMenuItem;
        private ToolStripMenuItem receiverDetailsToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripMenuItem receivedToolStripMenuItem;
        private ToolStripMenuItem sentToolStripMenuItem;
        private Button Search;
        private TextBox textBox1;
        private DataGridView dataGridView1;
    }
}