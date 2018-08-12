using System;
using MicrosoftExtensions.Interfaces;

namespace MicrosoftExtensions.Services
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
