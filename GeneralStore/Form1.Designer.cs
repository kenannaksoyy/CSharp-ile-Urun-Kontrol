namespace GeneralStore
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.addInfo = new System.Windows.Forms.Label();
            this.tbxProductStockAmountAdd = new System.Windows.Forms.TextBox();
            this.tbxProductPriceAdd = new System.Windows.Forms.TextBox();
            this.tbxProductNameAdd = new System.Windows.Forms.TextBox();
            this.lblProductStockAmountAdd = new System.Windows.Forms.Label();
            this.lblProductPriceAdd = new System.Windows.Forms.Label();
            this.lblProductNameAdd = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.UpdateInfo = new System.Windows.Forms.Label();
            this.tbxProductStockAmountUpdate = new System.Windows.Forms.TextBox();
            this.tbxProductPriceUpdate = new System.Windows.Forms.TextBox();
            this.tbxProductNameUpdate = new System.Windows.Forms.TextBox();
            this.lblProductStockAmountUpdate = new System.Windows.Forms.Label();
            this.lblProductPriceUpdate = new System.Windows.Forms.Label();
            this.lblProductNameUptade = new System.Windows.Forms.Label();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.DateTime = new System.Windows.Forms.DateTimePicker();
            this.Deleteİnfo = new System.Windows.Forms.Label();
            this.lblSearchName = new System.Windows.Forms.Label();
            this.tbxSearchName = new System.Windows.Forms.TextBox();
            this.tbxSearchId = new System.Windows.Forms.TextBox();
            this.lblSearchId = new System.Windows.Forms.Label();
            this.btxSearchId = new System.Windows.Forms.Button();
            this.btxRefresh = new System.Windows.Forms.Button();
            this.lblPriceRange = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxRange = new System.Windows.Forms.GroupBox();
            this.tbxMinPrice = new System.Windows.Forms.TextBox();
            this.tbxMaxPrice = new System.Windows.Forms.TextBox();
            this.btnRange = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.gbxAdd.SuspendLayout();
            this.gbxUpdate.SuspendLayout();
            this.gbxRange.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProduct
            // 
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduct.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(12, 12);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.RowTemplate.Height = 24;
            this.dgvProduct.Size = new System.Drawing.Size(793, 231);
            this.dgvProduct.TabIndex = 0;
            this.dgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellClick);
            // 
            // gbxAdd
            // 
            this.gbxAdd.BackColor = System.Drawing.SystemColors.Info;
            this.gbxAdd.Controls.Add(this.addInfo);
            this.gbxAdd.Controls.Add(this.tbxProductStockAmountAdd);
            this.gbxAdd.Controls.Add(this.tbxProductPriceAdd);
            this.gbxAdd.Controls.Add(this.tbxProductNameAdd);
            this.gbxAdd.Controls.Add(this.lblProductStockAmountAdd);
            this.gbxAdd.Controls.Add(this.lblProductPriceAdd);
            this.gbxAdd.Controls.Add(this.lblProductNameAdd);
            this.gbxAdd.Controls.Add(this.btnAddProduct);
            this.gbxAdd.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxAdd.Location = new System.Drawing.Point(12, 266);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(372, 227);
            this.gbxAdd.TabIndex = 1;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Add a Product";
            // 
            // addInfo
            // 
            this.addInfo.AutoSize = true;
            this.addInfo.Location = new System.Drawing.Point(183, 21);
            this.addInfo.Name = "addInfo";
            this.addInfo.Size = new System.Drawing.Size(180, 17);
            this.addInfo.TabIndex = 7;
            this.addInfo.Text = "Enter Product Information";
            // 
            // tbxProductStockAmountAdd
            // 
            this.tbxProductStockAmountAdd.Location = new System.Drawing.Point(186, 147);
            this.tbxProductStockAmountAdd.Name = "tbxProductStockAmountAdd";
            this.tbxProductStockAmountAdd.Size = new System.Drawing.Size(180, 25);
            this.tbxProductStockAmountAdd.TabIndex = 6;
            // 
            // tbxProductPriceAdd
            // 
            this.tbxProductPriceAdd.Location = new System.Drawing.Point(186, 100);
            this.tbxProductPriceAdd.Name = "tbxProductPriceAdd";
            this.tbxProductPriceAdd.Size = new System.Drawing.Size(180, 25);
            this.tbxProductPriceAdd.TabIndex = 5;
            // 
            // tbxProductNameAdd
            // 
            this.tbxProductNameAdd.Location = new System.Drawing.Point(186, 50);
            this.tbxProductNameAdd.Name = "tbxProductNameAdd";
            this.tbxProductNameAdd.Size = new System.Drawing.Size(180, 25);
            this.tbxProductNameAdd.TabIndex = 4;
            // 
            // lblProductStockAmountAdd
            // 
            this.lblProductStockAmountAdd.AutoSize = true;
            this.lblProductStockAmountAdd.Location = new System.Drawing.Point(6, 153);
            this.lblProductStockAmountAdd.Name = "lblProductStockAmountAdd";
            this.lblProductStockAmountAdd.Size = new System.Drawing.Size(155, 17);
            this.lblProductStockAmountAdd.TabIndex = 3;
            this.lblProductStockAmountAdd.Text = "Product Stock Amount";
            // 
            // lblProductPriceAdd
            // 
            this.lblProductPriceAdd.AutoSize = true;
            this.lblProductPriceAdd.Location = new System.Drawing.Point(6, 106);
            this.lblProductPriceAdd.Name = "lblProductPriceAdd";
            this.lblProductPriceAdd.Size = new System.Drawing.Size(97, 17);
            this.lblProductPriceAdd.TabIndex = 2;
            this.lblProductPriceAdd.Text = "Product Price";
            // 
            // lblProductNameAdd
            // 
            this.lblProductNameAdd.AutoSize = true;
            this.lblProductNameAdd.Location = new System.Drawing.Point(6, 56);
            this.lblProductNameAdd.Name = "lblProductNameAdd";
            this.lblProductNameAdd.Size = new System.Drawing.Size(101, 17);
            this.lblProductNameAdd.TabIndex = 1;
            this.lblProductNameAdd.Text = "Product Name";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddProduct.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddProduct.Location = new System.Drawing.Point(186, 181);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(180, 40);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = "Add New Product";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.BackColor = System.Drawing.SystemColors.Info;
            this.gbxUpdate.Controls.Add(this.UpdateInfo);
            this.gbxUpdate.Controls.Add(this.tbxProductStockAmountUpdate);
            this.gbxUpdate.Controls.Add(this.tbxProductPriceUpdate);
            this.gbxUpdate.Controls.Add(this.tbxProductNameUpdate);
            this.gbxUpdate.Controls.Add(this.lblProductStockAmountUpdate);
            this.gbxUpdate.Controls.Add(this.lblProductPriceUpdate);
            this.gbxUpdate.Controls.Add(this.lblProductNameUptade);
            this.gbxUpdate.Controls.Add(this.btnUpdateProduct);
            this.gbxUpdate.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxUpdate.Location = new System.Drawing.Point(433, 266);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(372, 227);
            this.gbxUpdate.TabIndex = 7;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Add a Product";
            // 
            // UpdateInfo
            // 
            this.UpdateInfo.AutoSize = true;
            this.UpdateInfo.Location = new System.Drawing.Point(183, 21);
            this.UpdateInfo.Name = "UpdateInfo";
            this.UpdateInfo.Size = new System.Drawing.Size(180, 17);
            this.UpdateInfo.TabIndex = 8;
            this.UpdateInfo.Text = "Enter Product Information";
            // 
            // tbxProductStockAmountUpdate
            // 
            this.tbxProductStockAmountUpdate.Location = new System.Drawing.Point(186, 147);
            this.tbxProductStockAmountUpdate.Name = "tbxProductStockAmountUpdate";
            this.tbxProductStockAmountUpdate.Size = new System.Drawing.Size(180, 25);
            this.tbxProductStockAmountUpdate.TabIndex = 6;
            // 
            // tbxProductPriceUpdate
            // 
            this.tbxProductPriceUpdate.Location = new System.Drawing.Point(186, 100);
            this.tbxProductPriceUpdate.Name = "tbxProductPriceUpdate";
            this.tbxProductPriceUpdate.Size = new System.Drawing.Size(180, 25);
            this.tbxProductPriceUpdate.TabIndex = 5;
            // 
            // tbxProductNameUpdate
            // 
            this.tbxProductNameUpdate.Location = new System.Drawing.Point(186, 50);
            this.tbxProductNameUpdate.Name = "tbxProductNameUpdate";
            this.tbxProductNameUpdate.Size = new System.Drawing.Size(180, 25);
            this.tbxProductNameUpdate.TabIndex = 4;
            // 
            // lblProductStockAmountUpdate
            // 
            this.lblProductStockAmountUpdate.AutoSize = true;
            this.lblProductStockAmountUpdate.Location = new System.Drawing.Point(6, 153);
            this.lblProductStockAmountUpdate.Name = "lblProductStockAmountUpdate";
            this.lblProductStockAmountUpdate.Size = new System.Drawing.Size(155, 17);
            this.lblProductStockAmountUpdate.TabIndex = 3;
            this.lblProductStockAmountUpdate.Text = "Product Stock Amount";
            // 
            // lblProductPriceUpdate
            // 
            this.lblProductPriceUpdate.AutoSize = true;
            this.lblProductPriceUpdate.Location = new System.Drawing.Point(6, 106);
            this.lblProductPriceUpdate.Name = "lblProductPriceUpdate";
            this.lblProductPriceUpdate.Size = new System.Drawing.Size(97, 17);
            this.lblProductPriceUpdate.TabIndex = 2;
            this.lblProductPriceUpdate.Text = "Product Price";
            // 
            // lblProductNameUptade
            // 
            this.lblProductNameUptade.AutoSize = true;
            this.lblProductNameUptade.Location = new System.Drawing.Point(6, 56);
            this.lblProductNameUptade.Name = "lblProductNameUptade";
            this.lblProductNameUptade.Size = new System.Drawing.Size(101, 17);
            this.lblProductNameUptade.TabIndex = 1;
            this.lblProductNameUptade.Text = "Product Name";
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdateProduct.Location = new System.Drawing.Point(186, 181);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(180, 40);
            this.btnUpdateProduct.TabIndex = 0;
            this.btnUpdateProduct.Text = "Update Product";
            this.btnUpdateProduct.UseVisualStyleBackColor = false;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteProduct.Location = new System.Drawing.Point(811, 86);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(302, 39);
            this.btnDeleteProduct.TabIndex = 8;
            this.btnDeleteProduct.Text = "Delete Product";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // DateTime
            // 
            this.DateTime.Location = new System.Drawing.Point(811, 12);
            this.DateTime.Name = "DateTime";
            this.DateTime.Size = new System.Drawing.Size(218, 22);
            this.DateTime.TabIndex = 9;
            // 
            // Deleteİnfo
            // 
            this.Deleteİnfo.AutoSize = true;
            this.Deleteİnfo.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Deleteİnfo.Location = new System.Drawing.Point(811, 66);
            this.Deleteİnfo.Name = "Deleteİnfo";
            this.Deleteİnfo.Size = new System.Drawing.Size(302, 19);
            this.Deleteİnfo.TabIndex = 10;
            this.Deleteİnfo.Text = "Select the Product and Press the Button";
            // 
            // lblSearchName
            // 
            this.lblSearchName.AutoSize = true;
            this.lblSearchName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSearchName.Location = new System.Drawing.Point(811, 139);
            this.lblSearchName.Name = "lblSearchName";
            this.lblSearchName.Size = new System.Drawing.Size(207, 19);
            this.lblSearchName.TabIndex = 11;
            this.lblSearchName.Text = "Search Product with Name";
            // 
            // tbxSearchName
            // 
            this.tbxSearchName.Location = new System.Drawing.Point(815, 161);
            this.tbxSearchName.Name = "tbxSearchName";
            this.tbxSearchName.Size = new System.Drawing.Size(203, 22);
            this.tbxSearchName.TabIndex = 12;
            this.tbxSearchName.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // tbxSearchId
            // 
            this.tbxSearchId.Location = new System.Drawing.Point(815, 222);
            this.tbxSearchId.Name = "tbxSearchId";
            this.tbxSearchId.Size = new System.Drawing.Size(203, 22);
            this.tbxSearchId.TabIndex = 14;
            // 
            // lblSearchId
            // 
            this.lblSearchId.AutoSize = true;
            this.lblSearchId.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSearchId.Location = new System.Drawing.Point(811, 200);
            this.lblSearchId.Name = "lblSearchId";
            this.lblSearchId.Size = new System.Drawing.Size(180, 19);
            this.lblSearchId.TabIndex = 13;
            this.lblSearchId.Text = "Search Product with Id";
            // 
            // btxSearchId
            // 
            this.btxSearchId.Location = new System.Drawing.Point(1038, 222);
            this.btxSearchId.Name = "btxSearchId";
            this.btxSearchId.Size = new System.Drawing.Size(75, 23);
            this.btxSearchId.TabIndex = 15;
            this.btxSearchId.Text = "Search";
            this.btxSearchId.UseVisualStyleBackColor = true;
            this.btxSearchId.Click += new System.EventHandler(this.btxSearchId_Click);
            // 
            // btxRefresh
            // 
            this.btxRefresh.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btxRefresh.Location = new System.Drawing.Point(811, 448);
            this.btxRefresh.Name = "btxRefresh";
            this.btxRefresh.Size = new System.Drawing.Size(160, 41);
            this.btxRefresh.TabIndex = 16;
            this.btxRefresh.Text = "Table Refresh";
            this.btxRefresh.UseVisualStyleBackColor = false;
            this.btxRefresh.Click += new System.EventHandler(this.btxRefresh_Click);
            // 
            // lblPriceRange
            // 
            this.lblPriceRange.AutoSize = true;
            this.lblPriceRange.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPriceRange.Location = new System.Drawing.Point(85, 23);
            this.lblPriceRange.Name = "lblPriceRange";
            this.lblPriceRange.Size = new System.Drawing.Size(112, 19);
            this.lblPriceRange.TabIndex = 17;
            this.lblPriceRange.Text = "Specify Range";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "Min";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "Max";
            // 
            // gbxRange
            // 
            this.gbxRange.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gbxRange.Controls.Add(this.btnRange);
            this.gbxRange.Controls.Add(this.tbxMaxPrice);
            this.gbxRange.Controls.Add(this.tbxMinPrice);
            this.gbxRange.Controls.Add(this.lblPriceRange);
            this.gbxRange.Controls.Add(this.label2);
            this.gbxRange.Controls.Add(this.label1);
            this.gbxRange.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxRange.Location = new System.Drawing.Point(832, 267);
            this.gbxRange.Name = "gbxRange";
            this.gbxRange.Size = new System.Drawing.Size(280, 169);
            this.gbxRange.TabIndex = 20;
            this.gbxRange.TabStop = false;
            this.gbxRange.Text = "Range Price";
            // 
            // tbxMinPrice
            // 
            this.tbxMinPrice.Location = new System.Drawing.Point(6, 76);
            this.tbxMinPrice.Name = "tbxMinPrice";
            this.tbxMinPrice.Size = new System.Drawing.Size(130, 27);
            this.tbxMinPrice.TabIndex = 20;
            // 
            // tbxMaxPrice
            // 
            this.tbxMaxPrice.Location = new System.Drawing.Point(144, 76);
            this.tbxMaxPrice.Name = "tbxMaxPrice";
            this.tbxMaxPrice.Size = new System.Drawing.Size(130, 27);
            this.tbxMaxPrice.TabIndex = 21;
            // 
            // btnRange
            // 
            this.btnRange.Location = new System.Drawing.Point(111, 109);
            this.btnRange.Name = "btnRange";
            this.btnRange.Size = new System.Drawing.Size(75, 40);
            this.btnRange.TabIndex = 22;
            this.btnRange.Text = "Show";
            this.btnRange.UseVisualStyleBackColor = true;
            this.btnRange.Click += new System.EventHandler(this.btnRange_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1308, 505);
            this.Controls.Add(this.gbxRange);
            this.Controls.Add(this.btxRefresh);
            this.Controls.Add(this.btxSearchId);
            this.Controls.Add(this.tbxSearchId);
            this.Controls.Add(this.lblSearchId);
            this.Controls.Add(this.tbxSearchName);
            this.Controls.Add(this.lblSearchName);
            this.Controls.Add(this.Deleteİnfo);
            this.Controls.Add(this.DateTime);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.gbxAdd);
            this.Controls.Add(this.dgvProduct);
            this.Name = "Form1";
            this.Text = "GeneralStore";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.gbxRange.ResumeLayout(false);
            this.gbxRange.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.TextBox tbxProductStockAmountAdd;
        private System.Windows.Forms.TextBox tbxProductPriceAdd;
        private System.Windows.Forms.TextBox tbxProductNameAdd;
        private System.Windows.Forms.Label lblProductStockAmountAdd;
        private System.Windows.Forms.Label lblProductPriceAdd;
        private System.Windows.Forms.Label lblProductNameAdd;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.TextBox tbxProductStockAmountUpdate;
        private System.Windows.Forms.TextBox tbxProductPriceUpdate;
        private System.Windows.Forms.TextBox tbxProductNameUpdate;
        private System.Windows.Forms.Label lblProductStockAmountUpdate;
        private System.Windows.Forms.Label lblProductPriceUpdate;
        private System.Windows.Forms.Label lblProductNameUptade;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Label addInfo;
        private System.Windows.Forms.Label UpdateInfo;
        private System.Windows.Forms.DateTimePicker DateTime;
        private System.Windows.Forms.Label Deleteİnfo;
        private System.Windows.Forms.Label lblSearchName;
        private System.Windows.Forms.TextBox tbxSearchName;
        private System.Windows.Forms.TextBox tbxSearchId;
        private System.Windows.Forms.Label lblSearchId;
        private System.Windows.Forms.Button btxSearchId;
        private System.Windows.Forms.Button btxRefresh;
        private System.Windows.Forms.Label lblPriceRange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbxRange;
        private System.Windows.Forms.Button btnRange;
        private System.Windows.Forms.TextBox tbxMaxPrice;
        private System.Windows.Forms.TextBox tbxMinPrice;
    }
}

