namespace WebAppGitCpmmands
{
    public class WeatherForecast
    { 
        public string Conclusion5  { get; set; }
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }

        public string Conclusion2 { get; set; }

         public string Conclusion3 { get; set; }

        public string Conclusion4 { get; set; }

        

    }
}
