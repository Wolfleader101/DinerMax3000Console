using System;

namespace DinerMax3000Console
{
	class Program
	{
		static void Main(string[] args)
		{
			FoodMenu summerMenu = new FoodMenu();
			summerMenu.Name = "Summer Menu";
			summerMenu.AddMenuItem("Salmon", "Fresh Salmon", 25.99);
			summerMenu.AddMenuItem("Chips", "Homemade Chips", 4.99);
			summerMenu.AddMenuItem("Pizza", "Pizza of your choice!", 14.99);
			summerMenu.HospitalDirections = "Down the street";

			DrinkMenu outsideDrinks = new DrinkMenu();
			outsideDrinks.Disclaimer = "Alcoholic drinks are 18+";
			outsideDrinks.AddMenuItem("Lemonade", "Sweet Bubbly drink", 4.00);

			Order HungryGuest = new Order();
			for(int x = 0; x <= summerMenu.items.Count - 1; x++)
			{
				MenuItem currentItem = summerMenu.items[x];
				HungryGuest.items.Add(currentItem);
			}

			foreach(MenuItem currentItem in outsideDrinks.items)
			{
				HungryGuest.items.Add(currentItem);
			}

			Console.WriteLine("The total price for the order is: " + HungryGuest.Total);

			try
			{
				outsideDrinks.AddMenuItem("Lemonade", "Sweet Bubbly drink", 0);
			}
			catch(Exception thrownException)
			{
				Console.WriteLine(thrownException.Message);
			}

		}
	}
}
