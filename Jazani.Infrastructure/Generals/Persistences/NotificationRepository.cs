using Jazani.Domain.Generals.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Jazani.Infrastructure.Generals.Persistences;
using Jazani.Infrastructure.Cores.Persistences;
using Jazani.Domain.Generals.Models;

using Jazani.Infrastructure.Cores.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Jazani.Infrastructure.Generals.Persistences
{
    public class NotificationRepository : CrudRepository<Notification, int>, INotificationRepository
    {
        
        public NotificationRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            
        }
       
        
    }
}
