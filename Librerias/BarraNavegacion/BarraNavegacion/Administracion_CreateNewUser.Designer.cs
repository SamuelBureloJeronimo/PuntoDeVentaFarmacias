namespace BarraNavegacion
{
    partial class Administracion_CreateNewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administracion_CreateNewUser));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buscar = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DG = new System.Windows.Forms.DataGridView();
            this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDeContrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClaveDepartamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.uploadUser = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG)).BeginInit();
            this.SuspendLayout();
            // 
            // ControlPanel
            // 
            this.ControlPanel.AutoScroll = true;
            this.ControlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.ControlPanel.Controls.Add(this.label1);
            this.ControlPanel.Controls.Add(this.pictureBox10);
            this.ControlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ControlPanel.Location = new System.Drawing.Point(0, 0);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(836, 53);
            this.ControlPanel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(54, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 53);
            this.label1.TabIndex = 2;
            this.label1.Text = "Subir nuevo usuario";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(0, 0);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(54, 53);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 1;
            this.pictureBox10.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.uploadUser);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buscar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.DG);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 443);
            this.panel1.TabIndex = 4;
            // 
            // buscar
            // 
            this.buscar.BackColor = System.Drawing.Color.Black;
            this.buscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.buscar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.buscar.ForeColor = System.Drawing.Color.White;
            this.buscar.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buscar.HintText = "Buscar por clave...";
            this.buscar.isPassword = false;
            this.buscar.LineFocusedColor = System.Drawing.Color.Lime;
            this.buscar.LineIdleColor = System.Drawing.Color.White;
            this.buscar.LineMouseHoverColor = System.Drawing.Color.White;
            this.buscar.LineThickness = 3;
            this.buscar.Location = new System.Drawing.Point(124, 43);
            this.buscar.Margin = new System.Windows.Forms.Padding(4);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(201, 35);
            this.buscar.TabIndex = 15;
            this.buscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.buscar_KeyUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(59, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // DG
            // 
            this.DG.AllowUserToAddRows = false;
            this.DG.AllowUserToDeleteRows = false;
            this.DG.AllowUserToResizeColumns = false;
            this.DG.AllowUserToResizeRows = false;
            this.DG.BackgroundColor = System.Drawing.Color.Black;
            this.DG.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clave,
            this.Nombre,
            this.Horario,
            this.FechaDeContrato,
            this.ClaveDepartamento,
            this.Salario});
            this.DG.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DG.Location = new System.Drawing.Point(58, 170);
            this.DG.Name = "DG";
            this.DG.ReadOnly = true;
            this.DG.Size = new System.Drawing.Size(723, 228);
            this.DG.TabIndex = 0;
            this.DG.Click += new System.EventHandler(this.DG_Click);
            // 
            // Clave
            // 
            this.Clave.HeaderText = "Clave";
            this.Clave.Name = "Clave";
            this.Clave.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 110;
            // 
            // Horario
            // 
            this.Horario.HeaderText = "Horario";
            this.Horario.Name = "Horario";
            this.Horario.ReadOnly = true;
            // 
            // FechaDeContrato
            // 
            this.FechaDeContrato.HeaderText = "Fecha de contrato";
            this.FechaDeContrato.Name = "FechaDeContrato";
            this.FechaDeContrato.ReadOnly = true;
            this.FechaDeContrato.Width = 150;
            // 
            // ClaveDepartamento
            // 
            this.ClaveDepartamento.HeaderText = "Clave de departamento";
            this.ClaveDepartamento.Name = "ClaveDepartamento";
            this.ClaveDepartamento.ReadOnly = true;
            this.ClaveDepartamento.Width = 120;
            // 
            // Salario
            // 
            this.Salario.HeaderText = "Salario (Mensual)";
            this.Salario.Name = "Salario";
            this.Salario.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(59, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(721, 32);
            this.label2.TabIndex = 16;
            this.label2.Text = "Empleados";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uploadUser
            // 
            this.uploadUser.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.uploadUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.uploadUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uploadUser.BorderRadius = 7;
            this.uploadUser.ButtonText = "   Subir";
            this.uploadUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uploadUser.DisabledColor = System.Drawing.Color.Gray;
            this.uploadUser.Iconcolor = System.Drawing.Color.Transparent;
            this.uploadUser.Iconimage = ((System.Drawing.Image)(resources.GetObject("uploadUser.Iconimage")));
            this.uploadUser.Iconimage_right = null;
            this.uploadUser.Iconimage_right_Selected = null;
            this.uploadUser.Iconimage_Selected = null;
            this.uploadUser.IconMarginLeft = 0;
            this.uploadUser.IconMarginRight = 0;
            this.uploadUser.IconRightVisible = true;
            this.uploadUser.IconRightZoom = 0D;
            this.uploadUser.IconVisible = true;
            this.uploadUser.IconZoom = 90D;
            this.uploadUser.IsTab = false;
            this.uploadUser.Location = new System.Drawing.Point(356, 38);
            this.uploadUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uploadUser.Name = "uploadUser";
            this.uploadUser.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.uploadUser.OnHovercolor = System.Drawing.Color.Black;
            this.uploadUser.OnHoverTextColor = System.Drawing.Color.White;
            this.uploadUser.selected = false;
            this.uploadUser.Size = new System.Drawing.Size(134, 44);
            this.uploadUser.TabIndex = 17;
            this.uploadUser.Text = "   Subir";
            this.uploadUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uploadUser.Textcolor = System.Drawing.Color.White;
            this.uploadUser.TextFont = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadUser.Visible = false;
            // 
            // Administracion_CreateNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ControlPanel);
            this.Name = "Administracion_CreateNewUser";
            this.Size = new System.Drawing.Size(836, 496);
            this.ControlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DG;
        private Bunifu.Framework.UI.BunifuMaterialTextbox buscar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horario;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDeContrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClaveDepartamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salario;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton uploadUser;
    }
}
