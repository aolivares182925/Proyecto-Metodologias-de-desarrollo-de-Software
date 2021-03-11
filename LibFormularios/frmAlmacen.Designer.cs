namespace LibFormularios
{
	partial class frmAlmacen
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlmacen));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.txtCodProveedor = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtPrecio = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cboClasificacion = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dgvProductos = new System.Windows.Forms.DataGridView();
			this.pnlTitulos.SuspendLayout();
			this.pnlBotones.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlTitulos
			// 
			this.pnlTitulos.Controls.Add(this.label2);
			this.pnlTitulos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pnlTitulos.Size = new System.Drawing.Size(761, 75);
			this.pnlTitulos.Controls.SetChildIndex(this.label2, 0);
			// 
			// pnlBotones
			// 
			this.pnlBotones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pnlBotones.Size = new System.Drawing.Size(761, 100);
			// 
			// btnNuevo
			// 
			this.btnNuevo.FlatAppearance.BorderSize = 0;
			this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
			// 
			// btnGuardar
			// 
			this.btnGuardar.FlatAppearance.BorderSize = 0;
			this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
			this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label2.Location = new System.Drawing.Point(227, 26);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(283, 23);
			this.label2.TabIndex = 15;
			this.label2.Text = "       ALMACEN DE PRODUCTOS";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtNombre);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.txtCodProveedor);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.txtPrecio);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.cboClasificacion);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.Color.Blue;
			this.groupBox1.Location = new System.Drawing.Point(12, 81);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(587, 111);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Digite datos del producto:";
			// 
			// txtNombre
			// 
			this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombre.Location = new System.Drawing.Point(159, 35);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(124, 20);
			this.txtNombre.TabIndex = 16;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.Black;
			this.label11.Location = new System.Drawing.Point(6, 36);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(147, 15);
			this.label11.TabIndex = 15;
			this.label11.Text = "Nombre del Producto:";
			// 
			// txtCodProveedor
			// 
			this.txtCodProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCodProveedor.Location = new System.Drawing.Point(425, 35);
			this.txtCodProveedor.Name = "txtCodProveedor";
			this.txtCodProveedor.Size = new System.Drawing.Size(141, 20);
			this.txtCodProveedor.TabIndex = 12;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(294, 36);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(125, 15);
			this.label7.TabIndex = 11;
			this.label7.Text = "Codigo Proveedor:";
			// 
			// txtPrecio
			// 
			this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPrecio.Location = new System.Drawing.Point(159, 69);
			this.txtPrecio.Name = "txtPrecio";
			this.txtPrecio.Size = new System.Drawing.Size(93, 20);
			this.txtPrecio.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(101, 70);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(52, 15);
			this.label4.TabIndex = 7;
			this.label4.Text = "Precio:";
			// 
			// cboClasificacion
			// 
			this.cboClasificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboClasificacion.FormattingEnabled = true;
			this.cboClasificacion.Items.AddRange(new object[] {
            "Limpieza",
            "Cuidados Personales",
            "Accesorios",
            "Comida",
            "Bebidas",
            "Comestibles Naturales",
            "Conserva"});
			this.cboClasificacion.Location = new System.Drawing.Point(425, 68);
			this.cboClasificacion.Name = "cboClasificacion";
			this.cboClasificacion.Size = new System.Drawing.Size(141, 21);
			this.cboClasificacion.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(326, 68);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(93, 15);
			this.label3.TabIndex = 5;
			this.label3.Text = "Clasificacion:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dgvProductos);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.ForeColor = System.Drawing.Color.Blue;
			this.groupBox2.Location = new System.Drawing.Point(12, 212);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(737, 223);
			this.groupBox2.TabIndex = 10;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Datos Adicionales:";
			// 
			// dgvProductos
			// 
			this.dgvProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvProductos.BackgroundColor = System.Drawing.Color.White;
			this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.dgvProductos.Location = new System.Drawing.Point(28, 22);
			this.dgvProductos.Name = "dgvProductos";
			this.dgvProductos.RowHeadersVisible = false;
			this.dgvProductos.RowHeadersWidth = 51;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			this.dgvProductos.RowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvProductos.Size = new System.Drawing.Size(694, 182);
			this.dgvProductos.TabIndex = 0;
			// 
			// frmAlmacen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(761, 541);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "frmAlmacen";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "frmAlmacen";
			this.Load += new System.EventHandler(this.frmAlmacen_Load);
			this.Controls.SetChildIndex(this.pnlTitulos, 0);
			this.Controls.SetChildIndex(this.pnlBotones, 0);
			this.Controls.SetChildIndex(this.groupBox1, 0);
			this.Controls.SetChildIndex(this.groupBox2, 0);
			this.pnlTitulos.ResumeLayout(false);
			this.pnlTitulos.PerformLayout();
			this.pnlBotones.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtCodProveedor;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtPrecio;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cboClasificacion;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridView dgvProductos;
	}
}