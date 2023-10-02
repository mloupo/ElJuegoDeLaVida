using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJDLV.Entidades.POCO_s
{
	public static class DirectorDeLaOrquesta
	{
		public static int TirarLosDados()
		{
			Random rnd = new ();
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

		public static void RepartirObjetos()
		{
			// Lógica para repartir objetos
		}
	}

}
