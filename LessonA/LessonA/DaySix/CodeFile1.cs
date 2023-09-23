public delegate void MethodHandlerA(); //parameterless void
public delegate int MethodHandlerB(int x, int y); //parameterized and return empty 

public class MathCalculator
{
    public void DoTask()
    {
        Console.WriteLine("calculator DoTask");
    }
    public int Add(int x, int y)
    {
        Console.WriteLine(x + " ," + y);
        return x + y;
    }
    public int Sub(int x, int y)
    {
        Console.WriteLine(x + " ," + y);
        return x - y;
    }
    public int Mul(int x, int y)
    {
        Console.WriteLine(x + " ," + y);
        return x * y;
    }
    public int Div(int x, int y)
    {
        Console.WriteLine(x + " ," + y);
        return x / y;
    }
    public String GetMode()
    {
        return "X500";
    }
}

public class DelegateDemo
{
    public static void TestOne()
    {
        MathCalculator mc = new MathCalculator();
        MethodHandlerA methodHandlerA = mc.DoTask;//new MethodHandlerA(mc.DoTask);
        MethodHandlerB methodHandlerB = mc.Add;//new MethodHandlerB(mc.Add);
        MethodHandlerB methodHanderTwoB = mc.Mul;//new MethodHandlerB(mc.Mul);
        // MethodHandlerB methodHandlerTwo = new MethodHandlerB(mc.Divide);
        methodHandlerA();
        int addResult = methodHandlerB(100, 50);
        Console.WriteLine( addResult );
        int MultiplyResult = methodHanderTwoB(20, 5);
        Console.WriteLine( MultiplyResult );


    }
    //What are delegates , different types of delegates , when to use which deleagate provide with code--QA 
    //Single delegate and multi class delegate. methods with return type are not suitable for multi cast only
    //void methods are suitable for them. All events are multi cast delegates.
    //Event is an action that is raised when state is modified.
    //ex for multi cast: bank balance is modified that is credited or debited. fuel level coming up on screen in bike
    //Events are triggered through functional pointers
    public static void TestTwo()
    {
        MathCalculator mc= new MathCalculator();
        MethodHandlerB methodHandlerB = mc.Add;
        methodHandlerB += mc.Mul;
        methodHandlerB (100, 50);
    }
}
