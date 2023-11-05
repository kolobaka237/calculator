try
{
    Console.WriteLine("Hi, it's calculator. Enter first number: ");
    double first = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter action (+ - * / %)");
    char action = Convert.ToChar(Console.ReadLine());
    Console.WriteLine("Enter second number: ");
    double second = Convert.ToDouble(Console.ReadLine());

    switch (action)
    {

        case '+':
            double result = first + second;
            Console.WriteLine(result);
            break;
        case '-':
            result = first - second;
            Console.WriteLine(result);
            break;
        case '*':
            result = first * second;
            Console.WriteLine(result);
            break;
        case '/':
            if (second == 0)
            {
                Console.WriteLine("You can't divide by 0");
            }
            else if (second != 0)
            {
                result = first / second;
                Console.WriteLine(result);
            }
            break;
            

    }
}
catch(Exception ex)
{
    Console.WriteLine("Check that the entered data is correct. You may have entered other characters instead of the numbers. ");
    Console.WriteLine("If you are entering a fractional number, use ',' as a separator.");
}

