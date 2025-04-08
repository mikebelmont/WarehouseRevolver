using WarehouseRevolver.CoreBusiness;

namespace WarehouseRevolver.UseCases.databasePlugin;

public interface IRepositoryP21
{
    List<bel_warehouse_revolver_readytopick> Readbel_warehouse_revolver_readytopick();
    List<WarehouseActivity> ReadWarehouseActivity();
    List<belWirelessTransactionsDaily> ReadbelWirelessTransactionsDaily();
    List<totalweight> Readtotalweight();














    }