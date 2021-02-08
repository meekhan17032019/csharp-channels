using System.Collections.Generic;
using System.Linq;

namespace async
{
    public static class LocalExtensions
    {
        public static string ToDelimitedString<T>(this List<T> list, string delimiter)
        {
            string result = "[";
            for (int i = 0; i < list.Count() - 1; i++)
            {
                result += $"{list[i]}{delimiter}";
            }
            result += list[list.Count() - 1];
            result += "]";
            return result;
        }
    }

}