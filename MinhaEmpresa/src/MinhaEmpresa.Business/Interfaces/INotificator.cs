using System;
using System.Collections.Generic;
using System.Text;
using MinhaEmpresa.Business.Notifications;

namespace MinhaEmpresa.Business.Interfaces
{
    public interface INotificator
    {
        bool HasNotification();
        List<Notification> GetNotifications();
        void Handle(Notification notification);
    }
}
