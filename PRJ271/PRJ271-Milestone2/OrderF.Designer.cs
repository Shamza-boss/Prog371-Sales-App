namespace PRJ271_Milestone2
{
    partial class OrderF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderF));
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.txtOrderNumber = new System.Windows.Forms.TextBox();
            this.txtOrderDescription = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDateTime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrder
            // 
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(354, 19);
            this.dgvOrder.Margin = new System.Windows.Forms.Padding(10);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowHeadersWidth = 62;
            this.dgvOrder.RowTemplate.Height = 28;
            this.dgvOrder.Size = new System.Drawing.Size(1264, 969);
            this.dgvOrder.TabIndex = 0;
            // 
            // txtOrderNumber
            // 
            this.txtOrderNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOrderNumber.Location = new System.Drawing.Point(15, 111);
            this.txtOrderNumber.Margin = new System.Windows.Forms.Padding(10);
            this.txtOrderNumber.Name = "txtOrderNumber";
            this.txtOrderNumber.Size = new System.Drawing.Size(315, 26);
            this.txtOrderNumber.TabIndex = 2;
            // 
            // txtOrderDescription
            // 
            this.txtOrderDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOrderDescription.Location = new System.Drawing.Point(16, 182);
            this.txtOrderDescription.Margin = new System.Windows.Forms.Padding(10);
            this.txtOrderDescription.Name = "txtOrderDescription";
            this.txtOrderDescription.Size = new System.Drawing.Size(315, 26);
            this.txtOrderDescription.TabIndex = 3;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQuantity.Location = new System.Drawing.Point(15, 253);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(10);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(315, 26);
            this.txtQuantity.TabIndex = 4;
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrice.Location = new System.Drawing.Point(15, 324);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(10);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(315, 26);
            this.txtPrice.TabIndex = 5;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(826, 1008);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(10);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(183, 55);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(1029, 1008);
            this.btnShowAll.Margin = new System.Windows.Forms.Padding(10);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(183, 55);
            this.btnShowAll.TabIndex = 7;
            this.btnShowAll.Text = "Show all";
            this.btnShowAll.UseVisualStyleBackColor = true;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(1232, 1008);
            this.Delete.Margin = new System.Windows.Forms.Padding(10);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(183, 55);
            this.Delete.TabIndex = 8;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1435, 1008);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(183, 55);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label1.Size = new System.Drawing.Size(44, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 80);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Order Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 151);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label3.Size = new System.Drawing.Size(133, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Order Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 222);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label4.Size = new System.Drawing.Size(112, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Order Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 293);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label5.Size = new System.Drawing.Size(44, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Price";
            // 
            // txtDateTime
            // 
            this.txtDateTime.Location = new System.Drawing.Point(16, 44);
            this.txtDateTime.Margin = new System.Windows.Forms.Padding(10);
            this.txtDateTime.Name = "txtDateTime";
            this.txtDateTime.Size = new System.Drawing.Size(315, 26);
            this.txtDateTime.TabIndex = 15;
            // 
            // OrderF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1637, 1079);
            this.Controls.Add(this.txtDateTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtOrderDescription);
            this.Controls.Add(this.txtOrderNumber);
            this.Controls.Add(this.dgvOrder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrderF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.TransparencyKey = System.Drawing.Color.Silver;
            this.Load += new System.EventHandler(this.OrderF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.TextBox txtOrderNumber;
        private System.Windows.Forms.TextBox txtOrderDescription;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker txtDateTime;
    }
}