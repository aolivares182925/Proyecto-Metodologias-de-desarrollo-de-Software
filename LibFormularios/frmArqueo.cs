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
	public partial class frmArqueo : frmPadre
	{
		private double aMontoTotal;
		public frmArqueo()
		{
			InitializeComponent();
			aMontoTotal = 0;
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
		public override bool EsRegistroValido()
		{
			if (txtB200.Text.Trim() != "" && txtB100.Text.Trim() != "" && txtB50.Text.Trim() != ""
				&& txtB10.Text.Trim() != "" && txtM5.Text.Trim() != "" && txtM2.Text.Trim() != ""
				&& txtM1.Text.Trim() != "" && txtM0_5.Text.Trim() != "" && txtM0_2.Text.Trim() != ""
				&& txtM0_1.Text.Trim() != "" && txtB20.Text.Trim() != ""
				&& txtObservaciones.Text.Trim() != "" )
				return true;
			else
				return false;
		}
		public override void Grabar()
		{ //-- al grabar un nuevo ejemplar, el formulario queda listo para

			//-- INSERTAR el siguiente registro

			try
			{
				if (EsRegistroValido())
				{ //-- Recuperar atributos, el primer atributo es la clave
					
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
		public void AsignarDatos()
		{
			//frmSubirInforme S = new frmSubirInforme();

			//S.txtCompSale.Text = aCodComponente;
			//S.txtNombreComp.Text = aNombre;
			//S.txtMarca.Text = aMarca;
			//S.txtEstadoDan.Text = aEstado;
		}

		private void frmArqueo_Load(object sender, EventArgs e)
		{
			//ListarRegistros();
			//this.Leer_datos("SELECT * FROM ArqueoVenta", ref resultados, "ArqueoVenta");

			//this.miFiltro = ((DataTable)resultados.Tables["ArqueoVenta"]).DefaultView;

			//this.dgvVentas.DataSource = miFiltro;
		}

        private void button1_Click(object sender, EventArgs e)
        {
			

            try
            {
				
				double B200 = long.Parse(txtB200.Text) * 200;
				double B100 = long.Parse(txtB100.Text) * 100; 
				double B50 = long.Parse(txtB50.Text) * 50;
				double B20 = long.Parse(txtB20.Text) * 20;
				double B10 = long.Parse(txtB10.Text) * 10 ;
				double M5 = long.Parse(txtM5.Text) * 5;
				double M2 = long.Parse(txtM2.Text) * 2 ;
				double M1 = long.Parse(txtM1.Text) * 1;
				double M0_5 = long.Parse(txtM0_5.Text) * 0.5;
				double M0_2 = long.Parse(txtM0_2.Text) * 0.2;
				double M0_1 = long.Parse(txtM0_1.Text) * 0.1;

				double Total =  B200 + B100 + B50 + B20 + B10 + M5 + M2 + M1 + M0_5 + M0_2 + M0_1;
			
				lblTotalRecaudado.Text =Total.ToString();
            }
            catch(Exception error)
            {
				MessageBox.Show(error.ToString(), "Datos erroneos");
			}
		}

        private void btnGuardar_Click(object sender, EventArgs e)
        {
			frmPanelArqueo PanelArqueoNuevo = new frmPanelArqueo();
			string titulosConteoDinero = "Nro     Denominacion     Cantidad     Parcial ";
			string Conteo_Dinero=(titulosConteoDinero + "\n"+
								 "1" + "          200                      " + txtB200.Text + "               " + (long.Parse(txtB200.Text) * 200).ToString() + "\n"+
								 "2" + "          100                      " + txtB100.Text + "               " + (long.Parse(txtB100.Text) * 100).ToString() + "\n" +
								 "3" + "          50                        " + txtB50.Text + "                " + (long.Parse(txtB50.Text) * 50).ToString() + "\n" +
								 "4" + "          20                        " + txtB20.Text + "                " + (long.Parse(txtB20.Text) * 20).ToString() + "\n" +
								 "5" + "          10                        " + txtB10.Text + "                " + (long.Parse(txtB10.Text) * 10).ToString() + "\n" +
								 "6" + "          5                          " + txtM5.Text + "                 " + (long.Parse(txtM5.Text) * 5).ToString() + "\n" +
								 "7" + "          2                          " + txtM2.Text + "                 " + (long.Parse(txtM2.Text) * 2).ToString() + "\n" +
								 "8" + "          1                          " + txtM1.Text + "                 " + (long.Parse(txtM1.Text) * 1).ToString() + "\n" +
								 "9" + "          0.5                      " + txtM0_5.Text + "               " + (long.Parse(txtM0_5.Text) * 0.5).ToString() + "\n" +
								 "10" + "         0.2                      " + txtM0_2.Text + "               " + (long.Parse(txtM0_2.Text) * 0.2).ToString() + "\n" +
								 "11" + "         0.1                      " + txtM0_1.Text + "               " + (long.Parse(txtM0_1.Text) * 0_1).ToString() + "\n" +
								 "\n"+
								 "Total Recaudado \t" + lblTotalRecaudado.Text);

			PanelArqueoNuevo.lblConteoDinero.Text = Conteo_Dinero;
			PanelArqueoNuevo.lblTotalConteoDinero.Text = lblTotalRecaudado.Text;
			PanelArqueoNuevo.txtObservaciones.Text = txtObservaciones.Text;

			string cero = "0";
			//Auxiliar
			
			PanelArqueoNuevo.lblFecha.Text = ((int.Parse(dtpFecha.Value.Day.ToString()) <10)? "0":"") + dtpFecha.Value.Day.ToString() + 
				"-"+ ((int.Parse(dtpFecha.Value.Month.ToString()) < 10) ? "0" : "") + dtpFecha.Value.Month.ToString() 
				+"-"+ dtpFecha.Value.Year.ToString() ;


			//PanelArqueoNuevo.lblFecha.Text = "hola"; 

			PanelArqueoNuevo.Show();

			

			//PanelArqueoNuevo.TopLevel = false;
			//PanelArqueoNuevo.Dock = DockStyle.Fill;
			//this.pnlContenedor.Controls.Add(PanelArqueoNuevo);
			//this.pnlContenedor.Tag = PanelArqueoNuevo;
			//PanelArqueoNuevo.Show();
		}

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }
    }
	
}
