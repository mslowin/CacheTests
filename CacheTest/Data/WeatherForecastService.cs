using Microsoft.Extensions.Caching.Memory;

namespace CacheTest.Data
{
	public class WeatherForecastService
	{
		private static readonly string[] Summaries = new[]
		{
			"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
		};

		////private readonly IMemoryCache _memoryCache;

		////public WeatherForecastService(IMemoryCache memoryCache)
		////{
		////	_memoryCache = memoryCache;
		////}

		////public string GetSetSampleCache()
		////{
		////	string key = "_Key_SampleCache";
		////	var encodedCache = _memoryCache.Get(key);

		////	if (encodedCache == null)
		////	{
		////		var options = new MemoryCacheEntryOptions()
		////			.SetSlidingExpiration(TimeSpan.FromSeconds(5))
		////			.SetAbsoluteExpiration(DateTime.Now.AddMinutes(1));
		////		_memoryCache.Set(key, DateTime.Now.Ticks.ToString(), options);
		////		return _memoryCache.Get(key).ToString();
		////	}
		////	else
		////	{
		////		return _memoryCache.Get(key).ToString();
		////	}
		////}

		public async Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
		{
			var rng = new Random();
			await Task.Delay(1500);
			return Enumerable.Range(1, 5).Select(index => new WeatherForecast
			{
				Date = startDate.AddDays(index),
				TemperatureC = Random.Shared.Next(-20, 55),
				Summary = Summaries[Random.Shared.Next(Summaries.Length)]
			}).ToArray();
		}
	}
}