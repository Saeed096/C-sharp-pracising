using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learning
{
    internal static class Extensions
    {
        public static IEnumerable<T> Filter<T>(this IEnumerable<T> items, Predicate<T> predicate)  
        {

            foreach (T item in items) 
            {
                if (predicate(item))
                {
                    yield return item;
                }
            }

        }
        IEnumerable

    }
}
