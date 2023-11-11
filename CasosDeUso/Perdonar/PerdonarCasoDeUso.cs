using EJDLV.Entidades.Interfaces.Comportamiento;

namespace CasosDeUso.Perdonar
{
	public class PerdonarCasoDeUso
	{
		public void Perdonar(IEntidadEspecial entidad)
		{
			entidad.RealizarAccionEspecial();
		}
	}
}