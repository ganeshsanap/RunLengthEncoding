using System;

namespace RunLengthEncoding
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( PrintRLE("122333444455555"));
        }

        static string PrintRLE(string inputString)
        {
            try
            {
                string output = string.Empty;
                if (!string.IsNullOrEmpty(inputString.Trim()))
                {
                    int n = inputString.Length;
                    for (int i = 0; i < n; i++)
                    {
                        int count = 1;
                        while (i < n - 1 && inputString[i] == inputString[i + 1])
                        {
                            count++;
                            i++;
                        }
                        output = output + inputString[i] + Convert.ToString(count);
                        //Console.Write(inputString[i]);
                        //Console.Write(count);
                    }
                    //Console.WriteLine();
                    //Console.WriteLine(output);
                }
                else
                {
                    output = "Please enter valid string.";
                    //Console.WriteLine("Please enter string.");
                }
                return output;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
