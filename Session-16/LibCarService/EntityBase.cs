using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCarService {
    public abstract class EntityBase : IEntityBase {
        public Guid Id { get; set; }
    }
}
