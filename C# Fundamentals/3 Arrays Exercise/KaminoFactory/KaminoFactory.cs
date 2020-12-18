using System;


namespace KaminoFactory
{
    class KaminoFactory
    {
        static void Main(string[] args)
        {    
            int sequencesLength = int.Parse(Console.ReadLine());
            string input = string.Empty;
            int counter = 0;

            int bestCount = 0;
            int bestCounter = 0;
            int bestIndex = 0;
            string bestDnaSequence = string.Empty;
            int bestSum = 0;

            while ((input = Console.ReadLine()) != "Clone them!")
            {
                string sequences = input.Replace("!","");
      

                string[] dnaSequences = sequences.Split('0',StringSplitOptions.RemoveEmptyEntries);

                int count = 0;
                int sum = 0;
                string bestSequences = string.Empty;
                counter++;

                foreach (string dnaPart in dnaSequences)
                {
                    if (dnaPart.Length>count)
                    {
                        count = dnaPart.Length;
                        bestSequences = dnaPart;

                    }

                    sum += dnaPart.Length;
                }

                int beginIndex = sequences.IndexOf(bestSequences);

                if (count > bestCount 
                    || (count == bestCount && beginIndex < bestIndex) 
                    || (count == bestCount && beginIndex == bestIndex && sum > bestSum)
                    ||(counter==1))
                {
                    bestCount = count;
                    bestCounter = counter;
                    bestDnaSequence = sequences;
                    bestIndex = beginIndex;
                    bestSum = sum;
                }
            }


            char[] result = bestDnaSequence.ToCharArray();
            Console.WriteLine($"Best DNA sample {bestCounter} with sum: {bestSum}.");
            Console.WriteLine($"{string.Join(' ',result)}");


       
        }
    }
}
