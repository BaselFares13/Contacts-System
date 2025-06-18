using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsBusinessLayer;

namespace ContactFormsApp
{
    public partial class ShowContactsForm : Form
    {
        public ShowContactsForm()
        {
            InitializeComponent();
        }

        private void ShowContactsForm_Load(object sender, EventArgs e)
        {
            refreshDataGridView();
        }

        private void refreshDataGridView()
        {
            DgvContactsList.DataSource = clsContact.ListContacts();

        }

        private void BtnAddContact_Click(object sender, EventArgs e)
        {
            EditRemoveForm frm = new EditRemoveForm(-1);
            frm.ShowDialog();
            refreshDataGridView();

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditRemoveForm frm = new EditRemoveForm((int)DgvContactsList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            refreshDataGridView();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsContact.DeletedContact((int)DgvContactsList.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("Contact Was Deleted Successfully !");
            } else
            {
                MessageBox.Show("Something Went Wrong !");
            }

            refreshDataGridView();
        }
    }
}
