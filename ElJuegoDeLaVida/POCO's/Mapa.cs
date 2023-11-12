using EJDLV.Entidades.POCO_s.Superficies;

namespace EJDLV.Entidades.POCO_s
{
	public class Mapa
	{
		public List<Terreno>? Terrenos { get; set; }

		public void InicializarMapa()
		{
			List<Terreno> terrenos = ObtenerListaTerrenos();

			if (terrenos.Count > 0)
			{
				Terrenos = terrenos;
				DistribuirEntidades();
				// Otros procesos de inicialización si los hay
			}
		}

		private static List<Terreno> ObtenerListaTerrenos()
		{
			List<Terreno> terrenos = new()
			{
				// Agregar terrenos a la lista
				new Terreno("Terreno1", new Terrestre()),
				new Terreno("Terreno2", new Acuatica())
			};
			return terrenos;
		}

		private void DistribuirEntidades()
		{
			foreach (Terreno terreno in Terrenos)
			{
				// Aca va la lógica para asignar entidades a los terrenos
				// Ejemplo asignar una entidad de prueba
				Entidad entidad = new();
				terreno.AsignarEntidad(entidad);
			}
		}
	}
}


