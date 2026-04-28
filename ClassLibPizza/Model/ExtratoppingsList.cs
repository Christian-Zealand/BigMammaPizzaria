using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibPizza.Model
{
	public class ExtratoppingsList


	{
		#region Instancefields
		//Instancefields
		private List<Extratoppings> _extratoppingsList;
		#endregion

		#region Constructors
		//Constructor
		public ExtratoppingsList()
		{
			_extratoppingsList = new List<Extratoppings>();
		}

		public ExtratoppingsList(List<Extratoppings> extratoppingsList)
		{
			_extratoppingsList = extratoppingsList;
		}
		#endregion

		#region Properties
		//Properties
		public List<Extratoppings> Extratoppings
		{
			get { return _extratoppingsList; }
			set { _extratoppingsList = value; }
		}
		#endregion

		#region Methods
		//ToString:

		public override string ToString()
		{
			string result = "ExtratoppingsList:\n";

			foreach (Extratoppings extratopping in _extratoppingsList)
			{
				result = result + extratopping;
			}
			return result;
		}


		//Methods Create, update, delete, read - CRUD
		public void AddExtratopping(Extratoppings extratopping)
		{
			_extratoppingsList.Add(extratopping);
		}

		public List<Extratoppings> GetAllExtratoppings()
		{
			return new List<Extratoppings>(_extratoppingsList);
		}

		public Extratoppings Get(int extraToppingId)

		{
			Extratoppings extratoppingfound = null;
			foreach (Extratoppings ToppingId in _extratoppingsList)
			{
				if (ToppingId.ExtraToppingId == extraToppingId)
				{
					extratoppingfound = ToppingId;

				}
			}
			if (extratoppingfound != null)
			{
				return extratoppingfound;
			}
			else
			{
				throw new Exception("Extratopping with ID: " + extraToppingId + "not found.");
			}
		}

		public Extratoppings Remove(int extraToppingId)
		{
			Extratoppings removeExtratopping = Get(extraToppingId);
			_extratoppingsList.Remove(removeExtratopping);
			return removeExtratopping;
		}

		public Extratoppings Update(int extraToppingId, Extratoppings updatedExtratopping)
		{
			Extratoppings updateExtratoppings = Get(extraToppingId);
			updateExtratoppings.ExtraToppingName = updatedExtratopping.ExtraToppingName;
			updateExtratoppings.ExtraToppingPrice = updatedExtratopping.ExtraToppingPrice;

			return updateExtratoppings;

		}
		#endregion
	}
}

