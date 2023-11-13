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
					var terreno = new Terreno($"Terreno_{i}_{j}", new Terrestre()); // Aca crear metodo que cree terrenos con superficies aleatorias
					terrenos.Add(terreno);
				}
			}
			// Resto de la lógica de inicialización si es necesario
		}

		public void AgregarEntidadEnPosicion(Posicion posicion, Entidad entidad)
		{
			if (PosicionEsValida(posicion) && ObtenerTerrenoEnPosicion(posicion).Entidades == null)
			{
				ObtenerTerrenoEnPosicion(posicion).AsignarEntidad(entidad);
				entidad.Posicion = posicion;
			}
			else
			{
				Console.WriteLine("No se puede agregar la entidad en la posición especificada.");
			}
		}

		public void EliminarEntidadEnPosicion(Posicion posicion)
		{
			if (PosicionEsValida(posicion))
			{
				var terreno = ObtenerTerrenoEnPosicion(posicion);
				if (terreno.Entidades != null && terreno.Entidades.Count > 0)
				{
					var entidadAEliminar = terreno.Entidades[0]; // Suponemos que solo hay una entidad en esa posición
					terreno.Entidades = null;
					entidadAEliminar.Posicion = null; // Set the Posicion property to null
				}
				else
				{
					Console.WriteLine("No hay entidad para eliminar en la posición especificada.");
				}
			}
			else
			{
				Console.WriteLine("Posición no válida.");
			}
		}


		private bool PosicionEsValida(Posicion posicion)
		{
			int tamanoMapa = (int)Math.Sqrt(terrenos.Count);
			return posicion.X >= 0 && posicion.X < tamanoMapa &&
				   posicion.Y >= 0 && posicion.Y < tamanoMapa;
		}


		public void AgregarEntidad(Entidad entidad, Posicion posicion)
		{
			var terreno = ObtenerTerrenoEnPosicion(posicion);
			terreno?.AsignarEntidad(entidad);
		}

		public void AgregarObjeto(Objeto objeto, Posicion posicion)
		{
			var terreno = ObtenerTerrenoEnPosicion(posicion);
			terreno?.AsignarObjeto(objeto);
		}

		private Terreno ObtenerTerrenoEnPosicion(Posicion posicion)
		{
			var index = posicion.X + posicion.Y * Math.Sqrt(terrenos.Count);
			if (index >= 0 && index < terrenos.Count)
			{
				return terrenos[(int)index];
			}
			return null;
		}
	}
}


