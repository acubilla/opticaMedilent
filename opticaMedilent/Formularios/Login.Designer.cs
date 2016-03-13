namespace opticaMedilent
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.pictureVer = new DevExpress.XtraEditors.PictureEdit();
            this.chckVer = new DevExpress.XtraEditors.CheckEdit();
            this.loginButton = new DevExpress.XtraEditors.SimpleButton();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.txtUser = new DevExpress.XtraEditors.TextEdit();
            this.lbPassword = new DevExpress.XtraEditors.LabelControl();
            this.lbUser = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureVer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chckVer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.pictureVer);
            this.groupControl1.Controls.Add(this.chckVer);
            this.groupControl1.Controls.Add(this.loginButton);
            this.groupControl1.Controls.Add(this.txtPassword);
            this.groupControl1.Controls.Add(this.txtUser);
            this.groupControl1.Controls.Add(this.lbPassword);
            this.groupControl1.Controls.Add(this.lbUser);
            this.groupControl1.Location = new System.Drawing.Point(200, 26);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(379, 205);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "LOGIN";
            // 
            // pictureVer
            // 
            this.pictureVer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureVer.EditValue = ((object)(resources.GetObject("pictureVer.EditValue")));
            this.pictureVer.Enabled = false;
            this.pictureVer.Location = new System.Drawing.Point(285, 102);
            this.pictureVer.Name = "pictureVer";
            this.pictureVer.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureVer.Properties.Appearance.Options.UseBackColor = true;
            this.pictureVer.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureVer.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureVer.Properties.ZoomPercent = 5D;
            this.pictureVer.Size = new System.Drawing.Size(29, 31);
            this.pictureVer.TabIndex = 6;
            // 
            // chckVer
            // 
            this.chckVer.Location = new System.Drawing.Point(266, 108);
            this.chckVer.Name = "chckVer";
            this.chckVer.Properties.Caption = "";
            this.chckVer.Size = new System.Drawing.Size(52, 19);
            this.chckVer.TabIndex = 5;
            this.chckVer.CheckStateChanged += new System.EventHandler(this.chckVer_CheckStateChanged);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(176, 153);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Iniciar Sesion";
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.EditValue = "";
            this.txtPassword.Location = new System.Drawing.Point(151, 107);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(151, 45);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 2;
            // 
            // lbPassword
            // 
            this.lbPassword.Location = new System.Drawing.Point(51, 110);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(57, 13);
            this.lbPassword.TabIndex = 1;
            this.lbPassword.Text = "PASSWORD";
            // 
            // lbUser
            // 
            this.lbUser.Location = new System.Drawing.Point(51, 48);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(46, 13);
            this.lbUser.TabIndex = 0;
            this.lbUser.Text = "USUARIO";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 278);
            this.Controls.Add(this.groupControl1);
            this.LookAndFeel.SkinName = "Office 2007 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "Login";
            this.Text = "CONTROL DE FICHAS";
            this.Shown += new System.EventHandler(this.Login_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureVer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chckVer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtUser;
        private DevExpress.XtraEditors.LabelControl lbPassword;
        private DevExpress.XtraEditors.LabelControl lbUser;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.SimpleButton loginButton;
        private DevExpress.XtraEditors.PictureEdit pictureVer;
        private DevExpress.XtraEditors.CheckEdit chckVer;
    }
}

