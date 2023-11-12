using EJDLV.Entidades.Interfaces.Comportamiento;

namespace EJDLV.Entidades.POCO_s
{
	public class Turno
	{
		private readonly List<IJugador> jugadores;
		private int indiceJugadorActual;

		public Turno(List<IJugador> jugadores)
		{
			this.jugadores = jugadores ?? throw new ArgumentNullException(nameof(jugadores));
			indiceJugadorActual = 0;
		}

		public IJugador JugadorActual => jugadores[indiceJugadorActual];

		public void AvanzarTurno()
		{
			indiceJugadorActual = (indiceJugadorActual + 1) % jugadores.Count;
		}

		public void RealizarAcciones()
		{
			if (JugadorActual.EsControladoPorIA())
			{
				// Lógica específica para jugador controlado por la IA (COM).
				// Puedes usar una estrategia aquí.
			}
			else
			{
				// Lógica para que el jugador actual realice sus acciones.
				// Puedes llamar a métodos específicos de Jugador o realizar otras acciones del juego.
			}
		}
	}
}
