using EJDLV.Entidades.Interfaces;
using EJDLV.Entidades.POCO_s;

namespace EJDLV.Entidades.Personajes
{
	public class Lucifer : ILucifer
	{
		public void Comer()
		{
			// Lucifer se alimenta de la vida total de las demas entidades cuando las mata
		}

		public void Defenderse()
		{
			throw new NotImplementedException();
		}

		public string ExpresarMensaje(string mensaje)
		{
			throw new NotImplementedException();
		}

		public void Interactuar()
		{
			throw new NotImplementedException();
		}

		public void MoverseAtravesDe(string medio)
		{
			throw new NotImplementedException();
		}
		public void Tentar(IEntidad entidad)
		{
			// Implementación de la tentación
		}
		public void Maldicion(IEntidad entidad)
		{
			// Implementación de la habilidad de maldición
		}

		public void Atacar(Entidad objetivo)
		{
			throw new NotImplementedException();
		}
	}
}