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
	public partial class frmAdmUsuarios: frmPadre
	{
		private CUsuarios aUsuarios;

		public frmAdmUsuarios()
		{
			InitializeComponent();
			IniciarEntidad(new CUsuarios());
			aUsuarios = new CUsuarios();
		}
		//============= REDEFINICION DE LOS METODOS VIRTUALES ====================
		//-- Establecer los valores que iran a la tabla
		public override string[] AsignarValoresAtributos()
		{
			string Codigo = "";
			if (dgvUsuarios.Rows.Count > 0)
			{
				Codigo = dgvUsuarios[0, dgvUsuarios.CurrentCell.RowIndex].Value.ToString();
			}
			//-- recuperar el codigo del ejemplar (de la fila seleccionada en el grid) 
			return new string[] { Codigo, txtID.Text, txtContraseña.Text, txtApPaterno.Text, txtApMaterno.Text, txtNombres.Text, cboTipo.Text };
		}
		//-- Listar los registros y mostrarlos en el datagrid	
		public override void ListarRegistros()
		{ //-- Mostrar los ejemplares relacionados con el libro seleccionado 
			dgvUsuarios.DataSource = (aEntidad as CUsuarios).MostrarRegistros();
		}
		//-----------------------------------------------------------
		//-- Iniciar los atributos clave y no clave en blanco
		public override void InicializarAtributoClave()
		{
			txtApPaterno.Text = "";
			txtApMaterno.Text = "";
			txtNombres.Text = "";
			cboTipo.Text = "";
			txtID.Text = "";
			txtContraseña.Text = "";
		}
		public override void InicializarAtributosNoClave()
		{
			txtID.Text = "";
			txtContraseña.Text = "";
		}
		//-----------------------------------------------------------
		//-- verificar los campos obligatorios(codigo y titulo) estén llenos
		public override bool EsRegistroValido()
		{
			if (txtApPaterno.Text.Trim() != "" && txtApMaterno.Text.Trim() != "" && txtNombres.Text.Trim() != ""
				&& cboTipo.Text != "")
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
		//--------------------EVENTOS----------------------------------
		private void btnVolver_Click(object sender, EventArgs e)
		{
			this.Hide();
			frmInterAdmin A = new frmInterAdmin();
			A.ShowDialog();
		}

		private void groupBox2_Enter(object sender, EventArgs e)
		{

		}

		private void txtNID_TextChanged(object sender, EventArgs e)
		{

		}

		private void frmAdmUsuarios_Load(object sender, EventArgs e)
		{
			ListarRegistros();
		}
	}
}
