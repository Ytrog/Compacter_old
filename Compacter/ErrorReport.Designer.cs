namespace Compacter
{
    partial class ErrorReport
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
            this.tbExceptions = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbExceptions
            // 
            this.tbExceptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbExceptions.Location = new System.Drawing.Point(0, 0);
            this.tbExceptions.Multiline = true;
            this.tbExceptions.Name = "tbExceptions";
            this.tbExceptions.Size = new System.Drawing.Size(800, 450);
            this.tbExceptions.TabIndex = 0;
            // 
            // ErrorReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbExceptions);
            this.Name = "ErrorReport";
            this.Text = "Errors";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbExceptions;
    }
}