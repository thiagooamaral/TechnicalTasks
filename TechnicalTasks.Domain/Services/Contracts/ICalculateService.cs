namespace TechnicalTasks.Domain.Services.Contracts
{
    public interface ICalculateService
    {
        decimal CalculateDiscountNew(decimal amount, int type, int years);
        decimal CalculateDiscountOld(decimal amount, int type, int years);
    }
}