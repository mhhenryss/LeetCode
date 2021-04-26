using System;

namespace LeetCode
{
    public class LongestPalindromicSubstringSolution
    {
        private string _s;

        public string LongestPalindrome(string s)
        {
            _s = s;

            var max = 0;
            var startIndex = 0;
            for (var i = 0; i < _s.Length; i++)
            {
                var subLength = (_s.Length - 1 - i) * 2;
                var curOddLimit = subLength + 1;
                var curEvenLimit = subLength;

                var oddLength = curOddLimit > max ? GetMaxLength(i, i) : 0;
                var evenLength = curEvenLimit > max ? GetMaxLength(i, i + 1) : 0;
                var curMax = oddLength > evenLength ? oddLength : evenLength;

                if (curMax > max)
                {
                    max = curMax;
                    startIndex = i - (max - 1) / 2;
                }
            }

            var result = _s.Substring(startIndex, max);
            return result;
        }

        private int GetMaxLength(int l, int r)
        {
            while (l >= 0 && r < _s.Length && _s[l] == _s[r])
            {
                l--;
                r++;
            }

            var length = r - l - 1;
            return length;
        }
    }
}