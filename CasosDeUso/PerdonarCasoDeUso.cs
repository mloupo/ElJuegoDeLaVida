using EJDLV.Entidades.Interfaces;
using System;

namespace CasosDeUso
{
	public class PerdonarCasoDeUso
	{
		public void Perdonar(IEntidadEspecial entidad)
		{
			entidad.RealizarAccionEspecial();
		}
	}
}