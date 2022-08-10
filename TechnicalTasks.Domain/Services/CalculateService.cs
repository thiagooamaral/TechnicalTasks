namespace TechnicalTasks.Domain.Services
{
    using Contracts;

    public class CalculateService : ICalculateService
    {
        public CalculateService() {}

        // New version: code refactoring
        public decimal CalculateDiscountNew(decimal amount, int type, int years)
        {
            const decimal maxDiscount = 0.05m;
            decimal discount = years > 5 ? maxDiscount : years / 100m;

            switch (type)
            {
                case 1: 
                    return amount;
                case 2: 
                    return (0.9m * amount) - discount * (0.9m * amount);
                case 3: 
                    return (0.7m * amount) - discount * (0.7m * amount);
                case 4: 
                    return (0.5m * amount) - discount * (0.5m * amount);
                default: 
                    return 0m;
            }
        }

        // Old version: provided as an example
        public decimal CalculateDiscountOld(decimal amount, int type, int years)
        {
            decimal result = 0;
            decimal disc = (years > 5) ? (decimal)5 / 100 : (decimal)years / 100;
            if (type == 1)
            {
                result = amount;
            }
            else if (type == 2)
            {
                result = (amount - (0.1m * amount)) - disc * (amount - (0.1m * amount));
            }
            else if (type == 3)
            {
                result = (0.7m * amount) - disc * (0.7m * amount);
            }
            else if (type == 4)
            {
                result = (amount - (0.5m * amount)) - disc * (amount - (0.5m * amount));
            }
            return result;
        }
    }
}