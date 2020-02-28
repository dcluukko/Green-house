
namespace Greenhouse.Models {
	public class Plant 
	{
		public int Water {get; set;}
		public int Sunshine {get; set;}
		public  int Minerals {get; set;}
		public string Name {get; set;}


		public Plant(int water, int sunshine, int minerals, string name) 
		{
			Water = water;
			Sunshine = sunshine;
			Minerals = minerals;
			Name = name;
		}	

		public void AddSunshine(int sunshine)
		{
		  Sunshine += sunshine;
		}
		public void AddWater(int water)
		{
			Water += water;
		}
		public void AddMinerals(int minerals)
		{
			Minerals += minerals;
		}
		public void DecreaseHealth()
		{
			Water -= 1;
			Sunshine -= 1;
			Minerals -= 1;
		}
		public void RandomDisaster(int number)
		{
			if (number ==1)
			{
				Console.WriteLine("Your plant has been attacked by a swarm of slugs! Minerals have been lost");
				SlugBite();
			}
			if (number == 2)
			{
				Console.WriteLine("Your plant has suffered a drought! Water has been lost :(");
				Drought();
			}
			if (number == 3)
			{
				Console.WriteLine("A nuclear holocaust hit, your plant has lost Sunshine.");
				Nuclear();
			}	
		}
		public void SlugBite(int minerals)
		{
			Minerals -= minerals;
		}
		public void Drought(int water)
		{
			Water -= water;
		}
		public void Nuclear(int sunlight)
		{
			Sunlight -= sunlight;
		}
	}
}
