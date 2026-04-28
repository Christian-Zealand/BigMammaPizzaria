using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibPizza.Model
{
	public class OrdreListe
	{
		//Instancefields
		private List<Ordre> _listeAllOrdre;


		//Constructor

		public OrdreListe()
		{
			_listeAllOrdre = new List<Ordre>();
		}	

		public OrdreListe(List<Ordre> listeAllOrdre)
		{
			_listeAllOrdre = listeAllOrdre;
		}

		//Properties

		public List<Ordre> ListeAllOrdre
		{
			get { return _listeAllOrdre; }
			set { _listeAllOrdre = value; }
		}

		//ToString:

		public override string ToString()
		{
			string result = "OrdreListe for all pizzas: \n";
			foreach (Ordre ordre in _listeAllOrdre)
			{
				result = result + ordre;
			}
			return result;
		}

	}
}
