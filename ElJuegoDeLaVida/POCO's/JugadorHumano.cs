using EJDLV.Entidades.Interfaces.Comportamiento;

namespace EJDLV.Entidades.POCO_s
{
	public class JugadorHumano : IJugador
	{
		public string Nombre { get; private set; }
		public int Puntos { get; set; }

		// Constructor para inicializar el jugador con un nombre
		public JugadorHumano(string nombre)
		{
			Nombre = nombre;
			Puntos = 0;
		}

		public void RealizarAcciones()
		{
			// Implementa las acciones específicas del jugador humano
		}
	}
}
