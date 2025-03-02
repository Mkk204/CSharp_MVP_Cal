//OperationFactory.cs
using System;

public static class OperationFactory
{
    public static Operation CreateOperation(char operate)
    {
        //Operation operation = null;
        switch (operate)
        {
            case '+':
                return new OperationAdd();

            case '-':
                return new OperationSub();

            case '*':
                return new OperationMulti();

            case '/':
                return new OperationDiv();

            default:
                throw new ArgumentException("不支援的運算子");
        }
    }
}



