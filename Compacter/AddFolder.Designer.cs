namespace Compacter
{
    partial class AddFolder
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.txtSelectedFolder = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioCompress = new System.Windows.Forms.RadioButton();
            this.radioUncompress = new System.Windows.Forms.RadioButton();
            this.radioList = new System.Windows.Forms.RadioButton();
            this.listBoxMethods = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnSelectFolder);
            this.flowLayoutPanel1.Controls.Add(this.txtSelectedFolder);
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.btnAdd);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(399, 225);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(3, 3);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(121, 23);
            this.btnSelectFolder.TabIndex = 0;
            this.btnSelectFolder.Text = "Seclect Folder";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // txtSelectedFolder
            // 
            this.flowLayoutPanel1.SetFlowBreak(this.txtSelectedFolder, true);
            this.txtSelectedFolder.Location = new System.Drawing.Point(130, 3);
            this.txtSelectedFolder.Name = "txtSelectedFolder";
            this.txtSelectedFolder.Size = new System.Drawing.Size(241, 22);
            this.txtSelectedFolder.TabIndex = 1;
            this.txtSelectedFolder.TextChanged += new System.EventHandler(this.txtSelectedFolder_TextChanged);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.listBoxMethods);
            this.groupBox1.Controls.Add(this.radioList);
            this.groupBox1.Controls.Add(this.radioUncompress);
            this.groupBox1.Controls.Add(this.radioCompress);
            this.groupBox1.Location = new System.Drawing.Point(3, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 150);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // radioCompress
            // 
            this.radioCompress.AutoSize = true;
            this.radioCompress.Location = new System.Drawing.Point(7, 25);
            this.radioCompress.Name = "radioCompress";
            this.radioCompress.Size = new System.Drawing.Size(92, 21);
            this.radioCompress.TabIndex = 0;
            this.radioCompress.Text = "Compress";
            this.radioCompress.UseVisualStyleBackColor = true;
            this.radioCompress.CheckedChanged += new System.EventHandler(this.radioCompress_CheckedChanged);
            // 
            // radioUncompress
            // 
            this.radioUncompress.AutoSize = true;
            this.radioUncompress.Location = new System.Drawing.Point(7, 52);
            this.radioUncompress.Name = "radioUncompress";
            this.radioUncompress.Size = new System.Drawing.Size(108, 21);
            this.radioUncompress.TabIndex = 1;
            this.radioUncompress.Text = "Uncompress";
            this.radioUncompress.UseVisualStyleBackColor = true;
            this.radioUncompress.CheckedChanged += new System.EventHandler(this.radioUncompress_CheckedChanged);
            // 
            // radioList
            // 
            this.radioList.AutoSize = true;
            this.radioList.Checked = true;
            this.radioList.Location = new System.Drawing.Point(7, 77);
            this.radioList.Name = "radioList";
            this.radioList.Size = new System.Drawing.Size(51, 21);
            this.radioList.TabIndex = 2;
            this.radioList.TabStop = true;
            this.radioList.Text = "List";
            this.radioList.UseVisualStyleBackColor = true;
            this.radioList.CheckedChanged += new System.EventHandler(this.radioList_CheckedChanged);
            // 
            // listBoxMethods
            // 
            this.listBoxMethods.Enabled = false;
            this.listBoxMethods.ItemHeight = 16;
            this.listBoxMethods.Items.AddRange(new object[] {
            "NTFS",
            "EXE:XPRESS4K",
            "EXE:XPRESS8K",
            "EXE:XPRESS16K",
            "EXE:LZX"});
            this.listBoxMethods.Location = new System.Drawing.Point(146, 52);
            this.listBoxMethods.Name = "listBoxMethods";
            this.listBoxMethods.Size = new System.Drawing.Size(120, 84);
            this.listBoxMethods.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Method";
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(289, 32);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // AddFolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 225);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddFolder";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Add Folder";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.TextBox txtSelectedFolder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioList;
        private System.Windows.Forms.RadioButton radioUncompress;
        private System.Windows.Forms.RadioButton radioCompress;
        private System.Windows.Forms.ListBox listBoxMethods;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
    }
}