using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EthiopiaCoffe.Domain.Abstract.Entities
{
    public interface IHasDelete
    {
        public bool IsDeleted { get; set; }
    }
}
