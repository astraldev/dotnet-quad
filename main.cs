using System;
class QuadraticEquationSolver{
  static double positiveX(double na, double nb, double nc){
    return ((-1*nb) + Math.Sqrt((nb*nb)-(4*na*nc)))/2*na;
  }
  static double negativeX(double na, double nb, double nc){
    return ((-1*nb) - Math.Sqrt((nb*nb)-(4*na*nc)))/2*na;
  }
  static void Main(){
    //Quadratic Expression solver
    //Asuming that the user inputs the correct Values...
    while(true){
      Console.Write("Enter the the values of the quadratic equation\n");

      Console.Write("a : ");
      string a = Console.ReadLine();

      Console.Write("b : ");
      string b = Console.ReadLine();

      Console.Write("c : ");
      string c = Console.ReadLine();

      double temp = 0.0;

      if (Double.TryParse(a, out temp) && Double.TryParse(b, out temp) && Double.TryParse(c, out temp)){
        double na, nb, nc;

        na = Double.Parse(a);
        nb = Double.Parse(b);
        nc = Double.Parse(c);

        double ans1 = QuadraticEquationSolver.positiveX(na, nb, nc);
        double ans2 = QuadraticEquationSolver.negativeX(na, nb, nc);

        Console.Write("x = {0:f4} or x  = {1:f4}\n", ans1, ans2);

        break;

      } else {
        Console.WriteLine("Enter Correct Values...\n");
      }
    }
  }
}