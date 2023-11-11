namespace EJDLV.Entidades.PersonajesEspeciales
{
	public static class DirectorDeLaOrquesta
	{
		public static int TirarLosDados()
		{
			Random rnd = new();
			return rnd.Next(1, 7);
		}

		public static void IniciarJuego()
		{
			CrearMapa();
			CrearEntidades();
			CrearTerrenos();
		}

		private static void CrearMapa()
		{
			// Lógica para crear el mapa
		}

		private static void CrearEntidades()
		{
			// Lógica para crear las entidades
		}

		public static void CrearTerrenos()
		{
			// Lógica para crear los terrenos
		}

		public static void CrearObjetos()
		{
			// Lógica para crear los objetos
		}

		public static void RepartirEntidades()
		{
			// Lógica para repartir entidades
		}

		public static void RepartirTerrenos()
		{
			// Lógica para repartir terrenos
		}

		public static void RepartirObjetos()
		{
			// Lógica para repartir objetos
		}
	}
}
