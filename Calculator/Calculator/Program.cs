Console.WriteLine("Simple Calculator");

while (true)
{
    Console.Write("Enter first number: ");
    double a = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter operator (+, -, *, /): ");
    string op = Console.ReadLine();

    Console.Write("Enter second number: ");
    double b = Convert.ToDouble(Console.ReadLine());

    double result = op switch
    {
        "+" => a + b,
        "-" => a - b,
        "*" => a * b,
        "/" => b != 0 ? a / b : throw new DivideByZeroException(),
        _ => throw new InvalidOperationException("Unknown operator")
    };

    Console.WriteLine($"Result: {result}");
    Console.WriteLine();
}