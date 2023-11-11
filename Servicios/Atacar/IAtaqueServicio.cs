using EJDLV.Entidades.POCO_s;
namespace Servicios.Atacar
{
	public interface IAtaqueServicio
	{
		void Atacar(Entidad atacante, Entidad objetivo);
	}
}
