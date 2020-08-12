using System;
namespace ConsecutiveChars
{
    public static class ConsecutiveChars
    {
        public static string RemoveConsecutiveChars(this string value, int amount)
        {
            if (string.IsNullOrEmpty(value)) return string.Empty;

            var res = string.Empty;
            var localCounter = 1;

            res += value[0];
            for(var i = 1; i < value.Length; i++)
            {
                var current = value[i];

                if(localCounter < amount && res[res.Length - 1] == current)
                {
                    res += current;
                    localCounter++;
                }
                else if(res[res.Length - 1] != current)
                {
                    localCounter = 0;
                    res += current;
                    localCounter++;
                }
            }

            return res;
        }
    }
}
