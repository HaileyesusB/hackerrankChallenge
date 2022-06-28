using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

/*
       * Complete the 'aVeryBigSum' function below.
       *
       * The function is expected to return a LONG_INTEGER.
       * The function accepts LONG_INTEGER_ARRAY ar as parameter.
       */

namespace hackerrankChallenge
{
    class AVeryBigSum
    {
    }



class Results
    {

      

        public static long aVeryBigSum(List<long> ar)
        {
            return 0;
        }

    }

    class Solutions
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int arCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<long> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt64(arTemp)).ToList();

            long result = Results.aVeryBigSum(ar);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }

}
