using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibPizza.Model
{
	public class Pizza
	{

		#region instance fields
		private int _pizzaNo;
		private string _name;
		private double _price;
		private bool _vegan;
		private bool _calzone;
		private bool _gluten;
		private string _ingrediens;
		private bool _delivery;
		private List<Topping> _toppings;
		#endregion

		#region constructors
		public Pizza()
		{
			_pizzaNo = 0;
			_name = "dummy";
			_price = 0;
			_vegan = false;
			_calzone = false;
			_gluten = false;
			_ingrediens = "dummy";
			_delivery = false;
			_toppings = new List<Topping>();
		}

		public Pizza (int pizzaNo, string name, double price, bool vegan, bool calzone, bool gluten, string ingrediens, bool delivery, List<Topping> toppings)
		{
			_pizzaNo = pizzaNo;
			_name = name;
			_price = price;
			_vegan = vegan;
			_calzone = calzone;
			_gluten = gluten;
			_ingrediens = ingrediens;
			_delivery = delivery;
			_toppings = toppings;
		}
		#endregion

		#region properties
		public int PizzaNo
		{
			get { return _pizzaNo; }
			set { _pizzaNo = value; }
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
		public bool Vegan
		{
			get { return _vegan; }
			set { _vegan = value; }
		}
		public bool Calzone
		{
			get { return _calzone; }
			set { _calzone = value; }
		}
		
		public bool Gluten
		{
			get { return _gluten; }
			set { _gluten = value; }
		}

		public string Ingrediens
		{
			get { return _ingrediens; }
			set { _ingrediens = value; }
		}
		public bool Delivery
		{
			get { return _delivery; }
			set { _delivery = value; }
		}
		public List<Topping> Toppings
		{
			get { return _toppings; }
			set { _toppings = value; }
		}
		#endregion

		#region methods()
		public override string ToString()
		{
			return "PizzaNo= " + PizzaNo + " Name= " + Name + " Price= " + Price + " Vegan= " + Vegan + " Calzone= " + Calzone + " Gluten= " + Gluten + " Ingridiens= " + Ingrediens + " Delivery= " + Delivery + " Toppings= " + Toppings;
		}
		#endregion
	}
}
