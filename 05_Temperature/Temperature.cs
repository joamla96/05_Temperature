using System;

namespace _05_Temperature {
	enum Unit {	Celcius, Fahrenheit }

	internal class Temperature {

		public double Fahrenheit { get; internal set; }
		public double Celcius { get; internal set; }

		private static double ConversionRate = 5.0 / 9.0;

		public Temperature() {

		}

		public Temperature(Unit scale, double v) {
			if (scale == Unit.Celcius)
				this.Celcius = v;
			else this.Fahrenheit = v;

		}

		internal static double FahrenheitToCelcius(double v) {
			return (v - 32) * ConversionRate;
		}

		internal static double CelciusToFahrenheit(double v) {
			return (v / ConversionRate) + 32;
		}
	}
}