using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica10
{
	class Program
	{
		static void Main(string[] args)
		{
			bool pregunta = true;
			int valor = 0;
			int sumatoria = 0;
			List<int> lista = new List<int>();

			Console.Clear();

			Console.WriteLine("10: Pide a usuario introducir numeros hasta que el numero sea cero luego imprime la sumatoria de estos.");
			Console.WriteLine();

			while (pregunta)
			{

				Console.Write("Ingrese valor: ");
				valor = int.Parse(Console.ReadLine());

				if (valor == 0)
				{
					Console.WriteLine("El valor introducido es cero (0), el programa Procederá a calcular la sumatoria de los valores introducidos.");
					Console.ReadKey();

					foreach (int valores in lista)
					{
						sumatoria = sumatoria + valores;
					}
					Console.WriteLine("El resultado de sumar los {0} valores es: {1}.", lista.Count, sumatoria);
					Console.ReadKey();


				}
				else
				{
					lista.Add(valor);
				}




				Console.ReadKey();
			}
		}
	}
}
