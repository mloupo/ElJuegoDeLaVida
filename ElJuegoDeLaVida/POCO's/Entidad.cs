using EJDLV.Entidades.Interfaces;
using EJDLV.Entidades.POCO_s.EJDLV.Entidades.POCO_s;

namespace EJDLV.Entidades.POCO_s
{
	public class Entidad : IEntidad, IEntidadEspecial

	{
		public IAtaqueEstrategia EstrategiaAtaque { get; set; }
		public Terreno TerrenoActual { get; set; }
		public string? Nombre { get; init; }
		public IReino? Reino { get; set; }
		public IDieta? Dieta { get; set; }
		public IMedioAmbiente? MedioAmbiente { get; set; }
		public int EnergiaMaxima { get; set; }
		public int EnergiaActual { get; set; }
		public int VidaMaxima { get; set; }
		public int VidaActual { get; set; }
		public int IntensidadAtaque { get; set; }
		public int IntensidadDefensa { get; set; }
		public int Alcance { get; set; }
		public Posicion Posicion { get; set; }


		public Entidad() { }

		public Entidad(
					string? nombre,
					IReino? reino,
					IDieta? dieta,
					IMedioAmbiente? medioAmbiente,
					int energiaMaxima,
					int energiaActual,
					int vidaMaxima,
					int vidaActual,
					int intensidadAtaque,
					int intensidadDefensa,
					int alcance
					)
		{
			Nombre = nombre;
			Reino = reino;
			Dieta = dieta;
			MedioAmbiente = medioAmbiente;
			EnergiaMaxima = energiaMaxima;
			EnergiaActual = energiaActual;
			VidaMaxima = vidaMaxima;
			VidaActual = vidaActual;
			IntensidadAtaque = intensidadAtaque;
			IntensidadDefensa = intensidadDefensa;
			Alcance = alcance;
		}

		public void Comer()
		{
			throw new NotImplementedException();
		}

		public void Descansar()
		{
			throw new NotImplementedException();
		}

		public void Morir()
		{
			throw new NotImplementedException();
		}

		public string ExpresarMensaje(string mensaje)
		{
			throw new NotImplementedException();
		}

		public void MoverseAtravesDe(string medio)
		{
			throw new NotImplementedException();
		}

		public void Interactuar()
		{
			throw new NotImplementedException();
		}


		public void Atacar(Entidad objetivo)
		{
			EstrategiaAtaque.RealizarAtaque(this, objetivo);
		}


		public void Defenderse()
		{
			throw new NotImplementedException();
		}

		public void RealizarAccionEspecial()
		{
			throw new NotImplementedException();
		}
	}
}
