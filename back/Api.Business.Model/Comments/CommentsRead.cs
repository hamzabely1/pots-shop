using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Business.Model.Comments
{
    public class CommentsRead
    {
        public int Id { get; set; }
        public int IdItem { get; set; }
        public int IdUser { get; set; }
        public string Content { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
