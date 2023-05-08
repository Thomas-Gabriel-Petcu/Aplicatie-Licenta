namespace Aplicatie_de_gestiune_a_animalelor.Classes
{
    using System.Timers;
    public static class AnimalTypes
    {
        public static Dictionary<string, int> Types { get; } = new Dictionary<string, int>()
        {
            {"Pisica", 0},
            {"Caine",  1}
        };
        public static Dictionary<string, string> PluralTypes { get; } = new Dictionary<string, string>()
        {
            {"Pisica", "Pisici"},
            {"Caine",  "Caini"}
        };
    }
    public static class Statistics
    {
        static int registeredAnimals;
        static int unregisteredAnimals;
        static int registeredAppointments;
        //nr caini
        //nr pisici
        //caini exprimati ca procent din total  
        //pisici exprimate ca procent din total 
        //de fapt toate animalele exprimate ca procent. Necesita conexiune la DB
        //varsta medie a animalelor
        //greutatea medie
        //procentul de animale vaccinate
        //procentul de animale sterilizate
        //poate si numarul

        //numarul animalelor inregistrate de la inceputul lunii
        //numarul animalelor iesite din sistem de la inceputul lunii
        //numarul programarilor inregistrate de la inceputul lunii
        static Statistics()
        {

        }
        public static void SetIncrementAnimals()
        {
            registeredAnimals++;
        }
        public static void SetIncrementUnregisteredAnimals()
        {
            unregisteredAnimals++;
        }
        public static int GetRegisteredAnimals()
        {
            return registeredAnimals;
        }
        public static int GetUnregisteredAnimals()
        {
            return unregisteredAnimals;
        }
        public static void SetRegisteredAppointments()
        {
            registeredAppointments += 1;
        }
        public static int GetRegisteredAppointments()
        {
            return registeredAppointments;
        }
        public static void WipeData()
        {
            registeredAnimals = 0;
            unregisteredAnimals = 0;
            registeredAppointments = 0;
        }
    }
    public struct AnimalSettings
    {
        public int animalType;
        public string race;
        public string age;
        public int sexType;
        public float weight;
        public bool isVaccinated;
        public bool isSterilized;
    }
}
