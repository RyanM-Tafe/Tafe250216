using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Calculator
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class MortgageCalculator : Page
	{
		public MortgageCalculator()
		{
			this.InitializeComponent();
		}

		private void calculateButton_Click(object sender, RoutedEventArgs e)
		{
			try
			{


				double annualInterestRate = double.Parse(annualRateTextBox.Text) / 100;
				double principal = double.Parse(principalTextBox.Text);
				int years = int.Parse(yearsTextBox.Text);
				int months = int.Parse(monthsTextBox.Text);
				double monthlyInterestRate = annualInterestRate / 12.0;
				int numberOfPayments = years * 12 + months;

				double numerator = principal * Math.Pow(1 + monthlyInterestRate, numberOfPayments) * monthlyInterestRate;
				double denominator = Math.Pow(1 + monthlyInterestRate, numberOfPayments) - 1;
				double monthlyRepayment = numerator / denominator;


				monthlyInterestRate = monthlyInterestRate * 0.01;
				monthlyRateTextBox.Text = monthlyInterestRate.ToString();
				repaymentTextBox.Text = monthlyRepayment.ToString();


			}
			catch (Exception ex)
			{

				ContentDialog errorDialog = new ContentDialog()
				{
					Title = "Input Error",
					Content = "Please ensure all fields are filled with valid numbers.\n\n" + ex.Message,
					CloseButtonText = "OK"
				};
				_ = errorDialog.ShowAsync();
			}

		}

		private void exitButton_Click(object sender, RoutedEventArgs e)
		{
			Frame.Navigate(typeof(MainMenu));
		}
	}
}
