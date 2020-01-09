using System;
using System.Collections.Generic;
using System.Text;

namespace DinerMax3000Console
{
	class Order
	{
		public List<MenuItem> items = new List<MenuItem>();

		public double Total
		{
			get
			{
				double Total = 0;
				foreach(MenuItem item in items)
				{
					Total += item.Price;
				}
				return Total;
			}
		}
	}
}
