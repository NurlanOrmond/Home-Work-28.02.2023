// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

System.Console.WriteLine("\n\nDefine cross point of two Linear Functions \n\n"+"****************\n" + 
"y = k1 * x + b1 \n"+"y = k2 * x + b2\n"+"****************");


List <double> GetSlopeIntercept ()
{
    System.Console.Write("\nEnter Slope (k1) for the 1st Linear function: ");
    List <double> consts = new List<double>();
    double k1 = int.Parse(Console.ReadLine());
    consts.Add (k1);
    System.Console.Write("\nEnter Intercept (b1) for the 1st Linear function: ");
    double b1 =int.Parse(Console.ReadLine());
    consts.Add (b1);

    System.Console.Write("\nEnter Slope (k2) for the 2nd Linear function: ");
    double k2 = int.Parse(Console.ReadLine());
    consts.Add (k2);
    System.Console.Write("\nEnter Intercept (b2) for the 2nd Linear function: ");
    double b2 = int.Parse(Console.ReadLine());
    consts.Add (b2); 

    return consts;
}

   
      
void IntersectionPoint (List <double> list)
{
    double k1 = list[0];
    double b1 = list[1];
    double k2 = list[2];
    double b2 = list[3];

double x=(b2-b1)/(k1-k2);
double y=k2*x+b2;

if (k1==k2) 
    {
        System.Console.WriteLine("\n******************************");
        System.Console.WriteLine("\nLines are parallel!!!\n\n");
    }
    else
    {  
        System.Console.WriteLine("****************************************************");
        System.Console.WriteLine($"\n\nCross point of two lines at X={x} and Y={y} \n\n");
    }
 

}


IntersectionPoint (GetSlopeIntercept());

