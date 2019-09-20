using System;
using System.Collections.Generic;
using System.Linq;

namespace ConcatenatingOfWords
{
    public class Solution
    {
        public int solution(string[] words)
        {
            if (words.Count() == 0) return 0;
            if (words.Count() == 1)
            {
                return GetLoggestRun(words[0]);
            }
            List<int> counts = new List<int>();
            var ms = Permutate<string>(words).Select(a => a.Aggregate((current, next) => $"{current}{next}")).ToList();
            foreach (var g in ms)
            {
                counts.Add(GetLoggestRun(g));
            }
            return counts.Max();
        }
        public int GetLoggestRun(string word)
        {
            return new string(word.Select((c, index) => word.Substring(index).TakeWhile(e => e == c))
                                   .OrderByDescending(e => e.Count())
                                   .First().ToArray()).Length;
        }
        public static IEnumerable<IEnumerable<TSource>> Permutate<TSource>(IEnumerable<TSource> source)
        {
            var list = source.ToList();

            if (list.Count > 1)
                return from s in list
                       from p in Permutate(list.Take(list.IndexOf(s)).Concat(list.Skip(list.IndexOf(s) + 1)))
                       select Prepend(p, s);

            return new[] { list };
        }
        public static IEnumerable<TSource> Prepend<TSource>(IEnumerable<TSource> source, TSource item)
        {

            yield return item;

            foreach (var element in source)
                yield return element;
        }
    }
}
