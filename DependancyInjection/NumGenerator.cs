namespace DependancyInjection
{
    public class NumGenerator : INumberGenerator
    {
        public int RandomValue { get; }
        public NumGenerator()
        {
            RandomValue = new Random().Next(1000);
        }
    }
    public interface INumberGenerator
    {
        public int RandomValue { get; }
    }
}
