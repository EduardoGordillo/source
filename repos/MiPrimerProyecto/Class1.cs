using System;

public class Class1
{
	public Class1()
	{
		int a = 3;
		int b = 8;
		int c = 6;

		bool d = a > b;
		bool e = b < c;
		bool f = (c + 3) > a;

		bool op1 = d && e;
		bool op2 = f && e;
		bool op3 = (d || f) && (!e || f);
		Console.WriteLine("Op1: " + op1);
		Console.WriteLine("Op2: " + op2);
		Console.WriteLine("Op3: " + op3);
	}
}
