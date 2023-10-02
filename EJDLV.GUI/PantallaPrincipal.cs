namespace EJDLV.GUI
{
	public partial class PantallaPrincipal : Form
	{
		public PantallaPrincipal()
		{
			InitializeComponent();
		}

		private void BtnNuevoJuego_Click(object sender, EventArgs e)
		{
			// iniciar un nuevo juego
			// abrir la pantalla de configuración de partida o cargar un escenario inicial.
			ConfiguracionPartida configuracionPartida = new();
			configuracionPartida.Show();
		}

		private void BtnCargarPartida_Click(object sender, EventArgs e)
		{
			// abrir una pantalla para seleccionar y cargar una partida guardada.
			SeleccionarPartida seleccionarPartida = new();
			seleccionarPartida.Show();
		}

		private void BtnSalir_Click(object sender, EventArgs e)
		{
			Application.Exit(); // Cierra la aplicación.
		}
	}
}