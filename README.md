# Codility Concatenating Of Words
## Task description
An array of N words is given. Each word consists of small letters ('a' − 'z'). Our goal is to concatenate the words in such a way as to obtain a single word with the longest possible substring composed of one particular letter. Find the length of such a substring.

Write a function:

class Solution { public int solution(string[] words); }

that, given an array words containing N strings, returns the length of the longest substring of a word created as described above.

Examples:

1. Given N=3 and words=["aabb", "aaaa", "bbab"], your function should return 6. One of the best concatenations is words[1] + words[0] + words[2] = "aaaaaabbbbab". The longest substring is composed of letter 'a' and its length is 6.

2. Given N=3 and words=["xxbxx", "xbx", "x"], your function should return 4. One of the best concatenations is words[0] + words[2] + words[1] = "xxbxxxxbx". The longest substring is composed of letter 'x' and its length is 4.

3. Given N=4 and words=["dd", "bb", "cc", "dd"], your function should return 4. One of the best concatenations is words[0] + words[3] + words[1] + words[2] = "ddddbbcc". The longest substring is composed of letter 'd' and its length is 4.

Write an efficient algorithm for the following assumptions:

N is an integer within the range [1..100,000];
all the words are non−empty and consist only of lowercase letters (a−z);
S denotes the sum of the lengths of words; S is an integer within the range [1..100,000].

## Score ...
44
▶max_words_with_long_substring
S = 100,000, each word contains long substring with one letter.✘TIMEOUT ERROR
running time: 1.484 sec., time limit: 0.100 sec.
1.1.484 sTIMEOUT ERROR, running time: 1.484 sec., time limit: 0.100 sec.
stderr:
Unhandled Exception:
OutOfMemoryException
[ERROR] FATAL UNHANDLED EXCEPTION: System.OutOfMemoryException: Out of memory
  at (wrapper managed-to-native) object:__icall_wrapper_mono_gc_alloc_string (intptr,intptr,int)
  at (wrapper alloc) object:AllocString (intptr,int)
  at System.Text.StringBuilder..ctor (System.String value, Int32 startIndex, Int32 length, Int32 capacity, Int32 maxCapacity) [0x00000] in <filename unknown>:0 
  at System.Text.StringBuilder..ctor (System.String value, Int32 startIndex, Int32 length, Int32 capacity) [0x00000] in <filename unknown>:0 
  at System.Text.StringBuilder..ctor (Int32 capacity) [0x00000] in <filename unknown>:0 
  at System.String.FormatHelper (System.Text.StringBuilder result, IFormatProvider provider, System.String format, System.Object[] args) [0x00000] in <filename unknown>:0 
  at System.String.Format (IFormatProvider provider, System.String format, System.Object[] args) [0x00000] in <filename unknown>:0 
  at System.String.Format (System.String format, System.Object arg0, System.Object arg1) [0x00000] in <filename unknown>:0 
  at Solution.<solution>m__2 (System.String current, System.String next) [0x00000] in <filename unknown>:0 
  at System.Linq.Enumerable.Aggregate[String] (IEnumerable`1 source, System.Func`3 func) [0x00000] in <filename unknown>:0 
  at Solution.<solution>m__0 (IEnumerable`1 a) [0x00000] in <filename unknown>:0 
  at System.Linq.Enumerable+<CreateSelectIterator>c__Iterator10`2[System.Collections.Generic.IEnumerable`1[System.String],System.String].MoveNext () [0x00000] in <filename unknown>:0 
  at System.Collections.Generic.List`1[System.String]..ctor (IEnumerable`1 collection) [0x00000] in <filename unknown>:0 
  at System.Linq.Enumerable.ToList[String] (IEnumerable`1 source) [0x00000] in <filename unknown>:0 
  at Solution.solution (System.String[] words) [0x00000] in <filename unknown>:0 
  at SolutionWrapper.run (System.String input, System.String output) [0x00000] in <filename unknown>:0 
  at SolutionWrapper.Main (System.String[] args) [
2.6.000 sTIMEOUT ERROR, Killed. Hard limit reached: 6.000 sec.
3.6.000 sTIMEOUT ERROR, Killed. Hard limit reached: 6.000 sec.
