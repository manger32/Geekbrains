int functionSummingExpAndOne(int N)
{
    int resulting_variable = 0;
    for (int i = 0; i < N; ++i)
    {
        resulting_variable += 1<<i+1;
    }
    return resulting_variable;
}
double functionSineCosine(int N, double x, int n)
{
    double resulting_variable = x;
    for (int i = 0; i < N; ++i)
    {
        double px = x;
        for (int j = 0; j < i; ++j)
        {
            px *= x;
        }
        resulting_variable += (Math.Cos(n*Math.PI*px)+Math.Sin(N*Math.PI*px));
    }
    return resulting_variable;
}
bool outing = true;
int which = 0;
while (outing)
{
    Console.WriteLine("Choose a function: 1: SUM(f(k),k=1..N) | 2: x + (cos(n*pi*x/2) + sin(n*pi*x)/3) + (cos(n*pi*x^2/2) + sin(n*pi*x^2)/3) +...");
    which = Convert.ToInt32(Console.ReadLine());
    switch(which)
    {
        case 0:
        {
            Console.WriteLine("You haven't chosen anything");
            break;
        }
        case 1:
        {
            Console.WriteLine($"You have chosen Option #{which}");
            Console.WriteLine("Input integer N for summing first N terms of SUM(f(k),k=1..N)");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Result of f({N}) = {functionSummingExpAndOne(N)}"); 
            break;
        }
        case 2:
        {
            Console.WriteLine($"You have chosen Option #{which}");
            Console.WriteLine("Input integer N, integer n and Point x (floating-point) for summing first N terms of x + (cos(n*pi*x/2) + sin(n*pi*x)/3) + (cos(n*pi*x^2/2) + sin(n*pi*x^2)/3) +...)");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now integer n");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now floating-point x (comma for floating part)");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Result of f({n},{x},{N}) = {functionSineCosine(N, x, n)}"); 
            break;
        }
        default:
        {
            Console.WriteLine("Incorrect choice of a function for the program");
            break;
        }
    }
    Console.WriteLine("Another calculation?");
    string sanswer = Console.ReadLine();
    if (sanswer.ToUpper() == "NO")
    {
        outing = false;
        Console.WriteLine("Exiting program...");
    }
}
    
