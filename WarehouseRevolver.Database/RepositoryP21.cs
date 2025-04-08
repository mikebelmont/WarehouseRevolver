using WarehouseRevolver.CoreBusiness;
using WarehouseRevolver.UseCases.databasePlugin;
using System.Collections.Generic;
using WarehouseRevolver.Database.helper;

namespace WarehouseRevolver.Database;
public class RepositoryP21 : IRepositoryP21
{
    private readonly IP21DataAccess p21DataAccess;

    public RepositoryP21(IP21DataAccess p21DataAccess)
    {
        this.p21DataAccess = p21DataAccess;
    }

    public List<belWirelessTransactionsDaily> ReadbelWirelessTransactionsDaily()
    {
        var sql = $"SELECT *\r\nFROM belWirelessTransactionsDaily\r\nORDER BY transaction_line_end_date DESC";
        return p21DataAccess.Query<belWirelessTransactionsDaily, dynamic>(sql, new { });
    }

    public List<bel_warehouse_revolver_readytopick> Readbel_warehouse_revolver_readytopick()
    {
        var sql = $"EXEC bel_warehouse_revolver_readytopick";
        return p21DataAccess.Query<bel_warehouse_revolver_readytopick, dynamic>(sql, new { });
    }

    public List<totalweight> Readtotalweight()
    {
        var sql = $"SELECT EmployeeName, SUM(TotalWeight) TotalWeight\r\nFROM belWirelessTransactionsDaily\r\nGROUP BY EmployeeName\r\nORDER BY TotalWeight DESC";
        return p21DataAccess.Query<totalweight, dynamic>(sql, new { });
    }

    public List<WarehouseActivity> ReadWarehouseActivity()
    {
        var sql = $"SELECT \r\n       location_id,\r\n\tdbo.p21_fn_code_description(wireless_transaction_type_cd) WarehouseType,\r\n       wireless_transaction_number,\r\n\t   name,\r\n\t   FORMAT(transaction_start_date, 'hh:mm tt') ScanStarted,\r\n\t   DATEDIFF(MINUTE,transaction_start_date ,transaction_end_date) MinutesWorked\r\nFROM wireless_trans_audit_hdr\r\nINNER JOIN users ON created_by = id\r\nWHERE DATEDIFF(DAY, wireless_trans_audit_hdr.date_created, GETDATE()) = 0\r\n\r\nORDER BY  transaction_end_date DESC\r\n";
        return p21DataAccess.Query<WarehouseActivity, dynamic>(sql, new { });
    }
}
