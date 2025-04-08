using WarehouseRevolver.CoreBusiness;
using WarehouseRevolver.UseCases.databasePlugin;
using WarehouseRevolver.UseCases.interfaces;

namespace WarehouseRevolver.UseCases;

public class ReadbelWirelessTransactionsDailyUseCase : IReadbelWirelessTransactionsDailyUseCase
{
    private readonly IRepositoryP21 repositoryP21;

    public ReadbelWirelessTransactionsDailyUseCase(IRepositoryP21 repositoryP21)
    {
        this.repositoryP21 = repositoryP21;
    }
    public List<belWirelessTransactionsDaily> Execute()
    {
        return repositoryP21.ReadbelWirelessTransactionsDaily();
    }

}
