namespace EJDLV.Entidades.POCO_s
{
	public class MapaCosmico
	{
		private Terreno[,] terrenos;

		public MapaCosmico(int tamano)
		{
			terrenos = new Terreno[tamano, tamano];
			// Inicializar el tablero, asignar superficies, etc.
		}

		public void AgregarEntidad(Entidad entidad, Posicion posicion)
		{
			// Lógica para agregar una entidad al tablero en una posición específica
			if (PosicionEsValida(posicion) && terrenos[posicion.X, posicion.Y].Entidad == null)
			{
				terrenos[posicion.X, posicion.Y].Entidad = entidad;
				entidad.Posicion = posicion;
			}
			// Manejar casos no válidos o lanzar excepciones según sea necesario
		}
		private bool PosicionEsValida(Posicion posicion)
		{
			// Lógica para verificar si la posición está dentro de los límites del tablero
			return posicion.X >= 0 && posicion.X < terrenos.GetLength(0) &&
				   posicion.Y >= 0 && posicion.Y < terrenos.GetLength(1);
		}


		// Otras funciones relacionadas con el tablero
		public void Iniciar()
		{
			// Lógica de inicio del juego para el tablero
		}
	}
}