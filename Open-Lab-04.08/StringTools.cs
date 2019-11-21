using System;
using System.Collections.Generic;

namespace Open_Lab_04._08
{
    public class StringTools
    {
        public string[] IsFourLetters(string[] strings)
        {
            var a = new List<string>();
            foreach (string name in strings)
            if (name.Length == 4)
            a.Add(name);

            return a.ToArray();
        }
    } 
}
