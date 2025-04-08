using WarehouseRevolver.UseCases.databasePlugin;

namespace WarehouseRevolver.UseCases;

public class Template
{
    private readonly IRepositoryP21 repositoryP21;

    public Template(IRepositoryP21 repositoryP21)
    {
        this.repositoryP21 = repositoryP21;
    }

}
