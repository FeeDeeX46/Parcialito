using System;

namespace Parcialito
{

	public abstract class ConGuitarra
	{
		public void ensayar()
		{
			acomodarGuitarra();
			revisarCuerdas();
			afinarCuerdas();
		}
		
		public void tocar()
		{
			leerPartitura();
			tocarInstrumento();
		}
		
		public abstract void acomodarGuitarra();
		public abstract void revisarCuerdas();
		public abstract void afinarCuerdas();
		public abstract void leerPartitura();
		public abstract void tocarInstrumento();
	}
}
