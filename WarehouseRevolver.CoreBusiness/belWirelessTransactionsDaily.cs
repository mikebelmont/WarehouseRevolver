namespace WarehouseRevolver.CoreBusiness;

public class belWirelessTransactionsDaily
{
    public decimal location_id { get; set; }
    public string EmployeeName { get; set; } = string.Empty;
    public string TransactionType { get; set; } = string.Empty;
    public decimal wireless_transaction_number { get; set; }
    public string ActivityStartTime { get; set; } = string.Empty;
    public string ActivityTime { get; set; } = string.Empty;
    public DateTime transaction_start_date { get; set; }
    public DateTime transaction_end_date { get; set; }
    public decimal transaction_line_number { get; set; }
    public DateTime transaction_line_start_date { get; set; }
    public DateTime transaction_line_end_date { get; set; }
    public string item_id { get; set; } = string.Empty;
    public string item_desc { get; set; } = string.Empty;
    public string ItemDetail { get; set; } = string.Empty;
    public string ActionType { get; set; } = string.Empty;
    public string ItemWeight { get; set; } = string.Empty;
    public string bin_id { get; set; } = string.Empty;
}
