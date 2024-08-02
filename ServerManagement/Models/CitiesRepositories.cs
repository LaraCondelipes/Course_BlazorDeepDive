namespace ServerManagement.Models
{
    public class CitiesRepositories
    {
        private static List<string> cities = new List<string>()
        {
            "Toronto",
            "Montreal",
            "Ottawa",
            "Calgary",
            "Halifax"
        };

        //the function GetCities() just returns the list of cities
        public static List<string> GetCities() => cities;

    }
}
