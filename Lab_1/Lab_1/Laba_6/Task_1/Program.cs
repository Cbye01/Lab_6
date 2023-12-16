namespace Laba_6
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Calculator<int> intCalculator = new Calculator<int>();
            intCalculator.PerformOperations(5, 3);

        
            Calculator<double> doubleCalculator = new Calculator<double>();
            doubleCalculator.PerformOperations(5.5, 2.2);

        
            Calculator<float> floatCalculator = new Calculator<float>();
            floatCalculator.PerformOperations(4.5f, 1.5f);
        }
    }
}