namespace PetGroomingSystem
{
    partial class frmOwner
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
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblOwnName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblOwnEmail = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvOwners = new System.Windows.Forms.DataGridView();
            this.ownersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petGroomingDataSet = new PetGroomingSystem.PetGroomingDataSet();
            this.ownersTableAdapter = new PetGroomingSystem.PetGroomingDataSetTableAdapters.OwnersTableAdapter();
            this.GroupBoxOwner = new System.Windows.Forms.GroupBox();
            this.OwnerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOwners)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petGroomingDataSet)).BeginInit();
            this.GroupBoxOwner.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(114, 11);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(125, 20);
            this.txtFullName.TabIndex = 0;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(114, 50);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(125, 20);
            this.txtPhone.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(114, 95);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(125, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(114, 139);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(125, 20);
            this.txtAddress.TabIndex = 3;
            // 
            // lblOwnName
            // 
            this.lblOwnName.AutoSize = true;
            this.lblOwnName.Location = new System.Drawing.Point(28, 14);
            this.lblOwnName.Name = "lblOwnName";
            this.lblOwnName.Size = new System.Drawing.Size(54, 13);
            this.lblOwnName.TabIndex = 4;
            this.lblOwnName.Text = "Full Name";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(28, 53);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(55, 13);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "Phone No";
            // 
            // lblOwnEmail
            // 
            this.lblOwnEmail.AutoSize = true;
            this.lblOwnEmail.Location = new System.Drawing.Point(28, 98);
            this.lblOwnEmail.Name = "lblOwnEmail";
            this.lblOwnEmail.Size = new System.Drawing.Size(32, 13);
            this.lblOwnEmail.TabIndex = 6;
            this.lblOwnEmail.Text = "Email";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(28, 142);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 7;
            this.lblAddress.Text = "Address";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(411, 330);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(514, 330);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(617, 330);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(514, 376);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvOwners
            // 
            this.dgvOwners.AutoGenerateColumns = false;
            this.dgvOwners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOwners.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OwnerID,
            this.FullName,
            this.Phone,
            this.Email,
            this.Address});
            this.dgvOwners.DataSource = this.ownersBindingSource;
            this.dgvOwners.Location = new System.Drawing.Point(472, 70);
            this.dgvOwners.Name = "dgvOwners";
            this.dgvOwners.Size = new System.Drawing.Size(545, 145);
            this.dgvOwners.TabIndex = 12;
            this.dgvOwners.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOwners_CellClick);
            // 
            // ownersBindingSource
            // 
            this.ownersBindingSource.DataMember = "Owners";
            this.ownersBindingSource.DataSource = this.petGroomingDataSet;
            // 
            // petGroomingDataSet
            // 
            this.petGroomingDataSet.DataSetName = "PetGroomingDataSet";
            this.petGroomingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ownersTableAdapter
            // 
            this.ownersTableAdapter.ClearBeforeFill = true;
            // 
            // GroupBoxOwner
            // 
            this.GroupBoxOwner.Controls.Add(this.lblAddress);
            this.GroupBoxOwner.Controls.Add(this.lblOwnEmail);
            this.GroupBoxOwner.Controls.Add(this.lblPhone);
            this.GroupBoxOwner.Controls.Add(this.lblOwnName);
            this.GroupBoxOwner.Controls.Add(this.txtAddress);
            this.GroupBoxOwner.Controls.Add(this.txtEmail);
            this.GroupBoxOwner.Controls.Add(this.txtPhone);
            this.GroupBoxOwner.Controls.Add(this.txtFullName);
            this.GroupBoxOwner.Location = new System.Drawing.Point(44, 46);
            this.GroupBoxOwner.Name = "GroupBoxOwner";
            this.GroupBoxOwner.Size = new System.Drawing.Size(290, 186);
            this.GroupBoxOwner.TabIndex = 13;
            this.GroupBoxOwner.TabStop = false;
            this.GroupBoxOwner.Text = "Owner";
            // 
            // OwnerID
            // 
            this.OwnerID.DataPropertyName = "OwnerID";
            this.OwnerID.HeaderText = "OwnerID";
            this.OwnerID.Name = "OwnerID";
            this.OwnerID.ReadOnly = true;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "FullName";
            this.FullName.Name = "FullName";
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            // 
            // frmOwner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 614);
            this.Controls.Add(this.GroupBoxOwner);
            this.Controls.Add(this.dgvOwners);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Name = "frmOwner";
            this.Text = "Owner";
            this.Load += new System.EventHandler(this.frmOwner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOwners)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petGroomingDataSet)).EndInit();
            this.GroupBoxOwner.ResumeLayout(false);
            this.GroupBoxOwner.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblOwnName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblOwnEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvOwners;
        private PetGroomingDataSet petGroomingDataSet;
        private System.Windows.Forms.BindingSource ownersBindingSource;
        private PetGroomingDataSetTableAdapters.OwnersTableAdapter ownersTableAdapter;
        private System.Windows.Forms.GroupBox GroupBoxOwner;
        private System.Windows.Forms.DataGridViewTextBoxColumn OwnerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
    }
}