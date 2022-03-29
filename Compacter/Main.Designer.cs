namespace Compacter
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.dgvCommands = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAddFolder = new System.Windows.Forms.ToolStripButton();
            this.tsbExecute = new System.Windows.Forms.ToolStripButton();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ctxMenuDataGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxDeleteButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommands)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.ctxMenuDataGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.statusStrip1);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.dgvCommands);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(800, 399);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(800, 450);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsProgress});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 24);
            this.statusStrip1.TabIndex = 0;
            // 
            // tsProgress
            // 
            this.tsProgress.Name = "tsProgress";
            this.tsProgress.Size = new System.Drawing.Size(100, 18);
            this.tsProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // dgvCommands
            // 
            this.dgvCommands.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCommands.ContextMenuStrip = this.ctxMenuDataGrid;
            this.dgvCommands.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCommands.Location = new System.Drawing.Point(0, 0);
            this.dgvCommands.Name = "dgvCommands";
            this.dgvCommands.RowTemplate.Height = 24;
            this.dgvCommands.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCommands.Size = new System.Drawing.Size(800, 399);
            this.dgvCommands.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddFolder,
            this.tsbExecute});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(201, 27);
            this.toolStrip1.TabIndex = 0;
            // 
            // tsbAddFolder
            // 
            this.tsbAddFolder.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddFolder.Image")));
            this.tsbAddFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddFolder.Name = "tsbAddFolder";
            this.tsbAddFolder.Size = new System.Drawing.Size(105, 24);
            this.tsbAddFolder.Text = "Add folder";
            this.tsbAddFolder.Click += new System.EventHandler(this.tsbAddFolder_Click);
            // 
            // tsbExecute
            // 
            this.tsbExecute.Image = ((System.Drawing.Image)(resources.GetObject("tsbExecute.Image")));
            this.tsbExecute.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExecute.Name = "tsbExecute";
            this.tsbExecute.Size = new System.Drawing.Size(84, 24);
            this.tsbExecute.Text = "Execute";
            this.tsbExecute.Click += new System.EventHandler(this.tsbExecute_Click);
            // 
            // ctxMenuDataGrid
            // 
            this.ctxMenuDataGrid.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxMenuDataGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxDeleteButton});
            this.ctxMenuDataGrid.Name = "ctxMenuDataGrid";
            this.ctxMenuDataGrid.Size = new System.Drawing.Size(123, 28);
            // 
            // ctxDeleteButton
            // 
            this.ctxDeleteButton.Name = "ctxDeleteButton";
            this.ctxDeleteButton.Size = new System.Drawing.Size(122, 24);
            this.ctxDeleteButton.Text = "Delete";
            this.ctxDeleteButton.ToolTipText = "Delete the current row";
            this.ctxDeleteButton.Click += new System.EventHandler(this.ctxDeleteButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "Main";
            this.Text = "Compacter";
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommands)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ctxMenuDataGrid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripButton tsbAddFolder;
        private System.Windows.Forms.DataGridView dgvCommands;
        private System.Windows.Forms.ToolStripButton tsbExecute;
        private System.Windows.Forms.ToolStripProgressBar tsProgress;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ContextMenuStrip ctxMenuDataGrid;
        private System.Windows.Forms.ToolStripMenuItem ctxDeleteButton;
    }
}

