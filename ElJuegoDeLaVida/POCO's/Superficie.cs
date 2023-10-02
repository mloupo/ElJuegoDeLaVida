using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJDLV.Entidades.POCO_s
{
	namespace EJDLV.Entidades.POCO_s
	{
		public interface ISuperficie
		{
			// Aquí métodos comunes a ambas superficies.
		}

		public abstract class Superficie : ISuperficie
		{
			// Aquí propiedades comunes a ambas superficies.
		}

		public class Acuatica : ISuperficie
		{
			// Aquí comportamientos específicos para superficies acuáticas.
		}

		public class Terrestre : ISuperficie
		{
			// Aquí comportamientos específicos para superficies terrestres.
		}
	}

}
