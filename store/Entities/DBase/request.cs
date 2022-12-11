using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store.Entities.DBase
{
    internal class request: BaseEntity
    {
        public DateTime DateOfCreation { get; set; }
        public DateTime PlanDateOfCompletion { get; set; }
        public DateTime DateOfCompletion { get; set; }

    }
}
