namespace PVF.src.Views.NavegationBar.Help
{
    partial class navbarHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(navbarHelp));
            this.panelAyuda = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.bunifuFlatButton22 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label17 = new System.Windows.Forms.Label();
            this.panelAyuda.SuspendLayout();
            this.panel18.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAyuda
            // 
            this.panelAyuda.BackColor = System.Drawing.Color.DarkCyan;
            this.panelAyuda.Controls.Add(this.panel18);
            this.panelAyuda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAyuda.Location = new System.Drawing.Point(0, 0);
            this.panelAyuda.Name = "panelAyuda";
            this.panelAyuda.Size = new System.Drawing.Size(270, 82);
            this.panelAyuda.TabIndex = 23;
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.Transparent;
            this.panel18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel18.Controls.Add(this.bunifuFlatButton22);
            this.panel18.Controls.Add(this.label17);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel18.Location = new System.Drawing.Point(0, 0);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(188, 82);
            this.panel18.TabIndex = 4;
            // 
            // bunifuFlatButton22
            // 
            this.bunifuFlatButton22.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton22.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton22.BorderRadius = 0;
            this.bunifuFlatButton22.ButtonText = "Ayuda online ->";
            this.bunifuFlatButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton22.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton22.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuFlatButton22.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton22.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton22.Iconimage")));
            this.bunifuFlatButton22.Iconimage_right = null;
            this.bunifuFlatButton22.Iconimage_right_Selected = null;
            this.bunifuFlatButton22.Iconimage_Selected = null;
            this.bunifuFlatButton22.IconMarginLeft = 0;
            this.bunifuFlatButton22.IconMarginRight = 0;
            this.bunifuFlatButton22.IconRightVisible = true;
            this.bunifuFlatButton22.IconRightZoom = 0D;
            this.bunifuFlatButton22.IconVisible = true;
            this.bunifuFlatButton22.IconZoom = 90D;
            this.bunifuFlatButton22.IsTab = false;
            this.bunifuFlatButton22.Location = new System.Drawing.Point(0, 0);
            this.bunifuFlatButton22.Name = "bunifuFlatButton22";
            this.bunifuFlatButton22.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton22.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton22.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton22.selected = false;
            this.bunifuFlatButton22.Size = new System.Drawing.Size(176, 55);
            this.bunifuFlatButton22.TabIndex = 7;
            this.bunifuFlatButton22.Text = "Ayuda online ->";
            this.bunifuFlatButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton22.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton22.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label17
            // 
            this.label17.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label17.ForeColor = System.Drawing.Color.Aquamarine;
            this.label17.Location = new System.Drawing.Point(0, 55);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(184, 23);
            this.label17.TabIndex = 1;
            this.label17.Text = "Ayuda";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // navbarHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelAyuda);
            this.Name = "navbarHelp";
            this.Size = new System.Drawing.Size(270, 82);
            this.panelAyuda.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelAyuda;
        private System.Windows.Forms.Panel panel18;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton22;
        private System.Windows.Forms.Label label17;
    }
}
