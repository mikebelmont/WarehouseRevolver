using WarehouseRevolver.CoreBusiness;

namespace WarehouseRevolver.UseCases.interfaces;

public interface IReadbelWirelessTransactionsDailyUseCase
{
    List<belWirelessTransactionsDaily> Execute();
}