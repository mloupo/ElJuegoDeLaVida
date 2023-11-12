using EJDLV.Entidades.Interfaces.Comportamiento;

namespace EJDLV.Entidades.POCO_s
{
	// En la clase Jugador
	public class Jugador : IJugador
	{
		public string Nombre { get; private set; }
		public int Puntos { get; set; }

		public Jugador(string nombre)
		{
			Nombre = nombre;
			Puntos = 0;
		}

		public void RealizarAcciones()
		{
			// Implementa las acciones específicas del jugador
		}

		public bool EsControladoPorIA()
		{
			// Implementa la lógica para determinar si el jugador es controlado por la IA
			// Puede depender de alguna propiedad específica del jugador.
			return false; // Por ahora, asumimos que no es controlado por la IA.
		}
	}
}
