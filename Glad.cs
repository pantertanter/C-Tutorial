class Glad : IHumor, IHouses
{
    public enum Level
    {
        Low,
        Medium,
        High
    }
    public void humorSound()
    {
        Console.WriteLine("Ha ha ha ha");
    }
    public void SqrM(int sqrM)
    {
        Console.Write($"The house is {sqrM} square meters in size");
        if (sqrM > 15)
        {
            Console.Write($" and thats why I'm happy");
        }
    }
}