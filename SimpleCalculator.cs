﻿// TO DO

/*
    1. Build a method for the calculator input
    2. Build a method that parses the input for the operands to number type (double)
    3. Build the engine of the calculator that responds based on the operation to be performed
*/

Console.Title = "=====Simple Calculator=====";
Console.WriteLine("=====Simple Calculator=====");
Console.WriteLine("Available opperations are: +, -, /, *, %, and mod(Modulo).");
CalculatorInputAndOutPut();

void CalculatorInputAndOutPut()
{
    try
    {
        bool flag = true;

        do
        {
            Console.Write("Enter your first number: ");
            double firstInput = ConvertInputToNumeric(Console.ReadLine()!);

            Console.Write("Enter your operator: ");
            string arithmeticOperator = Console.ReadLine()!;

            Console.Write("Enter your second number: ");
            double secondInput = ConvertInputToNumeric(Console.ReadLine()!);

            var output = CalculatorEngine(firstInput, secondInput, arithmeticOperator);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Result: {output}");
            Console.ResetColor();

            string continueOption = string.Empty;

            do
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Do you want to continue Y/N: ");
                Console.ResetColor();

                continueOption = Console.ReadLine()!;

            } while (continueOption != "y" && continueOption != "n");

            flag = continueOption == "y";

        } while (flag);

    }
    catch (Exception ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Error: {0}", ex.Message);
        Console.ResetColor();
    }
}

double ConvertInputToNumeric(string stringInput)
{
    if (!double.TryParse(stringInput, out double convertedNumber))
    {
        throw new FormatException("Expected a numeric value!");
    }

    return convertedNumber;
}

double CalculatorEngine(double argNumber1, double argNumber2, string argOperation)
{
    double result;

    switch (argOperation.ToLower())
    {
        case "add":
        case "+":
            result = argNumber1 + argNumber2;
            break;
        case "minus":
        case "-":
            result = argNumber1 - argNumber2;
            break;
        case "multiply":
        case "*":
            result = argNumber1 * argNumber2;
            break;
        case "divide":
        case "/":
            result = argNumber1 / argNumber2;
            break;
        case "percentage":
        case "%":
            result =((argNumber1 /100) * argNumber2);
            break;
        case "modulo":  //% modulo
        case "mod":
            result = argNumber1 % argNumber2;
            break;
        default:
            throw new InvalidOperationException("Operator not recognized!");
    }

    return result;
}



/*
    1. Build a method for the calculator input
    2. Build a method that parses the input for the operands to number type (double)
    3. Build the engine of the calculator that responds based on the operation to be performed
*/
/*
Console.ForegroundColor = ConsoleColor.Green;
Console.BackgroundColor = ConsoleColor.White; 
Console.WriteLine("===Simple Calculator===");
Console.ResetColor();

double result;
bool flag = true;

try
{
    do
    {
        Console.WriteLine("1. Addition:\n2. Substraction:\n3. Multiplication:\n4. Division:\n5. Percentage: ");
        double operatorInput = double.Parse(Console.ReadLine()!);
        double firstOperand;
        double secondOperand;

        switch(operatorInput)
        {
            case 1:
                Console.WriteLine("Provide first operand");
                firstOperand = Convert.ToDouble(Console.ReadLine()!);
                Console.WriteLine("Provide second operand");
                secondOperand = Convert.ToDouble(Console.ReadLine()!);
                result = firstOperand + secondOperand;
                Console.WriteLine(result);
            break;

            case 2:
                Console.WriteLine("Provide first operand");
                firstOperand = Convert.ToDouble(Console.ReadLine()!);
                Console.WriteLine("Provide second operand");
                secondOperand = Convert.ToDouble(Console.ReadLine()!);
                result = firstOperand - secondOperand;
                Console.WriteLine(result);
            break;

            case 3:
                Console.WriteLine("Provide first operand");
                firstOperand = Convert.ToDouble(Console.ReadLine()!);
                Console.WriteLine("Provide second operand");
                secondOperand = Convert.ToDouble(Console.ReadLine()!);
                result = firstOperand * secondOperand;
                Console.WriteLine(result);
            break;

            case 4:
                Console.WriteLine("Provide first operand");
                firstOperand = Convert.ToDouble(Console.ReadLine()!);
                Console.WriteLine("Provide second operand");
                secondOperand = Convert.ToDouble(Console.ReadLine()!);
                result = firstOperand / secondOperand;
                Console.WriteLine(result);
            break;

            case 5:
                Console.WriteLine("Provide first operand");
                firstOperand = Convert.ToDouble(Console.ReadLine()!);
                result = firstOperand / 100;
                Console.WriteLine(result);
            break;
            
            default:
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.BackgroundColor = ConsoleColor.Yellow; 
                Console.WriteLine("Invalid Input");
                Console.ResetColor();
            break;
        }

        string option;
        do
        {
            Console.WriteLine("Do you want to perform another calculation? (Y/N)");
            option = Console.ReadLine()!.ToLower();
            
        } 
        while (!option.Equals("y".ToLower()) && !option.Equals("n".ToLower()));
        
        {
            Console.WriteLine("Thank you for using our app");
        }
        
       
        flag = option.Equals("y".ToLower());

    } while (flag);
}

catch (Exception)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.BackgroundColor = ConsoleColor.Yellow;  
    Console.WriteLine("Expected Numbers only");
}   Console.ResetColor();

*/
