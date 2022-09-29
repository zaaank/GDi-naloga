using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownloadZIP.Data
{

    internal class ZavezancEntity
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public string Number1 { get; set; }
        public string Number2 { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public int Rating { get; set; }
    }
}
