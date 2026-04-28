using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibPizza.Model
{
	public class Ordre
	{
		private int _orderNo;
		private int _date;
		private double _tPrice;
		private List<Pizza> _pizzaList;

		public Ordre()
		{
		_orderNo = 0;
		_date = 0;
		_tPrice = 0;
		_pizzaList = new List<Pizza>();
		}
		public Ordre (int orderNo, int date, double tPrice, List<Pizza> pizzaList)
		{
		_orderNo =orderNo;
		_date=date;
		_tPrice=tPrice;
		_pizzaList =pizzaList;
		}

		public int OrdreNo
		{  
		get { return _orderNo; } 
		set { _orderNo = value; }
		}
		public int Date
		{
		 get { return _date; }
		 set { _date = value; }
		}
		public double TPrice
		{
		get { return _tPrice; }
		set { _tPrice = value; }
		}
		public List<Pizza> PizzaList
		{
		get { return _pizzaList; }
		set { _pizzaList =value; }
		}

		//methods

		public override string ToString()
		{
			return "OdreNo= " + OrdreNo + " Date= " + Date + " Total price= " + TPrice;
		}
	}
}
