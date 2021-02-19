using System;
using System.Collections.Generic; 

namespace OpenKattis_Test2_D
{
    class PushZero
    {
        static void Main(string[] args)
        {

            //int[] Number = new int[5];
            int[] Number = { 2, 2, 1 };
            int ArrLength = Number.Length;
             
            int finalNo = 0;
            /*for(int i = 0;i< ArrLength; i++)
            {
                Number[i] = Convert.ToInt32(Console.ReadLine());
            }*/
            for (int i = 0; i < ArrLength; i++)
            {
                int count = 0;
                for (int j = 0; j < ArrLength; j++)
                {
                    if ( i != j )
                    {
                        if (Number[i] == Number[j])
                            count++;
                    }
                }
                if (count == 0)
                {
                    finalNo = Number[i];
                    Console.WriteLine(finalNo);
                }
            }
            


        }
    }
}