namespace BarraNavegacion
{
    partial class Productos_ConsultaIngresos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos_ConsultaIngresos));
            this.panelForm = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bdMedic = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fech = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inversion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gananciasEstimadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.bttonClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelForm.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdMedic)).BeginInit();
            this.ControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttonClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panelForm
            // 
            this.panelForm.AutoScroll = true;
            this.panelForm.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panelForm.Controls.Add(this.panel1);
            this.panelForm.Controls.Add(this.ControlPanel);
            this.panelForm.Location = new System.Drawing.Point(24, 15);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(1069, 436);
            this.panelForm.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.bdMedic);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1069, 396);
            this.panel1.TabIndex = 30;
            // 
            // bdMedic
            // 
            this.bdMedic.AllowUserToAddRows = false;
            this.bdMedic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bdMedic.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Nombre,
            this.pC,
            this.pV,
            this.tipo,
            this.lote,
            this.iva,
            this.fech,
            this.inversion,
            this.gananciasEstimadas});
            this.bdMedic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bdMedic.Location = new System.Drawing.Point(0, 0);
            this.bdMedic.Name = "bdMedic";
            this.bdMedic.ReadOnly = true;
            this.bdMedic.Size = new System.Drawing.Size(1069, 396);
            this.bdMedic.TabIndex = 0;
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            this.Código.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // pC
            // 
            this.pC.HeaderText = "Precio de compra c/u";
            this.pC.Name = "pC";
            this.pC.ReadOnly = true;
            // 
            // pV
            // 
            this.pV.HeaderText = "Precio de venta c/u";
            this.pV.Name = "pV";
            this.pV.ReadOnly = true;
            // 
            // tipo
            // 
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            // 
            // lote
            // 
            this.lote.HeaderText = "Cantidad";
            this.lote.Name = "lote";
            this.lote.ReadOnly = true;
            // 
            // iva
            // 
            this.iva.HeaderText = "IVA %";
            this.iva.Name = "iva";
            this.iva.ReadOnly = true;
            // 
            // fech
            // 
            this.fech.HeaderText = "Fecha de compra";
            this.fech.Name = "fech";
            this.fech.ReadOnly = true;
            this.fech.Width = 126;
            // 
            // inversion
            // 
            this.inversion.HeaderText = "Inversión";
            this.inversion.Name = "inversion";
            this.inversion.ReadOnly = true;
            // 
            // gananciasEstimadas
            // 
            this.gananciasEstimadas.HeaderText = "Ganancias estimadas";
            this.gananciasEstimadas.Name = "gananciasEstimadas";
            this.gananciasEstimadas.ReadOnly = true;
            // 
            // ControlPanel
            // 
            this.ControlPanel.AutoScroll = true;
            this.ControlPanel.BackColor = System.Drawing.Color.Black;
            this.ControlPanel.Controls.Add(this.label1);
            this.ControlPanel.Controls.Add(this.pictureBox10);
            this.ControlPanel.Controls.Add(this.bttonClose);
            this.ControlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ControlPanel.Location = new System.Drawing.Point(0, 0);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(1069, 40);
            this.ControlPanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(48, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Consulta de Ingresos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(0, 0);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(48, 40);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 1;
            this.pictureBox10.TabStop = false;
            // 
            // bttonClose
            // 
            this.bttonClose.BackColor = System.Drawing.Color.Transparent;
            this.bttonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.bttonClose.Image = ((System.Drawing.Image)(resources.GetObject("bttonClose.Image")));
            this.bttonClose.ImageActive = null;
            this.bttonClose.Location = new System.Drawing.Point(1025, 0);
            this.bttonClose.Name = "bttonClose";
            this.bttonClose.Size = new System.Drawing.Size(44, 40);
            this.bttonClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bttonClose.TabIndex = 0;
            this.bttonClose.TabStop = false;
            this.bttonClose.Zoom = 10;
            this.bttonClose.Click += new System.EventHandler(this.bttonClose_Click);
            // 
            // Productos_ConsultaIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelForm);
            this.Name = "Productos_ConsultaIngresos";
            this.Size = new System.Drawing.Size(1106, 465);
            this.panelForm.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdMedic)).EndInit();
            this.ControlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttonClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView bdMedic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn pC;
        private System.Windows.Forms.DataGridViewTextBoxColumn pV;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn lote;
        private System.Windows.Forms.DataGridViewTextBoxColumn iva;
        private System.Windows.Forms.DataGridViewTextBoxColumn fech;
        private System.Windows.Forms.DataGridViewTextBoxColumn inversion;
        private System.Windows.Forms.DataGridViewTextBoxColumn gananciasEstimadas;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox10;
        public Bunifu.Framework.UI.BunifuImageButton bttonClose;
    }
}
