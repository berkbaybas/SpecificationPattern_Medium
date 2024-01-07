using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecificationPattern_Medium.Models
{
    public class ConcertTicket
    {
        public TicketType TicketType { get; set; }
    }

    public enum TicketType
    {
        VIP,
        Normal
    }
}
