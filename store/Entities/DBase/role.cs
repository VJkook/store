using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store.Entities.DBase
{
    internal class role: BaseEntity
    {
        public string RoleName { get; set; } = null!;
    }
}
