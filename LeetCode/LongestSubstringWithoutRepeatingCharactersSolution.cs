using System.Collections.Generic;

namespace LeetCode
{
    public class LongestSubstringWithoutRepeatingCharactersSolution
    {
        public int LengthOfLongestSubstring(string s)
        {
            var charArray = s.ToCharArray();
            var result = 0;
            var tResult = 0;
            var head = 0;
            var dic = new Dictionary<char, int>();

            for (var i = 0; i < charArray.Length; i++)
            {
                if (dic.ContainsKey(charArray[i]) && dic[charArray[i]] >= head)
                {
                    head = dic[charArray[i]] + 1;
                    tResult = i - dic[charArray[i]];
                }
                else
                {
                    tResult++;
                }
                dic[charArray[i]] = i;
                result = result > tResult ? result : tResult;
            }

            return result;
        }
    }
}