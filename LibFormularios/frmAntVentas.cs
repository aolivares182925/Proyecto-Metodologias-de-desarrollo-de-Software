using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using LibClases;

namespace LibFormularios
{
	public partial class frmAntVentas : frmPadre
	{
		private CProductos aProductos;
		private CVentas aVentas;
		private int aCantidad;
		private double aPago;
		private string aNroProducto;
		private string aNroVenta;

		public frmAntVentas()
		{
			InitializeComponent();
			IniciarEntidad(new CVentas());
			aVentas = new CVentas();
			//IniciarEntidad(new CProductos());
			aProductos = new CProductos();
			aCantidad = 0;
			aPago = 0;
			aNroVenta = "";
		}
		//============= REDEFINICION DE LOS METODOS VIRTUALES ====================
		//-- Establecer los valores que iran a la tabla
		public override string[] AsignarValoresAtributos()
		{
			string Codigo = "";
			if (dgvProductos.Rows.Count > 0)
			{
				Codigo = dgvProductos[0, dgvProductos.CurrentCell.RowIndex].Value.ToString();
				aNroVenta = dgvProductos[0, dgvProductos.CurrentCell.RowIndex].Value.ToString();
			}
			//-- recuperar el codigo del ejemplar (de la fila seleccionada en el grid) 
			return new string[] { Codigo, dtpFecha.Value.ToShortDateString(), txtDNI.Text, txtNombreC.Text, txtCodCajero.Text };
		}
		//-- Listar los registros y mostrarlos en el datagrid	
		public override void ListarRegistros()
		{ //-- Mostrar los ejemplares relacionados con el libro seleccionado 
			dgvProductos.DataSource = aProductos.MostrarRegistrosConCodigo();
			
		}
		//-----------------------------------------------------------
		//-- Iniciar los atributos clave y no clave en blanco
		public override void InicializarAtributoClave()
		{
			txtCodCajero.Text = "";
			txtDNI.Text = "";
			txtNombreC.Text = "";
		}
		public override void InicializarAtributosNoClave()
		{
			txtCodProducto.Text = "";
			txtNombreP.Text = "";
			txtPrecio.Text = "";
			txtProducto.Text = "";
			txtCantidad.Text = "1";
			txtPago.Text = "";
		}
		//----------------------------------------------------------
		public void CalcularMonto()
		{
			aCantidad = int.Parse(txtCantidad.Text);
			aPago = aCantidad * double.Parse(txtPrecio.Text);
			txtPago.Text = aPago.ToString();
		}
		//-----------------------------------------------------------
		//-- verificar los campos obligatorios(codigo y titulo) estén llenos
		public override bool EsRegistroValido()
		{
			if (txtCodCajero.Text.Trim() != "" && txtDNI.Text.Trim() != "" && txtNombreC.Text.Trim() != "")
				return true;
			else
				return false;
		}
		//-----------------------------------------------------------
		public override void Grabar()
		{ //-- al grabar un nuevo ejemplar, el formulario queda listo para

			//-- INSERTAR el siguiente registro

			try
			{
				if (EsRegistroValido())
				{ //-- Recuperar atributos, el primer atributo es la clave
					string[] Atributos = AsignarValoresAtributos();

					//-- Se realiza la inserciòn sin verificar si existe la clave
					//-- primaria, ya que en este caso la clave es autonumerica.


					aEntidad.Insertar(Atributos);
					//-- Inicializar el formulario

					MessageBox.Show("OPERACION REALIZADA EXITOSAMENTE", "CONFIRMACION");
					InicializarAtributos();
					ListarRegistros();
				}
				else
					MessageBox.Show("DEBE COMPLETAR EL LLENADO DEL FORMULARIO",
					"ALERTA");

			}
			catch (Exception e)
			{
				MessageBox.Show(e.ToString(), "ERROR AL REALIZAR LA OPERACION");
			}
		}

		DataSet resultados = new DataSet();
		DataView miFiltro;

		public void Leer_datos(string query, ref DataSet dstprincipal, string tabla)
		{
			try
			{
				string Consulta = "Data Source=DESKTOP-H4RJ2LR; DataBase = DBSupermercado; integrated security = True";
				SqlConnection cn = new SqlConnection(Consulta);
				SqlCommand cmd = new SqlCommand(query, cn);
				cn.Open();
				SqlDataAdapter da = new SqlDataAdapter(cmd);

				da.Fill(dstprincipal, tabla);
				da.Dispose();
				cn.Close();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		public void AsignarDatos()
		{
			//frmSubirInforme S = new frmSubirInforme();

			//S.txtCompSale.Text = aCodComponente;
			//S.txtNombreComp.Text = aNombre;
			//S.txtMarca.Text = aMarca;
			//S.txtEstadoDan.Text = aEstado;
		}
		public void LeerDetalleVentas()
		{
			this.Leer_datos("SELECT * FROM DetalleVenta", ref resultados, "DetalleVenta");

			this.miFiltro = ((DataTable)resultados.Tables["DetalleVenta"]).DefaultView;

			this.dgvDetalleVentas.DataSource = miFiltro;
		}
		public void Registrar_datos(string Cantidad, ref DataSet dstprincipal, string tabla)
		{
			try
			{
				string Consulta = "Data Source=DESKTOP-H4RJ2LR; DataBase = DBSupermercado; integrated security = True";
				SqlConnection cn = new SqlConnection(Consulta);
				string query = "insert into DetalleVenta values(" + aNroVenta + "," + aNroProducto + "," + Cantidad + ")";
				MessageBox.Show("SE GUARDO CORRECTAMENTE");
				
				SqlCommand cmd = new SqlCommand(query, cn);
				cn.Open();
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				cmd.ExecuteNonQuery();

				da.Fill(dstprincipal, tabla);
				da.Dispose();
				cn.Close();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		//----------------------------EVENTOS--------------------------------------
		private void frmAntVentas_Load(object sender, EventArgs e)
		{
			this.Leer_datos("SELECT NroProducto, Cod_Producto, Nombre_Producto, Precio FROM Producto", ref resultados, "Producto");

			this.miFiltro = ((DataTable)resultados.Tables["Producto"]).DefaultView;

			this.dgvProductos.DataSource = miFiltro;

			txtCantidad.Text = "1";

			LeerDetalleVentas();

		}

		//private void txtProducto_KeyUp(object sender, KeyEventArgs e)
		//{
		//	string Salida = "";
		//	string[] Palabra_Busqueda = this.txtProducto.Text.Split(' ');

		//	foreach (string Palabra in Palabra_Busqueda)
		//	{
		//		if (Salida.Length == 0)
		//		{
		//			Salida = "(Nombre_Producto LIKE '%" + Palabra + "%' OR Precio LIKE '%" + Palabra +
		//				"%' OR Cod_Proveedor LIKE '%" + Palabra + "%' OR Clasificacion LIKE '%" + Palabra + "%')";
		//		}
		//		else
		//		{
		//			Salida += "AND (Nombre_Producto like '%" + Palabra + "%' OR Precio LIKE '%" + Palabra + "%' OR " +
		//				"Cod_Proveedor LIKE '%" + Palabra + "%' OR Clasificacion LIKE '%" + Palabra + "%')";
		//		}
		//	}

		//	this.miFiltro.RowFilter = Salida;
		//}
		
		private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridViewRow D = dgvProductos.Rows[e.RowIndex];

				txtNombreP.Text = D.Cells["Nombre_Producto"].Value.ToString();

				txtPrecio.Text = D.Cells["Precio"].Value.ToString();

				txtCodProducto.Text = D.Cells["Cod_Producto"].Value.ToString();

				aNroProducto = D.Cells["NroProducto"].Value.ToString();

				//CalcularMonto();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
		}

		private void btnVolver_Click(object sender, EventArgs e)
		{
			this.Hide();
			frmInterCajero C = new frmInterCajero();
			C.ShowDialog();
		}

		private void rdbConBoleta_CheckedChanged(object sender, EventArgs e)
		{
			if (rdbConBoleta.Checked == true)
			{
				gpbCliente.Visible = true;
			}
			
		}

		private void rdbSinBoleta_CheckedChanged(object sender, EventArgs e)
		{
			if (rdbConBoleta.Checked == false)
			{
				gpbCliente.Visible = false;
				txtNombreC.Text = "SIN NOMBRE";
				txtDNI.Text = "SIN DNI";
			}
		}

		private void label12_Click(object sender, EventArgs e)
		{

		}

		private void txtDNI_TextChanged(object sender, EventArgs e)
		{

		}

		private void groupBox2_Enter(object sender, EventArgs e)
		{

		}

		private void txtPago_TextChanged(object sender, EventArgs e)
		{
			CalcularMonto();
		}

		private void btnCalcularMonto_Click(object sender, EventArgs e)
		{
			CalcularMonto();
		}

		private void btnVerVentas_Click(object sender, EventArgs e)
		{
			frmReporVentas Rv = new frmReporVentas();
			Rv.ShowDialog();
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			this.Registrar_datos(txtCantidad.Text, ref resultados, "DetalleVenta");

			InicializarAtributos();
		}
	}
}
