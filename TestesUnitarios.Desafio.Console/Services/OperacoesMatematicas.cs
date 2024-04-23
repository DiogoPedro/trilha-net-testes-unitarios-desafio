using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesUnitarios.Desafio.Console.Services
{
	public class OperacoesMatematicas
	{
		public static int Fibonacci(int n)
		{
			return n <= 1 ? n : Fibonacci(n - 1) + Fibonacci(n - 2);
		}

		public static bool[] CrivodeEratostenes(int upperLimit)
		{
			bool[] number = new bool[upperLimit + 1];

			for (int i = 2; i <= upperLimit; i++)
			{
				number[i] = true;
			}

			for (int j = 2; j * j <= upperLimit; j++)
			{
				if (number[j] == true)
				{
					for (int i = j * j; i <= upperLimit; i += j)
					{
						number[i] = false;
					}
				}
			}
			return number;
		}
		public static int AlgoritmoEuclides(int a, int b)
		{
			while (b != 0)
			{
				int temp = b;
				b = a % b;
				a = temp;
			}
			return a;
		}

	}
}
