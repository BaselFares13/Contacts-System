namespace ContactFormsApp
{
    partial class ShowContactsForm
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
            this.DgvContactsList = new System.Windows.Forms.DataGridView();
            this.BtnAddContact = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DgvContactsList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvContactsList
            // 
            this.DgvContactsList.AllowUserToAddRows = false;
            this.DgvContactsList.AllowUserToDeleteRows = false;
            this.DgvContactsList.AllowUserToOrderColumns = true;
            this.DgvContactsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvContactsList.ContextMenuStrip = this.contextMenuStrip1;
            this.DgvContactsList.Location = new System.Drawing.Point(12, 170);
            this.DgvContactsList.Name = "DgvContactsList";
            this.DgvContactsList.ReadOnly = true;
            this.DgvContactsList.RowHeadersWidth = 51;
            this.DgvContactsList.RowTemplate.Height = 26;
            this.DgvContactsList.Size = new System.Drawing.Size(1168, 446);
            this.DgvContactsList.TabIndex = 0;
            // 
            // BtnAddContact
            // 
            this.BtnAddContact.Location = new System.Drawing.Point(943, 48);
            this.BtnAddContact.Name = "BtnAddContact";
            this.BtnAddContact.Size = new System.Drawing.Size(237, 85);
            this.BtnAddContact.TabIndex = 1;
            this.BtnAddContact.Text = "Add New Contact";
            this.BtnAddContact.UseVisualStyleBackColor = true;
            this.BtnAddContact.Click += new System.EventHandler(this.BtnAddContact_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 80);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // ShowContactsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 628);
            this.Controls.Add(this.BtnAddContact);
            this.Controls.Add(this.DgvContactsList);
            this.Name = "ShowContactsForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ShowContactsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvContactsList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvContactsList;
        private System.Windows.Forms.Button BtnAddContact;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}