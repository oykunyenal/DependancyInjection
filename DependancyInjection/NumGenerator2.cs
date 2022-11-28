namespace DependancyInjection
{
    public class NumGenerator2 : INumGenerator2
    {
        public int RandomValue { get; }

        public NumGenerator2()
        {
            RandomValue = new Random().Next(1000);
        }
    }

    public interface INumGenerator2
    {
        public int RandomValue { get; }
    }
}
