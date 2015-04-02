using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoUserV2.Data.Model
{
    public class Todo
    {
        public int TodoId { get; set; }
        public string Task { get; set; }
        
        public int UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}
