// See https://aka.ms/new-console-template for more information

//static void ProcessBmi()
//{
//    double height = 175d; 
//    double weight = 75d; 
//    double bmi = 0d;
//    if (height > 0d && weight > 0d)
//    {
//        var h = height / 100d; 
//        bmi = weight / h / h;
//    } 

//    Console.WriteLine($"The BMI is : {bmi:N}.");
//}

//Action processBmiAction = new Action(ProcessBmi);

//Action processBmiAction = ProcessBmi;
//processBmiAction();

//static void ProcessBmi(double height, double weight)
//{
//    double bmi = 0d;
//    if (height > 0d && weight > 0d)
//    {
//        var h = height / 100d;

//        bmi = weight / h / h;
//    }

//    Console.WriteLine($"The BMI is : {bmi:N}.");
//}

//Action<double, double> doWorkAction = new Action<double, double>(ProcessBmi);
//doWorkAction(175d, 75d);

Action<double, double> processBmiAction = (height, weight) =>
{
    double bmi = 0d;
    if (height > 0d && weight > 0d)
    {
        var h = height / 100d;

        bmi = weight / h / h;
    }

    Console.WriteLine($"The BMI is : {bmi:N}.");
};

processBmiAction(175d, 75d);