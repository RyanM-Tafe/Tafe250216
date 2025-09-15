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
	public sealed partial class CurrancyConverter : Page
	{
		public CurrancyConverter()
		{
			this.InitializeComponent();
		}

		private void calculateButton_Click(object sender, RoutedEventArgs e)
		{
			if (fromCurrency.SelectedIndex == 0 && toCurrency.SelectedIndex == 1 && !amount.Text.Equals(""))
			{
				try
				{
					double value = double.Parse(amount.Text);
					double result = value * 0.85189982;
					inputAmount.Text = amount.Text + " US Dollars";
					outputResult.Text = "€" + result.ToString() + " Euros";
					outputFrom.Text = "1 USD = 0.85189982 Euros";
					outputTo.Text = "1 Euro = 1.1739732 USD";
				} catch
				{
					Console.WriteLine($"Unable to parse '{amount.Text}'");
					amount.Text = "";
					inputAmount.Text = "";
					outputResult.Text = "";
					outputFrom.Text = "";
					outputTo.Text = "";
				}
			}
			else if (fromCurrency.SelectedIndex == 0 && toCurrency.SelectedIndex == 2 && !amount.Text.Equals(""))
			{
				try
				{
					double value = double.Parse(amount.Text);
					double result = value * 0.72872436;
					inputAmount.Text = amount.Text + " US Dollars";
					outputResult.Text = "£" + result.ToString() + " British Pound";
					outputFrom.Text = "1 USD = 0.72872436 British Pound";
					outputTo.Text = "1 British Pound = 1.371907 USD";
				}
				catch
				{
					Console.WriteLine($"Unable to parse '{amount.Text}'");
					amount.Text = "";
					inputAmount.Text = "";
					outputResult.Text = "";
					outputFrom.Text = "";
					outputTo.Text = "";
				}
			}
			else if (fromCurrency.SelectedIndex == 0 && toCurrency.SelectedIndex == 3 && !amount.Text.Equals(""))
			{
				try
				{
					double value = double.Parse(amount.Text);
					double result = value * 74.257327;
					inputAmount.Text = amount.Text + " US Dollars";
					outputResult.Text = "₹" + result.ToString() + " Indian Rupee";
					outputFrom.Text = "1 USD = 74.257327 Indian Rupee";
					outputTo.Text = "1 Indian Rupee = 0.011492628 USD";
				}
				catch
				{
					Console.WriteLine($"Unable to parse '{amount.Text}'");
					amount.Text = "";
					inputAmount.Text = "";
					outputResult.Text = "";
					outputFrom.Text = "";
					outputTo.Text = "";
				}
			}




			else if (fromCurrency.SelectedIndex == 1 && toCurrency.SelectedIndex == 0 && !amount.Text.Equals(""))
			{
				try
				{
					double value = double.Parse(amount.Text);
					double result = value * 1.1739732;
					inputAmount.Text = amount.Text + " Euros";
					outputResult.Text = "$" + result.ToString() + " USD";
					outputFrom.Text = "1 Euro = 1.1739732 USD";
					outputTo.Text = "1 USD = 0.85189982 Euros";
				}
				catch
				{
					Console.WriteLine($"Unable to parse '{amount.Text}'");
					amount.Text = "";
					inputAmount.Text = "";
					outputResult.Text = "";
					outputFrom.Text = "";
					outputTo.Text = "";
				}
			}
			else if (fromCurrency.SelectedIndex == 1 && toCurrency.SelectedIndex == 2 && !amount.Text.Equals(""))
			{
				try
				{
					double value = double.Parse(amount.Text);
					double result = value * 0.8556672;
					inputAmount.Text = amount.Text + " Euros";
					outputResult.Text = "£" + result.ToString() + " British Pound";
					outputFrom.Text = "1 Euro = 0.8556672 British Pound";
					outputTo.Text = "1 British Pound = 1.1686692 Euros";
				}
				catch
				{
					Console.WriteLine($"Unable to parse '{amount.Text}'");
					amount.Text = "";
					inputAmount.Text = "";
					outputResult.Text = "";
					outputFrom.Text = "";
					outputTo.Text = "";
				}
			}
			else if (fromCurrency.SelectedIndex == 1 && toCurrency.SelectedIndex == 3 && !amount.Text.Equals(""))
			{
				try
				{
					double value = double.Parse(amount.Text);
					double result = value * 87.00755;
					inputAmount.Text = amount.Text + " Euros";
					outputResult.Text = "₹" + result.ToString() + " Indian Rupee";
					outputFrom.Text = "1 Euros = 87.00755 Indian Rupee";
					outputTo.Text = "1 Indian Rupee = 0.013492774 Euros";
				}
				catch
				{
					Console.WriteLine($"Unable to parse '{amount.Text}'");
					amount.Text = "";
					inputAmount.Text = "";
					outputResult.Text = "";
					outputFrom.Text = "";
					outputTo.Text = "";
				}
			}





			else if (fromCurrency.SelectedIndex == 2 && toCurrency.SelectedIndex == 0 && !amount.Text.Equals(""))
			{
				try
				{
					double value = double.Parse(amount.Text);
					double result = value * 1.371907;
					inputAmount.Text = amount.Text + " Britsh Pound";
					outputResult.Text = "$" + result.ToString() + " USD";
					outputFrom.Text = "1 Britsh Pound = 1.371907 USD";
					outputTo.Text = "1 USD = 0.72872436 Britsh Pounds";
				}
				catch
				{
					Console.WriteLine($"Unable to parse '{amount.Text}'");
					amount.Text = "";
					inputAmount.Text = "";
					outputResult.Text = "";
					outputFrom.Text = "";
					outputTo.Text = "";
				}
			}
			else if (fromCurrency.SelectedIndex == 2 && toCurrency.SelectedIndex == 1 && !amount.Text.Equals(""))
			{
				try
				{
					double value = double.Parse(amount.Text);
					double result = value * 1.1686692;
					inputAmount.Text = amount.Text + " Britsh Pound";
					outputResult.Text = "€" + result.ToString() + " Euro";
					outputFrom.Text = "1 Britsh Pound = 1.1686692 Euros";
					outputTo.Text = "1 Euro = 0.8556672 Britsh Pounds";
				}
				catch
				{
					Console.WriteLine($"Unable to parse '{amount.Text}'");
					amount.Text = "";
					inputAmount.Text = "";
					outputResult.Text = "";
					outputFrom.Text = "";
					outputTo.Text = "";
				}
			}
			else if (fromCurrency.SelectedIndex == 2 && toCurrency.SelectedIndex == 3 && !amount.Text.Equals(""))
			{
				try
				{
					double value = double.Parse(amount.Text);
					double result = value * 101.68635;
					inputAmount.Text = amount.Text + " Britsh Pound";
					outputResult.Text = "₹" + result.ToString() + " Indian Rupee";
					outputFrom.Text = "1 Britsh Pound = 101.68635 Indian Rupee";
					outputTo.Text = "1 Indian Rupee = 0.0098339397 Britsh Pounds";
				}
				catch
				{
					Console.WriteLine($"Unable to parse '{amount.Text}'");
					amount.Text = "";
					inputAmount.Text = "";
					outputResult.Text = "";
					outputFrom.Text = "";
					outputTo.Text = "";
				}
			}






			else if (fromCurrency.SelectedIndex == 3 && toCurrency.SelectedIndex == 0 && !amount.Text.Equals(""))
			{
				try
				{
					double value = double.Parse(amount.Text);
					double result = value * 0.011492628;
					inputAmount.Text = amount.Text + " Indian Rupee";
					outputResult.Text = "$" + result.ToString() + " USD";
					outputFrom.Text = "1 Indian Rupee = 0.011492628 USD";
					outputTo.Text = "1 USD = 74.257327 Indian Rupees";
				}
				catch
				{
					Console.WriteLine($"Unable to parse '{amount.Text}'");
					amount.Text = "";
					inputAmount.Text = "";
					outputResult.Text = "";
					outputFrom.Text = "";
					outputTo.Text = "";
				}
			}
			else if (fromCurrency.SelectedIndex == 3 && toCurrency.SelectedIndex == 1 && !amount.Text.Equals(""))
			{
				try
				{
					double value = double.Parse(amount.Text);
					double result = value * 0.013492774;
					inputAmount.Text = amount.Text + " Indian Rupee";
					outputResult.Text = "€" + result.ToString() + " Euro";
					outputFrom.Text = "1 Indian Rupee = 0.013492774 Euros";
					outputTo.Text = "1 Euro = 87.00755 Indian Rupees";
				}
				catch
				{
					Console.WriteLine($"Unable to parse '{amount.Text}'");
					amount.Text = "";
					inputAmount.Text = "";
					outputResult.Text = "";
					outputFrom.Text = "";
					outputTo.Text = "";
				}
			}
			else if (fromCurrency.SelectedIndex == 3 && toCurrency.SelectedIndex == 2 && !amount.Text.Equals(""))
			{
				try
				{
					double value = double.Parse(amount.Text);
					double result = value * 0.0098339397;
					inputAmount.Text = amount.Text + " Indian Rupee";
					outputResult.Text = "£" + result.ToString() + " British Pound";
					outputFrom.Text = "1 Indian Rupee = 0.0098339397 British Pound";
					outputTo.Text = "1 British Pound = 101.68635 Indian Rupees";
				}
				catch
				{
					Console.WriteLine($"Unable to parse '{amount.Text}'");
					amount.Text = "";
					inputAmount.Text = "";
					outputResult.Text = "";
					outputFrom.Text = "";
					outputTo.Text = "";
				}
			}
		}

		private void exitButton_Click(object sender, RoutedEventArgs e)
		{
			Frame.Navigate(typeof(MainMenu));
		}
	}
}
