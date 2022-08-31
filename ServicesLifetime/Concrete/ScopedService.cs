using ServicesLifetime.Abstract;

namespace ServicesLifetime.Concrete
{
    public class ScopedService : IScopedService
    {
        private int _randomNumber;
        public ScopedService()
        {
            Random rnd = new Random();
            _randomNumber = rnd.Next(1, 1000);
        }

        public int GetRandomNumber()
        {
            return _randomNumber;
        }
    }
}