using Jazani.Application.Generals.Dtos.NotificationTypes;
using Jazani.Domain.Generals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.Application.Generals.Dtos.Notifications
{
    public class NotificationDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string? Description { get; set; }
        public NotificationTypeSimpleDto Notificationtype { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool State { get; set; }

    }
}
