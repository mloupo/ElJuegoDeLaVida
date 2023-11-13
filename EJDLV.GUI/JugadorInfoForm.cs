namespace EJDLV.GUI
{
	public partial class JugadorInfoForm : Form
	{
		private Jugador jugador;
		private Label nombreLabel;
		private Label puntosLabel;

		public JugadorInfoForm(Jugador jugador)
		{
			InitializeComponent();
			this.jugador = jugador;
			nombreLabel = new Label();
			puntosLabel = new Label();
			ActualizarInformacion();
		}

		private void ActualizarInformacion()
		{
			// Actualizar etiquetas, cuadros de texto u otros controles con la información del jugador.
			nombreLabel.Text = jugador.Nombre;
			puntosLabel.Text = $"Puntos: {jugador.Puntos}";
			// Agregar más actualizaciones según sea necesario.
		}
	}
}
