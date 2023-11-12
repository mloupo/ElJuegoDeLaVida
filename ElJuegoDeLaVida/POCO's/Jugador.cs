using EJDLV.Entidades.Interfaces.Comportamiento;

namespace EJDLV.Entidades.POCO_s
{
	public class Jugador : IJugador
	{
		public string Nombre { get; private set; }
		public int Puntos { get; set; }

		// Lista de acciones disponibles para el jugador
		private List<IAccionJugador> acciones;

		// Constructor para inicializar el jugador con un nombre
		public Jugador(string nombre)
		{
			Nombre = nombre;
			Puntos = 0;
			acciones = new List<IAccionJugador>();
		}

		// Método para realizar acciones del jugador
		public void RealizarAcciones()
		{
			foreach (var accion in acciones)
			{
				accion.Ejecutar(this);
			}
		}

		// Método para agregar nuevas acciones al jugador
		public void AgregarAccion(IAccionJugador nuevaAccion)
		{
			acciones.Add(nuevaAccion);
		}

		public bool EsControladoPorIA()
		{
			throw new NotImplementedException();
		}
	}
}
