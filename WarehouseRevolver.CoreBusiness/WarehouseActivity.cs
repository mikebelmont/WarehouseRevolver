using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseRevolver.CoreBusiness;

public class WarehouseActivity
{
    public int location_id { get; set; }
    public string WarehouseType { get; set; }
    public int wireless_transaction_number { get; set; }
    public string name { get; set; }
    public string ScanStarted { get; set; }
    public int MinutesWorked { get; set; }
}
