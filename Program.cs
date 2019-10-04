using System;

namespace Parcialito
{
	class Program
	{
		public static void Main(string[] args)
		{	
			ConGuitarraCriolla guitarraCriolla = new ConGuitarraCriolla();
			ConGuitarraElectrica guitarraElectrica = new ConGuitarraElectrica();
			
			Guitarrista guitarrista = new Guitarrista(guitarraCriolla);
			
			guitarrista.ensayar();
			guitarrista.tocar();
			
			Console.ReadKey(true);
		}
	}
}
