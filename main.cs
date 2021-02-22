using System;
class QuadraticEquationSolver{
  static void Main(){
    //Quadratic Expression solver
    //Asuming that the user inputs the correct Values...
    Console.Write("Enter the the values of the quadratic equation\n");
    Console.Write("a : ");
    int a = int.Parse(Console.ReadLine());
    Console.Write("b : ");
    int b = int.Parse(Console.ReadLine());
    Console.Write("c : ");
    int c = int.Parse(Console.ReadLine());
    double it3 = -1 * b;
    double it4 = 2 * a;
    double opp = Math.Sqrt((b*b) - (4*a*c));
    double ans1 = (it3 + opp ) / it4 ;
    double ans2 = (it3 - opp) / it4;
    Console.Write("x = {0:f4} or x  = {1:f4}", ans1, ans2);
    
  }
}