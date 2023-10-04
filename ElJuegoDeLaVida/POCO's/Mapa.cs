﻿using EJDLV.Entidades.POCO_s.EJDLV.Entidades.POCO_s;
using System;
using System.Collections.Generic;

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
				// add more "Terrenos" here



			};

			return terrenos;
		}

		private void DistribuirEntidades()
		{
			foreach (Terreno terreno in Terrenos)
			{
				// Aquí la lógica para asignar entidades a los terrenos
				// Ejemplo de asignar una entidad de prueba
				Entidad entidad = new ();
				terreno.AsignarEntidad(entidad);
			}
		}
	}
}

