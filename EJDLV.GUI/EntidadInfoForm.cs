namespace EJDLV.GUI
{
	public partial class EntidadInfoForm : Form
	{
		private IEntidad entidad;
		private Label nombreLabel;
		private Label energiaLabel;
		private Label vidaLabel;

		public EntidadInfoForm(IEntidad entidad)
		{
			InitializeComponent();
			this.entidad = entidad;
			ActualizarInformacion();
		}

		private void ActualizarInformacion()
		{
			// Actualizar etiquetas, cuadros de texto u otros controles con la información de la entidad.
			nombreLabel.Text = entidad.Nombre;
			energiaLabel.Text = $"Energía: {entidad.EnergiaActual}/{entidad.EnergiaMaxima}";
			vidaLabel.Text = $"Vida: {entidad.VidaActual}/{entidad.VidaMaxima}";
			// Agregar más actualizaciones según sea necesario.
		}
	}
}
