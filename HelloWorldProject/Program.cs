using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldProject {
	class Program {
		// properties (variables) go first
		static int Age;
		// methods (functions) go last
		static void Main(string[] args) {
			System.Console.WriteLine("Hello, world!");
			Age = 0;
			Console.WriteLine(Age);
			int Counter = 1;
			Console.WriteLine("Value of counter is " + Counter);
			int numerator = 5;
			int denominator = 2;
			Console.WriteLine(numerator + " / " + denominator + " = " + numerator / denominator);
			var aLong = 0L; // initialize a long variable type
			double pi = 3.1419;
			double r = 1.0;
			double two = 2.0;
			double answer;
			answer = two * pi * r;
			Console.WriteLine(answer);
			var a = 3;
			var b = 4;
			//b = null;

			var c = Math.Sqrt(a * a + b * b);
			Console.WriteLine("c equals " + c);

			string s = "This is a string";
			Console.WriteLine(s);
			var sUppercase = s.ToUpper();
			Console.WriteLine(sUppercase);
			var sLowercase = sUppercase.ToLower();
			Console.WriteLine(sLowercase);

			var FirstName = "Greg";
			var LastName = "Doud";
			var FullName = FirstName + " " + LastName;
			Console.WriteLine("Full name is " + FullName);
			string aNullValue = null;

			string ANewFullName = $"{FirstName} {LastName}";
			Console.WriteLine(ANewFullName);
			string AreaCode = "513";
			string Exchange = "555";
			string Number = "1212";
			string Phone = $"({AreaCode}){Exchange}-{Number}";
			Console.WriteLine(Phone);

			var message = $"{FirstName} {LastName} phone number is {AreaCode}-{Exchange}-{Number}";
			Console.WriteLine(message);

			// booleans
			bool TrueValue = true; // or false;
			bool HasBlondHair = false;
			Console.WriteLine($"The value of the TrueValue variable is {TrueValue}");
		}
	}
}
