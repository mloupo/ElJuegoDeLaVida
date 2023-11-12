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

		// objeto podria 
	}
}
