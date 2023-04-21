namespace PVF
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bttonMax = new Bunifu.Framework.UI.BunifuImageButton();
            this.bttonMin = new Bunifu.Framework.UI.BunifuImageButton();
            this.bttonClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bttonLogin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtBoxPass = new System.Windows.Forms.TextBox();
            this.labelPass = new System.Windows.Forms.Label();
            this.txtBoxUser = new System.Windows.Forms.TextBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttonMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttonMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttonClose)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ControlPanel
            // 
            this.ControlPanel.BackColor = System.Drawing.Color.Gray;
            this.ControlPanel.Controls.Add(this.label1);
            this.ControlPanel.Controls.Add(this.pictureBox2);
            this.ControlPanel.Controls.Add(this.bunifuImageButton1);
            this.ControlPanel.Controls.Add(this.bttonMax);
            this.ControlPanel.Controls.Add(this.bttonMin);
            this.ControlPanel.Controls.Add(this.bttonClose);
            this.ControlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ControlPanel.Location = new System.Drawing.Point(0, 0);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(425, 37);
            this.ControlPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(40, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuImageButton1.Enabled = false;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(249, 0);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(44, 37);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 3;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Visible = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // bttonMax
            // 
            this.bttonMax.BackColor = System.Drawing.Color.Transparent;
            this.bttonMax.Dock = System.Windows.Forms.DockStyle.Right;
            this.bttonMax.Enabled = false;
            this.bttonMax.Image = ((System.Drawing.Image)(resources.GetObject("bttonMax.Image")));
            this.bttonMax.ImageActive = null;
            this.bttonMax.Location = new System.Drawing.Point(293, 0);
            this.bttonMax.Name = "bttonMax";
            this.bttonMax.Size = new System.Drawing.Size(44, 37);
            this.bttonMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bttonMax.TabIndex = 2;
            this.bttonMax.TabStop = false;
            this.bttonMax.Visible = false;
            this.bttonMax.Zoom = 10;
            // 
            // bttonMin
            // 
            this.bttonMin.BackColor = System.Drawing.Color.Transparent;
            this.bttonMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.bttonMin.Enabled = false;
            this.bttonMin.Image = ((System.Drawing.Image)(resources.GetObject("bttonMin.Image")));
            this.bttonMin.ImageActive = null;
            this.bttonMin.Location = new System.Drawing.Point(337, 0);
            this.bttonMin.Name = "bttonMin";
            this.bttonMin.Size = new System.Drawing.Size(44, 37);
            this.bttonMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bttonMin.TabIndex = 1;
            this.bttonMin.TabStop = false;
            this.bttonMin.Visible = false;
            this.bttonMin.Zoom = 10;
            // 
            // bttonClose
            // 
            this.bttonClose.BackColor = System.Drawing.Color.Transparent;
            this.bttonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.bttonClose.Image = ((System.Drawing.Image)(resources.GetObject("bttonClose.Image")));
            this.bttonClose.ImageActive = null;
            this.bttonClose.Location = new System.Drawing.Point(381, 0);
            this.bttonClose.Name = "bttonClose";
            this.bttonClose.Size = new System.Drawing.Size(44, 37);
            this.bttonClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bttonClose.TabIndex = 0;
            this.bttonClose.TabStop = false;
            this.bttonClose.Zoom = 10;
            this.bttonClose.Click += new System.EventHandler(this.bttonClose_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.ControlPanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.bttonLogin);
            this.panel1.Controls.Add(this.txtBoxPass);
            this.panel1.Controls.Add(this.labelPass);
            this.panel1.Controls.Add(this.txtBoxUser);
            this.panel1.Controls.Add(this.labelUser);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(48, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 440);
            this.panel1.TabIndex = 2;
            // 
            // bttonLogin
            // 
            this.bttonLogin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bttonLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttonLogin.BorderRadius = 0;
            this.bttonLogin.ButtonText = "Iniciar Sesion";
            this.bttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttonLogin.DisabledColor = System.Drawing.Color.Gray;
            this.bttonLogin.Iconcolor = System.Drawing.Color.Transparent;
            this.bttonLogin.Iconimage = ((System.Drawing.Image)(resources.GetObject("bttonLogin.Iconimage")));
            this.bttonLogin.Iconimage_right = null;
            this.bttonLogin.Iconimage_right_Selected = null;
            this.bttonLogin.Iconimage_Selected = null;
            this.bttonLogin.IconMarginLeft = 0;
            this.bttonLogin.IconMarginRight = 0;
            this.bttonLogin.IconRightVisible = true;
            this.bttonLogin.IconRightZoom = 0D;
            this.bttonLogin.IconVisible = true;
            this.bttonLogin.IconZoom = 90D;
            this.bttonLogin.IsTab = false;
            this.bttonLogin.Location = new System.Drawing.Point(94, 298);
            this.bttonLogin.Name = "bttonLogin";
            this.bttonLogin.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bttonLogin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bttonLogin.OnHoverTextColor = System.Drawing.Color.White;
            this.bttonLogin.selected = false;
            this.bttonLogin.Size = new System.Drawing.Size(137, 36);
            this.bttonLogin.TabIndex = 5;
            this.bttonLogin.Text = "Iniciar Sesion";
            this.bttonLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttonLogin.Textcolor = System.Drawing.Color.White;
            this.bttonLogin.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttonLogin.Click += new System.EventHandler(this.bttonLogin_Click);
            // 
            // txtBoxPass
            // 
            this.txtBoxPass.Location = new System.Drawing.Point(81, 254);
            this.txtBoxPass.Name = "txtBoxPass";
            this.txtBoxPass.Size = new System.Drawing.Size(164, 20);
            this.txtBoxPass.TabIndex = 4;
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPass.Location = new System.Drawing.Point(77, 229);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(118, 22);
            this.labelPass.TabIndex = 3;
            this.labelPass.Text = "Contraseña";
            // 
            // txtBoxUser
            // 
            this.txtBoxUser.Location = new System.Drawing.Point(81, 189);
            this.txtBoxUser.Name = "txtBoxUser";
            this.txtBoxUser.Size = new System.Drawing.Size(164, 20);
            this.txtBoxUser.TabIndex = 2;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelUser.Location = new System.Drawing.Point(77, 164);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(82, 22);
            this.labelUser.TabIndex = 1;
            this.labelUser.Text = "Usuario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(114, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(425, 572);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ControlPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ControlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttonMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttonMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttonClose)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ControlPanel;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton bttonMax;
        private Bunifu.Framework.UI.BunifuImageButton bttonMin;
        private Bunifu.Framework.UI.BunifuImageButton bttonClose;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBoxPass;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.TextBox txtBoxUser;
        private System.Windows.Forms.Label labelUser;
        private Bunifu.Framework.UI.BunifuFlatButton bttonLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}