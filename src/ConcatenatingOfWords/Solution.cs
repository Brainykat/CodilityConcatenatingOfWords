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
                return GetItsCount(words[0]);
            }
            List<int> counts = new List<int>();
            var ms = Permutate<string>(words).Select(a => a.Aggregate((current, next) => $"{current}{next}")).ToList();
            foreach (var g in ms)
            {
                counts.Add(GetItsCount(g));
            }
            return counts.Max();
        }
        /// This is too slow but it works
        /// Reduced my score to 44 due to timeouts
        public int GetItsCount(string word)
        {
            string a = "";
            List<string> vs = new List<string>();
            if (word.Length == 1) return 1;
            for (int i = 0; i <= word.Length - 1; i++)
            {
                if (string.IsNullOrWhiteSpace(a))
                {
                    a += word[i];
                    if (i == word.Length - 1)
                    {
                        vs.Add(a);
                    }
                }
                else
                {
                    if (a.Length == 1)
                    {
                        if (a[0] == word[i])
                        {
                            a += word[i];
                            if (i == word.Length - 1)
                            {
                                vs.Add(a);
                            }
                        }
                        else
                        {
                            a = word[i].ToString();
                            vs.Add(a);
                        }
                    }
                    else
                    {
                        if (a[a.Length - 1] == word[i])
                        {
                            a += word[i];
                            if (i == word.Length - 1)
                            {
                                vs.Add(a);
                            }
                        }
                        else
                        {
                            vs.Add(a);
                            a = word[i].ToString();
                            vs.Add(a);
                        }
                    }
                }

            }
            var mm = vs.OrderByDescending(s => s.Length).FirstOrDefault();
            var dd = mm.Length;

            return vs.OrderByDescending(s => s.Length).FirstOrDefault().Trim().Length;
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
        //This filters repetition
        public static IEnumerable<IEnumerable<T>> GetPermutations<T>(IEnumerable<T> items)
        {
            if (items.Count() > 1)
            {
                return items.SelectMany(item => GetPermutations(items.Where(i => !i.Equals(item))),
                                       (item, permutation) => new[] { item }.Concat(permutation));
            }
            else
            {
                return new[] { items };
            }
        }

        public static IEnumerable<TSource> Prepend<TSource>(IEnumerable<TSource> source, TSource item)
        {

            yield return item;

            foreach (var element in source)
                yield return element;
        }
    }
}
