using System;
using NinjectDI.Interfaces;

namespace NinjectDI.Services
{
    public class RandomNumberService : INumberService
    {
        public string GetNumber()
        {
            Random random = new Random();
            return random.NextDouble().ToString();
        }
    }

}
