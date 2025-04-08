using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseRevolver.CoreBusiness;
using WarehouseRevolver.UseCases.databasePlugin;
using WarehouseRevolver.UseCases.interfaces;

namespace WarehouseRevolver.UseCases;

public class Readbel_warehouse_revolver_readytopickUseCase : IReadbel_warehouse_revolver_readytopickUseCase
{
    private readonly IRepositoryP21 repositoryP21;

    public Readbel_warehouse_revolver_readytopickUseCase(IRepositoryP21 repositoryP21)
    {
        this.repositoryP21 = repositoryP21;
    }
    public List<bel_warehouse_revolver_readytopick> Execute()
    {
        return repositoryP21.Readbel_warehouse_revolver_readytopick();
    }
}
