using System;
using System.Collections.Generic;
using Greenhouse.Models;
using System.Drawing;

namespace Greenhouse
{
	public class Program
	{
		public static void Main()
		{
			Plant fern = new Plant(1, 1, 1, "Gully");
			Plant spider = new Plant(1, 2, 3, "Oscar");
			Plant jade = new Plant(1, 1, 1, "Alexa");
			Plant snake = new Plant(1, 1, 1, "Reginald");

			List<Plant> Plants = new List<Plant>() { fern, spider, jade, snake };
			CheckOnPlant(Plants);
		}
		public static void CheckOnPlant(List<Plant> Plants) 
		{
			Console.WriteLine("Hi! Which of your four plants do you want to check on?");
			Console.WriteLine("Gully ** Oscar ** Alexa ** Reginald");
			string stringName = Console.ReadLine();
			List<Plant> matchPlantName = new List<Plant>() {};
			foreach (Plant plant in Plants)
			{
				if (stringName.Equals(plant.Name))
				{	
					//Show Plant Name and Stats
					ShowPlantStats(plant);
					Console.WriteLine("To Add Sunshine type '1', to add water type '2' , and Minerals type '3'");
					int answer = int.Parse(Console.ReadLine());
					if (answer == 1)
					{
						plant.AddSunshine(10);
						ShowPlantStats(plant);
					}
					else if (answer == 2)
					{
						plant.AddWater(10);
						ShowPlantStats(plant);
					}			
					else if (answer == 3)
					{
						plant.AddMinerals(10);
						ShowPlantStats(plant);
					}
					else
					{
						Console.WriteLine("Sorry that's not the correct input");
						CheckOnPlant(Plants);
					}
					Console.WriteLine("Ready for tomorrow? Type 'Y' or 'N'");
					string nextDay = Console.ReadLine();
					if(nextDay.Equals("Y") || nextDay.Equals("y"))
					{
						SetNewDay(Plants);
					}
					else
					{
						CheckOnPlant(Plants);
					}
				}
			}	
		}
		public static void ShowPlantStats (Plant plant)
		{
			Console.WriteLine("Here is your plant named " + plant.Name + "!");
			Console.WriteLine("Water: " + plant.Water);
			Console.WriteLine("Sunshine: " + plant.Sunshine);
			Console.WriteLine("Minerals: " + plant.Minerals);
			Console.WriteLine("------------------------------------");
		}
		public static void SetNewDay (List<Plant> Plants)
		{
			foreach (Plant plant in Plants)
			{
				plant.DecreaseHealth();
				Console.WriteLine(@"            ^^                   @@@@@@@@@
       ^^       ^^            @@@@@@@@@@@@@@@
                            @@@@@@@@@@@@@@@@@@              ^^
                           @@@@@@@@@@@@@@@@@@@@
 ~~~~ ~~ ~~~~~ ~~~~~~~~ ~~ &&&&&&&&&&&&&&&&&&&& ~~~~~~~ ~~~~~~~~~~~ ~~~
 ~         ~~   ~  ~       ~~~~~~~~~~~~~~~~~~~~ ~       ~~     ~~ ~
   ~      ~~      ~~ ~~ ~~  ~~~~~~~~~~~~~ ~~~~  ~     ~~~    ~ ~~~  ~ ~~
   ~  ~~     ~         ~      ~~~~~~  ~~ ~~~       ~~ ~ ~~  ~~ ~
 ~  ~       ~ ~      ~           ~~ ~~~~~~  ~      ~~  ~             ~~
       ~             ~        ~      ~      ~~   ~             ~

------------------------------------------------
Thank you for visiting https://asciiart.website/
This ASCII pic can be found at
https://asciiart.website//index.php?art=nature/sunset
");
			}

		}
	}
}