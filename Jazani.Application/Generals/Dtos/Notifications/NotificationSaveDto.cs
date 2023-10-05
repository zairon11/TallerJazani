using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.Application.Generals.Dtos.Notifications
{
    public class NotificationSaveDto
    {
        public string Name { get; set; } = default!;
        public string? Description { get; set; }
        public int NotificationtypeId { get; set; }
    }
}
