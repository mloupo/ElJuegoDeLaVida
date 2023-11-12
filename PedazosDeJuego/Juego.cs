namespace PedazosDeJuego
{
	public class Juego
	{
		private MapaCosmico tablero;

		public Juego(int tamanoTablero)
		{
			tablero = new MapaCosmico(tamanoTablero);
		}

		public void Iniciar()
		{
			// Lógica de inicio del juego
			// Podemos establecer las entidades iniciales, configuraciones, etc.
		}

		public void JugarTurno()
		{
			// Lógica para gestionar un turno de juego
			// Puede implicar movimientos, interacciones, eventos cósmicos, etc.
		}
	}
}