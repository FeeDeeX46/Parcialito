using System;

namespace Parcialito
{

	public class ConGuitarraCriolla: ConGuitarra
	{
		override public void acomodarGuitarra()
		{
			Console.WriteLine("El guitarrista esta acomodando la guitarra criolla");
		}
		
		override public void revisarCuerdas()
		{
			Console.WriteLine("El guitarrista esta revisando las cuerdas de la guitarra criolla");
		}
		
		override public void afinarCuerdas()
		{
			Console.WriteLine("El guitarrista esta afinando las cuerdas de la guitarra criolla");
		}

		override public void leerPartitura()
		{
			Console.WriteLine("El guitarrista esta leyendo la partitura de la guitarra criolla");
		}

		override public void tocarInstrumento()
		{
			Console.WriteLine("El guitarrista esta tocando la guitarra criolla");
		}
	}
}
