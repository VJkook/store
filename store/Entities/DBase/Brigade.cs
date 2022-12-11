using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store.Entities.DBase
{
    internal class Brigade: BaseEntity
    {
        public int NumberOfBrigade { get; set; } 
        public string? Comment { get; set; }

    }
}
