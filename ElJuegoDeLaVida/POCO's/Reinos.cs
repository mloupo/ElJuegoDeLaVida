using EJDLV.Entidades.Interfaces.MedioAmbiente;

namespace EJDLV.Entidades.POCO_s
{
	public class Reino : IReino
	{
		public string ObtenerNombreReino()
		{
			return this.GetType().Name;
		}
	}

	public class Animal : Reino
	{

	}

	public class Vegetal : Reino
	{

	}

	public class Mitologico : Reino
	{

	}

	public class Humano : Animal
	{

	}

	public class DeDiosTodoPoderoso
	{

	}

	public class DelInfierno
	{

	}

	public class DeLasMaquinas
	{

	}
}
