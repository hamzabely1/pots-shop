using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Business.Model.Item
{
    public class ItemBase
    {
        public string? ItemName { get; set; }
        public string? ItemDescription { get; set; }
        public int? ItemIdCategory { get; set; }
        public float ItemPrice { get; set; }      
        public int ItemStock { get; set; }
        public string? ItemImage { get; set; }
        public int ItemIdColor { get; set; }
        public int ItemIdMaterial { get; set;}
        public DateTime ItemUpdateDate { get;set; }
        public DateTime ItemCreatedDate { get; set;}
    }
}
