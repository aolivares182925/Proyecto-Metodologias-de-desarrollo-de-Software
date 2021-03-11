namespace LibFormularios
{
	partial class frmAntVentas
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAntVentas));
			this.label2 = new System.Windows.Forms.Label();
			this.dgvProductos = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtCodCajero = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.dtpFecha = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtNombreP = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.txtPrecio = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtCantidad = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtProducto = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.gpbCliente = new System.Windows.Forms.GroupBox();
			this.txtNombreC = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txtDNI = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.rdbConBoleta = new System.Windows.Forms.RadioButton();
			this.rdbSinBoleta = new System.Windows.Forms.RadioButton();
			this.dgvDetalleVentas = new System.Windows.Forms.DataGridView();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnCalcularMonto = new System.Windows.Forms.Button();
			this.label14 = new System.Windows.Forms.Label();
			this.txtPago = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.txtCodProducto = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.panel6 = new System.Windows.Forms.Panel();
			this.btnVerVentas = new System.Windows.Forms.Button();
			this.pnlTitulos.SuspendLayout();
			this.pnlBotones.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.gpbCliente.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVentas)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlTitulos
			// 
			this.pnlTitulos.Controls.Add(this.label2);
			this.pnlTitulos.Size = new System.Drawing.Size(780, 75);
			this.pnlTitulos.Controls.SetChildIndex(this.label2, 0);
			// 
			// pnlBotones
			// 
			this.pnlBotones.Controls.Add(this.panel6);
			this.pnlBotones.Controls.Add(this.btnVerVentas);
			this.pnlBotones.Location = new System.Drawing.Point(0, 480);
			this.pnlBotones.Size = new System.Drawing.Size(780, 100);
			this.pnlBotones.Controls.SetChildIndex(this.btnGuardar, 0);
			this.pnlBotones.Controls.SetChildIndex(this.btnNuevo, 0);
			this.pnlBotones.Controls.SetChildIndex(this.panel2, 0);
			this.pnlBotones.Controls.SetChildIndex(this.panel3, 0);
			this.pnlBotones.Controls.SetChildIndex(this.btnVerVentas, 0);
			this.pnlBotones.Controls.SetChildIndex(this.panel6, 0);
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
			this.label2.Location = new System.Drawing.Point(253, 26);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(243, 23);
			this.label2.TabIndex = 16;
			this.label2.Text = "       ATENCION DE VENTAS";
			// 
			// dgvProductos
			// 
			this.dgvProductos.BackgroundColor = System.Drawing.Color.White;
			this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
			this.dgvProductos.Location = new System.Drawing.Point(15, 113);
			this.dgvProductos.Name = "dgvProductos";
			this.dgvProductos.RowHeadersVisible = false;
			this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvProductos.Size = new System.Drawing.Size(369, 182);
			this.dgvProductos.TabIndex = 2;
			this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
			// 
			// Column1
			// 
			this.Column1.HeaderText = "";
			this.Column1.Name = "Column1";
			this.Column1.Width = 40;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtCodCajero);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.dtpFecha);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.Color.Blue;
			this.groupBox1.Location = new System.Drawing.Point(15, 302);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(344, 77);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Datos del producto:";
			// 
			// txtCodCajero
			// 
			this.txtCodCajero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCodCajero.Location = new System.Drawing.Point(101, 21);
			this.txtCodCajero.Name = "txtCodCajero";
			this.txtCodCajero.Size = new System.Drawing.Size(106, 20);
			this.txtCodCajero.TabIndex = 20;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.Black;
			this.label9.Location = new System.Drawing.Point(9, 22);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(86, 15);
			this.label9.TabIndex = 19;
			this.label9.Text = "Cod. Cajero:";
			// 
			// dtpFecha
			// 
			this.dtpFecha.CustomFormat = "dd/MM/yyyy";
			this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpFecha.Location = new System.Drawing.Point(101, 47);
			this.dtpFecha.Name = "dtpFecha";
			this.dtpFecha.Size = new System.Drawing.Size(128, 20);
			this.dtpFecha.TabIndex = 17;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(43, 47);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(50, 15);
			this.label3.TabIndex = 5;
			this.label3.Text = "Fecha:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.ForeColor = System.Drawing.Color.Black;
			this.label8.Location = new System.Drawing.Point(182, 75);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(27, 16);
			this.label8.TabIndex = 18;
			this.label8.Text = "S/.";
			// 
			// txtNombreP
			// 
			this.txtNombreP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombreP.Location = new System.Drawing.Point(107, 48);
			this.txtNombreP.Name = "txtNombreP";
			this.txtNombreP.Size = new System.Drawing.Size(127, 20);
			this.txtNombreP.TabIndex = 16;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.Black;
			this.label11.Location = new System.Drawing.Point(39, 49);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(62, 15);
			this.label11.TabIndex = 15;
			this.label11.Text = "Nombre:";
			// 
			// txtPrecio
			// 
			this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPrecio.Location = new System.Drawing.Point(107, 74);
			this.txtPrecio.Name = "txtPrecio";
			this.txtPrecio.Size = new System.Drawing.Size(69, 20);
			this.txtPrecio.TabIndex = 12;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(49, 76);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(52, 15);
			this.label7.TabIndex = 11;
			this.label7.Text = "Precio:";
			// 
			// txtCantidad
			// 
			this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCantidad.Location = new System.Drawing.Point(107, 100);
			this.txtCantidad.Name = "txtCantidad";
			this.txtCantidad.Size = new System.Drawing.Size(85, 20);
			this.txtCantidad.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(33, 101);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(68, 15);
			this.label4.TabIndex = 7;
			this.label4.Text = "Cantidad:";
			// 
			// txtProducto
			// 
			this.txtProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtProducto.Location = new System.Drawing.Point(225, 87);
			this.txtProducto.Name = "txtProducto";
			this.txtProducto.Size = new System.Drawing.Size(286, 20);
			this.txtProducto.TabIndex = 11;
			//this.txtProducto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtProducto_KeyUp);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(151, 88);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(68, 15);
			this.label6.TabIndex = 10;
			this.label6.Text = "Producto:";
			// 
			// gpbCliente
			// 
			this.gpbCliente.Controls.Add(this.txtNombreC);
			this.gpbCliente.Controls.Add(this.label10);
			this.gpbCliente.Controls.Add(this.txtDNI);
			this.gpbCliente.Controls.Add(this.label12);
			this.gpbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gpbCliente.ForeColor = System.Drawing.Color.Blue;
			this.gpbCliente.Location = new System.Drawing.Point(15, 412);
			this.gpbCliente.Name = "gpbCliente";
			this.gpbCliente.Size = new System.Drawing.Size(344, 62);
			this.gpbCliente.TabIndex = 12;
			this.gpbCliente.TabStop = false;
			this.gpbCliente.Text = "Datos del cliente:";
			this.gpbCliente.Visible = false;
			// 
			// txtNombreC
			// 
			this.txtNombreC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombreC.Location = new System.Drawing.Point(74, 21);
			this.txtNombreC.Name = "txtNombreC";
			this.txtNombreC.Size = new System.Drawing.Size(94, 20);
			this.txtNombreC.TabIndex = 16;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.Black;
			this.label10.Location = new System.Drawing.Point(6, 22);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(62, 15);
			this.label10.TabIndex = 15;
			this.label10.Text = "Nombre:";
			// 
			// txtDNI
			// 
			this.txtDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDNI.Location = new System.Drawing.Point(214, 21);
			this.txtDNI.MaxLength = 8;
			this.txtDNI.Name = "txtDNI";
			this.txtDNI.Size = new System.Drawing.Size(124, 20);
			this.txtDNI.TabIndex = 12;
			this.txtDNI.TextChanged += new System.EventHandler(this.txtDNI_TextChanged);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.Color.Black;
			this.label12.Location = new System.Drawing.Point(173, 25);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(35, 15);
			this.label12.TabIndex = 11;
			this.label12.Text = "DNI:";
			this.label12.Click += new System.EventHandler(this.label12_Click);
			// 
			// rdbConBoleta
			// 
			this.rdbConBoleta.AutoSize = true;
			this.rdbConBoleta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdbConBoleta.Location = new System.Drawing.Point(227, 386);
			this.rdbConBoleta.Name = "rdbConBoleta";
			this.rdbConBoleta.Size = new System.Drawing.Size(143, 20);
			this.rdbConBoleta.TabIndex = 14;
			this.rdbConBoleta.TabStop = true;
			this.rdbConBoleta.Text = "Con Datos-Cliente";
			this.rdbConBoleta.UseVisualStyleBackColor = true;
			this.rdbConBoleta.CheckedChanged += new System.EventHandler(this.rdbConBoleta_CheckedChanged);
			// 
			// rdbSinBoleta
			// 
			this.rdbSinBoleta.AutoSize = true;
			this.rdbSinBoleta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdbSinBoleta.Location = new System.Drawing.Point(61, 386);
			this.rdbSinBoleta.Name = "rdbSinBoleta";
			this.rdbSinBoleta.Size = new System.Drawing.Size(136, 20);
			this.rdbSinBoleta.TabIndex = 15;
			this.rdbSinBoleta.TabStop = true;
			this.rdbSinBoleta.Text = "Sin Datos-Cliente";
			this.rdbSinBoleta.UseVisualStyleBackColor = true;
			this.rdbSinBoleta.CheckedChanged += new System.EventHandler(this.rdbSinBoleta_CheckedChanged);
			// 
			// dgvDetalleVentas
			// 
			this.dgvDetalleVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDetalleVentas.Location = new System.Drawing.Point(421, 113);
			this.dgvDetalleVentas.Name = "dgvDetalleVentas";
			this.dgvDetalleVentas.Size = new System.Drawing.Size(340, 182);
			this.dgvDetalleVentas.TabIndex = 16;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnCalcularMonto);
			this.groupBox2.Controls.Add(this.label14);
			this.groupBox2.Controls.Add(this.txtPago);
			this.groupBox2.Controls.Add(this.label15);
			this.groupBox2.Controls.Add(this.txtCodProducto);
			this.groupBox2.Controls.Add(this.label13);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.txtNombreP);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.txtPrecio);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.txtCantidad);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.ForeColor = System.Drawing.Color.Blue;
			this.groupBox2.Location = new System.Drawing.Point(405, 301);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(356, 173);
			this.groupBox2.TabIndex = 17;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Datos de la venta:";
			this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
			// 
			// btnCalcularMonto
			// 
			this.btnCalcularMonto.BackColor = System.Drawing.Color.Turquoise;
			this.btnCalcularMonto.ForeColor = System.Drawing.Color.Black;
			this.btnCalcularMonto.Location = new System.Drawing.Point(262, 90);
			this.btnCalcularMonto.Name = "btnCalcularMonto";
			this.btnCalcularMonto.Size = new System.Drawing.Size(88, 53);
			this.btnCalcularMonto.TabIndex = 22;
			this.btnCalcularMonto.Text = "Calcular Pago";
			this.btnCalcularMonto.UseVisualStyleBackColor = false;
			this.btnCalcularMonto.Click += new System.EventHandler(this.btnCalcularMonto_Click);
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.ForeColor = System.Drawing.Color.Black;
			this.label14.Location = new System.Drawing.Point(182, 127);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(27, 16);
			this.label14.TabIndex = 21;
			this.label14.Text = "S/.";
			// 
			// txtPago
			// 
			this.txtPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPago.Location = new System.Drawing.Point(107, 126);
			this.txtPago.Name = "txtPago";
			this.txtPago.Size = new System.Drawing.Size(69, 20);
			this.txtPago.TabIndex = 20;
			this.txtPago.TextChanged += new System.EventHandler(this.txtPago_TextChanged);
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.ForeColor = System.Drawing.Color.Black;
			this.label15.Location = new System.Drawing.Point(21, 127);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(80, 15);
			this.label15.TabIndex = 19;
			this.label15.Text = "Pago Total:";
			// 
			// txtCodProducto
			// 
			this.txtCodProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCodProducto.Location = new System.Drawing.Point(107, 21);
			this.txtCodProducto.Name = "txtCodProducto";
			this.txtCodProducto.Size = new System.Drawing.Size(127, 20);
			this.txtCodProducto.TabIndex = 18;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.ForeColor = System.Drawing.Color.Black;
			this.label13.Location = new System.Drawing.Point(0, 22);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(101, 15);
			this.label13.TabIndex = 17;
			this.label13.Text = "Cod. Producto:";
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
			this.panel6.Location = new System.Drawing.Point(12, 35);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(5, 32);
			this.panel6.TabIndex = 47;
			// 
			// btnVerVentas
			// 
			this.btnVerVentas.FlatAppearance.BorderSize = 0;
			this.btnVerVentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
			this.btnVerVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnVerVentas.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVerVentas.ForeColor = System.Drawing.Color.White;
			this.btnVerVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnVerVentas.Image")));
			this.btnVerVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnVerVentas.Location = new System.Drawing.Point(15, 35);
			this.btnVerVentas.Name = "btnVerVentas";
			this.btnVerVentas.Size = new System.Drawing.Size(152, 35);
			this.btnVerVentas.TabIndex = 46;
			this.btnVerVentas.Text = "Ver Ventas";
			this.btnVerVentas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnVerVentas.UseVisualStyleBackColor = true;
			this.btnVerVentas.Click += new System.EventHandler(this.btnVerVentas_Click);
			// 
			// frmAntVentas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(780, 580);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.dgvDetalleVentas);
			this.Controls.Add(this.rdbSinBoleta);
			this.Controls.Add(this.rdbConBoleta);
			this.Controls.Add(this.gpbCliente);
			this.Controls.Add(this.txtProducto);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dgvProductos);
			this.Name = "frmAntVentas";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmAntVentas";
			this.Load += new System.EventHandler(this.frmAntVentas_Load);
			this.Controls.SetChildIndex(this.dgvProductos, 0);
			this.Controls.SetChildIndex(this.groupBox1, 0);
			this.Controls.SetChildIndex(this.pnlTitulos, 0);
			this.Controls.SetChildIndex(this.pnlBotones, 0);
			this.Controls.SetChildIndex(this.label6, 0);
			this.Controls.SetChildIndex(this.txtProducto, 0);
			this.Controls.SetChildIndex(this.gpbCliente, 0);
			this.Controls.SetChildIndex(this.rdbConBoleta, 0);
			this.Controls.SetChildIndex(this.rdbSinBoleta, 0);
			this.Controls.SetChildIndex(this.dgvDetalleVentas, 0);
			this.Controls.SetChildIndex(this.groupBox2, 0);
			this.pnlTitulos.ResumeLayout(false);
			this.pnlTitulos.PerformLayout();
			this.pnlBotones.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.gpbCliente.ResumeLayout(false);
			this.gpbCliente.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVentas)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dgvProductos;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtNombreP;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtPrecio;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtCantidad;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtProducto;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DateTimePicker dtpFecha;
		private System.Windows.Forms.TextBox txtCodCajero;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.GroupBox gpbCliente;
		private System.Windows.Forms.TextBox txtNombreC;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtDNI;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
		private System.Windows.Forms.RadioButton rdbConBoleta;
		private System.Windows.Forms.RadioButton rdbSinBoleta;
		private System.Windows.Forms.DataGridView dgvDetalleVentas;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtCodProducto;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox txtPago;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Button btnCalcularMonto;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Button btnVerVentas;
	}
}