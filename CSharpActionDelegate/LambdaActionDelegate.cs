namespace CSharp_Action_Delegate
{
    public class LambdaActionDelegate
    {
        public Action BmiWithNonGenericAction = () =>
        {
            var height = 175d;
            var weight = 75d;
            var bmi = 0d;
            if (height > 0d && weight > 0d)
            {
                var h = height / 100d;

                bmi = weight / h / h;
            }

            Console.WriteLine($"The BMI is : {bmi:N}.");
        };

        public Action<double, double> BmiWithGenericAction = (height, weight) =>
        {
            double bmi = 0d;
            if (height > 0d && weight > 0d)
            {
                var h = height / 100d;

                bmi = weight / h / h;
            }

            Console.WriteLine($"The BMI is : {bmi:N}.");
        };
    }
}
