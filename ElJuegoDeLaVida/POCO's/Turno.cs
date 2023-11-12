namespace EJDLV.Entidades.POCO_s
{
	public class Turno
	{
		private readonly List<Jugador> jugadores;
		private int indiceJugadorActual;

		public Turno(List<Jugador> jugadores)
		{
			this.jugadores = jugadores ?? throw new ArgumentNullException(nameof(jugadores));
			indiceJugadorActual = 0;
		}

		public Jugador JugadorActual => jugadores[indiceJugadorActual];

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
