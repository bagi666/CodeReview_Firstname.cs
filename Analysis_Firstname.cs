using System;

using static System.Math;

namespace Interview

{

	public class Analysis

	{

		public double GetRandomNumber1()

		{

			Random random = new Random();
			// Round() - Округляет значение до ближайшего целого или указанного количества десятичных знаков.			
			// Random.NextDouble() - Возвращает случайное число с плавающей запятой, которое больше или равно 0,0 и меньше 1,0.
			return Round((random.NextDouble() - 0.5) * 2);

		}

		public double GetRandomNumber2()

		{

			Random random = new Random();

			return Round((random.NextDouble() - 0.5) * 2.99);

		}

	}

}

class MainAnalysis {

	public static void Main() {

		Interview.Analysis A = new Interview.Analysis();
		Console.WriteLine("{0}", A.GetRandomNumber1());
		Console.WriteLine("\n{0}", A.GetRandomNumber2());
		
	}

}
