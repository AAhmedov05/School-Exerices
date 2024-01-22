using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IRunes.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cover { get; set; }
        public decimal Price { get; set; }
    }
}
