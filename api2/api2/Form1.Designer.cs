namespace api2
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonorders = new System.Windows.Forms.Button();
            this.addressDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bvinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.line1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bvinDataGridViewTextBoxColumn,
            this.Email,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.line1DataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.postalCodeDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.addressDTOBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 384);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonorders
            // 
            this.buttonorders.Location = new System.Drawing.Point(367, 12);
            this.buttonorders.Name = "buttonorders";
            this.buttonorders.Size = new System.Drawing.Size(75, 23);
            this.buttonorders.TabIndex = 1;
            this.buttonorders.Text = "Rendelések";
            this.buttonorders.UseVisualStyleBackColor = true;
            this.buttonorders.Click += new System.EventHandler(this.buttonorders_Click);
            // 
            // addressDTOBindingSource
            // 
            this.addressDTOBindingSource.DataSource = typeof(Hotcakes.CommerceDTO.v1.Contacts.AddressDTO);
            // 
            // bvinDataGridViewTextBoxColumn
            // 
            this.bvinDataGridViewTextBoxColumn.DataPropertyName = "Bvin";
            this.bvinDataGridViewTextBoxColumn.HeaderText = "Azonosító";
            this.bvinDataGridViewTextBoxColumn.Name = "bvinDataGridViewTextBoxColumn";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "Keresztnév";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Vezetéknév";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // line1DataGridViewTextBoxColumn
            // 
            this.line1DataGridViewTextBoxColumn.DataPropertyName = "Line1";
            this.line1DataGridViewTextBoxColumn.HeaderText = "Cím";
            this.line1DataGridViewTextBoxColumn.Name = "line1DataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "Település";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // postalCodeDataGridViewTextBoxColumn
            // 
            this.postalCodeDataGridViewTextBoxColumn.DataPropertyName = "PostalCode";
            this.postalCodeDataGridViewTextBoxColumn.HeaderText = "PostalCode";
            this.postalCodeDataGridViewTextBoxColumn.Name = "postalCodeDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonorders);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource addressDTOBindingSource;
        private System.Windows.Forms.Button buttonorders;
        private System.Windows.Forms.DataGridViewTextBoxColumn bvinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn line1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
    }
}

