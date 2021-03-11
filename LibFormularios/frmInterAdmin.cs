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


namespace LibFormularios
{
	public partial class frmInterAdmin : Form
	{
		// ====================ATRIBUTOS==============================
		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[DllImport("user32.DLL", EntryPoint = "SendMessage")]
		private extern static void SendMessage(System.IntPtr hwnd, int wmsg,
			int wparam, int lparam);

		public frmInterAdmin()
		{
			InitializeComponent();
		}
		// --------------------CONTENEDOR------------------------------
		private void AbrirFormHijo(object frmHijo)
		{
			if (this.pnlContenedor.Controls.Count > 0)
				this.pnlContenedor.Controls.RemoveAt(0);

			Form fh = frmHijo as Form;
			fh.TopLevel = false;
			fh.Dock = DockStyle.Fill;
			this.pnlContenedor.Controls.Add(fh);
			this.pnlContenedor.Tag = fh;
			fh.Show();
		}
		// --------------------EVENTOS---------------------------------
		private void btnCerrar_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnMinimizar_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void btnMaximizar_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Maximized;
			btnMaximizar.Visible = false;
			btnRestaurar.Visible = true;
		}

		private void btnRestaurar_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Normal;
			btnRestaurar.Visible = false;
			btnMaximizar.Visible = true;
		}

		private void btnVolver_Click(object sender, EventArgs e)
		{
			//this.Hide();
			if (MessageBox.Show("Esta seguro que quiere salir?", "Waiting",
				MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
			{
				this.Hide();
				frmLogin L = new frmLogin();
				L.ShowDialog();
				this.Close();
			}
		}

		private void panel10_Paint(object sender, PaintEventArgs e)
		{

		}

		private void pnlBarraTitulo_Paint(object sender, PaintEventArgs e)
		{

		}

		private void pnlBarraTitulo_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}

		private void btnEmpleados_Click(object sender, EventArgs e)
		{
			//this.Hide();
			//frmAdmUsuarios U = new frmAdmUsuarios();
			//U.ShowDialog();
			AbrirFormHijo(new frmAdmUsuarios());
		}

		private void btnProductos_Click(object sender, EventArgs e)
		{
			//this.Hide();
			//frmAlmacen A = new frmAlmacen();
			//A.ShowDialog();
			AbrirFormHijo(new frmAlmacen());
		}

		private void btnArqueo_Click(object sender, EventArgs e)
		{
			AbrirFormHijo(new frmArqueo());
		}
	}
}
