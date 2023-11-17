namespace EJDLV.Entidades.Interfaces.Comportamiento
{
	public interface IEntidadEspecial
	{
		string ExpresarMensaje(string mensaje);
		void MoverseAtravesDe(string medio); // el medio por el que pasa serìa un terreno
		void Interactuar();
		void RealizarAccionEspecial();
	}
}
