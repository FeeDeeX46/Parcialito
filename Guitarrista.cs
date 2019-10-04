using System;

namespace Parcialito
{

	public class Guitarrista
	{
		protected ConGuitarra guitarra;
		
		public Guitarrista(ConGuitarra guitarra)
		{
			this.guitarra = guitarra;
		}		
		
		public void ensayar()
		{
			guitarra.acomodarGuitarra();
			guitarra.revisarCuerdas();
			guitarra.afinarCuerdas();
		}
		
		public void tocar()
		{
			guitarra.leerPartitura();
			guitarra.tocarInstrumento();			
		}
	}
}
