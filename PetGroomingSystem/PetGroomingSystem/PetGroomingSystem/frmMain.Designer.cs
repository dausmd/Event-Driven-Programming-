namespace PetGroomingSystem
{
    partial class frmMain
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnOwners = new System.Windows.Forms.Button();
            this.btnPets = new System.Windows.Forms.Button();
            this.btnBooking = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.petGroomingDataSet1 = new PetGroomingSystem.PetGroomingDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.petGroomingDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.LightSalmon;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.Enabled = false;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Montserrat Subrayada", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Sienna;
            this.lblTitle.Location = new System.Drawing.Point(32, 34);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(570, 35);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Pet Grooming Management System";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // btnOwners
            // 
            this.btnOwners.BackColor = System.Drawing.Color.LightSalmon;
            this.btnOwners.Font = new System.Drawing.Font("Montserrat Subrayada", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOwners.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnOwners.Location = new System.Drawing.Point(77, 153);
            this.btnOwners.Name = "btnOwners";
            this.btnOwners.Size = new System.Drawing.Size(139, 46);
            this.btnOwners.TabIndex = 1;
            this.btnOwners.Text = "Owner";
            this.btnOwners.UseVisualStyleBackColor = false;
            this.btnOwners.Click += new System.EventHandler(this.btnOwners_Click);
            // 
            // btnPets
            // 
            this.btnPets.BackColor = System.Drawing.Color.LightSalmon;
            this.btnPets.Font = new System.Drawing.Font("Montserrat Subrayada", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPets.ForeColor = System.Drawing.Color.Sienna;
            this.btnPets.Location = new System.Drawing.Point(77, 220);
            this.btnPets.Name = "btnPets";
            this.btnPets.Size = new System.Drawing.Size(139, 46);
            this.btnPets.TabIndex = 2;
            this.btnPets.Text = "Pets";
            this.btnPets.UseVisualStyleBackColor = false;
            // 
            // btnBooking
            // 
            this.btnBooking.BackColor = System.Drawing.Color.LightSalmon;
            this.btnBooking.Font = new System.Drawing.Font("Montserrat Subrayada", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooking.ForeColor = System.Drawing.Color.Sienna;
            this.btnBooking.Location = new System.Drawing.Point(77, 284);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(139, 42);
            this.btnBooking.TabIndex = 3;
            this.btnBooking.Text = "Booking";
            this.btnBooking.UseVisualStyleBackColor = false;
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.LightSalmon;
            this.btnPayment.Font = new System.Drawing.Font("Montserrat Subrayada", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.Color.Sienna;
            this.btnPayment.Location = new System.Drawing.Point(77, 349);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(139, 42);
            this.btnPayment.TabIndex = 4;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = false;
            // 
            // petGroomingDataSet1
            // 
            this.petGroomingDataSet1.DataSetName = "PetGroomingDataSet";
            this.petGroomingDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1114, 624);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnBooking);
            this.Controls.Add(this.btnPets);
            this.Controls.Add(this.btnOwners);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmMain";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.petGroomingDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnOwners;
        private System.Windows.Forms.Button btnPets;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.Button btnPayment;
        private PetGroomingDataSet petGroomingDataSet1;
    }
}

