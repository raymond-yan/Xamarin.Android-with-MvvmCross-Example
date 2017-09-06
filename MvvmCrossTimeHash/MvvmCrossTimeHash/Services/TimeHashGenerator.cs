using System;

namespace MvvmCrossTimeHash.Services
{
    class TimeHashGenerator : ITimeHashGenerator
    {
        public string GenerateHash()
        {
            var timeStr = DateTime.Now.ToString("MM/dd/yyyy h:mm tt ss");
            return timeStr.GetHashCode().ToString();
        }
    }
}
