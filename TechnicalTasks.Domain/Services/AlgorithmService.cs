namespace TechnicalTasks.Domain.Services
{
    using Contracts;

    public class AlgorithmService : IAlgorithmService
    {
        public AlgorithmService() {}

        public string DivisibleNumber(int number)
        {
            if (number % 7 == 0)
                return "Jazz";
            
            if (number % 3 == 0 && number % 5 == 0)
                return "JazzSalsa";

            if (number % 3 == 0)
                return "Salsa";

            return "The number is not divisible according to the exercise";
        }
    }
}