namespace api2
{
    partial class Form2
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.orderDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bvinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastUpdatedUtcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeOfOrderUtcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thirdPartyOrderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shippingStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isPlacedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.statusCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billingAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shippingAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.affiliateIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fraudScoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shippingMethodIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shippingMethodDisplayNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shippingProviderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shippingProviderServiceCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalTaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemsTaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shippingTaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shippingTaxRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalShippingBeforeDiscountsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalOrderBeforeDiscountsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalShippingDiscountsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalOrderDiscountsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalHandlingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalGrandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.bvinDataGridViewTextBoxColumn,
            this.storeIdDataGridViewTextBoxColumn,
            this.lastUpdatedUtcDataGridViewTextBoxColumn,
            this.timeOfOrderUtcDataGridViewTextBoxColumn,
            this.orderNumberDataGridViewTextBoxColumn,
            this.thirdPartyOrderIdDataGridViewTextBoxColumn,
            this.userEmailDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn,
            this.paymentStatusDataGridViewTextBoxColumn,
            this.shippingStatusDataGridViewTextBoxColumn,
            this.isPlacedDataGridViewCheckBoxColumn,
            this.statusCodeDataGridViewTextBoxColumn,
            this.statusNameDataGridViewTextBoxColumn,
            this.billingAddressDataGridViewTextBoxColumn,
            this.shippingAddressDataGridViewTextBoxColumn,
            this.affiliateIDDataGridViewTextBoxColumn,
            this.fraudScoreDataGridViewTextBoxColumn,
            this.instructionsDataGridViewTextBoxColumn,
            this.shippingMethodIdDataGridViewTextBoxColumn,
            this.shippingMethodDisplayNameDataGridViewTextBoxColumn,
            this.shippingProviderIdDataGridViewTextBoxColumn,
            this.shippingProviderServiceCodeDataGridViewTextBoxColumn,
            this.totalTaxDataGridViewTextBoxColumn,
            this.itemsTaxDataGridViewTextBoxColumn,
            this.shippingTaxDataGridViewTextBoxColumn,
            this.shippingTaxRateDataGridViewTextBoxColumn,
            this.totalShippingBeforeDiscountsDataGridViewTextBoxColumn,
            this.totalOrderBeforeDiscountsDataGridViewTextBoxColumn,
            this.totalShippingDiscountsDataGridViewTextBoxColumn,
            this.totalOrderDiscountsDataGridViewTextBoxColumn,
            this.totalHandlingDataGridViewTextBoxColumn,
            this.totalGrandDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.orderDTOBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 44);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(755, 384);
            this.dataGridView2.TabIndex = 0;
            // 
            // orderDTOBindingSource
            // 
            this.orderDTOBindingSource.DataSource = typeof(Hotcakes.CommerceDTO.v1.Orders.OrderDTO);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // bvinDataGridViewTextBoxColumn
            // 
            this.bvinDataGridViewTextBoxColumn.DataPropertyName = "Bvin";
            this.bvinDataGridViewTextBoxColumn.HeaderText = "Bvin";
            this.bvinDataGridViewTextBoxColumn.Name = "bvinDataGridViewTextBoxColumn";
            // 
            // storeIdDataGridViewTextBoxColumn
            // 
            this.storeIdDataGridViewTextBoxColumn.DataPropertyName = "StoreId";
            this.storeIdDataGridViewTextBoxColumn.HeaderText = "StoreId";
            this.storeIdDataGridViewTextBoxColumn.Name = "storeIdDataGridViewTextBoxColumn";
            // 
            // lastUpdatedUtcDataGridViewTextBoxColumn
            // 
            this.lastUpdatedUtcDataGridViewTextBoxColumn.DataPropertyName = "LastUpdatedUtc";
            this.lastUpdatedUtcDataGridViewTextBoxColumn.HeaderText = "LastUpdatedUtc";
            this.lastUpdatedUtcDataGridViewTextBoxColumn.Name = "lastUpdatedUtcDataGridViewTextBoxColumn";
            // 
            // timeOfOrderUtcDataGridViewTextBoxColumn
            // 
            this.timeOfOrderUtcDataGridViewTextBoxColumn.DataPropertyName = "TimeOfOrderUtc";
            this.timeOfOrderUtcDataGridViewTextBoxColumn.HeaderText = "TimeOfOrderUtc";
            this.timeOfOrderUtcDataGridViewTextBoxColumn.Name = "timeOfOrderUtcDataGridViewTextBoxColumn";
            // 
            // orderNumberDataGridViewTextBoxColumn
            // 
            this.orderNumberDataGridViewTextBoxColumn.DataPropertyName = "OrderNumber";
            this.orderNumberDataGridViewTextBoxColumn.HeaderText = "OrderNumber";
            this.orderNumberDataGridViewTextBoxColumn.Name = "orderNumberDataGridViewTextBoxColumn";
            // 
            // thirdPartyOrderIdDataGridViewTextBoxColumn
            // 
            this.thirdPartyOrderIdDataGridViewTextBoxColumn.DataPropertyName = "ThirdPartyOrderId";
            this.thirdPartyOrderIdDataGridViewTextBoxColumn.HeaderText = "ThirdPartyOrderId";
            this.thirdPartyOrderIdDataGridViewTextBoxColumn.Name = "thirdPartyOrderIdDataGridViewTextBoxColumn";
            // 
            // userEmailDataGridViewTextBoxColumn
            // 
            this.userEmailDataGridViewTextBoxColumn.DataPropertyName = "UserEmail";
            this.userEmailDataGridViewTextBoxColumn.HeaderText = "UserEmail";
            this.userEmailDataGridViewTextBoxColumn.Name = "userEmailDataGridViewTextBoxColumn";
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            // 
            // paymentStatusDataGridViewTextBoxColumn
            // 
            this.paymentStatusDataGridViewTextBoxColumn.DataPropertyName = "PaymentStatus";
            this.paymentStatusDataGridViewTextBoxColumn.HeaderText = "PaymentStatus";
            this.paymentStatusDataGridViewTextBoxColumn.Name = "paymentStatusDataGridViewTextBoxColumn";
            // 
            // shippingStatusDataGridViewTextBoxColumn
            // 
            this.shippingStatusDataGridViewTextBoxColumn.DataPropertyName = "ShippingStatus";
            this.shippingStatusDataGridViewTextBoxColumn.HeaderText = "ShippingStatus";
            this.shippingStatusDataGridViewTextBoxColumn.Name = "shippingStatusDataGridViewTextBoxColumn";
            // 
            // isPlacedDataGridViewCheckBoxColumn
            // 
            this.isPlacedDataGridViewCheckBoxColumn.DataPropertyName = "IsPlaced";
            this.isPlacedDataGridViewCheckBoxColumn.HeaderText = "IsPlaced";
            this.isPlacedDataGridViewCheckBoxColumn.Name = "isPlacedDataGridViewCheckBoxColumn";
            // 
            // statusCodeDataGridViewTextBoxColumn
            // 
            this.statusCodeDataGridViewTextBoxColumn.DataPropertyName = "StatusCode";
            this.statusCodeDataGridViewTextBoxColumn.HeaderText = "StatusCode";
            this.statusCodeDataGridViewTextBoxColumn.Name = "statusCodeDataGridViewTextBoxColumn";
            // 
            // statusNameDataGridViewTextBoxColumn
            // 
            this.statusNameDataGridViewTextBoxColumn.DataPropertyName = "StatusName";
            this.statusNameDataGridViewTextBoxColumn.HeaderText = "StatusName";
            this.statusNameDataGridViewTextBoxColumn.Name = "statusNameDataGridViewTextBoxColumn";
            // 
            // billingAddressDataGridViewTextBoxColumn
            // 
            this.billingAddressDataGridViewTextBoxColumn.DataPropertyName = "BillingAddress";
            this.billingAddressDataGridViewTextBoxColumn.HeaderText = "BillingAddress";
            this.billingAddressDataGridViewTextBoxColumn.Name = "billingAddressDataGridViewTextBoxColumn";
            // 
            // shippingAddressDataGridViewTextBoxColumn
            // 
            this.shippingAddressDataGridViewTextBoxColumn.DataPropertyName = "ShippingAddress";
            this.shippingAddressDataGridViewTextBoxColumn.HeaderText = "ShippingAddress";
            this.shippingAddressDataGridViewTextBoxColumn.Name = "shippingAddressDataGridViewTextBoxColumn";
            // 
            // affiliateIDDataGridViewTextBoxColumn
            // 
            this.affiliateIDDataGridViewTextBoxColumn.DataPropertyName = "AffiliateID";
            this.affiliateIDDataGridViewTextBoxColumn.HeaderText = "AffiliateID";
            this.affiliateIDDataGridViewTextBoxColumn.Name = "affiliateIDDataGridViewTextBoxColumn";
            // 
            // fraudScoreDataGridViewTextBoxColumn
            // 
            this.fraudScoreDataGridViewTextBoxColumn.DataPropertyName = "FraudScore";
            this.fraudScoreDataGridViewTextBoxColumn.HeaderText = "FraudScore";
            this.fraudScoreDataGridViewTextBoxColumn.Name = "fraudScoreDataGridViewTextBoxColumn";
            // 
            // instructionsDataGridViewTextBoxColumn
            // 
            this.instructionsDataGridViewTextBoxColumn.DataPropertyName = "Instructions";
            this.instructionsDataGridViewTextBoxColumn.HeaderText = "Instructions";
            this.instructionsDataGridViewTextBoxColumn.Name = "instructionsDataGridViewTextBoxColumn";
            // 
            // shippingMethodIdDataGridViewTextBoxColumn
            // 
            this.shippingMethodIdDataGridViewTextBoxColumn.DataPropertyName = "ShippingMethodId";
            this.shippingMethodIdDataGridViewTextBoxColumn.HeaderText = "ShippingMethodId";
            this.shippingMethodIdDataGridViewTextBoxColumn.Name = "shippingMethodIdDataGridViewTextBoxColumn";
            // 
            // shippingMethodDisplayNameDataGridViewTextBoxColumn
            // 
            this.shippingMethodDisplayNameDataGridViewTextBoxColumn.DataPropertyName = "ShippingMethodDisplayName";
            this.shippingMethodDisplayNameDataGridViewTextBoxColumn.HeaderText = "ShippingMethodDisplayName";
            this.shippingMethodDisplayNameDataGridViewTextBoxColumn.Name = "shippingMethodDisplayNameDataGridViewTextBoxColumn";
            // 
            // shippingProviderIdDataGridViewTextBoxColumn
            // 
            this.shippingProviderIdDataGridViewTextBoxColumn.DataPropertyName = "ShippingProviderId";
            this.shippingProviderIdDataGridViewTextBoxColumn.HeaderText = "ShippingProviderId";
            this.shippingProviderIdDataGridViewTextBoxColumn.Name = "shippingProviderIdDataGridViewTextBoxColumn";
            // 
            // shippingProviderServiceCodeDataGridViewTextBoxColumn
            // 
            this.shippingProviderServiceCodeDataGridViewTextBoxColumn.DataPropertyName = "ShippingProviderServiceCode";
            this.shippingProviderServiceCodeDataGridViewTextBoxColumn.HeaderText = "ShippingProviderServiceCode";
            this.shippingProviderServiceCodeDataGridViewTextBoxColumn.Name = "shippingProviderServiceCodeDataGridViewTextBoxColumn";
            // 
            // totalTaxDataGridViewTextBoxColumn
            // 
            this.totalTaxDataGridViewTextBoxColumn.DataPropertyName = "TotalTax";
            this.totalTaxDataGridViewTextBoxColumn.HeaderText = "TotalTax";
            this.totalTaxDataGridViewTextBoxColumn.Name = "totalTaxDataGridViewTextBoxColumn";
            // 
            // itemsTaxDataGridViewTextBoxColumn
            // 
            this.itemsTaxDataGridViewTextBoxColumn.DataPropertyName = "ItemsTax";
            this.itemsTaxDataGridViewTextBoxColumn.HeaderText = "ItemsTax";
            this.itemsTaxDataGridViewTextBoxColumn.Name = "itemsTaxDataGridViewTextBoxColumn";
            // 
            // shippingTaxDataGridViewTextBoxColumn
            // 
            this.shippingTaxDataGridViewTextBoxColumn.DataPropertyName = "ShippingTax";
            this.shippingTaxDataGridViewTextBoxColumn.HeaderText = "ShippingTax";
            this.shippingTaxDataGridViewTextBoxColumn.Name = "shippingTaxDataGridViewTextBoxColumn";
            // 
            // shippingTaxRateDataGridViewTextBoxColumn
            // 
            this.shippingTaxRateDataGridViewTextBoxColumn.DataPropertyName = "ShippingTaxRate";
            this.shippingTaxRateDataGridViewTextBoxColumn.HeaderText = "ShippingTaxRate";
            this.shippingTaxRateDataGridViewTextBoxColumn.Name = "shippingTaxRateDataGridViewTextBoxColumn";
            // 
            // totalShippingBeforeDiscountsDataGridViewTextBoxColumn
            // 
            this.totalShippingBeforeDiscountsDataGridViewTextBoxColumn.DataPropertyName = "TotalShippingBeforeDiscounts";
            this.totalShippingBeforeDiscountsDataGridViewTextBoxColumn.HeaderText = "TotalShippingBeforeDiscounts";
            this.totalShippingBeforeDiscountsDataGridViewTextBoxColumn.Name = "totalShippingBeforeDiscountsDataGridViewTextBoxColumn";
            // 
            // totalOrderBeforeDiscountsDataGridViewTextBoxColumn
            // 
            this.totalOrderBeforeDiscountsDataGridViewTextBoxColumn.DataPropertyName = "TotalOrderBeforeDiscounts";
            this.totalOrderBeforeDiscountsDataGridViewTextBoxColumn.HeaderText = "TotalOrderBeforeDiscounts";
            this.totalOrderBeforeDiscountsDataGridViewTextBoxColumn.Name = "totalOrderBeforeDiscountsDataGridViewTextBoxColumn";
            // 
            // totalShippingDiscountsDataGridViewTextBoxColumn
            // 
            this.totalShippingDiscountsDataGridViewTextBoxColumn.DataPropertyName = "TotalShippingDiscounts";
            this.totalShippingDiscountsDataGridViewTextBoxColumn.HeaderText = "TotalShippingDiscounts";
            this.totalShippingDiscountsDataGridViewTextBoxColumn.Name = "totalShippingDiscountsDataGridViewTextBoxColumn";
            // 
            // totalOrderDiscountsDataGridViewTextBoxColumn
            // 
            this.totalOrderDiscountsDataGridViewTextBoxColumn.DataPropertyName = "TotalOrderDiscounts";
            this.totalOrderDiscountsDataGridViewTextBoxColumn.HeaderText = "TotalOrderDiscounts";
            this.totalOrderDiscountsDataGridViewTextBoxColumn.Name = "totalOrderDiscountsDataGridViewTextBoxColumn";
            // 
            // totalHandlingDataGridViewTextBoxColumn
            // 
            this.totalHandlingDataGridViewTextBoxColumn.DataPropertyName = "TotalHandling";
            this.totalHandlingDataGridViewTextBoxColumn.HeaderText = "TotalHandling";
            this.totalHandlingDataGridViewTextBoxColumn.Name = "totalHandlingDataGridViewTextBoxColumn";
            // 
            // totalGrandDataGridViewTextBoxColumn
            // 
            this.totalGrandDataGridViewTextBoxColumn.DataPropertyName = "TotalGrand";
            this.totalGrandDataGridViewTextBoxColumn.HeaderText = "TotalGrand";
            this.totalGrandDataGridViewTextBoxColumn.Name = "totalGrandDataGridViewTextBoxColumn";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bvinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastUpdatedUtcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeOfOrderUtcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thirdPartyOrderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shippingStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isPlacedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billingAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shippingAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn affiliateIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fraudScoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn instructionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shippingMethodIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shippingMethodDisplayNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shippingProviderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shippingProviderServiceCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalTaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemsTaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shippingTaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shippingTaxRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalShippingBeforeDiscountsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalOrderBeforeDiscountsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalShippingDiscountsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalOrderDiscountsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalHandlingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalGrandDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderDTOBindingSource;
    }
}