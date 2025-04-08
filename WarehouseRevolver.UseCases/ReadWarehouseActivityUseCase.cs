using WarehouseRevolver.CoreBusiness;
using WarehouseRevolver.UseCases.databasePlugin;

namespace WarehouseRevolver.UseCases;

public class ReadWarehouseActivityUseCase : IReadWarehouseActivityUseCase
{
    private readonly IRepositoryP21 repositoryP21;

    public ReadWarehouseActivityUseCase(IRepositoryP21 repositoryP21)
    {
        this.repositoryP21 = repositoryP21;
    }
    public List<WarehouseActivity> Execute()
    {
        return repositoryP21.ReadWarehouseActivity();
    }
}
