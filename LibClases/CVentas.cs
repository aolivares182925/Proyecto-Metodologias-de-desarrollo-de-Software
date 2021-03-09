using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LibClases
{
	public class CVentas: CEntidad
	{
		//=============== ATRIBUTOS =======================
		//-- Todos heredados de CEntidad ----
		//================ METODOS ========================
		//-------------- Constructores --------------------
		public CVentas() : base("Venta", true)
		{
		}
		//------ Implementación de metodos abstractos -----
		public override string[] NombresAtributos()
		{
			return new string[] { "Fecha", "DNI_Cliente", "Nombre_Cliente", "NroUsuarios" };
		}
		//------ Métodos especificos de Ejemplares ----------------
		public DataTable ListaDeAsignaciones(string pVenta)
		{ //-- lista los ejemplares que le corresponden a un libro determinado
			string Consulta = "select * from Venta where IdVenta= '"

			+ pVenta + "'";

			aConexion.EjecutarSelect(Consulta);
			return aConexion.Datos.Tables[0];
		}
		//------------------------------------------------------
		public DataTable MostrarRegistros()
		{
			string Consulta = "select Nro_Venta, IdVenta, Fecha, DNI_Cliente, Nombre_Cliente, NroUsuarios" +
				" from Venta ";

			aConexion.EjecutarSelect(Consulta);
			return aConexion.Datos.Tables[0];
		}
		//-------------------------------------------------------
		public DataTable MostrarRegistrosConCodigo()
		{
			string Consulta = "select IdVenta, Fecha, DNI_Cliente, Nombre_Cliente, NroUsuarios "  +" from Producto ";

			aConexion.EjecutarSelect(Consulta);
			return aConexion.Datos.Tables[0];
		}
	}
}
