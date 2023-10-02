using EJDLV.Entidades.Interfaces;
using EJDLV.Entidades.POCO_s;
using System;

namespace EJDLV.Entidades.Personajes
{
	public class Jesus : IJesus
	{
		public void Atacar()
		{
			throw new NotImplementedException();
		}

		public void Atacar(Entidad objetivo)
		{
			throw new NotImplementedException();
		}

		public void Bendecir(IEntidad entidad)
		{
			throw new NotImplementedException();
		}

		public void Comer()
		{
			// Jesus se alimenta de la "Fe"
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
	}
}
