using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem2
{
    class Problem2
    {
        static void Main(string[] args)
        {
            string pattern =  @"(\*|@)([A-Za-z]{3,})\1: ((\[\w\]\|)*)"; 
            Regex regPattern = new Regex(pattern);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                Match match = regPattern.Match(input);

                if (!match.Success)
                {
                    Console.WriteLine("Valid message not found!");
                }
                else
                {
                  
                    
                     string tag = match.Groups[2].ToString();
                     string numbers = match.Groups[3].Value;
                    StringBuilder sb = new StringBuilder();
                 
                        string valpattern = @"(\w+)";
                        Regex valRegex = new Regex(valpattern);
                        MatchCollection val = valRegex.Matches(numbers);

                    string gg = String.Concat(val);
                   
                    foreach (char item in gg)
                    {
                  
                        int current = item;
                        sb.AppendFormat(" "+ current);
                      
                    }
                    Console.WriteLine($"{tag}: {string.Join(' ',sb)}");


                }


            }

        }
    }
}
