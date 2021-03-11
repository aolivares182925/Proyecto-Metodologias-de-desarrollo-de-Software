
namespace LibFormularios
{
    partial class frmPanelArqueo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPanelArqueo));
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.dgvVentasEfectuadas = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtObservaciones = new System.Windows.Forms.TextBox();
			this.txtResumen = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.lblConteoDinero = new System.Windows.Forms.Label();
			this.lblFecha = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.lblTotalVentasEfectuadas = new System.Windows.Forms.Label();
			this.lblTotalConteoDinero = new System.Windows.Forms.Label();
			this.pnlTitulos.SuspendLayout();
			this.pnlBotones.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvVentasEfectuadas)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlTitulos
			// 
			this.pnlTitulos.Controls.Add(this.label2);
			this.pnlTitulos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.pnlTitulos.Size = new System.Drawing.Size(780, 75);
			this.pnlTitulos.Controls.SetChildIndex(this.label2, 0);
			// 
			// pnlBotones
			// 
			this.pnlBotones.Location = new System.Drawing.Point(0, 480);
			this.pnlBotones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.pnlBotones.Size = new System.Drawing.Size(780, 100);
			// 
			// btnNuevo
			// 
			this.btnNuevo.FlatAppearance.BorderSize = 0;
			this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
			this.btnNuevo.Visible = false;
			// 
			// btnGuardar
			// 
			this.btnGuardar.FlatAppearance.BorderSize = 0;
			this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
			this.btnGuardar.Visible = false;
			// 
			// panel3
			// 
			this.panel3.Visible = false;
			// 
			// panel2
			// 
			this.panel2.Visible = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
			this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label2.Location = new System.Drawing.Point(283, 26);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(190, 23);
			this.label2.TabIndex = 18;
			this.label2.Text = "     Panel de Arqueo";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(9, 78);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(183, 24);
			this.label4.TabIndex = 3;
			this.label4.Text = "Ventas Efectuadas";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(424, 78);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(175, 24);
			this.label3.TabIndex = 4;
			this.label3.Text = "Conteo de Dinero";
			// 
			// dgvVentasEfectuadas
			// 
			this.dgvVentasEfectuadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvVentasEfectuadas.Location = new System.Drawing.Point(13, 114);
			this.dgvVentasEfectuadas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.dgvVentasEfectuadas.Name = "dgvVentasEfectuadas";
			this.dgvVentasEfectuadas.RowHeadersWidth = 51;
			this.dgvVentasEfectuadas.RowTemplate.Height = 24;
			this.dgvVentasEfectuadas.Size = new System.Drawing.Size(341, 162);
			this.dgvVentasEfectuadas.TabIndex = 5;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtObservaciones);
			this.groupBox1.Controls.Add(this.txtResumen);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.Color.Blue;
			this.groupBox1.Location = new System.Drawing.Point(13, 321);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox1.Size = new System.Drawing.Size(393, 154);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Informe:";
			// 
			// txtObservaciones
			// 
			this.txtObservaciones.Location = new System.Drawing.Point(4, 80);
			this.txtObservaciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtObservaciones.Multiline = true;
			this.txtObservaciones.Name = "txtObservaciones";
			this.txtObservaciones.Size = new System.Drawing.Size(373, 71);
			this.txtObservaciones.TabIndex = 3;
			// 
			// txtResumen
			// 
			this.txtResumen.Location = new System.Drawing.Point(4, 37);
			this.txtResumen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtResumen.Name = "txtResumen";
			this.txtResumen.Size = new System.Drawing.Size(373, 23);
			this.txtResumen.TabIndex = 2;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(2, 61);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(121, 17);
			this.label7.TabIndex = 1;
			this.label7.Text = "Observaciones:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(2, 18);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(80, 17);
			this.label6.TabIndex = 0;
			this.label6.Text = "Resumen:";
			// 
			// lblConteoDinero
			// 
			this.lblConteoDinero.AutoSize = true;
			this.lblConteoDinero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblConteoDinero.Location = new System.Drawing.Point(428, 114);
			this.lblConteoDinero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblConteoDinero.Name = "lblConteoDinero";
			this.lblConteoDinero.Size = new System.Drawing.Size(14, 20);
			this.lblConteoDinero.TabIndex = 8;
			this.lblConteoDinero.Text = "-";
			// 
			// lblFecha
			// 
			this.lblFecha.AutoSize = true;
			this.lblFecha.Location = new System.Drawing.Point(524, 408);
			this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblFecha.Name = "lblFecha";
			this.lblFecha.Size = new System.Drawing.Size(37, 13);
			this.lblFecha.TabIndex = 9;
			this.lblFecha.Text = "Fecha";
			this.lblFecha.Visible = false;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Black;
			this.label8.Location = new System.Drawing.Point(15, 295);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(54, 20);
			this.label8.TabIndex = 10;
			this.label8.Text = "Total:";
			// 
			// lblTotalVentasEfectuadas
			// 
			this.lblTotalVentasEfectuadas.AutoSize = true;
			this.lblTotalVentasEfectuadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotalVentasEfectuadas.ForeColor = System.Drawing.Color.Black;
			this.lblTotalVentasEfectuadas.Location = new System.Drawing.Point(82, 295);
			this.lblTotalVentasEfectuadas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblTotalVentasEfectuadas.Name = "lblTotalVentasEfectuadas";
			this.lblTotalVentasEfectuadas.Size = new System.Drawing.Size(34, 20);
			this.lblTotalVentasEfectuadas.TabIndex = 11;
			this.lblTotalVentasEfectuadas.Text = "0.0";
			// 
			// lblTotalConteoDinero
			// 
			this.lblTotalConteoDinero.AutoSize = true;
			this.lblTotalConteoDinero.Location = new System.Drawing.Point(524, 422);
			this.lblTotalConteoDinero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblTotalConteoDinero.Name = "lblTotalConteoDinero";
			this.lblTotalConteoDinero.Size = new System.Drawing.Size(96, 13);
			this.lblTotalConteoDinero.TabIndex = 12;
			this.lblTotalConteoDinero.Text = "TotalConteoDinero";
			this.lblTotalConteoDinero.Visible = false;
			// 
			// frmPanelArqueo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(780, 580);
			this.Controls.Add(this.lblTotalConteoDinero);
			this.Controls.Add(this.lblTotalVentasEfectuadas);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.lblFecha);
			this.Controls.Add(this.lblConteoDinero);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dgvVentasEfectuadas);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "frmPanelArqueo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmPanelArqueo";
			this.Load += new System.EventHandler(this.frmPanelArqueo_Load);
			this.Controls.SetChildIndex(this.label4, 0);
			this.Controls.SetChildIndex(this.label3, 0);
			this.Controls.SetChildIndex(this.dgvVentasEfectuadas, 0);
			this.Controls.SetChildIndex(this.groupBox1, 0);
			this.Controls.SetChildIndex(this.lblConteoDinero, 0);
			this.Controls.SetChildIndex(this.lblFecha, 0);
			this.Controls.SetChildIndex(this.pnlTitulos, 0);
			this.Controls.SetChildIndex(this.pnlBotones, 0);
			this.Controls.SetChildIndex(this.label8, 0);
			this.Controls.SetChildIndex(this.lblTotalVentasEfectuadas, 0);
			this.Controls.SetChildIndex(this.lblTotalConteoDinero, 0);
			this.pnlTitulos.ResumeLayout(false);
			this.pnlTitulos.PerformLayout();
			this.pnlBotones.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvVentasEfectuadas)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvVentasEfectuadas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label lblFecha;
        public System.Windows.Forms.Label lblConteoDinero;
        public System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.TextBox txtResumen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotalVentasEfectuadas;
        public System.Windows.Forms.Label lblTotalConteoDinero;
    }
}