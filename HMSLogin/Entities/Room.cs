using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSLogin.Entities
{
    class Room
    {
        int roomId { get; set; }
        int wardId { get; set; }
        roomType roomType { get; set; }
    }
    enum roomType { PUBLIC, SEMIPRIVATE, PRIVATE }
}
