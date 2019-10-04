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
			guitarra.ensayar();
			
		}
		
		public void tocar()
		{
			guitarra.tocar();			
		}
	}
}
