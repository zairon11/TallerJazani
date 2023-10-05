using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Jazani.Domain.Cores.Repositories;
using Jazani.Domain.Generals.Models;


namespace Jazani.Domain.Generals.Repositories
{
    public interface INotificationRepository : ICrudRepository<Notification, int>
    {
        Task<IReadOnlyList<Notification>> FindAllAsync();
    }
}
