using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJDLV.Entidades.POCO_s
{
	public abstract class Objeto : IObjeto
	{
		public void interactuar()
		{
			throw new NotImplementedException();
		}
	}

	public interface IObjeto
	{
		public void interactuar();
	}

	public class PalabraDeDios : IObjeto
	{
		public void interactuar()
		{
			throw new NotImplementedException();
		}
	}
}
