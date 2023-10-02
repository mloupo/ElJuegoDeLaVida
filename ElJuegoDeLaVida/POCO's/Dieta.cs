using EJDLV.Entidades.Interfaces;

namespace ElJuegoDeLaVida
{
	public abstract class Dieta : IDieta
	{
		public void Comer()
		{
			throw new NotImplementedException();
		}
	}

	public class Carnivoro : Dieta
	{

	}

	public class Herbivoro : Dieta
	{

	}

	public class EnergiaElectrica : Dieta
	{

	}

	public class EnergiaNuclear : Dieta
	{

	}

	public class EnergiaSolar : Dieta
	{

	}

	public class Fe : Dieta
	{

	}


}