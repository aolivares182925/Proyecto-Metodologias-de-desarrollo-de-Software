using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibClases;

namespace LibFormularios
{
	public partial class frmAlmacen : frmPadre
	{
		private CProductos aProductos;

		public frmAlmacen()
		{
			InitializeComponent();
			IniciarEntidad(new CProductos());
			aProductos = new CProductos();
		}

		//============= REDEFINICION DE LOS METODOS VIRTUALES ====================
		//-- Establecer los valores que iran a la tabla
		public override string[] AsignarValoresAtributos()
		{
			string Codigo = "";
			if (dgvProductos.Rows.Count > 0)
			{
				Codigo = dgvProductos[0, dgvProductos.CurrentCell.RowIndex].Value.ToString();
			}
			//-- recuperar el codigo del ejemplar (de la fila seleccionada en el grid) 
			return new string[] {Codigo, txtNombre.Text,txtPrecio.Text,txtCodProveedor.Text,cboClasificacion.Text};
		}
		//-- Listar los registros y mostrarlos en el datagrid	
		public override void ListarRegistros()
		{ //-- Mostrar los ejemplares relacionados con el libro seleccionado 
			dgvProductos.DataSource = (aEntidad as CProductos).MostrarRegistros();
		}
		//-----------------------------------------------------------
		//-- Iniciar los atributos clave y no clave en blanco
		public override void InicializarAtributoClave()
		{
			txtNombre.Text = "";
			txtPrecio.Text = "";
		}
		public override void InicializarAtributosNoClave()
		{
			txtNombre.Text = "";
			txtPrecio.Text = "";
			txtCodProveedor.Text = "";
			cboClasificacion.Text = "";
		}
		//-----------------------------------------------------------
		//-- verificar los campos obligatorios(codigo y titulo) estén llenos
		public override bool EsRegistroValido()
		{
			if (txtNombre.Text.Trim() != "" && txtPrecio.Text.Trim() != "" && txtCodProveedor.Text.Trim() != ""
				&& cboClasificacion.Text !="")
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
		//-- Eliminar el registro del grid
		//public void EliminarRegistro()
		//{
		//	// Eliminar registro
		//	if (txtCodRegistro.Text.Trim() != "")
		//	{   // Eliminar registro
		//		aEntidad.Eliminar(txtCodRegistro.Text);
		//		MessageBox.Show("Registro eliminado exitosamente");
		//		//dgvRegistroEquipos.DataSource = aEntidad.ListaGeneral();
		//	}
		//	else
		//		MessageBox.Show("No se puede eliminar");
		//}
		//----------------------EVENTOS-------------------------------------
		private void btnVolver_Click(object sender, EventArgs e)
		{
			this.Hide();
			frmInterAdmin A = new frmInterAdmin();
			A.ShowDialog();
		}
		// -------------------------------------------------------------
		private void frmAlmacen_Load(object sender, EventArgs e)
		{
			ListarRegistros();
		}

        
        //----------------------------------------------------

    }
}
