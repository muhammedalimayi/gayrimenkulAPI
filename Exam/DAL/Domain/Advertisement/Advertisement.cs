using DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Domain.Advertisement
{
    public class Advertisement
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Fitment Fitment { get; set; }
        public Status Status { get; set; }
        public decimal Price { get; set; }

    }
}
