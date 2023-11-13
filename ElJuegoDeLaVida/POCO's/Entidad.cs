using EJDLV.Entidades.Interfaces.Comportamiento;
using EJDLV.Entidades.Interfaces.MedioAmbiente;
using EJDLV.Entidades.POCO_s.EstrategiasAtaque;
using EJDLV.Entidades.POCO_s.EstrategiasDefensa;

namespace EJDLV.Entidades.POCO_s
{
	public class Entidad : IEntidad, IEntidadEspecial
	{
		private IAtaqueEstrategia? _estrategiaAtaque;
		public IAtaqueEstrategia? EstrategiaAtaque
		{
			get { return _estrategiaAtaque ??= new AtaqueNormal(); }
			set { _estrategiaAtaque = value; }
		}

		private IDefensaEstrategia? _estrategiaDefensa;
		public IDefensaEstrategia? EstrategiaDefensa
		{
			get { return _estrategiaDefensa ??= new DefensaNormal(); }
			set { _estrategiaDefensa = value; }
		}

		public Terreno? TerrenoActual { get; set; }
		public string? Nombre { get; set; }
		public IReino? Reino { get; set; }
		public IDieta? Dieta { get; set; }
		public IMedioAmbiente? MedioAmbiente { get; set; }
		public int EnergiaMaxima { get; set; }
		public int EnergiaActual { get; set; }
		public int VidaMaxima { get; set; }
		public int VidaActual { get; set; }
		public int IntensidadAtaque { get; set; }
		public int IntensidadDefensa { get; set; }
		public int Alcance { get; set; }
		public Posicion? Posicion { get; set; }


		public Entidad() { }

		public Entidad(
					string? nombre,
					IReino? reino,
					IDieta? dieta,
					IMedioAmbiente? medioAmbiente,
					int energiaMaxima,
					int energiaActual,
					int vidaMaxima,
					int vidaActual,
					int intensidadAtaque,
					int intensidadDefensa,
					int alcance
					)
		{
			Nombre = nombre;
			Reino = reino;
			Dieta = dieta;
			MedioAmbiente = medioAmbiente;
			EnergiaMaxima = energiaMaxima;
			EnergiaActual = energiaActual;
			VidaMaxima = vidaMaxima;
			VidaActual = vidaActual;
			IntensidadAtaque = intensidadAtaque;
			IntensidadDefensa = intensidadDefensa;
			Alcance = alcance;
		}

		public void CrearEntidad(Mapa mapa, string nombre, IReino reino, IDieta dieta, IMedioAmbiente medioAmbiente, int energiaMaxima, int vidaMaxima, int intensidadAtaque, int intensidadDefensa, int alcance)
		{
			// Lógica para crear una nueva entidad y colocarla en el mapa
			var nuevaEntidad = new Entidad(nombre, reino, dieta, medioAmbiente, energiaMaxima, energiaMaxima, vidaMaxima, vidaMaxima, intensidadAtaque, intensidadDefensa, alcance);
			mapa.AgregarEntidadEnPosicion(this.Posicion, nuevaEntidad);
		}

		public string ObtenerInformacion()
		{
			// Devolver información relevante de la entidad (nombre, posición, estado actual, etc.)
			return $"Entidad: {Nombre}, Posición: {Posicion}, Energía: {EnergiaActual}/{EnergiaMaxima}, Vida: {VidaActual}/{VidaMaxima}";
		}

		public void ActualizarInformacion(
							string nuevoNombre,
							int nuevaEnergiaMaxima,
							int nuevaVidaMaxima,
							int nuevaIntensidadAtaque,
							int nuevaIntensidadDefensa,
							int nuevoAlcance
							)
		{
			// Actualizar la información de la entidad con nuevos valores
			Nombre = nuevoNombre;
			EnergiaMaxima = nuevaEnergiaMaxima;
			VidaMaxima = nuevaVidaMaxima;
			IntensidadAtaque = nuevaIntensidadAtaque;
			IntensidadDefensa = nuevaIntensidadDefensa;
			Alcance = nuevoAlcance;
		}

		public void EliminarEntidad(Mapa mapa)
		{
			// Eliminar la entidad del mapa
			mapa.EliminarEntidadEnPosicion(this.Posicion);
		}
		public void Comer()
		{
			throw new NotImplementedException();
		}

		public void Descansar()
		{
			throw new NotImplementedException();
		}

		public void Morir()
		{
			throw new NotImplementedException();
		}

		public string ExpresarMensaje(string mensaje)
		{
			throw new NotImplementedException();
		}

		public void MoverseAtravesDe(string medio)
		{
			throw new NotImplementedException();
		}

		public void Interactuar()
		{
			throw new NotImplementedException();
		}

		public void SeleccionarAtaque(IAtaqueEstrategia estrategia)
		{
			throw new NotImplementedException();
		}

		public void RealizarAtaque(Entidad objetivo)
		{
			EstrategiaAtaque.RealizarAtaque(this, objetivo);
		}

		public void SeleccionarDefensa(IDefensaEstrategia estrategia)
		{
			throw new NotImplementedException();
		}

		public void RealizarDefensa()
		{
			EstrategiaDefensa.RealizarDefensa();
		}

		public void RealizarAccionEspecial()
		{
			throw new NotImplementedException();
		}

	}
}
