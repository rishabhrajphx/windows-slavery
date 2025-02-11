using System;
using System.Linq;
using MyWcfProject.Interfaces;

namespace MyWcfProject.Services
{
    public class MyService : IMyService
    {
        public int C2F(int c)
        {
            return (int)(c * 9.0 / 5.0 + 32);
        }

        public int F2C(int f)
        {
            return (int)((f - 32) * 5.0 / 9.0);
        }

        public string Sort(string s)
        {
            var numbers = s.Split(',').Select(float.Parse).OrderBy(n => n);
            return string.Join(",", numbers);
        }
    }
}