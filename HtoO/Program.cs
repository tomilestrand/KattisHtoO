using System;
using System.Collections.Generic;

namespace HtoO
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> data = new Dictionary<char, int>();
            Dictionary<char, int> result = new Dictionary<char, int>();
            string[] inputs = Console.ReadLine().Split(' ');
            int amount = int.Parse(inputs[1]);
            string input = inputs[0];
            string temp;
            for (int i = 0; i < input.Length; i++)
            {
                temp = "";
                for (int j = 1; j <= 3; j++)
                {
                    if (i + j < input.Length && char.IsDigit(input[i + j]))
                    {
                        temp += input[i + j];
                    }
                    else
                    {
                        break;
                    }
                }
                if (!data.ContainsKey(input[i]))
                {
                    data.Add(input[i], 0);
                }
                data[input[i]] += temp.Length > 0 ? int.Parse(temp) : 1;
                i += temp.Length;
            }
            input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                temp = "";
                for (int j = 1; j <= 3; j++)
                {
                    if (i + j < input.Length && char.IsDigit(input[i + j]))
                    {
                        temp += input[i + j];
                    }
                    else
                    {
                        break;
                    }
                }
                if (!result.ContainsKey(input[i]))
                {
                    result.Add(input[i], 0);
                }
                result[input[i]] += temp.Length > 0 ? int.Parse(temp) : 1;
                i += temp.Length;
            }
            int output = int.MaxValue;
            int tempInt;
            foreach (var item in result)
            {
                if (!data.ContainsKey(item.Key))
                {
                    output = 0;
                    break;
                }
                tempInt = data[item.Key] * amount / item.Value;
                output = Math.Min(output, tempInt);
            }
            Console.WriteLine(output);
        }
    }
}
