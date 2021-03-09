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

        private void frmPanelArqueo_Load(object sender, EventArgs e)
        {
            ListarRegistros();

            this.Leer_datos("SELECT * FROM ArqueoVenta", ref resultados, "ArqueoVenta");

            this.miFiltro = ((DataTable)resultados.Tables["ArqueoVenta"]).DefaultView;

            this.dgvVentasEfectuadas.DataSource = miFiltro;
        }
    }

    
}
