namespace CSharp_Action_Delegate
{
    public class NonGenericActionDelegate
    {
        public void ProcessBmi()
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
        }

        //Action bmiNonGenericAction = new Action(ProcessBmi);
        //Action bmiDirectNonGenericAction = ProcessBmi;

        //bmiNonGenericAction();
        //bmiDirectNonGenericAction();
    }
}
