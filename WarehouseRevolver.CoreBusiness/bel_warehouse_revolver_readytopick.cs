namespace WarehouseRevolver.CoreBusiness;

public class bel_warehouse_revolver_readytopick
{
    public string printer_name { get; set; }
    public string Date_Printed { get; set; }
    public int pick_ticket_no { get; set; }
    public int order_no { get; set; }
    public int lines { get; set; }
    public decimal weight { get; set; }
}
