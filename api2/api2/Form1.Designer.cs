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
            this.addressDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonorders = new System.Windows.Forms.Button();
            this.buttonaddcontact = new System.Windows.Forms.Button();
            this.Szerkesztes = new System.Windows.Forms.DataGridViewLinkColumn();
            this.delete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.azonositoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vezeteknevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keresztnevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telepulesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ugyfelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ugyfelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.azonositoDataGridViewTextBoxColumn,
            this.vezeteknevDataGridViewTextBoxColumn,
            this.keresztnevDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.telepulesDataGridViewTextBoxColumn,
            this.cimDataGridViewTextBoxColumn,
            this.Szerkesztes,
            this.delete});
            this.dataGridView1.DataSource = this.ugyfelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(844, 482);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // addressDTOBindingSource
            // 
            this.addressDTOBindingSource.DataSource = typeof(Hotcakes.CommerceDTO.v1.Contacts.AddressDTO);
            // 
            // buttonorders
            // 
            this.buttonorders.Location = new System.Drawing.Point(781, 553);
            this.buttonorders.Name = "buttonorders";
            this.buttonorders.Size = new System.Drawing.Size(75, 23);
            this.buttonorders.TabIndex = 1;
            this.buttonorders.Text = "Rendelések";
            this.buttonorders.UseVisualStyleBackColor = true;
            this.buttonorders.Click += new System.EventHandler(this.buttonorders_Click);
            // 
            // buttonaddcontact
            // 
            this.buttonaddcontact.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonaddcontact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonaddcontact.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonaddcontact.Location = new System.Drawing.Point(759, 12);
            this.buttonaddcontact.Name = "buttonaddcontact";
            this.buttonaddcontact.Size = new System.Drawing.Size(97, 36);
            this.buttonaddcontact.TabIndex = 2;
            this.buttonaddcontact.Text = "Új ügyfél";
            this.buttonaddcontact.UseVisualStyleBackColor = false;
            this.buttonaddcontact.Click += new System.EventHandler(this.buttonaddcontact_Click);
            // 
            // Szerkesztes
            // 
            this.Szerkesztes.HeaderText = "Szerkesztés";
            this.Szerkesztes.Name = "Szerkesztes";
            this.Szerkesztes.ReadOnly = true;
            this.Szerkesztes.Text = "Szerkesztés";
            this.Szerkesztes.UseColumnTextForLinkValue = true;
            // 
            // delete
            // 
            this.delete.HeaderText = "Törlés";
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // azonositoDataGridViewTextBoxColumn
            // 
            this.azonositoDataGridViewTextBoxColumn.DataPropertyName = "azonosito";
            this.azonositoDataGridViewTextBoxColumn.HeaderText = "azonosito";
            this.azonositoDataGridViewTextBoxColumn.Name = "azonositoDataGridViewTextBoxColumn";
            // 
            // vezeteknevDataGridViewTextBoxColumn
            // 
            this.vezeteknevDataGridViewTextBoxColumn.DataPropertyName = "vezeteknev";
            this.vezeteknevDataGridViewTextBoxColumn.HeaderText = "vezeteknev";
            this.vezeteknevDataGridViewTextBoxColumn.Name = "vezeteknevDataGridViewTextBoxColumn";
            // 
            // keresztnevDataGridViewTextBoxColumn
            // 
            this.keresztnevDataGridViewTextBoxColumn.DataPropertyName = "keresztnev";
            this.keresztnevDataGridViewTextBoxColumn.HeaderText = "keresztnev";
            this.keresztnevDataGridViewTextBoxColumn.Name = "keresztnevDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // telepulesDataGridViewTextBoxColumn
            // 
            this.telepulesDataGridViewTextBoxColumn.DataPropertyName = "telepules";
            this.telepulesDataGridViewTextBoxColumn.HeaderText = "telepules";
            this.telepulesDataGridViewTextBoxColumn.Name = "telepulesDataGridViewTextBoxColumn";
            // 
            // cimDataGridViewTextBoxColumn
            // 
            this.cimDataGridViewTextBoxColumn.DataPropertyName = "cim";
            this.cimDataGridViewTextBoxColumn.HeaderText = "cim";
            this.cimDataGridViewTextBoxColumn.Name = "cimDataGridViewTextBoxColumn";
            // 
            // ugyfelBindingSource
            // 
            this.ugyfelBindingSource.DataSource = typeof(api2.ugyfel);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSearch.Location = new System.Drawing.Point(466, 17);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(287, 26);
            this.textBoxSearch.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(389, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Keresés:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(918, 588);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonaddcontact);
            this.Controls.Add(this.buttonorders);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ugyfelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource addressDTOBindingSource;
        private System.Windows.Forms.Button buttonorders;
        private System.Windows.Forms.DataGridViewTextBoxColumn varosDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ugyfelBindingSource;
        private System.Windows.Forms.Button buttonaddcontact;
        private System.Windows.Forms.DataGridViewTextBoxColumn azonositoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vezeteknevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keresztnevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telepulesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn Szerkesztes;
        private System.Windows.Forms.DataGridViewLinkColumn delete;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label1;
    }
}

