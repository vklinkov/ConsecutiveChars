using System;
namespace ConsecutiveChars
{
    public static class ConsecutiveChars
    {
        public static string RemoveConsecutiveChars(this string value, int amount)
        {
            if (string.IsNullOrEmpty(value)) return string.Empty;

            var res = value[0].ToString();
            var counter = 1;

            for(var i = 1; i < value.Length; i++)
            {
                var current = value[i];

                if(res[res.Length - 1] == current)
                {
                    if(counter < amount)
                    {
                        res += current;
                        counter++;
                    }
                }
                else
                {
                    res += current;
                    counter = 1;
                }
            }

            return res;
        }
    }
}
