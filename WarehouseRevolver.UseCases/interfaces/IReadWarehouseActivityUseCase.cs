using WarehouseRevolver.CoreBusiness;

namespace WarehouseRevolver.UseCases;

public interface IReadWarehouseActivityUseCase
{
    List<WarehouseActivity> Execute();
}