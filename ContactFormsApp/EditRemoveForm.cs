using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using ContactsBusinessLayer;

namespace ContactFormsApp
{
    public partial class EditRemoveForm : Form
    {
        private clsContact _Contact;
        public EditRemoveForm(int ContactID)
        {
            InitializeComponent();
            LoadData(ContactID);


        }


        private void LoadData(int ContactID)
        {
            TbContactID.Enabled = false;
            
            if (ContactID == -1) {
                _Contact = new clsContact();
                LMainTitle.Text = "Add New Contact";
                return;
            }

            LMainTitle.Text = "Update Contact";

            _Contact = clsContact.Find(ContactID);

            TbContactID.Text = _Contact.ContactID.ToString();
            TbFirstName.Text = _Contact.FirstName;
            TbLastName.Text = _Contact.LastName;
            TbPhone.Text = _Contact.Phone;
            TbAddress.Text = _Contact.Address;
            TbEmail.Text = _Contact.Email;
            DtpDateOfBirth.Value = _Contact.DateOfBirth;
            CbCountry.SelectedIndex = _Contact.CountryID - 1;
            if(_Contact.ImagePath != "") { 
                PbContact.Image = Image.FromFile(_Contact.ImagePath);
                BtnRemoveImage.Visible = true;
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void EditRemoveForm_Load(object sender, EventArgs e)
        {

        }

        private void TbFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void DtpDateOfBirth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            _Contact.FirstName = TbFirstName.Text;
            _Contact.LastName = TbLastName.Text;
            _Contact.Email = TbEmail.Text;
            _Contact.Phone = TbPhone.Text;
            _Contact.Address = TbAddress.Text;
            _Contact.DateOfBirth = DtpDateOfBirth.Value;
            _Contact.CountryID = CbCountry.SelectedIndex+1;
            if (PbContact.Image == null) {
                _Contact.ImagePath = "";
            }

            if (_Contact.Save())
            {
                MessageBox.Show("Contact Was Saved Successfully !");
            }
            else
            {
                MessageBox.Show("Something Went Wrong !");
            }

            LoadData(_Contact.ContactID);
        }

        private void BtnEditImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                _Contact.ImagePath = openFileDialog1.FileName;
                PbContact.Image = Image.FromFile(_Contact.ImagePath);
                BtnRemoveImage.Visible = true;
            }

        }

        private void BtnRemoveImage_Click(object sender, EventArgs e)
        {
            _Contact.ImagePath = "";
            PbContact.Image = null;
            BtnRemoveImage.Visible = false;
        }

        private void label3_Click_2(object sender, EventArgs e)
        {

        }
    }
}
