using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCarService
{
    public class TransactionLine : EntityBase
    {
        public Transaction Transaction { get; set; }
        public Guid TransactionId { get; set; }
        public ServiceTask ServiceTask { get; set; }
        public Guid ServiceTaskId { get; set; }
        public Engineer Engineer { get; set; }
        public Guid EngineerId { get; set; }
        public decimal Hours { get; set; }
        public decimal PricePerHour { get; set; }
        public decimal Price { get; set; }


        public TransactionLine()
        {
            Id = Guid.NewGuid();
        }
    }
}
