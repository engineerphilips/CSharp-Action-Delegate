namespace CSharp_Func_Delegate
{
    public class FuncDelegateWithoutInputParameter
    {
        public double ProcessBmi()
        {
            var height = 175d;
            var weight = 75d;
            double bmi = 0d;
            if (height > 0d && weight > 0d)
            {
                var h = height / 100d;

                bmi = weight / h / h;
            }

            return bmi;
        }
    }
}
