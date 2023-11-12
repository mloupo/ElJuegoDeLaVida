using EJDLV.Entidades.Interfaces.Comportamiento;
using EJDLV.Entidades.Interfaces.Entidades;
using EJDLV.Entidades.POCO_s;

namespace EJDLV.Entidades.PersonajesEspeciales
{
	public class Jesus : IJesus
	{
		// Implementar logica de ataque especifica a Jesús
		public void Atacar(Entidad objetivo)
		{
			// Logica de ataque especifica a Jesús
		}
		public void Defenderse()
		{
			throw new NotImplementedException();
		}

		public void Comer()
		{
			// Jesús se alimenta de la "Fe"
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

		public void Perdonar(IEntidad entidad)
		{
			throw new NotImplementedException();
		}

		public void Redimir(IEntidad entidad)
		{
			throw new NotImplementedException();
		}

		public void Sanar(IEntidad entidad)
		{
			throw new NotImplementedException();
		}
		public void Bendecir(IEntidad entidad)
		{
			throw new NotImplementedException();
		}

		public void RealizarAccionEspecial()
		{
			throw new NotImplementedException();
		}


	}
}
