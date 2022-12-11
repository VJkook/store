using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store.Entities.DBase
{
    internal class Process: request
    {
        public string Status { get; set; } = null!;
        public DateTime StartOfProcess { get; set; }
       // public DateTime EndOfProcess { get; set; }
        public int CountOfFinishedProducts { get; set; }
    }
}
