using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibPizza.Model
{
	public class Menu
	{
		private List<Pizza> _pizzas;

		public Menu()
		{
		_pizzas = new List<Pizza>();
		}
		public Menu(List<Pizza> pizzas) 
		{
		_pizzas = pizzas;
		}

		public List<Pizza> Pizzas
		{
			get { return _pizzas; }
			set { _pizzas = value; }
		}

		#region Methods

		public override string ToString()
		{
			string res = " ";
			foreach (Pizza pizza in _pizzas) 
			{
				res = res + pizza + " Name= " + pizza.Name;
			}
			return res;
		}



		public void AddPizza(Pizza pizza)
		{
			_pizzas.Add(pizza);
		}

		public Pizza GetPizza(int id)
		{
			Pizza pizzaFound = null;
			foreach (var pizza in _pizzas)
			{
				if (pizza.PizzaNo == id)
				{
					return pizza;
				}
			}
			return pizzaFound;
		}

		public Pizza UpdatePizza (int id, Pizza updatedPizza)
		{
			Pizza PizzaToUpdate = GetPizza(id);
			PizzaToUpdate.Name = updatedPizza.Name;
			PizzaToUpdate.Price = updatedPizza.Price;
			PizzaToUpdate.Vegan = updatedPizza.Vegan;
			PizzaToUpdate.Calzone = updatedPizza.Calzone;
			PizzaToUpdate.Gluten = updatedPizza.Gluten;
			PizzaToUpdate.Ingrediens = updatedPizza.Ingrediens;

			return PizzaToUpdate;
		}

		public Pizza DeletePizza (int id)
		{
			Pizza pizzaToDelete = GetPizza(id);
			_pizzas.Remove(pizzaToDelete);
			return pizzaToDelete;
		}

		#endregion
	}
}
