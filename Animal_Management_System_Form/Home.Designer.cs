
namespace Animal_Management_System_Form
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel = new System.Windows.Forms.Panel();
            pannelMenu = new System.Windows.Forms.Panel();
            icLogout = new FontAwesome.Sharp.IconButton();
            icArea = new FontAwesome.Sharp.IconButton();
            icfood = new FontAwesome.Sharp.IconButton();
            icAnimal = new FontAwesome.Sharp.IconButton();
            panel2 = new System.Windows.Forms.Panel();
            icHome = new FontAwesome.Sharp.IconButton();
            iconProfile = new FontAwesome.Sharp.IconButton();
            pannelLogo = new System.Windows.Forms.Panel();
            pannelTop = new System.Windows.Forms.Panel();
            lbchildForm = new System.Windows.Forms.Label();
            iconChild = new FontAwesome.Sharp.IconPictureBox();
            pannelshadow = new System.Windows.Forms.Panel();
            pannelMenu.SuspendLayout();
            panel2.SuspendLayout();
            pannelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconChild).BeginInit();
            SuspendLayout();
            // 
            // panel
            // 
            panel.BackColor = System.Drawing.Color.FromArgb(26, 25, 62);
            panel.Dock = System.Windows.Forms.DockStyle.Fill;
            panel.Location = new System.Drawing.Point(219, 107);
            panel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel.Name = "panel";
            panel.Size = new System.Drawing.Size(1099, 581);
            panel.TabIndex = 0;
            // 
            // pannelMenu
            // 
            pannelMenu.BackColor = System.Drawing.Color.FromArgb(31, 30, 68);
            pannelMenu.Controls.Add(icLogout);
            pannelMenu.Controls.Add(icArea);
            pannelMenu.Controls.Add(icfood);
            pannelMenu.Controls.Add(icAnimal);
            pannelMenu.Controls.Add(panel2);
            pannelMenu.Controls.Add(iconProfile);
            pannelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            pannelMenu.Location = new System.Drawing.Point(0, 0);
            pannelMenu.Name = "pannelMenu";
            pannelMenu.Size = new System.Drawing.Size(219, 688);
            pannelMenu.TabIndex = 3;
            // 
            // icLogout
            // 
            icLogout.FlatAppearance.BorderSize = 0;
            icLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            icLogout.ForeColor = System.Drawing.Color.Gainsboro;
            icLogout.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            icLogout.IconColor = System.Drawing.SystemColors.ActiveCaption;
            icLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icLogout.IconSize = 32;
            icLogout.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            icLogout.Location = new System.Drawing.Point(3, 625);
            icLogout.Name = "icLogout";
            icLogout.Padding = new System.Windows.Forms.Padding(10, 0, 21, 0);
            icLogout.Size = new System.Drawing.Size(214, 60);
            icLogout.TabIndex = 11;
            icLogout.Text = "Logout";
            icLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            icLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            icLogout.UseVisualStyleBackColor = true;
            icLogout.Click += icLogout_Click;
            // 
            // icArea
            // 
            icArea.FlatAppearance.BorderSize = 0;
            icArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            icArea.ForeColor = System.Drawing.Color.Gainsboro;
            icArea.IconChar = FontAwesome.Sharp.IconChar.Pagelines;
            icArea.IconColor = System.Drawing.SystemColors.ActiveCaption;
            icArea.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icArea.IconSize = 32;
            icArea.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            icArea.Location = new System.Drawing.Point(3, 329);
            icArea.Name = "icArea";
            icArea.Padding = new System.Windows.Forms.Padding(10, 0, 21, 0);
            icArea.Size = new System.Drawing.Size(214, 60);
            icArea.TabIndex = 9;
            icArea.Text = "Area Management";
            icArea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            icArea.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            icArea.UseVisualStyleBackColor = true;
            icArea.Click += icArea_Click;
            // 
            // icfood
            // 
            icfood.FlatAppearance.BorderSize = 0;
            icfood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            icfood.ForeColor = System.Drawing.Color.Gainsboro;
            icfood.IconChar = FontAwesome.Sharp.IconChar.Bone;
            icfood.IconColor = System.Drawing.SystemColors.ActiveCaption;
            icfood.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icfood.IconSize = 32;
            icfood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            icfood.Location = new System.Drawing.Point(3, 247);
            icfood.Name = "icfood";
            icfood.Padding = new System.Windows.Forms.Padding(10, 0, 21, 0);
            icfood.Size = new System.Drawing.Size(217, 60);
            icfood.TabIndex = 8;
            icfood.Text = "Food Management";
            icfood.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            icfood.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            icfood.UseVisualStyleBackColor = true;
            icfood.Click += icfood_Click;
            // 
            // icAnimal
            // 
            icAnimal.FlatAppearance.BorderSize = 0;
            icAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            icAnimal.ForeColor = System.Drawing.Color.Gainsboro;
            icAnimal.IconChar = FontAwesome.Sharp.IconChar.Dog;
            icAnimal.IconColor = System.Drawing.SystemColors.ActiveCaption;
            icAnimal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icAnimal.IconSize = 32;
            icAnimal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            icAnimal.Location = new System.Drawing.Point(3, 176);
            icAnimal.Name = "icAnimal";
            icAnimal.Padding = new System.Windows.Forms.Padding(10, 0, 21, 0);
            icAnimal.Size = new System.Drawing.Size(217, 60);
            icAnimal.TabIndex = 7;
            icAnimal.Text = "Animal Management";
            icAnimal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            icAnimal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            icAnimal.UseVisualStyleBackColor = true;
            icAnimal.Click += icAnimal_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(icHome);
            panel2.Dock = System.Windows.Forms.DockStyle.Top;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(219, 96);
            panel2.TabIndex = 6;
            // 
            // icHome
            // 
            icHome.FlatAppearance.BorderSize = 0;
            icHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            icHome.ForeColor = System.Drawing.Color.Gainsboro;
            icHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            icHome.IconColor = System.Drawing.SystemColors.ActiveCaption;
            icHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icHome.IconSize = 32;
            icHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            icHome.Location = new System.Drawing.Point(3, 13);
            icHome.Name = "icHome";
            icHome.Padding = new System.Windows.Forms.Padding(10, 0, 21, 0);
            icHome.Size = new System.Drawing.Size(214, 79);
            icHome.TabIndex = 10;
            icHome.Text = "Home";
            icHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            icHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            icHome.UseVisualStyleBackColor = true;
            icHome.Click += icHome_Click;
            // 
            // iconProfile
            // 
            iconProfile.FlatAppearance.BorderSize = 0;
            iconProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            iconProfile.ForeColor = System.Drawing.Color.Gainsboro;
            iconProfile.IconChar = FontAwesome.Sharp.IconChar.User;
            iconProfile.IconColor = System.Drawing.SystemColors.ActiveCaption;
            iconProfile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconProfile.IconSize = 32;
            iconProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            iconProfile.Location = new System.Drawing.Point(3, 101);
            iconProfile.Name = "iconProfile";
            iconProfile.Padding = new System.Windows.Forms.Padding(10, 0, 21, 0);
            iconProfile.Size = new System.Drawing.Size(219, 60);
            iconProfile.TabIndex = 5;
            iconProfile.Text = "Profile";
            iconProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            iconProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            iconProfile.UseVisualStyleBackColor = true;
            iconProfile.Click += iconProfile_Click;
            // 
            // pannelLogo
            // 
            pannelLogo.Location = new System.Drawing.Point(0, 29);
            pannelLogo.Name = "pannelLogo";
            pannelLogo.Size = new System.Drawing.Size(219, 157);
            pannelLogo.TabIndex = 0;
            // 
            // pannelTop
            // 
            pannelTop.BackColor = System.Drawing.Color.FromArgb(26, 25, 62);
            pannelTop.Controls.Add(lbchildForm);
            pannelTop.Controls.Add(iconChild);
            pannelTop.Dock = System.Windows.Forms.DockStyle.Top;
            pannelTop.Location = new System.Drawing.Point(219, 0);
            pannelTop.Name = "pannelTop";
            pannelTop.Size = new System.Drawing.Size(1099, 96);
            pannelTop.TabIndex = 4;
            pannelTop.MouseDown += pannelTop_MouseDown;
            // 
            // lbchildForm
            // 
            lbchildForm.AutoSize = true;
            lbchildForm.ForeColor = System.Drawing.Color.Gainsboro;
            lbchildForm.Location = new System.Drawing.Point(64, 43);
            lbchildForm.Name = "lbchildForm";
            lbchildForm.Size = new System.Drawing.Size(50, 20);
            lbchildForm.TabIndex = 6;
            lbchildForm.Text = "Home";
            // 
            // iconChild
            // 
            iconChild.BackColor = System.Drawing.Color.FromArgb(26, 25, 62);
            iconChild.ForeColor = System.Drawing.Color.MediumPurple;
            iconChild.IconChar = FontAwesome.Sharp.IconChar.Home;
            iconChild.IconColor = System.Drawing.Color.MediumPurple;
            iconChild.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconChild.IconSize = 40;
            iconChild.Location = new System.Drawing.Point(18, 29);
            iconChild.Name = "iconChild";
            iconChild.Size = new System.Drawing.Size(40, 40);
            iconChild.TabIndex = 5;
            iconChild.TabStop = false;
            // 
            // pannelshadow
            // 
            pannelshadow.BackColor = System.Drawing.Color.FromArgb(26, 25, 62);
            pannelshadow.Dock = System.Windows.Forms.DockStyle.Top;
            pannelshadow.Location = new System.Drawing.Point(219, 96);
            pannelshadow.Name = "pannelshadow";
            pannelshadow.Size = new System.Drawing.Size(1099, 11);
            pannelshadow.TabIndex = 0;
            // 
            // Home
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Control;
            ClientSize = new System.Drawing.Size(1318, 688);
            Controls.Add(panel);
            Controls.Add(pannelshadow);
            Controls.Add(pannelTop);
            Controls.Add(pannelMenu);
            Controls.Add(pannelLogo);
            ForeColor = System.Drawing.SystemColors.ControlText;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Home";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            pannelMenu.ResumeLayout(false);
            panel2.ResumeLayout(false);
            pannelTop.ResumeLayout(false);
            pannelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconChild).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel pannelMenu;
        private System.Windows.Forms.Panel pannelLogo;
        private FontAwesome.Sharp.IconButton icArea;
        private FontAwesome.Sharp.IconButton icfood;
        private FontAwesome.Sharp.IconButton icAnimal;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton iconProfile;
        private FontAwesome.Sharp.IconButton icHome;
        private System.Windows.Forms.Panel pannelTop;
        private System.Windows.Forms.Label lbchildForm;
        private FontAwesome.Sharp.IconPictureBox iconChild;
        private System.Windows.Forms.Panel pannelshadow;
        private FontAwesome.Sharp.IconButton icLogout;
    }
}

