using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangoliAlgorithm15
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> rangoliCharsList = new List<char> { 'a', 'b','c','d','e','f','g','h','i','j','k','l','m','n','o' };
            int masterListCount = rangoliCharsList.Count;
            List<char> listOfChars = new List<char>(); 

            for (int currentLevel = masterListCount - 1; currentLevel >= 0; currentLevel--)
            {
                listOfChars.Add(rangoliCharsList[currentLevel]);
                PrintOutRangoliLine(masterListCount,listOfChars, currentLevel);
            }


            for (int currentLevel = 1; currentLevel < masterListCount; currentLevel++)
            {
                int indexToRemove = masterListCount - currentLevel;
                PrintOutRangoliLine(masterListCount, listOfChars, currentLevel);
                char ttt = listOfChars[indexToRemove];
                listOfChars.RemoveAt(indexToRemove);
            }
            Console.WriteLine("Press Enter To Exit");
            Console.ReadLine();
        }

        static  void PrintOutRangoliLine(int masterListSize, List<char> listOfChars, int currentLevel)
        {
            StringBuilder rangoliLine = new StringBuilder();
            int listOfCharSize = listOfChars.Count;
            int numPreceedingHyphens = currentLevel * 2;
            int numDistinctWordsOnLine = masterListSize - currentLevel;
            for (int a = 0; a < numPreceedingHyphens; a++)
            {
                rangoliLine.Append("-");
            }

            for (int b = 0; b < numDistinctWordsOnLine; b++)
            {
                rangoliLine.Append(listOfChars[b]);
                if (currentLevel < masterListSize-1)
                {
                    rangoliLine.Append("-");
                }
            }

            for (int c = numDistinctWordsOnLine-2; c >= 0 ; c--)
            {
                rangoliLine.Append(listOfChars[c]);     
                if(c > 0)
                {
                    rangoliLine.Append("-");                    
                }
            }
            for (int a = 0; a < numPreceedingHyphens; a++)
            {
                rangoliLine.Append("-");
            }          
            Console.WriteLine(rangoliLine);
        }
    }
}
