using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LibClases
{
	public class CProductos: CEntidad
	{
		//=============== ATRIBUTOS =======================
		//-- Todos heredados de CEntidad ----
		//================ METODOS ========================
		//-------------- Constructores --------------------
		public CProductos() : base("Producto", true)
		{
		}
		//------ Implementación de metodos abstractos -----
		public override string[] NombresAtributos()
		{
			return new string[] { "CodProducto", "Nombre_Producto", "Precio", "Cod_Proveedor", "Clasificacion" };
		}
		//------ Métodos especificos de Ejemplares ----------------
		public DataTable ListaDeAsignaciones(string pCodProducto)
		{ //-- lista los ejemplares que le corresponden a un libro determinado
			string Consulta = "select * from Producto where NroProducto= '"

			+ pCodProducto + "'";

			aConexion.EjecutarSelect(Consulta);
			return aConexion.Datos.Tables[0];
		}
		//------------------------------------------------------
		public DataTable MostrarRegistros()
		{
			string Consulta = "select Cod_Producto, Nombre_Producto, Precio, Cod_Proveedor, Clasificacion" +
				" from Producto ";

			aConexion.EjecutarSelect(Consulta);
			return aConexion.Datos.Tables[0];
		}
		//-------------------------------------------------------
		public DataTable MostrarRegistrosConCodigo()
		{
			string Consulta = "select NroProducto, Cod_Producto, Nombre_Producto, Precio, Cod_Proveedor, Clasificacion" +
				" from Producto ";

			aConexion.EjecutarSelect(Consulta);
			return aConexion.Datos.Tables[0];
		}
	}
}
