namespace LibFormularios
{
	partial class frmReporVentas
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporVentas));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label1 = new System.Windows.Forms.Label();
			this.pnlBarraTitulo = new System.Windows.Forms.Panel();
			this.pnlBotones = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnCerrar = new System.Windows.Forms.Button();
			this.panel4 = new System.Windows.Forms.Panel();
			this.btnInprimir = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dgvVentas = new System.Windows.Forms.DataGridView();
			this.pnlBarraTitulo.SuspendLayout();
			this.pnlBotones.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
			this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label1.Location = new System.Drawing.Point(262, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(234, 23);
			this.label1.TabIndex = 9;
			this.label1.Text = "       REPORTES DE VENTAS";
			// 
			// pnlBarraTitulo
			// 
			this.pnlBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
			this.pnlBarraTitulo.Controls.Add(this.label1);
			this.pnlBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlBarraTitulo.Location = new System.Drawing.Point(0, 0);
			this.pnlBarraTitulo.Name = "pnlBarraTitulo";
			this.pnlBarraTitulo.Size = new System.Drawing.Size(780, 87);
			this.pnlBarraTitulo.TabIndex = 10;
			// 
			// pnlBotones
			// 
			this.pnlBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
			this.pnlBotones.Controls.Add(this.panel1);
			this.pnlBotones.Controls.Add(this.btnCerrar);
			this.pnlBotones.Controls.Add(this.panel4);
			this.pnlBotones.Controls.Add(this.btnInprimir);
			this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlBotones.Location = new System.Drawing.Point(0, 480);
			this.pnlBotones.Name = "pnlBotones";
			this.pnlBotones.Size = new System.Drawing.Size(780, 100);
			this.pnlBotones.TabIndex = 11;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
			this.panel1.Location = new System.Drawing.Point(15, 29);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(5, 32);
			this.panel1.TabIndex = 45;
			// 
			// btnCerrar
			// 
			this.btnCerrar.FlatAppearance.BorderSize = 0;
			this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
			this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCerrar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCerrar.ForeColor = System.Drawing.Color.White;
			this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
			this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCerrar.Location = new System.Drawing.Point(18, 29);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(152, 35);
			this.btnCerrar.TabIndex = 44;
			this.btnCerrar.Text = "Cerrar";
			this.btnCerrar.UseVisualStyleBackColor = true;
			this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
			this.panel4.Location = new System.Drawing.Point(613, 29);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(5, 32);
			this.panel4.TabIndex = 43;
			// 
			// btnInprimir
			// 
			this.btnInprimir.FlatAppearance.BorderSize = 0;
			this.btnInprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
			this.btnInprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnInprimir.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnInprimir.ForeColor = System.Drawing.Color.White;
			this.btnInprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnInprimir.Image")));
			this.btnInprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnInprimir.Location = new System.Drawing.Point(616, 29);
			this.btnInprimir.Name = "btnInprimir";
			this.btnInprimir.Size = new System.Drawing.Size(152, 35);
			this.btnInprimir.TabIndex = 42;
			this.btnInprimir.Text = "Imprimir";
			this.btnInprimir.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dgvVentas);
			this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 107);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(756, 367);
			this.groupBox1.TabIndex = 12;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Registro de Ventas";
			// 
			// dgvVentas
			// 
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			this.dgvVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvVentas.BackgroundColor = System.Drawing.Color.White;
			this.dgvVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvVentas.Location = new System.Drawing.Point(6, 62);
			this.dgvVentas.Name = "dgvVentas";
			this.dgvVentas.RowHeadersVisible = false;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
			this.dgvVentas.RowsDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvVentas.Size = new System.Drawing.Size(738, 289);
			this.dgvVentas.TabIndex = 13;
			// 
			// frmReporVentas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(780, 580);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.pnlBotones);
			this.Controls.Add(this.pnlBarraTitulo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmReporVentas";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmReporVentas";
			this.Load += new System.EventHandler(this.frmReporVentas_Load);
			this.pnlBarraTitulo.ResumeLayout(false);
			this.pnlBarraTitulo.PerformLayout();
			this.pnlBotones.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel pnlBarraTitulo;
		private System.Windows.Forms.Panel pnlBotones;
		private System.Windows.Forms.Panel panel4;
		protected System.Windows.Forms.Button btnInprimir;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView dgvVentas;
		private System.Windows.Forms.Panel panel1;
		protected System.Windows.Forms.Button btnCerrar;
	}
}