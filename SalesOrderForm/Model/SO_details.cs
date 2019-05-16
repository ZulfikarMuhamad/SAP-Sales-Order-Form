using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesOrderForm.Model
{
    class SO_header 
    {
        public string DocEntry { get; set; }
        public string DocNum { get; set; }
        public string PrimaryNumberingPOS { get; set; }
        public string DocumentNumberingPOS { get; set; }
        public string CardCode { get; set; }
        public string CardName { get; set; }
        public DateTime PostingDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public DateTime DocumentDate { get; set; }
        public string POSOutlet { get; set; }
        public int SalesPersonCode { get; set; }
        public string SalesPersonName { get; set; }
        public string ShipToOnline { get; set; }
        public double TotalTransaction { get; set; }
        public List<SO_details> Lines = new List<SO_details>();
    }
    class SO_details
    {
        public int LineNum { get; set; }
        public string ItemCode { get; set; }
        public string Description { get; set; }
        public int UomEntry { get; set; }
        public string UomCode { get; set; }
        public double Quantity { get; set; }
        public double UnitPrice { get; set; }
        public string WarehouseCode { get; set; }
        public string WarehouseName { get; set; }
        public double DiscountPercent { get; set; }
        public double LineTotal { get; set; }
    }

    class SalesOrder
    {
        public int errorCode { get; set; }
        public string message { get; set; }
        public int recordCount { get; set; }
        public SO_header Values = new SO_header();
    }
}
