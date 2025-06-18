namespace ContactFormsApp
{
    partial class EditRemoveForm
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
            this.LMainTitle = new System.Windows.Forms.Label();
            this.BtnRemoveImage = new System.Windows.Forms.Button();
            this.BtnEditImage = new System.Windows.Forms.Button();
            this.PbContact = new System.Windows.Forms.PictureBox();
            this.LContactID = new System.Windows.Forms.Label();
            this.TbContactID = new System.Windows.Forms.TextBox();
            this.TbFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TbLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TbEmail = new System.Windows.Forms.TextBox();
            this.LEmail = new System.Windows.Forms.Label();
            this.TbPhone = new System.Windows.Forms.TextBox();
            this.LPhone = new System.Windows.Forms.Label();
            this.TbAddress = new System.Windows.Forms.TextBox();
            this.LAddress = new System.Windows.Forms.Label();
            this.LDateOfBirth = new System.Windows.Forms.Label();
            this.DtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.LCountry = new System.Windows.Forms.Label();
            this.CbCountry = new System.Windows.Forms.ComboBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PbContact)).BeginInit();
            this.SuspendLayout();
            // 
            // LMainTitle
            // 
            this.LMainTitle.AutoSize = true;
            this.LMainTitle.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.LMainTitle.Location = new System.Drawing.Point(183, 34);
            this.LMainTitle.Name = "LMainTitle";
            this.LMainTitle.Size = new System.Drawing.Size(228, 30);
            this.LMainTitle.TabIndex = 0;
            this.LMainTitle.Text = "Add New Contact";
            // 
            // BtnRemoveImage
            // 
            this.BtnRemoveImage.Location = new System.Drawing.Point(474, 137);
            this.BtnRemoveImage.Name = "BtnRemoveImage";
            this.BtnRemoveImage.Size = new System.Drawing.Size(75, 23);
            this.BtnRemoveImage.TabIndex = 1;
            this.BtnRemoveImage.Text = "Remove";
            this.BtnRemoveImage.UseVisualStyleBackColor = true;
            this.BtnRemoveImage.Visible = false;
            this.BtnRemoveImage.Click += new System.EventHandler(this.BtnRemoveImage_Click);
            // 
            // BtnEditImage
            // 
            this.BtnEditImage.Location = new System.Drawing.Point(382, 137);
            this.BtnEditImage.Name = "BtnEditImage";
            this.BtnEditImage.Size = new System.Drawing.Size(75, 23);
            this.BtnEditImage.TabIndex = 2;
            this.BtnEditImage.Text = "Add";
            this.BtnEditImage.UseVisualStyleBackColor = true;
            this.BtnEditImage.Click += new System.EventHandler(this.BtnEditImage_Click);
            // 
            // PbContact
            // 
            this.PbContact.Location = new System.Drawing.Point(382, 176);
            this.PbContact.Name = "PbContact";
            this.PbContact.Size = new System.Drawing.Size(167, 140);
            this.PbContact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbContact.TabIndex = 3;
            this.PbContact.TabStop = false;
            // 
            // LContactID
            // 
            this.LContactID.AutoSize = true;
            this.LContactID.Font = new System.Drawing.Font("Tahoma", 10F);
            this.LContactID.Location = new System.Drawing.Point(19, 102);
            this.LContactID.Name = "LContactID";
            this.LContactID.Size = new System.Drawing.Size(90, 21);
            this.LContactID.TabIndex = 4;
            this.LContactID.Text = "Contact ID";
            // 
            // TbContactID
            // 
            this.TbContactID.Location = new System.Drawing.Point(139, 102);
            this.TbContactID.Name = "TbContactID";
            this.TbContactID.Size = new System.Drawing.Size(212, 24);
            this.TbContactID.TabIndex = 5;
            // 
            // TbFirstName
            // 
            this.TbFirstName.Location = new System.Drawing.Point(139, 142);
            this.TbFirstName.Name = "TbFirstName";
            this.TbFirstName.Size = new System.Drawing.Size(212, 24);
            this.TbFirstName.TabIndex = 7;
            this.TbFirstName.TextChanged += new System.EventHandler(this.TbFirstName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(19, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "First Name";
            // 
            // TbLastName
            // 
            this.TbLastName.Location = new System.Drawing.Point(139, 187);
            this.TbLastName.Name = "TbLastName";
            this.TbLastName.Size = new System.Drawing.Size(212, 24);
            this.TbLastName.TabIndex = 9;
            this.TbLastName.TextChanged += new System.EventHandler(this.TbLastName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(19, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Last Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TbEmail
            // 
            this.TbEmail.Location = new System.Drawing.Point(139, 231);
            this.TbEmail.Name = "TbEmail";
            this.TbEmail.Size = new System.Drawing.Size(212, 24);
            this.TbEmail.TabIndex = 11;
            // 
            // LEmail
            // 
            this.LEmail.AutoSize = true;
            this.LEmail.Font = new System.Drawing.Font("Tahoma", 10F);
            this.LEmail.Location = new System.Drawing.Point(19, 230);
            this.LEmail.Name = "LEmail";
            this.LEmail.Size = new System.Drawing.Size(51, 21);
            this.LEmail.TabIndex = 10;
            this.LEmail.Text = "Email";
            this.LEmail.Click += new System.EventHandler(this.label3_Click);
            // 
            // TbPhone
            // 
            this.TbPhone.Location = new System.Drawing.Point(139, 279);
            this.TbPhone.Name = "TbPhone";
            this.TbPhone.Size = new System.Drawing.Size(212, 24);
            this.TbPhone.TabIndex = 13;
            this.TbPhone.TextChanged += new System.EventHandler(this.TbPhone_TextChanged);
            // 
            // LPhone
            // 
            this.LPhone.AutoSize = true;
            this.LPhone.Font = new System.Drawing.Font("Tahoma", 10F);
            this.LPhone.Location = new System.Drawing.Point(19, 278);
            this.LPhone.Name = "LPhone";
            this.LPhone.Size = new System.Drawing.Size(55, 21);
            this.LPhone.TabIndex = 12;
            this.LPhone.Text = "Phone";
            this.LPhone.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // TbAddress
            // 
            this.TbAddress.Location = new System.Drawing.Point(139, 423);
            this.TbAddress.Multiline = true;
            this.TbAddress.Name = "TbAddress";
            this.TbAddress.Size = new System.Drawing.Size(212, 107);
            this.TbAddress.TabIndex = 15;
            // 
            // LAddress
            // 
            this.LAddress.AutoSize = true;
            this.LAddress.Font = new System.Drawing.Font("Tahoma", 10F);
            this.LAddress.Location = new System.Drawing.Point(19, 422);
            this.LAddress.Name = "LAddress";
            this.LAddress.Size = new System.Drawing.Size(70, 21);
            this.LAddress.TabIndex = 14;
            this.LAddress.Text = "Address";
            // 
            // LDateOfBirth
            // 
            this.LDateOfBirth.AutoSize = true;
            this.LDateOfBirth.Font = new System.Drawing.Font("Tahoma", 10F);
            this.LDateOfBirth.Location = new System.Drawing.Point(19, 328);
            this.LDateOfBirth.Name = "LDateOfBirth";
            this.LDateOfBirth.Size = new System.Drawing.Size(108, 21);
            this.LDateOfBirth.TabIndex = 16;
            this.LDateOfBirth.Text = "Date Of Birth";
            // 
            // DtpDateOfBirth
            // 
            this.DtpDateOfBirth.Location = new System.Drawing.Point(140, 326);
            this.DtpDateOfBirth.Name = "DtpDateOfBirth";
            this.DtpDateOfBirth.Size = new System.Drawing.Size(211, 24);
            this.DtpDateOfBirth.TabIndex = 17;
            this.DtpDateOfBirth.ValueChanged += new System.EventHandler(this.DtpDateOfBirth_ValueChanged);
            // 
            // LCountry
            // 
            this.LCountry.AutoSize = true;
            this.LCountry.Font = new System.Drawing.Font("Tahoma", 10F);
            this.LCountry.Location = new System.Drawing.Point(19, 375);
            this.LCountry.Name = "LCountry";
            this.LCountry.Size = new System.Drawing.Size(67, 21);
            this.LCountry.TabIndex = 18;
            this.LCountry.Text = "Country";
            // 
            // CbCountry
            // 
            this.CbCountry.FormattingEnabled = true;
            this.CbCountry.Items.AddRange(new object[] {
            "United States",
            "United Kingdom",
            "Canada",
            "Australia",
            "Germany"});
            this.CbCountry.Location = new System.Drawing.Point(139, 372);
            this.CbCountry.Name = "CbCountry";
            this.CbCountry.Size = new System.Drawing.Size(212, 24);
            this.CbCountry.TabIndex = 19;
            this.CbCountry.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(149, 595);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(122, 44);
            this.BtnClose.TabIndex = 20;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(307, 595);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(122, 44);
            this.BtnSave.TabIndex = 21;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.Location = new System.Drawing.Point(399, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 21);
            this.label3.TabIndex = 22;
            this.label3.Text = "Personal Picture";
            this.label3.Click += new System.EventHandler(this.label3_Click_2);
            // 
            // EditRemoveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 665);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.CbCountry);
            this.Controls.Add(this.LCountry);
            this.Controls.Add(this.DtpDateOfBirth);
            this.Controls.Add(this.LDateOfBirth);
            this.Controls.Add(this.TbAddress);
            this.Controls.Add(this.LAddress);
            this.Controls.Add(this.TbPhone);
            this.Controls.Add(this.LPhone);
            this.Controls.Add(this.TbEmail);
            this.Controls.Add(this.LEmail);
            this.Controls.Add(this.TbLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbFirstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbContactID);
            this.Controls.Add(this.LContactID);
            this.Controls.Add(this.PbContact);
            this.Controls.Add(this.BtnEditImage);
            this.Controls.Add(this.BtnRemoveImage);
            this.Controls.Add(this.LMainTitle);
            this.Name = "EditRemoveForm";
            this.Text = "EditRemoveForm";
            this.Load += new System.EventHandler(this.EditRemoveForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbContact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LMainTitle;
        private System.Windows.Forms.Button BtnRemoveImage;
        private System.Windows.Forms.Button BtnEditImage;
        private System.Windows.Forms.PictureBox PbContact;
        private System.Windows.Forms.Label LContactID;
        private System.Windows.Forms.TextBox TbContactID;
        private System.Windows.Forms.TextBox TbFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbEmail;
        private System.Windows.Forms.Label LEmail;
        private System.Windows.Forms.TextBox TbPhone;
        private System.Windows.Forms.Label LPhone;
        private System.Windows.Forms.TextBox TbAddress;
        private System.Windows.Forms.Label LAddress;
        private System.Windows.Forms.Label LDateOfBirth;
        private System.Windows.Forms.DateTimePicker DtpDateOfBirth;
        private System.Windows.Forms.Label LCountry;
        private System.Windows.Forms.ComboBox CbCountry;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label3;
    }
}