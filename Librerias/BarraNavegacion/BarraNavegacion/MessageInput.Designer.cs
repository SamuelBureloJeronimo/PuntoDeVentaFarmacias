namespace BarraNavegacion
{
    partial class MessageInput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageInput));
            this.labelText = new System.Windows.Forms.Label();
            this.boxPass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.boxPassConfirm = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.downBoxTipo = new Bunifu.Framework.UI.BunifuDropdown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegistrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // labelText
            // 
            this.labelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText.Location = new System.Drawing.Point(63, 64);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(483, 64);
            this.labelText.TabIndex = 3;
            this.labelText.Text = "Crear contraseña";
            // 
            // boxPass
            // 
            this.boxPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.boxPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.boxPass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.boxPass.ForeColor = System.Drawing.Color.Black;
            this.boxPass.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.boxPass.HintText = "contraseña";
            this.boxPass.isPassword = true;
            this.boxPass.LineFocusedColor = System.Drawing.Color.DarkCyan;
            this.boxPass.LineIdleColor = System.Drawing.Color.DarkSlateGray;
            this.boxPass.LineMouseHoverColor = System.Drawing.Color.Aquamarine;
            this.boxPass.LineThickness = 3;
            this.boxPass.Location = new System.Drawing.Point(69, 115);
            this.boxPass.Margin = new System.Windows.Forms.Padding(9);
            this.boxPass.Name = "boxPass";
            this.boxPass.Size = new System.Drawing.Size(319, 64);
            this.boxPass.TabIndex = 31;
            this.boxPass.Text = "ininini";
            this.boxPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // boxPassConfirm
            // 
            this.boxPassConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.boxPassConfirm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.boxPassConfirm.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.boxPassConfirm.ForeColor = System.Drawing.Color.Black;
            this.boxPassConfirm.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.boxPassConfirm.HintText = "contraseña";
            this.boxPassConfirm.isPassword = true;
            this.boxPassConfirm.LineFocusedColor = System.Drawing.Color.DarkCyan;
            this.boxPassConfirm.LineIdleColor = System.Drawing.Color.DarkSlateGray;
            this.boxPassConfirm.LineMouseHoverColor = System.Drawing.Color.Aquamarine;
            this.boxPassConfirm.LineThickness = 3;
            this.boxPassConfirm.Location = new System.Drawing.Point(69, 265);
            this.boxPassConfirm.Margin = new System.Windows.Forms.Padding(9);
            this.boxPassConfirm.Name = "boxPassConfirm";
            this.boxPassConfirm.Size = new System.Drawing.Size(319, 64);
            this.boxPassConfirm.TabIndex = 33;
            this.boxPassConfirm.Text = "ininini";
            this.boxPassConfirm.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 64);
            this.label1.TabIndex = 32;
            this.label1.Text = "Confirmar contraseña";
            // 
            // downBoxTipo
            // 
            this.downBoxTipo.BackColor = System.Drawing.Color.Transparent;
            this.downBoxTipo.BorderRadius = 3;
            this.downBoxTipo.DisabledColor = System.Drawing.Color.Gray;
            this.downBoxTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downBoxTipo.ForeColor = System.Drawing.Color.Black;
            this.downBoxTipo.Items = new string[] {
        "",
        "Emplado",
        "Gerente",
        "Admin"};
            this.downBoxTipo.Location = new System.Drawing.Point(69, 430);
            this.downBoxTipo.Margin = new System.Windows.Forms.Padding(9, 11, 9, 11);
            this.downBoxTipo.Name = "downBoxTipo";
            this.downBoxTipo.NomalColor = System.Drawing.Color.Teal;
            this.downBoxTipo.onHoverColor = System.Drawing.Color.Teal;
            this.downBoxTipo.selectedIndex = -1;
            this.downBoxTipo.Size = new System.Drawing.Size(439, 74);
            this.downBoxTipo.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(483, 64);
            this.label2.TabIndex = 36;
            this.label2.Text = "Rol";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRegistrar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegistrar.BorderRadius = 5;
            this.btnRegistrar.ButtonText = "Registrar";
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.DisabledColor = System.Drawing.Color.Gray;
            this.btnRegistrar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRegistrar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnRegistrar.Iconimage")));
            this.btnRegistrar.Iconimage_right = null;
            this.btnRegistrar.Iconimage_right_Selected = null;
            this.btnRegistrar.Iconimage_Selected = null;
            this.btnRegistrar.IconMarginLeft = 0;
            this.btnRegistrar.IconMarginRight = 0;
            this.btnRegistrar.IconRightVisible = true;
            this.btnRegistrar.IconRightZoom = 0D;
            this.btnRegistrar.IconVisible = true;
            this.btnRegistrar.IconZoom = 90D;
            this.btnRegistrar.IsTab = false;
            this.btnRegistrar.Location = new System.Drawing.Point(138, 547);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(16);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Normalcolor = System.Drawing.Color.DarkSlateGray;
            this.btnRegistrar.OnHovercolor = System.Drawing.Color.MediumSpringGreen;
            this.btnRegistrar.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnRegistrar.Padding = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.btnRegistrar.selected = false;
            this.btnRegistrar.Size = new System.Drawing.Size(288, 85);
            this.btnRegistrar.TabIndex = 42;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrar.Textcolor = System.Drawing.Color.White;
            this.btnRegistrar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // MessageInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 688);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.downBoxTipo);
            this.Controls.Add(this.boxPassConfirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxPass);
            this.Controls.Add(this.labelText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MessageInput";
            this.Text = "Registrar";
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label labelText;
        public Bunifu.Framework.UI.BunifuMaterialTextbox boxPass;
        public Bunifu.Framework.UI.BunifuMaterialTextbox boxPassConfirm;
        public System.Windows.Forms.Label label1;
        public Bunifu.Framework.UI.BunifuDropdown downBoxTipo;
        public System.Windows.Forms.Label label2;
        public Bunifu.Framework.UI.BunifuFlatButton btnRegistrar;
    }
}