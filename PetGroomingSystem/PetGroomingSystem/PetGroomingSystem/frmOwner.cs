using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetGroomingSystem
{
    public partial class frmOwner : Form
    {
        private PetGroomingDataSet petDataSet;
        private PetGroomingDataSetTableAdapters.OwnersTableAdapter ownersAdapter;

        private int selectedOwnerID = -1; // tracks which row is selected for update/delete

        public frmOwner()
        {
            InitializeComponent();
            petDataSet = new PetGroomingDataSet();
            ownersAdapter = new PetGroomingDataSetTableAdapters.OwnersTableAdapter();
        }

        private void frmOwner_Load(object sender, EventArgs e)
        {
            LoadOwners();
        }

        private void LoadOwners()
        {
            petDataSet.Owners.Clear();
            ownersAdapter.Fill(petDataSet.Owners);
            dgvOwners.DataSource = petDataSet.Owners;

            // Optional: hide OwnerID column from view, or keep visible for clarity
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            try
            {
                ownersAdapter.Insert(
                    txtFullName.Text.Trim(),
                    txtPhone.Text.Trim(),
                    txtEmail.Text.Trim(),
                    txtAddress.Text.Trim()
                );

                MessageBox.Show("Owner added successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadOwners();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding owner: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedOwnerID == -1)
            {
                MessageBox.Show("Please select an owner from the list first.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInput()) return;

            try
            {
                ownersAdapter.Update(
                    txtFullName.Text.Trim(),
                    txtPhone.Text.Trim(),
                    txtEmail.Text.Trim(),
                    txtAddress.Text.Trim(),
                    selectedOwnerID
                );

                MessageBox.Show("Owner updated successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadOwners();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating owner: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedOwnerID == -1)
            {
                MessageBox.Show("Please select an owner from the list first.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Delete this owner? This cannot be undone.",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    ownersAdapter.Delete(selectedOwnerID);
                    MessageBox.Show("Owner deleted.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadOwners();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    // Likely a foreign key conflict if owner still has pets
                    MessageBox.Show("Cannot delete: this owner may still have pets linked. " + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtFullName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            selectedOwnerID = -1;
            dgvOwners.ClearSelection();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Full Name is required.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Phone is required.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // Fires when user clicks a row in the grid -> populate textboxes
        private void dgvOwners_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // ignore header click

            DataGridViewRow row = dgvOwners.Rows[e.RowIndex];

            selectedOwnerID = Convert.ToInt32(row.Cells["OwnerID"].Value);
            txtFullName.Text = row.Cells["FullName"].Value.ToString();
            txtPhone.Text = row.Cells["Phone"].Value.ToString();
            txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";
            txtAddress.Text = row.Cells["Address"].Value?.ToString() ?? "";
        }
    }
}