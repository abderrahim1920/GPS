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
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
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
            this.panelMenu.Controls.Add(this.iconButton4);
            this.panelMenu.Controls.Add(this.NotificationsButton);
            this.panelMenu.Controls.Add(this.PaymentButton);
            this.panelMenu.Controls.Add(this.addButton);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(242, 796);
            this.panelMenu.TabIndex = 0;
            // 
            // iconButton4
            // 
            this.iconButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.iconButton4.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton4.IconSize = 32;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.Location = new System.Drawing.Point(0, 388);
            this.iconButton4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton4.Rotation = 0D;
            this.iconButton4.Size = new System.Drawing.Size(242, 74);
            this.iconButton4.TabIndex = 4;
            this.iconButton4.Text = "iconButton4";
            this.iconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton4.UseVisualStyleBackColor = true;
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
            this.NotificationsButton.Location = new System.Drawing.Point(0, 313);
            this.NotificationsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NotificationsButton.Name = "NotificationsButton";
            this.NotificationsButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.NotificationsButton.Rotation = 0D;
            this.NotificationsButton.Size = new System.Drawing.Size(242, 75);
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
            this.PaymentButton.Location = new System.Drawing.Point(0, 238);
            this.PaymentButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PaymentButton.Name = "PaymentButton";
            this.PaymentButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.PaymentButton.Rotation = 0D;
            this.PaymentButton.Size = new System.Drawing.Size(242, 75);
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
            this.addButton.Location = new System.Drawing.Point(0, 163);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addButton.Name = "addButton";
            this.addButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.addButton.Rotation = 0D;
            this.addButton.Size = new System.Drawing.Size(242, 75);
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
            this.panelLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(242, 163);
            this.panelLogo.TabIndex = 1;
            // 
            // HomeButton
            // 
            this.HomeButton.Image = global::GPS.Properties.Resources.xls;
            this.HomeButton.Location = new System.Drawing.Point(23, 24);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(194, 108);
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
            this.panelTitleBar.Location = new System.Drawing.Point(242, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(200, 60);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // labelTitleChildForm
            // 
            this.labelTitleChildForm.AutoSize = true;
            this.labelTitleChildForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.labelTitleChildForm.Location = new System.Drawing.Point(63, 24);
            this.labelTitleChildForm.Name = "labelTitleChildForm";
            this.labelTitleChildForm.Size = new System.Drawing.Size(44, 17);
            this.labelTitleChildForm.TabIndex = 1;
            this.labelTitleChildForm.Text = "Home";
            // 
            // IconCurrentChildForm
            // 
            this.IconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.IconCurrentChildForm.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.IconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.IconCurrentChildForm.IconColor = System.Drawing.SystemColors.MenuHighlight;
            this.IconCurrentChildForm.Location = new System.Drawing.Point(22, 17);
            this.IconCurrentChildForm.Name = "IconCurrentChildForm";
            this.IconCurrentChildForm.Size = new System.Drawing.Size(168, 32);
            this.IconCurrentChildForm.TabIndex = 0;
            this.IconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(242, 500);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(1060, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(242, 509);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1060, 287);
            this.panelDesktop.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 796);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1302, 796);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "MainForm";
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
        private FontAwesome.Sharp.IconButton iconButton4;
        private System.Windows.Forms.PictureBox HomeButton;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox IconCurrentChildForm;
        private System.Windows.Forms.Label labelTitleChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
    }
}