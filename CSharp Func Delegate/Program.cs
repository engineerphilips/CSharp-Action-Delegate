// See https://aka.ms/new-console-template for more information

//static double ProcessBmi()
//{
//    double height = 175d;
//    double weight = 75d;
//    double bmi = 0d;
//    if (height > 0d && weight > 0d)
//    {
//        var h = height / 100d;

//        bmi = weight / h / h;
//    }

//    return bmi;
//}

//Func<double> processBmiFunc = new Func<double>(ProcessBmi);
//Console.WriteLine($"The BMI is : {processBmiFunc:N}.");

//static double ProcessBmi(double height, double weight)
//{
//    double bmi = 0d;
//    if (height > 0d && weight > 0d)
//    {
//        var h = height / 100d;

//        bmi = weight / h / h;
//    }

//    return bmi;
//}

//Func<double, double, double> processBmiFunc = ProcessBmi;
//Console.WriteLine($"The BMI is : {processBmiFunc(175d, 75d):N}.");

Func<double, double, double> processBmiAction = (height, weight) =>
{
    double bmi = 0d;
    if (height > 0d && weight > 0d)
    {
        var h = height / 100d;

        bmi = weight / h / h;
    }

    return bmi;
};

Console.WriteLine($"The BMI is : {processBmiAction(175d, 75d):N}.");
