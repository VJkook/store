using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store.Entities.DBase
{
    internal class employee: User
    {
        public string JobTitle { get; set; } = null!;
    }
}
