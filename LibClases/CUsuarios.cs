using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LibClases
{
	public class CUsuarios: CEntidad
	{
		//=============== ATRIBUTOS =======================
		//-- Todos heredados de CEntidad ----
		//================ METODOS ========================
		//-------------- Constructores --------------------
		public CUsuarios() : base("Usuarios", true)
		{
		}
		//------ Implementación de metodos abstractos -----
		public override string[] NombresAtributos()
		{
			return new string[] { "IdUsuarios", "loginName", "Password", "APaterno", "AMaterno", "Nombres", "TipoUsuario" };
		}
		//------ Métodos especificos de Ejemplares ----------------
		public DataTable ListaDeAsignaciones(string pIdUsuarios)
		{ //-- lista los ejemplares que le corresponden a un libro determinado
			string Consulta = "select * from Usuarios where IdUsuarios= '"

			+ pIdUsuarios + "'";

			aConexion.EjecutarSelect(Consulta);
			return aConexion.Datos.Tables[0];
		}
		//------------------------------------------------------
		public DataTable MostrarRegistros()
		{
			string Consulta = "select IdUsuarios, APaterno, AMaterno, Nombres, TipoUsuario" +
				" from Usuarios ";

			aConexion.EjecutarSelect(Consulta);
			return aConexion.Datos.Tables[0];
		}
		//-------------------------------------------------------
		public DataTable MostrarRegistrosConCodigo()
		{
			string Consulta = "select NroUsuarios, IdUsuarios, APaterno, AMaterno, Nombres, TipoUsuario" +
				" from Usuarios ";

			aConexion.EjecutarSelect(Consulta);
			return aConexion.Datos.Tables[0];
		}
	}
}
