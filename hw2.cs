using System;


namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //הגדרת משתנים ללולאה להדפסת המערך
            int i = 0, j = 0;

            //בניית המערך
            string[,] arr1 = new string[3, 3];

            arr1[0,0] = "Main";
            arr1[0,1] = "Up";
            arr1[0,2] = "Sub";
            arr1[1,0] = "Down";
            arr1[1,1] = "Center";
            arr1[1,2] = "Up";
            arr1[2,0] = "Sub";
            arr1[2,1] = "Down";
            arr1[2,2] = "Main";

            //לולאה מקוננת להדפסת מערך דו מימדי
            for (i=0; i < 3; i++)
            {
                Console.Write(" \n");

                             for (j = 0; j < 3; j++)
                             {
                                 Console.Write(arr1[i, j] +" ");
                             }

            }

            Console.ReadKey();
        }
    }
}
