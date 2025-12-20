namespace _10dars;

internal class Program
{
    static void Main(string[] args)
    {
        Laptop laptop5 = new Laptop()
        {
            Brand = "HP Victus",
            Model = "XuyZnaet China Pro",
            Processor = "AMD Ryzen 42 Dota free McDonald's",
            ScreenType = "OLED",
            ManifacturedYear = 2029
        };

        Laptop laptop4 = new Laptop()
        {
            Brand = "Lenovo",
            Model = "GovnoPro",
            Processor = "Intel shit -7i pro version",
            ScreenType = "OLED",
            ManifacturedYear = 3924
        };

        Laptop laptop3 = new Laptop()
        {
            Brand = "MSI",
            Model = "Katana",
            Processor = "Intel core i9",
            ScreenType = "OLED",
            ManifacturedYear = 2023
        };

        Laptop laptop2 = new Laptop();
        laptop2.Brand = "Asus";
        laptop2.Model = "ROG";
        laptop2.Processor = "AMD Ryzen 7 12400";
        laptop2.ScreenType = "OLED";
        laptop2.ManifacturedYear = 2026;


        Laptop laptop1 = new Laptop()
        {
            Brand = "Asus",
            Model = "Vivobook G015",
            Processor = "AMD Ryzen 3 7000series",
            ScreenType = "OLED",
            ManifacturedYear = 2024
        };

        //--- --- --- --- ---

        Students student5 = new Students()
        {
            Id = 5,
            FirstName = "Rasoul",
            LastName = "Matrasulov",
            Height = 176,
            Weight = 80
        };

        Students student4 = new Students()
        {
            Id = 4,
            FirstName = "Rasoul",
            LastName = "Matrasulov",
            Height = 176,
            Weight = 80
        };

        Students student3 = new Students()
        {
            Id = 3,
            FirstName = "Rasoul",
            LastName = "Matrasulov",
            Height = 176,
            Weight = 80
        };

        Students student2 = new Students();
        student2.Id = 2;
        student2.FirstName = "John";
        student2.LastName = "Adolf";
        student2.Height = 169;
        student2.Weight = 65;

        Students student1 = new Students()
        {
            Id = 1,
            FirstName = "Rasoul",
            LastName = "Matrasulov",
            Height = 176,
            Weight = 80
        };

        //--- --- --- --- ---

        Countries country5 = new Countries()
        {
            CountryName = "Germany",
            CountryLeader = "Olaf Scholz",
            CountrySize = "357,022 km²",
            CountryLanguage = "de",
            CountryPopulation = 84000000
        };

        Countries country4 = new Countries()
        {
            CountryName = "Japan",
            CountryLeader = "Sanae Takaichi", 
            CountrySize = "377,975 square kilometers",
            CountryLanguage = "ja",
            CountryPopulation = 123000000
        };

        Countries country3 = new Countries()
        {
            CountryName = "France",
            CountryLeader = "Emmanuel Jean-Michel Frédéric Macron",
            CountrySize = "632,702 km²",
            CountryLanguage = "fr",
            CountryPopulation = 68600000
        };

        Countries country2 = new Countries();
        country2.CountryName = "Russia";
        country2.CountryLeader = "Vladimir Putin";
        country2.CountrySize = "17 million square kilometers";
        country2.CountryLanguage = "ru";
        country2.CountryPopulation = 146000000;

        Countries country1 = new Countries()
        {
            CountryName = "Uzbekistan",
            CountryLeader = "Shavkat Miromonovich Mirziyoyev",
            CountrySize = "448,978 square kilometers",
            CountryLanguage = "uz",
            CountryPopulation = 38000000
        };

        //--- --- --- --- ---

        Planets planet1 = new Planets()
        {
            PlanetName = "Earth",
            PlanetType = "terrestrial",
            Mass = "5.97 x 10²⁴ kilograms (kg)",
            HasRings = false,
            DistanceFromSun = "93 million miles"
        };

        Planets planet2 = new Planets()
        {
            PlanetName = "Mars",
            PlanetType = "terrestrial",
            Mass = "6.39 x 10²³ kilograms (kg)",
            HasRings = false,
            DistanceFromSun = "142 million miles"
        };

        Planets planet3 = new Planets()
        {
            PlanetName = "Jupiter",
            PlanetType = "gas giant",
            Mass = "1.90 x 10²⁷ kilograms (kg)",
            HasRings = true,
            DistanceFromSun = "484 million miles"
        };

        Planets planet4 = new Planets()
        {
            PlanetName = "Saturn",
            PlanetType = "gas giant",
            Mass = "5.68 x 10²⁶ kilograms (kg)",
            HasRings = true,
            DistanceFromSun = "886 million miles"
        };

        Planets planet5 = new Planets();
        planet5.PlanetName = "Neptune";
        planet5.PlanetType = "ice giant";
        planet5.Mass = "1.02 x 10²⁶ kilograms (kg)";
        planet5.HasRings = true;
        planet5.DistanceFromSun = "2.8 billion miles";

    }
};