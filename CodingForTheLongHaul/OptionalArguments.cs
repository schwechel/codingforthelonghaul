using System;
using System.Collections.Generic;
using System.Text;

namespace CodingForTheLongHaul
{
    public class OptionalArguments
    {
        public string LetsUseOptionalArguments(string one, string two)
        {
            return $"{one} {two}";
        }

        public string LetsUseOptionalArguments(string one, string two, string three = "", string four = "")
        {
            return $"{one} {two} {three}!!!";
        }
    }
}
