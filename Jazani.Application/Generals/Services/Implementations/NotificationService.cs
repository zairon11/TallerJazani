using Jazani.Application.Generals.Dtos.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Jazani.Domain.Generals.Models;
using Jazani.Domain.Generals.Repositories;
using AutoMapper;


namespace Jazani.Application.Generals.Services.Implementations
{
    public class NotificationService : INotificationService
    {
        private readonly INotificationRepository _notificationRepository;

        private readonly IMapper _mapper;

        public NotificationService(INotificationRepository notificationRepository, IMapper mapper)
        {
            _notificationRepository = notificationRepository;
            _mapper = mapper;
        }
        public async Task<NotificationDto> CreateAsync(NotificationSaveDto saveDto)
        {
            Notification notification = _mapper.Map<Notification>(saveDto);
            notification.RegistrationDate= DateTime.Now;
            await _notificationRepository.SaveAsync(notification);

            return _mapper.Map<NotificationDto>(notification);

        }

        public async Task<NotificationDto> DisabledAsync(int id)
        {
            Notification notification = await _notificationRepository.FindByIdAsync(id);
            notification.State = false;
            await _notificationRepository.SaveAsync(notification);

            return _mapper.Map<NotificationDto>(notification);
        }

        public async Task<NotificationDto> EditAsync(int id, NotificationSaveDto saveDto)
        {
            Notification notification = await _notificationRepository.FindByIdAsync(id);
            _mapper.Map<NotificationSaveDto, Notification>(saveDto, notification);
          
            await _notificationRepository.SaveAsync(notification);
            

            return _mapper.Map<NotificationDto>(notification);
        }

        public async Task<IReadOnlyList<NotificationDto>> FindAllAsync()
        {
            IReadOnlyList<Notification> notifications = await _notificationRepository.FindAllAsync();
            return _mapper.Map<IReadOnlyList<NotificationDto>>(notifications);
        }

        public async Task<NotificationDto?> FindByIdAsync(int id)
        {
            Notification notification = await _notificationRepository.FindByIdAsync(id);
           
            return _mapper.Map<NotificationDto>(notification);
        }
    }
}
