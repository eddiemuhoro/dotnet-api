using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Stock
    {
        public int StockId { get; set; }
        public string FirtName { get; set; } = string.Empty;
        public string LastName { get; set; }
        public string Email { get; set; }

        public List<Comment> Comments { get; set; } = new List<Comment>();
    }
}