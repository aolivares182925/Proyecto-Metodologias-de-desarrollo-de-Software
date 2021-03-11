using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;
using System.Data.SqlClient;

using LibClases;

namespace LibFormularios
{
	public partial class frmLogin : Form
	{
		public frmLogin()
		{
			InitializeComponent();
		}
		// Establecer conexion con SQL-server
		SqlConnection Conex = new SqlConnection("Server=LAPTOP-GCAFGI1G;DataBase=DBSupermercado; integrated security= True");
		// ===========================================================
		// ====================ATRIBUTOS==============================
		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[DllImport("user32.DLL", EntryPoint = "SendMessage")]
		private extern static void SendMessage(System.IntPtr hwnd, int wmsg,
			int wparam, int lparam);

		public void Logear(string User, string Pass)
		{
			try
			{

				Conex.Open();
				SqlCommand cmd = new SqlCommand("SELECT Nombres, TipoUsuario FROM Usuarios where LoginName = @user and Password = @pass", Conex);
				cmd.Parameters.AddWithValue("user", User);
				cmd.Parameters.AddWithValue("pass", Pass);

				SqlDataAdapter sda = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				sda.Fill(dt);

				if (txtUser.Text != "USUARIO" && txtUser.TextLength > 2)
				{
					if (txtContraseña.Text != "CONTRASEÑA")
					{
						if (dt.Rows.Count == 1)
						{
							this.Hide();
							if (dt.Rows[0][1].ToString() == "Admin")
							{
								frmInterAdmin A = new frmInterAdmin();
								A.ShowDialog();
							}
							else if (dt.Rows[0][1].ToString() == "Cajero")
							{
								frmInterCajero C = new frmInterCajero();
								C.ShowDialog();
							}
						}

						else
						{
							//MessageBox.Show("Usuario y/o Contraseña Incorrectos...");
							msgError("    Su Username o Contraseña fue incorrecta. \n   Por favor trate de nuevo.");
							txtContraseña.Clear();
							txtUser.Clear();
							txtContraseña.UseSystemPasswordChar = true;
							txtUser.Focus();
						}

					}
					else
					{
						msgError("Por favor ingrese su Contraseña.");
						txtContraseña.Clear();
						txtUser.Clear();
						txtContraseña.UseSystemPasswordChar = true;
						txtUser.Focus();
					}
				}
				else
				{
					msgError("Por favor ingrese su Username.");
					txtContraseña.Clear();
					txtUser.Clear();
					txtContraseña.UseSystemPasswordChar = true;
					txtUser.Focus();
				}

			}

			catch (Exception e)
			{
				MessageBox.Show(e.Message);
			}
			finally
			{
				Conex.Close();
			}
		}

		private void msgError(string msg)
		{
			lblErrorMensaje.Text = "    " + msg;
			lblErrorMensaje.Visible = true;
		}

		private void Logout(object sender, FormClosedEventArgs e)
		{
			//txtContraseña.Text = "Password";
			//txtContraseña.UseSystemPasswordChar = false;
			//txtUser.Text = "Username";
			//lblErrorMensaje.Visible = false;
			//this.Show();
			txtContraseña.Clear();
			txtUser.Clear();
			lblErrorMensaje.Visible = false;
			this.Show();
			txtUser.Focus();
		}

		private void btnCerrar_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnMinimizar_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void btnAcceder_Click(object sender, EventArgs e)
		{
			Logear(this.txtUser.Text, this.txtContraseña.Text);
		}

		private void txtUser_Enter(object sender, EventArgs e)
		{
			if (txtUser.Text == "USUARIO")
			{
				txtUser.Text = "";
				txtUser.ForeColor = Color.LightGray;
			}
		}

		private void txtUser_Leave(object sender, EventArgs e)
		{
			if (txtUser.Text == "")
			{
				txtUser.Text = "USUARIO";
				txtUser.ForeColor = Color.DimGray;
			}
		}

		private void txtContraseña_Enter(object sender, EventArgs e)
		{
			if (txtContraseña.Text == "CONTRASEÑA")
			{
				txtContraseña.Text = "";
				txtContraseña.ForeColor = Color.LightGray;
				txtContraseña.UseSystemPasswordChar = true;
			}
		}

		private void txtContraseña_Leave(object sender, EventArgs e)
		{
			if (txtContraseña.Text == "")
			{
				txtContraseña.Text = "CONTRASEÑA";
				txtContraseña.ForeColor = Color.DimGray;
				txtContraseña.UseSystemPasswordChar = false;
			}
		}

		private void pnlLogo_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}

		private void pnlLogin_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}
	}
}
