/*========================================================================
Estruturas de Repetição em C#
Desenvolvedor: Geovane Jorge

SPRINT:S5.PI2-22 - US193417 
==========================================================================*/



using System;

namespace Poo
{
	class Program
	{
		static void Main(string[] args)
		{
			/*========================================================================
			//Estrutura for
			int numero = 5;
			for (int contador = 0; contador <= 10; contador ++)
			{
				Console.WriteLine($"{numero} x {contador}= {numero * contador}");
			}
			==========================================================================*/
			///*=========================================================================
			 //	Estrutura WHILE

			int numero = 5;
			int contador = 1;
			while (contador <= 10)
			{
				Console.WriteLine($" {contador}º Execução: {numero} x {contador} = {numero * contador}");
				contador++;


				if (contador == 6)
				{
					break;
				}
			}

			//============================================================================*/


		}

	}
}

