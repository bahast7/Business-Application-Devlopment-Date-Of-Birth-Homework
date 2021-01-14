using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Enter Your Age:");
string age = Console.In.ReadLine();
		int age1 = int.Parse(age);
		int result = 2021 - age1;
Console.WriteLine("Your Age Is: " + result);
	}
}
