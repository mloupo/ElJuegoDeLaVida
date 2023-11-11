using EJDLV.Entidades.POCO_s;

namespace CasosDeUso.Atacar
{
	public class AtacarEntidadCasoDeUso
	{
		public void Ejecutar(Entidad atacante, Entidad objetivo)
		{
			// Verificamos si el atacante y el objetivo están en el mismo medio ambiente
			if (atacante.MedioAmbiente == objetivo.MedioAmbiente)
			{
				// Calculamos el daño basado en la intensidad de ataque del atacante y la defensa del objetivo
				int danio = atacante.IntensidadAtaque - objetivo.IntensidadDefensa;

				// Verificamos si el daño es positivo (si no, no hay efecto)
				if (danio > 0)
				{
					// Aplicamos el daño al objetivo
					objetivo.VidaActual -= danio;

					// Verificamos si el objetivo ha muerto
					if (objetivo.VidaActual <= 0)
					{
						objetivo.Morir();
					}
				}
			}
		}
	}
}







