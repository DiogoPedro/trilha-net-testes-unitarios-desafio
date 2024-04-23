using Xunit;
using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Testes
{
	public class OperacoesMatematicasTestes
	{
		[Theory]
		[InlineData(0, 0)]
		[InlineData(1, 1)]
		[InlineData(2, 1)]
		[InlineData(5, 5)]
		[InlineData(10, 55)]
		public void Fibonacci_DeveRetornarCorretamente(int n, int expected)
		{
			// Arrange
			// Criado pelo InlineData
			// Act
			int resultado = OperacoesMatematicas.Fibonacci(n);

			// Assert
			Assert.Equal(expected, resultado);
		}

		[Theory]
		[InlineData(10, 4)] // Até o número 10, há 4 primos (2, 3, 5, 7)
		[InlineData(20, 8)] // Até o número 20, há 8 primos (2, 3, 5, 7, 11, 13, 17, 19)
		public void CrivoDeEratostenes_DeveRetornarNumerosPrimosCorretamente(int limite, int esperado)
		{
			// Arrange

			// Act
			bool[] numerosPrimos = OperacoesMatematicas.CrivodeEratostenes(limite);
			int contadorPrimos = 0;
			for (int i = 2; i <= limite; i++)
			{
				if (numerosPrimos[i])
				{
					contadorPrimos++;
				}
			}

			// Assert
			Assert.Equal(esperado, contadorPrimos);
		}

		[Theory]
		[InlineData(10, 5, 5)] // MDC de 10 e 5 é 5
		[InlineData(15, 10, 5)] // MDC de 15 e 10 é 5
		[InlineData(36, 48, 12)] // MDC de 36 e 48 é 12
		public void AlgoritmoEuclides_DeveRetornarMDCCorretamente(int a, int b, int esperado)
		{
			// Arrange

			// Act
			int resultado = OperacoesMatematicas.AlgoritmoEuclides(a, b);

			// Assert
			Assert.Equal(esperado, resultado);
		}
	}
}
