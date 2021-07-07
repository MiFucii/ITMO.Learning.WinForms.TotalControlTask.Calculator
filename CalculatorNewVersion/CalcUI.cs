using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Calculator;

namespace SimpleCalculator
{
	public partial class CalcUI : System.Windows.Forms.Form
	{

		// Output Display Constants.
		private const string oneOut = "1";
		private const string twoOut = "2";
		private const string threeOut = "3";
		private const string fourOut = "4";
		private const string fiveOut = "5";
		private const string sixOut = "6";
		private const string sevenOut = "7";
		private const string eightOut = "8";
		private const string nineOut = "9";
		private const string zeroOut = "0";

		public CalcUI()
		{
			InitializeComponent();

			//
			// Get version information from the Calculator Module.
			lblCurrentVersion.Text = CalcEngine.GetVersion();
			tbOutputDisplayDown.Text = "0";
			PrintDlegateFunc = new PrintQE(PrintTbQE);
		}

		private delegate string AsyncQE(double a, double b, double c);
		delegate void PrintQE(string str);
		private PrintQE PrintDlegateFunc;

		protected void KeyPlus_Click (object sender, System.EventArgs e)
		{
			tbOutputDisplayUp.Text = CalcEngine.CalcOperation (CalcEngine.Operator.eAdd);
			
		}

		protected void KeyMinus_Click (object sender, System.EventArgs e)
		{
			tbOutputDisplayUp.Text = CalcEngine.CalcOperation (CalcEngine.Operator.eSubtract);
		}

		protected void KeyMultiply_Click (object sender, System.EventArgs e)
		{
			tbOutputDisplayUp.Text = CalcEngine.CalcOperation (CalcEngine.Operator.eMultiply);
		}

		protected void KeyDivide_Click (object sender, System.EventArgs e)
		{
			tbOutputDisplayUp.Text = CalcEngine.CalcOperation (CalcEngine.Operator.eDivide);
		}
		private void btnExponentiation_Click(object sender, EventArgs e)
		{
			tbOutputDisplayUp.Text = CalcEngine.CalcOperation(CalcEngine.Operator.eExponentiation);
		}

		//
		// Other non-numeric key click methods.
		//

		protected void KeySign_Click (object sender, System.EventArgs e)
		{
			tbOutputDisplayDown.Text = CalcEngine.CalcSign();
		}

		protected void KeyPoint_Click (object sender, System.EventArgs e)
		{
			tbOutputDisplayDown.Text = CalcEngine.CalcDecimal();
		}

		protected void btnCurrentDate_Click(object sender, System.EventArgs e)
		{
			tbOutputDisplayUp.Text = CalcEngine.GetDate();
			CalcEngine.CalcReset();
		}

		protected void KeyClear_Click (object sender, System.EventArgs e)
		{
			CalcEngine.CalcReset();
			tbOutputDisplayDown.Text = "0";
			tbOutputDisplayUp.Text = "";
		}

		//
		// Perform the calculation.
		//

		protected void KeyEqual_Click (object sender, System.EventArgs e)
		{
			tbOutputDisplayUp.Text = "";
			tbOutputDisplayDown.Text = CalcEngine.CalcEqual();
			CalcEngine.CalcReset();
		}

		//
		// Numeric key click methods.
		//

		protected void KeyNine_Click (object sender, System.EventArgs e)
		{
			tbOutputDisplayDown.Text = CalcEngine.CalcNumber (nineOut);
		}

		protected void KeyEight_Click (object sender, System.EventArgs e)
		{
			tbOutputDisplayDown.Text = CalcEngine.CalcNumber (eightOut);
		}

		protected void KeySeven_Click (object sender, System.EventArgs e)
		{
			tbOutputDisplayDown.Text = CalcEngine.CalcNumber (sevenOut);
		}

		protected void KeySix_Click (object sender, System.EventArgs e)
		{
			tbOutputDisplayDown.Text = CalcEngine.CalcNumber (sixOut);
		}

		protected void KeyFive_Click (object sender, System.EventArgs e)
		{
			tbOutputDisplayDown.Text = CalcEngine.CalcNumber (fiveOut);
		}

		protected void KeyFour_Click (object sender, System.EventArgs e)
		{
			tbOutputDisplayDown.Text = CalcEngine.CalcNumber (fourOut);
		}

		protected void KeyThree_Click (object sender, System.EventArgs e)
		{
			tbOutputDisplayDown.Text = CalcEngine.CalcNumber (threeOut);
		}

		protected void KeyTwo_Click (object sender, System.EventArgs e)
		{
			tbOutputDisplayDown.Text = CalcEngine.CalcNumber (twoOut);
		}

		protected void KeyOne_Click (object sender, System.EventArgs e)
		{
			tbOutputDisplayDown.Text = CalcEngine.CalcNumber (oneOut);
		}

		protected void KeyZero_Click (object sender, System.EventArgs e)
		{
			tbOutputDisplayDown.Text = CalcEngine.CalcNumber (zeroOut);
		}

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new CalcUI());
		}

        private void btnEngineering_Click(object sender, EventArgs e)
        {
            this.Width = Width + 95;
			this.Height = Height + 95;
            pExstraKey.Visible = true;
			pQeResult.Visible = true;
            pSimplKey.Location = new Point(249, 94);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStandard_Click(object sender, EventArgs e)
        {
            this.Width = Width - 95;
			this.Height = Height - 95;
			pExstraKey.Visible = false;
			pQeResult.Visible = false;
            pSimplKey.Location = new Point(152, 94);
        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {
			tbOutputDisplayDown.Text = CalcEngine.Factorial(int.Parse(CalcEngine.displayNumber)).ToString();
			CalcEngine.CalcReset();
		}

        private void btnSquareNumber_Click(object sender, EventArgs e)
        {
			tbOutputDisplayDown.Text = CalcEngine.SquareNumber(double.Parse(CalcEngine.displayNumber)).ToString();
			CalcEngine.CalcReset();
		}

        private void btnSquareRoot_Click(object sender, EventArgs e)
        {
			tbOutputDisplayDown.Text = CalcEngine.SquareRoot(double.Parse(CalcEngine.displayNumber)).ToString();
			CalcEngine.CalcReset();
		}

        private void btnInverse_Click(object sender, EventArgs e)
        {
			tbOutputDisplayDown.Text = CalcEngine.InverseNumber(double.Parse(CalcEngine.displayNumber)).ToString();
			CalcEngine.CalcReset();
		}

        private void btnExtractingCubeRoot_Click(object sender, EventArgs e)
        {
			tbOutputDisplayDown.Text = CalcEngine.ExtractingCubeRoot(double.Parse(CalcEngine.displayNumber)).ToString();
			CalcEngine.CalcReset();
		}

        private void KeyClearEndSymbol_Click(object sender, EventArgs e)
        {
			tbOutputDisplayDown.Text = Calculator.CalcEngine.CalcNumberDelete();
        }

        private void CalcUI_KeyPress(object sender, KeyPressEventArgs e)
        {
			if(char.IsDigit(e.KeyChar))
            {
				tbOutputDisplayDown.Text = CalcEngine.CalcNumber(e.KeyChar.ToString());
            }
			switch(e.KeyChar)
            {
				case '+': tbOutputDisplayUp.Text = CalcEngine.CalcOperation(CalcEngine.Operator.eAdd); break;
				case '-': tbOutputDisplayUp.Text = CalcEngine.CalcOperation(CalcEngine.Operator.eSubtract);break;
				case '*': tbOutputDisplayUp.Text = CalcEngine.CalcOperation(CalcEngine.Operator.eMultiply); break;
				case '/': tbOutputDisplayUp.Text = CalcEngine.CalcOperation(CalcEngine.Operator.eMultiply); break;
				case '.': tbOutputDisplayDown.Text = CalcEngine.CalcDecimal(); break;
				case (char)Keys.Back: tbOutputDisplayDown.Text = Calculator.CalcEngine.CalcNumberDelete(); break;
			}
        }

		void PrintTbQE(string str)
		{
			tbQeResult.Text = str;

		}
		private void CallBackMethod(IAsyncResult ar)
		{
			string str;
			AsyncQE qeDelegate = (AsyncQE)ar.AsyncState;
			str = qeDelegate.EndInvoke(ar).ToString();
			tbOutputDisplayDown.Invoke(PrintDlegateFunc, new object[] { str });
		}

		private void btnQEForm_Click(object sender, EventArgs e)
        {
			QuadraticEquationForm qef = new QuadraticEquationForm();
			qef.ShowDialog();

			if(qef.DialogResult == DialogResult.OK)
            {
				AsyncQE qeDelegate = new AsyncQE(CalcEngine.QuadraticEquation);
				AsyncCallback cb = new AsyncCallback(CallBackMethod);
				qeDelegate.BeginInvoke(double.Parse(qef.a), double.Parse(qef.b), double.Parse(qef.c), cb, qeDelegate);
				//tbOutputDisplayDown.Text = CalcEngine.QuadraticEquation(double.Parse(qef.a), double.Parse(qef.b), double.Parse(qef.c));
			}
        }
    }
}
