using EJDLV.Entidades.Interfaces.Comportamiento;

namespace EJDLV.Entidades.POCO_s
{
	public class Jugador : IJugador, IAccionJugador
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

		// Método para verificar si el jugador está controlado por IA
		public bool EsControladoPorIA()
		{
			// Lógica para determinar si el jugador está controlado por IA
			// Puedes implementar esto según tus necesidades
			return false;
		}

		// Ejemplo de implementación del método Ejecutar de la interfaz IAccionJugador
		public void Ejecutar(IJugador jugador)
		{
			Console.WriteLine($"{Nombre} está ejecutando una acción");
		}

		// Ejemplo de implementación del método MoverEntidad
		public void MoverEntidad(Entidad entidad, Terreno destino)
		{
			// Lógica para mover una entidad a un terreno limítrofe
			// Puedes implementar esto según tus necesidades
			Console.WriteLine($"{Nombre} está moviendo la entidad {entidad.Nombre} a un nuevo terreno");
		}

		// Ejemplo de implementación del método Atacar
		public void Atacar(Entidad atacante, Entidad objetivo)
		{
			// Lógica para que una entidad ataque a otra
			// Puedes implementar esto según tus necesidades
			Console.WriteLine($"{Nombre} está atacando a {objetivo.Nombre} con {atacante.Nombre}");
		}

		// Ejemplo de implementación del método Comer
		public void Comer(Entidad entidad, IInteractuable comida)
		{
			// Lógica para que una entidad coma
			// Puedes implementar esto según tus necesidades
			Console.WriteLine($"{Nombre} está comiendo {comida.Nombre} con {entidad.Nombre}");
		}
	}
}
