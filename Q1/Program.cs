using System;
namespace Q1
{
    class program
    {
        static void Main(string[] args)
        {

            //קליטת מספר מסוג מחרוזת מהשמתמש והשמת המחרוזת לטיפוס מספר שלם, משתנה- אורך המחרוזת

            Console.WriteLine("The length of the array");
                            
            int arrLe = Convert.ToInt32(Console.ReadLine());


            //קביעת אורך המערך בהתאם לקלט מהמשתמש

            int[] arr1 = new int[arrLe];


            //קליטת מחרוזת נוספת מהמשתמש והשמת המחרוזת לטיפוס מספר שלם, משתנה- מספר שבו נכפיל את המחרוזת

            Console.WriteLine("Multiply");

            int mul = Convert.ToInt32(Console.ReadLine());


            //איתחול המערך ל0,1,2,3... בהתאם לאורך המערך

            int[] arr = new int[arrLe];


            //הדפסת ערכי המשתנים אשר נקלטו מהמתמש

            Console.WriteLine($"\nThe length of the array {arrLe} \nMultiply {mul}");


            //ללולאה אשר תחזור על הפעולה בהתאם לערך המשתנה "אורך הלולאה" ותבצע הכפלה בין הערך שבתא המערך לבין המספר שנקלט מהמשתמש ונדפיס את התוצאה

            for (int i = 0; i < arrLe; i++)
            {
                arr[i] = i * mul;
                Console.WriteLine(arr[i]);
            }
                                                    
            Console.ReadKey();
        }
    }
}