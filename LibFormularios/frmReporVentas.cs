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
	public partial class frmReporVentas : Form
	{
		private CVentas aVentas;
		private string NroVentas;


		//--Metodos set y get
		public string CodComponente
		{
			get { return NroVentas; }
		}

		public frmReporVentas()
		{
			InitializeComponent();
			aVentas = new CVentas();
		}

		public void ListarRegistros()
		{
			aVentas.MostrarRegistros();
		}

		//---------------CONEXION-----------------------
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
		//----------------------------EVENTOS----------------------------------------------
		private void frmReporVentas_Load(object sender, EventArgs e)
		{
			//ListarRegistros();
			this.Leer_datos("SELECT * FROM Venta", ref resultados, "Venta");

			this.miFiltro = ((DataTable)resultados.Tables["Venta"]).DefaultView;

			this.dgvVentas.DataSource = miFiltro;
		}

		private void btnVolver_Click(object sender, EventArgs e)
		{
			this.Close();
			frmInterCajero C = new frmInterCajero();
			C.ShowDialog();
		}

		private void btnCerrar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

	}
}
