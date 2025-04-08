using WarehouseRevolver.CoreBusiness;
using WarehouseRevolver.UseCases.databasePlugin;
using WarehouseRevolver.UseCases.interfaces;

namespace WarehouseRevolver.UseCases;

public class ReadtotalweightUseCase : IReadtotalweightUseCase
{
    private readonly IRepositoryP21 repositoryP21;

    public ReadtotalweightUseCase(IRepositoryP21 repositoryP21)
    {
        this.repositoryP21 = repositoryP21;
    }
    public List<totalweight> Execute()
    {
        return repositoryP21.Readtotalweight();
    }
}
