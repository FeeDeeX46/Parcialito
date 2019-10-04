using System;

namespace Parcialito
{

	public abstract class ConGuitarra
	{
		void ensayar()
		{
			acomodarGuitarra();
			revisarCuerdas();
			afinarCuerdas();
		}
		
		void tocar()
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
