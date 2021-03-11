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
    public partial class frmPanelArqueo : frmPadre
    {
        public frmPanelArqueo()
        {
            InitializeComponent();
        }
        //---------------CONEXION-----------------------
        DataSet resultados = new DataSet();
        DataView miFiltro;
        public void Leer_datos(string query, ref DataSet dstprincipal, string tabla)
        {
            try
            {
                string Consulta = "Data Source=LAPTOP-GCAFGI1G; DataBase = DBSupermercado; integrated security = True";
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

        private void frmPanelArqueo_Load(object sender, EventArgs e)
        {
            ListarRegistros();
            //llenar la tabla de Ventas efectudas
            string fecha = "'"+lblFecha.Text + "'";
            string prueba = "SELECT * FROM ArqueoVenta WHERE Fecha = '01-01-2021' ";
            //"SELECT * FROM ArqueoVenta WHERE Fecha =" + fecha
            this.Leer_datos("SELECT * FROM ArqueoVenta WHERE Fecha =" + fecha, ref resultados, "ArqueoVenta");

            this.miFiltro = ((DataTable)resultados.Tables["ArqueoVenta"]).DefaultView;

            this.dgvVentasEfectuadas.DataSource = miFiltro;
            //Hallar el total de las ventas efectuadas
            double TotalVentasEfectuadas = 0;
            foreach (DataGridViewRow row in dgvVentasEfectuadas.Rows)
            {
                TotalVentasEfectuadas += Convert.ToDouble(row.Cells["Monto"].Value);
            }
            this.lblTotalVentasEfectuadas.Text = Convert.ToString(TotalVentasEfectuadas);

            //Realizar el resumen del arqueo
            double TotalRecaudado = Convert.ToDouble(lblTotalConteoDinero.Text);

            double TotalSobrante = TotalRecaudado - TotalVentasEfectuadas;

            if (TotalSobrante > 0)
            {
                txtResumen.Text = "Se encontro un sobrante de " + Convert.ToString(Math.Abs(TotalSobrante));
            }
            else if (TotalSobrante < 0)
            {
                txtResumen.Text = "Se encontro un faltante de " + Convert.ToString(Math.Abs(TotalSobrante));
            }
            else
            {
                txtResumen.Text = "ARQUEO EFECTUADO - CONFORME";
            }


        }

        
    }

    
}
