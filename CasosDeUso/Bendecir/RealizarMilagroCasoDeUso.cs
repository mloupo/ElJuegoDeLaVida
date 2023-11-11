using EJDLV.Entidades.PersonajesEspeciales;
using EJDLV.Entidades.POCO_s;

namespace CasosDeUso.Bendecir
{
	public class RealizarMilagroCasoDeUso
	{
		public void RealizarMilagro(Jesus Jesus, Entidad entidad)
		{
			Jesus.Bendecir(entidad);
		}
	}
}