using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCarService {
    public interface IEntityBase {

        public Guid Id { get; set; }
    }
}
