using NinjectDI.Interfaces;

namespace NinjectDI.Services
{
    public class AdditionNumberService : INumberService
    {
        private int _number = 1;

        public string GetNumber()
        {
            return $"{_number++}";
        }
    }
}
