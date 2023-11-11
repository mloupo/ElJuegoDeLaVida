using EJDLV.Entidades.POCO_s;

namespace EJDLV.Entidades.Interfaces.Comportamiento
{
	public interface IAtaqueEstrategia
	{
		void RealizarAtaque(Entidad atacante, Entidad objetivo);
	}
}
