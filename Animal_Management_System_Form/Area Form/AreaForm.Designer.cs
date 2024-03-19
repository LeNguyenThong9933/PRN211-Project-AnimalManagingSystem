namespace Animal_Management_System_Form.AreaForm
{
    partial class AreaForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new System.Windows.Forms.Label();
            dgvAreaList = new System.Windows.Forms.DataGridView();
            btnLoad = new System.Windows.Forms.Button();
            btnAdd = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnOrder = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            txtAreaSquare = new System.Windows.Forms.TextBox();
            txtAreaName = new System.Windows.Forms.TextBox();
            txtAreaId = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            btnAnimal = new System.Windows.Forms.Button();
            btnEmployee = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvAreaList).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label1.Location = new System.Drawing.Point(392, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(131, 35);
            label1.TabIndex = 1;
            label1.Text = "Area Form";
            // 
            // dgvAreaList
            // 
            dgvAreaList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAreaList.Location = new System.Drawing.Point(33, 308);
            dgvAreaList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvAreaList.Name = "dgvAreaList";
            dgvAreaList.RowHeadersWidth = 51;
            dgvAreaList.RowTemplate.Height = 25;
            dgvAreaList.Size = new System.Drawing.Size(865, 340);
            dgvAreaList.TabIndex = 2;
            dgvAreaList.CellDoubleClick += dgvAreaList_CellDoubleClick;
            dgvAreaList.CellFormatting += dgvAreaList_CellFormatting;
            // 
            // btnLoad
            // 
            btnLoad.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnLoad.Location = new System.Drawing.Point(43, 76);
            btnLoad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new System.Drawing.Size(91, 40);
            btnLoad.TabIndex = 3;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnAdd.Location = new System.Drawing.Point(229, 76);
            btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(91, 40);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnUpdate.Location = new System.Drawing.Point(406, 76);
            btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(91, 40);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnDelete.Location = new System.Drawing.Point(587, 76);
            btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(91, 40);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += BtnDelete_Click;
            // 
            // btnOrder
            // 
            btnOrder.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnOrder.Location = new System.Drawing.Point(770, 76);
            btnOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new System.Drawing.Size(91, 40);
            btnOrder.TabIndex = 7;
            btnOrder.Text = "Order By Square";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtAreaSquare);
            groupBox1.Controls.Add(txtAreaName);
            groupBox1.Controls.Add(txtAreaId);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            groupBox1.Location = new System.Drawing.Point(33, 188);
            groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox1.Size = new System.Drawing.Size(865, 112);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "View Infor";
            // 
            // txtAreaSquare
            // 
            txtAreaSquare.Enabled = false;
            txtAreaSquare.Location = new System.Drawing.Point(669, 67);
            txtAreaSquare.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtAreaSquare.Name = "txtAreaSquare";
            txtAreaSquare.ReadOnly = true;
            txtAreaSquare.Size = new System.Drawing.Size(148, 27);
            txtAreaSquare.TabIndex = 5;
            // 
            // txtAreaName
            // 
            txtAreaName.Enabled = false;
            txtAreaName.Location = new System.Drawing.Point(331, 67);
            txtAreaName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtAreaName.Name = "txtAreaName";
            txtAreaName.ReadOnly = true;
            txtAreaName.Size = new System.Drawing.Size(151, 27);
            txtAreaName.TabIndex = 4;
            // 
            // txtAreaId
            // 
            txtAreaId.Enabled = false;
            txtAreaId.Location = new System.Drawing.Point(42, 67);
            txtAreaId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtAreaId.Name = "txtAreaId";
            txtAreaId.ReadOnly = true;
            txtAreaId.Size = new System.Drawing.Size(114, 27);
            txtAreaId.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(703, 33);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(90, 20);
            label4.TabIndex = 2;
            label4.Text = "Area Square";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(368, 33);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(84, 20);
            label3.TabIndex = 1;
            label3.Text = "Area Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(70, 33);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(59, 20);
            label2.TabIndex = 0;
            label2.Text = "Area ID";
            // 
            // btnAnimal
            // 
            btnAnimal.Location = new System.Drawing.Point(301, 124);
            btnAnimal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnAnimal.Name = "btnAnimal";
            btnAnimal.Size = new System.Drawing.Size(121, 56);
            btnAnimal.TabIndex = 10;
            btnAnimal.Text = "View Animals In This Area";
            btnAnimal.UseVisualStyleBackColor = true;
            btnAnimal.Click += btnAnimal_Click;
            // 
            // btnEmployee
            // 
            btnEmployee.Location = new System.Drawing.Point(497, 124);
            btnEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new System.Drawing.Size(121, 56);
            btnEmployee.TabIndex = 11;
            btnEmployee.Text = "View Employee In This Area";
            btnEmployee.UseVisualStyleBackColor = true;
            btnEmployee.Click += btnEmployee_Click;
            // 
            // AreaForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(btnEmployee);
            Controls.Add(btnAnimal);
            Controls.Add(groupBox1);
            Controls.Add(btnOrder);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnLoad);
            Controls.Add(dgvAreaList);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "AreaForm";
            Size = new System.Drawing.Size(914, 665);
            Load += AreaForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAreaList).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAreaList;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAreaSquare;
        private System.Windows.Forms.TextBox txtAreaName;
        private System.Windows.Forms.TextBox txtAreaId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAnimal;
        private System.Windows.Forms.Button btnEmployee;
    }
}