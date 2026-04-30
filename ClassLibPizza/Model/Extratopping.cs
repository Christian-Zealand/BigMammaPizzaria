using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ClassLibPizza.Model
{
	public class Extratopping



	{
		#region  Instancefields
		//Instancefields
		private int _id;
		private string _name;
		private double _price;

		#endregion

		#region Constructors
		//Constructor

		public Extratopping()
		{
			_id = 0;
			_name = "";
			_price = 0.0;

		}

		public Extratopping(int extraToppingId, string extraToppingName, double extraToppingPrice)
		{
			_id = extraToppingId;
			_name = extraToppingName;
			_price = extraToppingPrice;

		}

		#endregion

		#region Properties
		//Properties

		public int Id
		{
			get { return _id; }
			set { _id = value; }
		}
		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}
		public double Price
		{
			get { return _price; }
			set { _price = value; }
		}

		#endregion

		#region Methods
		//ToString:
		public override string ToString()
		{
			return "\n Topping ID: " + Id + " Topping: " + Name + " Price: " + Price;
		}

		#endregion


	}
}

