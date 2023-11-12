using EJDLV.Entidades.POCO_s;

namespace EJDLV.Entidades.PersonajesEspeciales
{
	public static class DirectorDeLaOrquesta
	{
		private static readonly Random rnd = new Random();
		private static MapaCosmico mapaCosmico;

		public static int TirarLosDados() => rnd.Next(1, 7);

		public static void IniciarJuego()
		{
			mapaCosmico = CrearMapa();
			CrearEntidades();
			CrearTerrenos();
			CrearObjetos();
			RepartirEntidades();
			RepartirTerrenos();
			RepartirObjetos();
			IniciarTableroCosmico();
		}

		private static MapaCosmico CrearMapa()
		{
			return new MapaCosmico(10);
		}

		private static void CrearEntidades() { /* Lógica para crear entidades */ }

		private static void CrearTerrenos() { /* Lógica para crear terrenos */ }

		private static void CrearObjetos() { /* Lógica para crear objetos */ }

		private static void IniciarTableroCosmico()
		{
			mapaCosmico?.Iniciar();
		}

		private static void RepartirEntidades() { /* Lógica para repartir entidades */ }

		private static void RepartirTerrenos() { /* Lógica para repartir terrenos */ }

		private static void RepartirObjetos() { /* Lógica para repartir objetos */ }
	}

}
