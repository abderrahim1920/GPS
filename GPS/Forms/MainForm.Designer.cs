using System.Drawing;

namespace GPS.Forms
{
    partial class MainForm
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.clientsButton = new FontAwesome.Sharp.IconButton();
            this.NotificationsButton = new FontAwesome.Sharp.IconButton();
            this.PaymentButton = new FontAwesome.Sharp.IconButton();
            this.addButton = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.HomeButton = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.labelTitleChildForm = new System.Windows.Forms.Label();
            this.IconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HomeButton)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.clientsButton);
            this.panelMenu.Controls.Add(this.NotificationsButton);
            this.panelMenu.Controls.Add(this.PaymentButton);
            this.panelMenu.Controls.Add(this.addButton);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(207, 756);
            this.panelMenu.TabIndex = 0;
            // 
            // clientsButton
            // 
            this.clientsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.clientsButton.FlatAppearance.BorderSize = 0;
            this.clientsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientsButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.clientsButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.clientsButton.IconChar = FontAwesome.Sharp.IconChar.User;
            this.clientsButton.IconColor = System.Drawing.Color.Gainsboro;
            this.clientsButton.IconSize = 32;
            this.clientsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clientsButton.Location = new System.Drawing.Point(0, 315);
            this.clientsButton.Name = "clientsButton";
            this.clientsButton.Padding = new System.Windows.Forms.Padding(9, 0, 17, 0);
            this.clientsButton.Rotation = 0D;
            this.clientsButton.Size = new System.Drawing.Size(207, 60);
            this.clientsButton.TabIndex = 4;
            this.clientsButton.Text = "Clients";
            this.clientsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clientsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.clientsButton.UseVisualStyleBackColor = true;
            this.clientsButton.Click += new System.EventHandler(this.clientsButton_Click);
            // 
            // NotificationsButton
            // 
            this.NotificationsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.NotificationsButton.FlatAppearance.BorderSize = 0;
            this.NotificationsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NotificationsButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.NotificationsButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.NotificationsButton.IconChar = FontAwesome.Sharp.IconChar.Bell;
            this.NotificationsButton.IconColor = System.Drawing.Color.Gainsboro;
            this.NotificationsButton.IconSize = 32;
            this.NotificationsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NotificationsButton.Location = new System.Drawing.Point(0, 254);
            this.NotificationsButton.Name = "NotificationsButton";
            this.NotificationsButton.Padding = new System.Windows.Forms.Padding(9, 0, 17, 0);
            this.NotificationsButton.Rotation = 0D;
            this.NotificationsButton.Size = new System.Drawing.Size(207, 61);
            this.NotificationsButton.TabIndex = 3;
            this.NotificationsButton.Text = "Notifications";
            this.NotificationsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NotificationsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NotificationsButton.UseVisualStyleBackColor = true;
            this.NotificationsButton.Click += new System.EventHandler(this.NotificationsButton_Click);
            // 
            // PaymentButton
            // 
            this.PaymentButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.PaymentButton.FlatAppearance.BorderSize = 0;
            this.PaymentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PaymentButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.PaymentButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.PaymentButton.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.PaymentButton.IconColor = System.Drawing.Color.Gainsboro;
            this.PaymentButton.IconSize = 32;
            this.PaymentButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PaymentButton.Location = new System.Drawing.Point(0, 193);
            this.PaymentButton.Name = "PaymentButton";
            this.PaymentButton.Padding = new System.Windows.Forms.Padding(9, 0, 17, 0);
            this.PaymentButton.Rotation = 0D;
            this.PaymentButton.Size = new System.Drawing.Size(207, 61);
            this.PaymentButton.TabIndex = 2;
            this.PaymentButton.Text = "Paiements";
            this.PaymentButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PaymentButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PaymentButton.UseVisualStyleBackColor = true;
            this.PaymentButton.Click += new System.EventHandler(this.PaymentButton_Click);
            // 
            // addButton
            // 
            this.addButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.addButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.addButton.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.addButton.IconColor = System.Drawing.Color.Gainsboro;
            this.addButton.IconSize = 32;
            this.addButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addButton.Location = new System.Drawing.Point(0, 132);
            this.addButton.Name = "addButton";
            this.addButton.Padding = new System.Windows.Forms.Padding(9, 0, 17, 0);
            this.addButton.Rotation = 0D;
            this.addButton.Size = new System.Drawing.Size(207, 61);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Ajouter";
            this.addButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.HomeButton);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(207, 132);
            this.panelLogo.TabIndex = 1;
            // 
            // HomeButton
            // 
            this.HomeButton.Image = global::GPS.Properties.Resources.xls;
            this.HomeButton.Location = new System.Drawing.Point(20, 20);
            this.HomeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(166, 88);
            this.HomeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HomeButton.TabIndex = 1;
            this.HomeButton.TabStop = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitleBar.Controls.Add(this.labelTitleChildForm);
            this.panelTitleBar.Controls.Add(this.IconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(207, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1074, 49);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // labelTitleChildForm
            // 
            this.labelTitleChildForm.AutoSize = true;
            this.labelTitleChildForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.labelTitleChildForm.Location = new System.Drawing.Point(54, 20);
            this.labelTitleChildForm.Name = "labelTitleChildForm";
            this.labelTitleChildForm.Size = new System.Drawing.Size(34, 13);
            this.labelTitleChildForm.TabIndex = 1;
            this.labelTitleChildForm.Text = "Home";
            // 
            // IconCurrentChildForm
            // 
            this.IconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.IconCurrentChildForm.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.IconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.IconCurrentChildForm.IconColor = System.Drawing.SystemColors.MenuHighlight;
            this.IconCurrentChildForm.IconSize = 26;
            this.IconCurrentChildForm.Location = new System.Drawing.Point(19, 14);
            this.IconCurrentChildForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IconCurrentChildForm.Name = "IconCurrentChildForm";
            this.IconCurrentChildForm.Size = new System.Drawing.Size(144, 26);
            this.IconCurrentChildForm.TabIndex = 0;
            this.IconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(207, 49);
            this.panelShadow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(1074, 7);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(207, 56);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1074, 700);
            this.panelDesktop.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 756);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(1118, 654);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HomeButton)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconCurrentChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton addButton;
        private FontAwesome.Sharp.IconButton NotificationsButton;
        private FontAwesome.Sharp.IconButton PaymentButton;
        private FontAwesome.Sharp.IconButton clientsButton;
        private System.Windows.Forms.PictureBox HomeButton;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox IconCurrentChildForm;
        private System.Windows.Forms.Label labelTitleChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
    }
}