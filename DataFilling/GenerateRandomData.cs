using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreTask.Ibrahimahmed
{
    public class GenerateRandomData
    {
        private static Random random = new Random();

        public static float RandomFloat()
        {       
            float minValue = 1;
            float maxValue = 1000;

            // Generate a random double between 0.0 and 1.0, then scale it to the desired range
            double randomDouble = random.NextDouble(); // Returns a double between 0.0 and 1.0
            float randomFloat = (float)(minValue + (randomDouble * (maxValue - minValue)));

            return (float)Math.Round(randomFloat, 2);
        }

        public static DateTime RandomDateTime()
        {
            // Define the start and end dates
            DateTime startDate = new DateTime(2022, 1, 1);
            DateTime endDate = DateTime.Now;

            // Calculate the range in days
            int range = (endDate - startDate).Days;

            // Generate a random number of days to add
            int randomDayOffset = random.Next(range + 1);

            // Return the random date
            return startDate.AddDays(randomDayOffset);
        }

        public static string RandomPhoneNumber()
        {
            // Start with "010"
            string phoneNumber = "010";

            // Generate the next 8 digits
            for (int i = 0; i < 8; i++)
            {
                phoneNumber += random.Next(0, 10).ToString();
            }
            return phoneNumber;
        }

        public static string RandomAddress()
        {
            // Generate random street number
            int streetNumber = random.Next(1, 10000); // Street number between 1 and 9999

            // Generate random street name
            string[] streetNames = { "Main St", "Second St", "Third St", "Elm St", "Fourth St", "Fifth st", "Sixth St", "Seventh st" };
            string streetName = streetNames[random.Next(streetNames.Length)];

            // Generate random postal code
            string postalCode = random.Next(10000, 99999).ToString(); // 5-digit postal code

            // Generate random state or province
            string[] states = { "CA", "TX", "NY", "FL", "IL", "PA", "OH", "MI", "GA", "NC" };
            string state = states[random.Next(states.Length)];

            // Generate random country
            string[] countries = { "USA", "Canada", "UK", "Australia", "Germany", "France", "Italy", "Spain", "Mexico", "Brazil" };
            string country = countries[random.Next(countries.Length)];

            // Construct and return the random address
            return $"{streetNumber} {streetName}, {postalCode}, {state}, {country}";
        }

        
        public static string RandomCity()
        {
            List<string> cities = new List<string>
            {
                "New York City, USA",
                "London, UK",
                "Tokyo, Japan",
                "Paris, France",
                "Sydney, Australia",
                "Berlin, Germany",
                "Toronto, Canada",
                "São Paulo, Brazil",
                "Mumbai, India",
                "Shanghai, China",
                "Dubai, UAE",
                "Moscow, Russia",
                "Mexico City, Mexico",
                "Buenos Aires, Argentina",
                "Cairo, Egypt",
                "Johannesburg, South Africa",
                "Seoul, South Korea",
                "Rome, Italy",
                "Madrid, Spain",
                "Bangkok, Thailand",
                "Istanbul, Turkey",
                "Singapore, Singapore",
                "Lagos, Nigeria",
                "Amsterdam, Netherlands",
                "Zurich, Switzerland",
                "Los Angeles, USA",
                "Hong Kong, China",
                "Rio de Janeiro, Brazil",
                "Athens, Greece",
                "Cape Town, South Africa",
                "Kuala Lumpur, Malaysia",
                "Prague, Czech Republic",
                "Warsaw, Poland",
                "Nairobi, Kenya",
                "Stockholm, Sweden",
                "Vienna, Austria",
                "Manila, Philippines",
                "Vancouver, Canada",
                "Jakarta, Indonesia",
                "Casablanca, Morocco",
                "Lima, Peru",
                "Oslo, Norway",
                "Brussels, Belgium",
                "Dublin, Ireland",
                "Santiago, Chile",
                "Helsinki, Finland",
                "Beirut, Lebanon",
                "Copenhagen, Denmark",
                "Lisbon, Portugal",
                "Edinburgh, UK"  // Replaced Tel Aviv with Edinburgh
            };
            // Get a random index within the range of the list
            int randomIndex = random.Next(cities.Count);

            // Get the random city
            string randomCity = cities[randomIndex];

            return randomCity;
        }

    }
}
