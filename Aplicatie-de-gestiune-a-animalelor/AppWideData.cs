namespace Aplicatie_de_gestiune_a_animalelor
{
    public static class AnimalTypes
    {
        public static Dictionary<string, int> Types { get; } = new Dictionary<string, int>()
        {
            {"Pisica", 0},
            {"Caine",  1}
        };
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
