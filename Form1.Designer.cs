namespace ProductManagement
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnSaveProduct = new System.Windows.Forms.Button();
            this.datePickerProductExpire = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProductOrigin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductStock = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPriceTo = new System.Windows.Forms.TextBox();
            this.txtPriceFrom = new System.Windows.Forms.TextBox();
            this.btnFilterExpiredProducts = new System.Windows.Forms.Button();
            this.btnFilterProductFromJap = new System.Windows.Forms.Button();
            this.btnFilterHighestPrice = new System.Windows.Forms.Button();
            this.dgFilteredProduct = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnDeleteAllExpiredProduct = new System.Windows.Forms.Button();
            this.btnDeleteAllProduct = new System.Windows.Forms.Button();
            this.btnCheckIfExistExpiredProduct = new System.Windows.Forms.Button();
            this.txtDeleteOrigin = new System.Windows.Forms.TextBox();
            this.btnDeleteProductByOrigin = new System.Windows.Forms.Button();
            this.dgProduct = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.btnFilterProductByRange = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFilteredProduct)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduct)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnDeleteProduct);
            this.panel1.Controls.Add(this.btnSaveProduct);
            this.panel1.Controls.Add(this.datePickerProductExpire);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtProductOrigin);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtProductPrice);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtProductStock);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtProductName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtProductId);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 231);
            this.panel1.TabIndex = 0;
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(145, 181);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteProduct.TabIndex = 15;
            this.btnDeleteProduct.Text = "Xóa SP";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnSaveProduct
            // 
            this.btnSaveProduct.Location = new System.Drawing.Point(62, 181);
            this.btnSaveProduct.Name = "btnSaveProduct";
            this.btnSaveProduct.Size = new System.Drawing.Size(75, 23);
            this.btnSaveProduct.TabIndex = 14;
            this.btnSaveProduct.Text = "Lưu SP";
            this.btnSaveProduct.UseVisualStyleBackColor = true;
            this.btnSaveProduct.Click += new System.EventHandler(this.btnSaveProduct_Click);
            // 
            // datePickerProductExpire
            // 
            this.datePickerProductExpire.Location = new System.Drawing.Point(60, 144);
            this.datePickerProductExpire.Name = "datePickerProductExpire";
            this.datePickerProductExpire.Size = new System.Drawing.Size(186, 20);
            this.datePickerProductExpire.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 150);
            this.label6.MaximumSize = new System.Drawing.Size(0, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 26);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ngày hết \r\nhạn";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Xuất xứ";
            // 
            // txtProductOrigin
            // 
            this.txtProductOrigin.Location = new System.Drawing.Point(62, 118);
            this.txtProductOrigin.Name = "txtProductOrigin";
            this.txtProductOrigin.Size = new System.Drawing.Size(184, 20);
            this.txtProductOrigin.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Đơn giá:";
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(62, 92);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(184, 20);
            this.txtProductPrice.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số lượng";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtProductStock
            // 
            this.txtProductStock.Location = new System.Drawing.Point(62, 66);
            this.txtProductStock.Name = "txtProductStock";
            this.txtProductStock.Size = new System.Drawing.Size(184, 20);
            this.txtProductStock.TabIndex = 5;
            this.txtProductStock.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên SP:";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(62, 40);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(184, 20);
            this.txtProductName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã SP:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(62, 14);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(184, 20);
            this.txtProductId.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.btnFilterProductByRange);
            this.panel2.Controls.Add(this.txtPriceTo);
            this.panel2.Controls.Add(this.txtPriceFrom);
            this.panel2.Controls.Add(this.btnFilterExpiredProducts);
            this.panel2.Controls.Add(this.btnFilterProductFromJap);
            this.panel2.Controls.Add(this.btnFilterHighestPrice);
            this.panel2.Controls.Add(this.dgFilteredProduct);
            this.panel2.Location = new System.Drawing.Point(287, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(501, 231);
            this.panel2.TabIndex = 1;
            // 
            // txtPriceTo
            // 
            this.txtPriceTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceTo.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtPriceTo.Location = new System.Drawing.Point(451, 14);
            this.txtPriceTo.Multiline = true;
            this.txtPriceTo.Name = "txtPriceTo";
            this.txtPriceTo.Size = new System.Drawing.Size(39, 49);
            this.txtPriceTo.TabIndex = 20;
            this.txtPriceTo.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // txtPriceFrom
            // 
            this.txtPriceFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceFrom.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtPriceFrom.Location = new System.Drawing.Point(404, 14);
            this.txtPriceFrom.Multiline = true;
            this.txtPriceFrom.Name = "txtPriceFrom";
            this.txtPriceFrom.Size = new System.Drawing.Size(41, 49);
            this.txtPriceFrom.TabIndex = 16;
            // 
            // btnFilterExpiredProducts
            // 
            this.btnFilterExpiredProducts.Location = new System.Drawing.Point(191, 11);
            this.btnFilterExpiredProducts.Name = "btnFilterExpiredProducts";
            this.btnFilterExpiredProducts.Size = new System.Drawing.Size(88, 49);
            this.btnFilterExpiredProducts.TabIndex = 18;
            this.btnFilterExpiredProducts.Text = "Xuất toàn bộ SP quá hạn";
            this.btnFilterExpiredProducts.UseVisualStyleBackColor = true;
            this.btnFilterExpiredProducts.Click += new System.EventHandler(this.btnFilterExpiredProducts_Click);
            // 
            // btnFilterProductFromJap
            // 
            this.btnFilterProductFromJap.Location = new System.Drawing.Point(97, 11);
            this.btnFilterProductFromJap.Name = "btnFilterProductFromJap";
            this.btnFilterProductFromJap.Size = new System.Drawing.Size(88, 49);
            this.btnFilterProductFromJap.TabIndex = 17;
            this.btnFilterProductFromJap.Text = "1 SP từ Nhật Bản";
            this.btnFilterProductFromJap.UseVisualStyleBackColor = true;
            this.btnFilterProductFromJap.Click += new System.EventHandler(this.btnFilterProductFromJap_Click);
            // 
            // btnFilterHighestPrice
            // 
            this.btnFilterHighestPrice.Location = new System.Drawing.Point(3, 11);
            this.btnFilterHighestPrice.Name = "btnFilterHighestPrice";
            this.btnFilterHighestPrice.Size = new System.Drawing.Size(88, 49);
            this.btnFilterHighestPrice.TabIndex = 16;
            this.btnFilterHighestPrice.Text = "1 SP có ĐG cao nhất";
            this.btnFilterHighestPrice.UseVisualStyleBackColor = true;
            this.btnFilterHighestPrice.Click += new System.EventHandler(this.btnFilterHighestPrice_Click);
            // 
            // dgFilteredProduct
            // 
            this.dgFilteredProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFilteredProduct.Location = new System.Drawing.Point(0, 66);
            this.dgFilteredProduct.Name = "dgFilteredProduct";
            this.dgFilteredProduct.Size = new System.Drawing.Size(500, 164);
            this.dgFilteredProduct.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(48, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(184, 18);
            this.panel3.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.label9);
            this.panel6.Location = new System.Drawing.Point(-2, -2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(184, 18);
            this.panel6.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Nhập thông tin cá nhân";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Nhập thông tin cá nhân";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(437, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(199, 18);
            this.panel4.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Chọn chức năng tìm kiếm";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.dgProduct);
            this.panel5.Location = new System.Drawing.Point(12, 254);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(775, 193);
            this.panel5.TabIndex = 16;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel9.Controls.Add(this.label12);
            this.panel9.Location = new System.Drawing.Point(561, 11);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(184, 18);
            this.panel9.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(53, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Chọn thao tác";
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.btnDeleteAllExpiredProduct);
            this.panel8.Controls.Add(this.btnDeleteAllProduct);
            this.panel8.Controls.Add(this.btnCheckIfExistExpiredProduct);
            this.panel8.Controls.Add(this.txtDeleteOrigin);
            this.panel8.Controls.Add(this.btnDeleteProductByOrigin);
            this.panel8.Location = new System.Drawing.Point(542, 19);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(222, 170);
            this.panel8.TabIndex = 22;
            // 
            // btnDeleteAllExpiredProduct
            // 
            this.btnDeleteAllExpiredProduct.Location = new System.Drawing.Point(115, 117);
            this.btnDeleteAllExpiredProduct.Name = "btnDeleteAllExpiredProduct";
            this.btnDeleteAllExpiredProduct.Size = new System.Drawing.Size(91, 45);
            this.btnDeleteAllExpiredProduct.TabIndex = 24;
            this.btnDeleteAllExpiredProduct.Text = "Xóa toàn bộ SP quá hạn";
            this.btnDeleteAllExpiredProduct.UseVisualStyleBackColor = true;
            this.btnDeleteAllExpiredProduct.Click += new System.EventHandler(this.btnDeleteAllExpiredProduct_Click);
            // 
            // btnDeleteAllProduct
            // 
            this.btnDeleteAllProduct.Location = new System.Drawing.Point(14, 117);
            this.btnDeleteAllProduct.Name = "btnDeleteAllProduct";
            this.btnDeleteAllProduct.Size = new System.Drawing.Size(91, 45);
            this.btnDeleteAllProduct.TabIndex = 23;
            this.btnDeleteAllProduct.Text = "Xóa toàn bộ SP trong kho";
            this.btnDeleteAllProduct.UseVisualStyleBackColor = true;
            this.btnDeleteAllProduct.Click += new System.EventHandler(this.btnDeleteAllProduct_Click);
            // 
            // btnCheckIfExistExpiredProduct
            // 
            this.btnCheckIfExistExpiredProduct.Location = new System.Drawing.Point(14, 66);
            this.btnCheckIfExistExpiredProduct.Name = "btnCheckIfExistExpiredProduct";
            this.btnCheckIfExistExpiredProduct.Size = new System.Drawing.Size(192, 45);
            this.btnCheckIfExistExpiredProduct.TabIndex = 22;
            this.btnCheckIfExistExpiredProduct.Text = "Kiểm tra kho có SP quá hạn hay không ?";
            this.btnCheckIfExistExpiredProduct.UseVisualStyleBackColor = true;
            this.btnCheckIfExistExpiredProduct.Click += new System.EventHandler(this.btnCheckIfExistExpiredProduct_Click);
            // 
            // txtDeleteOrigin
            // 
            this.txtDeleteOrigin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeleteOrigin.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtDeleteOrigin.Location = new System.Drawing.Point(132, 15);
            this.txtDeleteOrigin.Multiline = true;
            this.txtDeleteOrigin.Name = "txtDeleteOrigin";
            this.txtDeleteOrigin.Size = new System.Drawing.Size(74, 45);
            this.txtDeleteOrigin.TabIndex = 21;
            // 
            // btnDeleteProductByOrigin
            // 
            this.btnDeleteProductByOrigin.Location = new System.Drawing.Point(14, 15);
            this.btnDeleteProductByOrigin.Name = "btnDeleteProductByOrigin";
            this.btnDeleteProductByOrigin.Size = new System.Drawing.Size(112, 45);
            this.btnDeleteProductByOrigin.TabIndex = 21;
            this.btnDeleteProductByOrigin.Text = "Xóa SP theo xuất xứ bất kỳ";
            this.btnDeleteProductByOrigin.UseVisualStyleBackColor = true;
            this.btnDeleteProductByOrigin.Click += new System.EventHandler(this.btnDeleteProductByOrigin_Click);
            // 
            // dgProduct
            // 
            this.dgProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProduct.Location = new System.Drawing.Point(3, 19);
            this.dgProduct.Name = "dgProduct";
            this.dgProduct.Size = new System.Drawing.Size(533, 171);
            this.dgProduct.TabIndex = 21;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.label10);
            this.panel7.Location = new System.Drawing.Point(36, 249);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(184, 18);
            this.panel7.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(175, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Danh sách sản phẩm sau khi nhập:";
            // 
            // btnFilterProductByRange
            // 
            this.btnFilterProductByRange.Location = new System.Drawing.Point(310, 14);
            this.btnFilterProductByRange.Name = "btnFilterProductByRange";
            this.btnFilterProductByRange.Size = new System.Drawing.Size(88, 49);
            this.btnFilterProductByRange.TabIndex = 21;
            this.btnFilterProductByRange.Text = "Xuất toàn bộ SP quá hạn";
            this.btnFilterProductByRange.UseVisualStyleBackColor = true;
            this.btnFilterProductByRange.Click += new System.EventHandler(this.btnFilterProductByRange_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFilteredProduct)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduct)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgFilteredProduct;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProductStock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.DateTimePicker datePickerProductExpire;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProductOrigin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnSaveProduct;
        private System.Windows.Forms.TextBox txtPriceFrom;
        private System.Windows.Forms.Button btnFilterExpiredProducts;
        private System.Windows.Forms.Button btnFilterProductFromJap;
        private System.Windows.Forms.Button btnFilterHighestPrice;
        private System.Windows.Forms.TextBox txtPriceTo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnDeleteAllExpiredProduct;
        private System.Windows.Forms.Button btnDeleteAllProduct;
        private System.Windows.Forms.Button btnCheckIfExistExpiredProduct;
        private System.Windows.Forms.TextBox txtDeleteOrigin;
        private System.Windows.Forms.Button btnDeleteProductByOrigin;
        private System.Windows.Forms.DataGridView dgProduct;
        private System.Windows.Forms.Button btnFilterProductByRange;
    }
}

