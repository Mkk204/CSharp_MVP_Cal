using System;

//Operation.cs
public class Operation
{
    public double NumberA { get; set; }
    public double NumberB { get; set; }

    public virtual double GetResult()
    {
        return 0;
    }
}

public class OperationAdd : Operation
{
    public override double GetResult()
    {
        return NumberA + NumberB;
    }
}

public class OperationSub : Operation
{
    public override double GetResult()
    {
        return NumberA - NumberB;
    }
}

public class OperationMulti : Operation
{
    public override double GetResult()
    {
        return NumberA * NumberB;
    }
}

public class OperationDiv : Operation
{
    public override double GetResult()
    {
        if(NumberB == 0)
        {
            throw new ArgumentException("除數不能為0");
        }
        return NumberA / NumberB;
    }
}


