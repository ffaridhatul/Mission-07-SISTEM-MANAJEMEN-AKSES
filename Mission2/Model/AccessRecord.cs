using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2.Model
{
    public class AccessRecord
    {
        public string CardId { get; set; }

        public int GateId { get; set; }

        public DateTime RecordDate { get; set; }

        public RecordTypeEnum AccessType { get; set; }
    }
}
