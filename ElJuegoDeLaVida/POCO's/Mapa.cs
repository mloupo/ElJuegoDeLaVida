using EJDLV.Entidades.POCO_s.Superficies;

namespace EJDLV.Entidades.POCO_s
{
	public class Mapa
	{
		private List<Terreno> terrenos;

		public Mapa(int tamano)
		{
			terrenos = new List<Terreno>();
			InicializarMapa(tamano);
		}

		private void InicializarMapa(int tamano)
		{
			for (int i = 0; i < tamano; i++)
			{
				for (int j = 0; j < tamano; j++)
				{
					var terreno = new Terreno($"Terreno_{i}_{j}", new Terrestre());
					terrenos.Add(terreno);
				}
			}
			// Resto de la lógica de inicialización si es necesario
		}

		public void AgregarEntidad(Entidad entidad, Posicion posicion)
		{
			// Lógica para agregar una entidad al tablero en una posición específica
			var terreno = ObtenerTerrenoEnPosicion(posicion);
			terreno?.AsignarEntidad(entidad);
		}

		public void AgregarObjeto(Objeto objeto, Posicion posicion)
		{
			// Lógica para agregar un objeto al tablero en una posición específica
			var terreno = ObtenerTerrenoEnPosicion(posicion);
			terreno?.AsignarObjeto(objeto);
		}

		private Terreno? ObtenerTerrenoEnPosicion(Posicion posicion)
		{
			// Lógica para obtener el terreno en una posición específica
			// (puedes adaptarla según la estructura de tu mapa)
			var index = posicion.X + posicion.Y * Math.Sqrt(terrenos.Count);
			if (index >= 0 && index < terrenos.Count)
			{
				return terrenos[(int)index];
			}
			return null;
		}

		// Otras funciones relacionadas con el tablero
	}
}


