using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Business.Model.Item
{
    public class ItemAdd
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int IdCategory { get; set; }
        public float Price { get; set; }
        public int Stock { get; set; }
        public string Image { get; set; }
        public int IdColor { get; set; }
        public int IdMaterial { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
