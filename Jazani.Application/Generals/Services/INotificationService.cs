using Jazani.Application.Generals.Dtos.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.Application.Generals.Services
{
    public interface INotificationService
    {
        
        Task<IReadOnlyList<NotificationDto>> FindAllAsync();
        Task<NotificationDto?> FindByIdAsync(int id);
        Task<NotificationDto> CreateAsync(NotificationSaveDto saveDto);
        Task<NotificationDto> EditAsync(int id, NotificationSaveDto saveDto);
        Task<NotificationDto> DisabledAsync(int id);
         
    }
}
