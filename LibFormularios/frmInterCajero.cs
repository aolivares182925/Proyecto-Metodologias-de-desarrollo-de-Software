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
using LibClases;

namespace LibFormularios
{
	public partial class frmInterCajero : Form
	{
		// ====================ATRIBUTOS==============================
		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[DllImport("user32.DLL", EntryPoint = "SendMessage")]
		private extern static void SendMessage(System.IntPtr hwnd, int wmsg,
			int wparam, int lparam);

		public frmInterCajero()
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
		//--------------------------------------------
		private void btnCerrar_Click(object sender, EventArgs e)
		{
			Application.Exit();
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

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void pnlMenuVertical_Paint(object sender, PaintEventArgs e)
		{

		}

		private void pnlBarraTitulo_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}

		private void btnReportes_Click(object sender, EventArgs e)
		{
			pnlSubMenu.Visible = true;

		}

		private void btnRpVentas_Click(object sender, EventArgs e)
		{
			//pnlSubMenu.Visible = false;
			//frmReporVentas RV = new frmReporVentas();
			//RV.ShowDialog();
			AbrirFormHijo(new frmReporVentas());
		}

		private void btnRpCompras_Click(object sender, EventArgs e)
		{
			pnlSubMenu.Visible = false;
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

		private void btnMinimizar_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void btnVentas_Click(object sender, EventArgs e)
		{
			//frmAntVentas V = new frmAntVentas();
			//V.ShowDialog();
			AbrirFormHijo(new frmAntVentas());
		}
	}
}
