namespace WindowsFormsApplication1
{
    partial class ViewAnSangForm
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
            this.GrdAnSang = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnAddAnSang = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.GrdAnSang)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrdAnSang
            // 
            this.GrdAnSang.AllowUserToAddRows = false;
            this.GrdAnSang.AllowUserToDeleteRows = false;
            this.GrdAnSang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdAnSang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdAnSang.Location = new System.Drawing.Point(0, 24);
            this.GrdAnSang.Name = "GrdAnSang";
            this.GrdAnSang.ReadOnly = true;
            this.GrdAnSang.Size = new System.Drawing.Size(284, 237);
            this.GrdAnSang.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddAnSang});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnAddAnSang
            // 
            this.btnAddAnSang.Name = "btnAddAnSang";
            this.btnAddAnSang.Size = new System.Drawing.Size(94, 20);
            this.btnAddAnSang.Text = "Them mon an";
            // 
            // ViewAnSangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.GrdAnSang);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ViewAnSangForm";
            this.Text = "An Sang";
            ((System.ComponentModel.ISupportInitialize)(this.GrdAnSang)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GrdAnSang;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnAddAnSang;

    }
}

