using System;

namespace EJDLV.ReglasNegocioDeLaAplicacion.CasosDeUso
{
	public class PerdonarCasoDeUso
	{
		public void Perdonar(IEntidadEspecial entidad)
		{
			entidad.RealizarAccionEspecial();
		}
	}
}