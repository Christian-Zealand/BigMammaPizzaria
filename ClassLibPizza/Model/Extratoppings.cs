using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ClassLibPizza.Model
{
	public class Extratoppings



	{
		//Instancefields
		private int _extraToppingId;
		private string _extraToppingName;
		private double _extraToppingPrice;

		//Constructor

		public Extratoppings()
		{
			_extraToppingId = 0;
			_extraToppingName = "";
			_extraToppingPrice = 0.0;

		}

		public Extratoppings(int extraToppingId, string extraToppingName, double extraToppingPrice)
		{
			_extraToppingId = extraToppingId;
			_extraToppingName = extraToppingName;
			_extraToppingPrice = extraToppingPrice;

		}
		//Properties

		public int ExtraToppingId
		{
			get { return _extraToppingId; }
			set { _extraToppingId = value; }
		}
		public string ExtraToppingName
		{
			get { return _extraToppingName; }
			set { _extraToppingName = value; }
		}
		public double ExtraToppingPrice
		{
			get { return _extraToppingPrice; }
			set { _extraToppingPrice = value; }
		}

		//ToString:
		public override string ToString()
		{
			return " Topping ID: " + ExtraToppingId + "Topping: " + ExtraToppingName + "Price: " + ExtraToppingPrice;
		}




	}
}

