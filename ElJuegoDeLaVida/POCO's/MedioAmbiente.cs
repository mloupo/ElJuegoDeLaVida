using EJDLV.Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJDLV.Entidades.POCO_s
{
	public abstract class MedioAmbiente : IMedioAmbiente
	{
		public void MoverseAtravesDe(string medio)
		{
			throw new NotImplementedException();
		}
	}

	public class  Agua
    {
        
    }

    public class Tierra
    {

	}

    public class Aire
    {

	}

    public class OmniPresencia
    {

    }
}
