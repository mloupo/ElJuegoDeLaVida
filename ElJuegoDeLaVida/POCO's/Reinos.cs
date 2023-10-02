using EJDLV.Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJDLV.Entidades.POCO_s
{
	public class Reino : IReino
	{
		public string ObtenerNombreReino()
		{
			throw new NotImplementedException();
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
