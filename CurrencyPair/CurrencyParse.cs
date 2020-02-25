using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyPair
{
    internal static class CurrencyParse
    {
        internal static TypeOfEnum Parse<TypeOfEnum>(string name) where TypeOfEnum : Enum
        {
            return (TypeOfEnum)Enum.Parse(typeof(TypeOfEnum), name, true);
        }
    }
}
