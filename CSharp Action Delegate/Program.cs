// See https://aka.ms/new-console-template for more information

//This method calculates BMI
static void ProcessBmi()
{
    double height = 175d;
    double weight = 75d;
    double bmi = 0d;
    if (height > 0d && weight > 0d)
    {
        var h = height / 100d;

        bmi = weight / h / h;
    }

    Console.WriteLine($"The BMI is : {bmi:N}.");
}

Action doWorkAction = ProcessBmi;
doWorkAction();