
namespace Animal_Management_System_Form
{
    partial class ProfileForm
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
            EmployeeDataGridView = new System.Windows.Forms.DataGridView();
            btnSearch = new System.Windows.Forms.Button();
            btnLoad = new System.Windows.Forms.Button();
            txtSearchIdEmployee = new System.Windows.Forms.TextBox();
            btnUpdate = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)EmployeeDataGridView).BeginInit();
            SuspendLayout();
            // 
            // EmployeeDataGridView
            // 
            EmployeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EmployeeDataGridView.Location = new System.Drawing.Point(3, 41);
            EmployeeDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            EmployeeDataGridView.Name = "EmployeeDataGridView";
            EmployeeDataGridView.RowHeadersWidth = 51;
            EmployeeDataGridView.RowTemplate.Height = 25;
            EmployeeDataGridView.Size = new System.Drawing.Size(832, 568);
            EmployeeDataGridView.TabIndex = 14;
            // 
            // btnSearch
            // 
            btnSearch.Location = new System.Drawing.Point(3, 7);
            btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(96, 27);
            btnSearch.TabIndex = 15;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new System.Drawing.Point(238, 7);
            btnLoad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new System.Drawing.Size(96, 27);
            btnLoad.TabIndex = 16;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // txtSearchIdEmployee
            // 
            txtSearchIdEmployee.Location = new System.Drawing.Point(105, 7);
            txtSearchIdEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtSearchIdEmployee.Name = "txtSearchIdEmployee";
            txtSearchIdEmployee.PlaceholderText = "Employee  ID";
            txtSearchIdEmployee.Size = new System.Drawing.Size(127, 27);
            txtSearchIdEmployee.TabIndex = 17;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(442, 7);
            btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(96, 27);
            btnUpdate.TabIndex = 18;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(544, 7);
            btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(96, 27);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(340, 7);
            btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(96, 27);
            btnAdd.TabIndex = 20;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(txtSearchIdEmployee);
            Controls.Add(btnLoad);
            Controls.Add(btnSearch);
            Controls.Add(EmployeeDataGridView);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "ProfileForm";
            Size = new System.Drawing.Size(839, 613);
            Load += ProfileForm_Load;
            ((System.ComponentModel.ISupportInitialize)EmployeeDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.DataGridView EmployeeDataGridView;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtSearchIdEmployee;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
    }
}
