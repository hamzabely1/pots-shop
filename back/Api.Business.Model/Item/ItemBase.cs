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

        public string? ItemType { get; set; }

        public float ItemPrice { get; set; }
        public int ItemStock { get; set; }

        public string? ItemImage { get; set; }







    }
}
