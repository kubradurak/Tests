namespace Calculator
{
    public class BasicOperations
    {
        public double Sum(double num1, double num2)
        {
          return num1 + num2;
        }
        public double Subtraction(double num1, double num2)
        {
            return num1 - num2;
        }
        public string Division(string num1, string num2)
        {
            try
            {
                if (num2 != "0")
                    return (Convert.ToDouble(num1) / Convert.ToDouble(num2)).ToString();
                else
                    throw new DivideByZeroException();
                
            }
            catch (DivideByZeroException ex)
            {
                return String.Format("Division of {0} by zero.", num2);
            }
        }
        public double Multiplication(double num1, double num2)
        {
            return num1 * num2;
        }
        
    }
}