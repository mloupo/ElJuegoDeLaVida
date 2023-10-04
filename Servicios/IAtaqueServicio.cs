using EJDLV.Entidades.POCO_s;
using System;
namespace Servicios
{
	public interface IAtaqueServicio
	{
		void Atacar(Entidad atacante, Entidad objetivo);
	}
}
