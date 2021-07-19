using System;

public class C_Sharp_FizzBuzz
{
	static string DivisibleByNumber(int Number, int Division, string Add, string Output)
	{
		if (Number % Division == 0)
		{
			return (Output += Add);
		}
		else
		{
			return Output;
		}
	}

	public static void Main(String[] args)
	{
		Console.WriteLine("Enter the number you want FizzBuzz to go up to from 1");
		int Number = Convert.ToInt32(Console.ReadLine());
		for (int x = 1; x <= Number; ++x)
		{
			string output = "";

			output = DivisibleByNumber(x, 3, "Fizz", output);
			output = DivisibleByNumber(x, 5, "Buzz", output);

			if (output == "")
			{
				output = Convert.ToString(x);
			}

			Console.Write(x);
			Console.Write(": ");
			Console.WriteLine(output);
		}
		Console.WriteLine("Press enter to close");
		Console.ReadLine();
	}
}