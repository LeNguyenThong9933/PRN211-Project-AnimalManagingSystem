
namespace Animal_Management_System_Form
{
    partial class FoodForm
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
            btnDelete = new System.Windows.Forms.Button();
            btnNew = new System.Windows.Forms.Button();
            btnLoad = new System.Windows.Forms.Button();
            dataGridView2 = new System.Windows.Forms.DataGridView();
            btnUpdate = new System.Windows.Forms.Button();
            lbExpiredDate = new System.Windows.Forms.Label();
            lbFoodName = new System.Windows.Forms.Label();
            txtFoodName = new System.Windows.Forms.TextBox();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            Add = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            Add.SuspendLayout();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(960, 16);
            btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(86, 31);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new System.Drawing.Point(48, 205);
            btnNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnNew.Name = "btnNew";
            btnNew.Size = new System.Drawing.Size(125, 31);
            btnNew.TabIndex = 8;
            btnNew.Text = "Add";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new System.Drawing.Point(776, 16);
            btnLoad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new System.Drawing.Size(86, 31);
            btnLoad.TabIndex = 7;
            btnLoad.Text = "&Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new System.Drawing.Point(318, 55);
            dataGridView2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new System.Drawing.Size(740, 486);
            dataGridView2.TabIndex = 0;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(868, 16);
            btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(86, 31);
            btnUpdate.TabIndex = 35;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lbExpiredDate
            // 
            lbExpiredDate.AutoSize = true;
            lbExpiredDate.Location = new System.Drawing.Point(21, 104);
            lbExpiredDate.Name = "lbExpiredDate";
            lbExpiredDate.Size = new System.Drawing.Size(95, 20);
            lbExpiredDate.TabIndex = 29;
            lbExpiredDate.Text = "Expired Date";
            // 
            // lbFoodName
            // 
            lbFoodName.AutoSize = true;
            lbFoodName.Location = new System.Drawing.Point(21, 52);
            lbFoodName.Name = "lbFoodName";
            lbFoodName.Size = new System.Drawing.Size(87, 20);
            lbFoodName.TabIndex = 32;
            lbFoodName.Text = "Food Name";
            // 
            // txtFoodName
            // 
            txtFoodName.Location = new System.Drawing.Point(21, 76);
            txtFoodName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtFoodName.Name = "txtFoodName";
            txtFoodName.Size = new System.Drawing.Size(242, 27);
            txtFoodName.TabIndex = 33;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new System.Drawing.Point(21, 131);
            dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(242, 27);
            dateTimePicker1.TabIndex = 34;
            // 
            // Add
            // 
            Add.Controls.Add(txtFoodName);
            Add.Controls.Add(lbFoodName);
            Add.Controls.Add(dateTimePicker1);
            Add.Controls.Add(btnNew);
            Add.Controls.Add(lbExpiredDate);
            Add.ForeColor = System.Drawing.Color.Gainsboro;
            Add.Location = new System.Drawing.Point(20, 45);
            Add.Name = "Add";
            Add.Size = new System.Drawing.Size(282, 275);
            Add.TabIndex = 36;
            Add.TabStop = false;
            Add.Text = "Add New Food";
            // 
            // FoodForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(Add);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnLoad);
            Controls.Add(dataGridView2);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "FoodForm";
            Size = new System.Drawing.Size(1098, 582);
            Load += FoodForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            Add.ResumeLayout(false);
            Add.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lbExpiredDate;
        private System.Windows.Forms.Label lbFoodName;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox Add;
    }
}
