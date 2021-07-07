using System;
using System.Runtime;
using System.Windows;
using System.Reflection;


namespace Calculator
{

	public class CalcEngine
	{
		//
		// Operation Constants.
		//
		public enum Operator:int
		{
			eUnknown = 0, eAdd = 1, eSubtract = 2, eMultiply = 3, eDivide = 4, eExponentiation = 5
		}

		//
		// Module-Level Constants
		//

		private static double negativeConverter = -1;
		// TODO: Upgrade the version number to 3.0.0.0
		private static string versionInfo = "Calculator v3.0.0.0";

		//
		// Module-level Variables.
		//
	
		private static double numericAnswer;
		private static string stringAnswer;
		public static string displayNumber => stringAnswer;
		private static Operator calcOperation;
		private static double firstNumber;
		private static double secondNumber;
		private static bool secondNumberAdded;
		private static bool decimalAdded;
 
		//
		// Class Constructor.
		//

		public CalcEngine ()
		{
			decimalAdded = false;
			secondNumberAdded = false;
		}

		//
		// Returns the custom version string to the caller.
		//

		public static string GetVersion ()
		{
			return (versionInfo);
		}
		//
		// Called when the Date key is pressed.
		//

		public static string GetDate ()
		{
			DateTime curDate = new DateTime();
			curDate = DateTime.Now;

			stringAnswer = String.Concat (curDate.ToShortDateString(), " ", curDate.ToLongTimeString());

			return (stringAnswer);
		}

		//
		// Called when a number key is pressed on the keypad.
		//

		public static string CalcNumber (string KeyNumber)
		{
			stringAnswer = string.Concat(stringAnswer, KeyNumber);
			return (stringAnswer);
		}
		public static string CalcNumberDelete()
        {
			if (stringAnswer != null) stringAnswer = stringAnswer.Remove(Convert.ToInt32(stringAnswer.Length - 1));
			else stringAnswer = "0";
            return stringAnswer;
		}

		//
		// Called when an operator is selected (+, -, *, /, n^x)
		//

		public static string CalcOperation (Operator calcOper)
		{
			string res;
			if (stringAnswer != "" && !secondNumberAdded)
			{
				firstNumber = double.Parse(stringAnswer);
				calcOperation = calcOper;
				stringAnswer = "";
				decimalAdded = false;
			}
			switch (calcOperation)
            {
				case Operator.eAdd: res = string.Concat(firstNumber," +"); break;
				case Operator.eSubtract: res = string.Concat(firstNumber, " -"); break;
				case Operator.eMultiply: res = string.Concat(firstNumber, " *"); break;
				case Operator.eDivide: res = string.Concat(firstNumber, " /"); break;
				case Operator.eExponentiation: res = string.Concat(firstNumber, "ⁿ"); break;
				default: res = ""; break;
			}
			return res;
		}

		//
		// Called when the +/- key is pressed.
		//

		public static string CalcSign ()
		{
			double numHold;

			if (stringAnswer != "")
			{
				numHold = System.Convert.ToDouble (stringAnswer);
				stringAnswer = System.Convert.ToString(numHold * negativeConverter);
			}
		
			return (stringAnswer);
		}

		//
		// Called when the . key is pressed.
		//

		public static string CalcDecimal ()
		{
			if (!decimalAdded && !secondNumberAdded)
			{
				if ((stringAnswer == "0") || (stringAnswer == "")) stringAnswer = "0,";
				else stringAnswer = string.Concat(stringAnswer, ',');


				decimalAdded = true;
			}

			return (stringAnswer);
		}

		//
		// Called when = is pressed.
		//

		public static string CalcEqual ()
		{
			bool validEquation = false;

			if (stringAnswer != "")
			{
				secondNumber = double.Parse(stringAnswer);
				secondNumberAdded = true;

				switch (calcOperation)
				{
					case Operator.eUnknown:
						validEquation = false;
						break;

					case Operator.eAdd:
						numericAnswer = firstNumber + secondNumber;
						validEquation = true;
						break;

					case Operator.eSubtract:
						numericAnswer = firstNumber - secondNumber;
						validEquation = true;
						break;

					case Operator.eMultiply:
						numericAnswer = firstNumber * secondNumber;
						validEquation = true;
						break;

					case Operator.eDivide:
						numericAnswer = firstNumber / secondNumber;
						validEquation = true;
						break;
					case Operator.eExponentiation:
						numericAnswer =  Math.Pow(firstNumber, secondNumber);
						validEquation = true;
						break;
					default:
						validEquation = false;
						break;
				}

				if (validEquation)
					stringAnswer = System.Convert.ToString (numericAnswer);
			}
			
			return (stringAnswer);
		}

		////Математический функции

		public static ulong Factorial(int x)
        {
			ulong answer = 1;
			checked
			{
				for (int i = 1; i <= x; i++)
				{
					answer *= (ulong)i;
				}
			}
			return answer;
		}

		public static double SquareRoot(double x)
        {
			return Math.Sqrt(x);
        }

		public static double SquareNumber(double x)
		{
			return Math.Pow(x, 2);
		}

		public static double ExtractingCubeRoot(double x)
        {
			
			return Math.Pow(x, 1.0/3.0);
		}

		public static double InverseNumber(double x)
		{
			return 1/x;
		}

		public static string QuadraticEquation(double a, double b, double c)
        {
			double d, x1, x2;
			string res;
			d = Math.Pow(b, 2) - 4 * a * c;
			if (d > -1)
			{
				if (d == 0)
				{
					x1 = (-b) / (2 * a);
					if (Convert.ToInt32(x1) == Convert.ToDouble(x1))
					{
						res = string.Concat("x = ", x1);
					}
					else res = string.Concat("x = ", x1 - x1 % 0.001);
					
				}
				else
				{
					string x1temp, x2temp;
					x1 = (-b + Math.Sqrt(d)) / (2 * a);					
					if (Convert.ToInt32(x1) == Convert.ToDouble(x1))
					{
						x1temp = string.Concat("x1 = ", x1);
					}
					else x1temp = string.Concat("x1 = ", x1 - x1 % 0.001);

					x2 = (-b - Math.Sqrt(d)) / (2 * a);
					if (Convert.ToInt32(x2) == Convert.ToDouble(x2))
					{
						x2temp = string.Concat("x2 = ", x2);
					}
					else x2temp = string.Concat("x2 = ", x2 - x2 % 0.001);

					//res = string.Concat("x1 = ", x1 - x1 % 0.001, ", x2 = ", x2 - x2 % 0.001);
					res = string.Concat(x1temp,", ", x2temp);
				}
			}
			else res = "Нет корней";
			System.Threading.Thread.Sleep(9000);
			return res;
		}

		//
		// Resets the various module-level variables for the next calculation.
		//

		public static void CalcReset ()
		{
			numericAnswer = 0;
			firstNumber = 0;
			secondNumber = 0;
			stringAnswer = "";
			calcOperation = Operator.eUnknown;
			decimalAdded = false;
			secondNumberAdded = false;			
		}
	}
}