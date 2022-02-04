﻿using FluentValidation.Results;
using GISA.ChangeDataCapture.Members.Application.Notifications;
using System.Collections.Generic;

namespace GISA.ChangeDataCapture.Members.Application.Contracts
{
    public interface INotificationContext
    {
        IReadOnlyCollection<Notification> Notifications { get; }
        bool HasNotifications { get; }
        void AddNotification(string key, string message);
        void AddNotification(Notification notification);
        void AddNotifications(IEnumerable<Notification> notificationList);
        void AddNotifications(ValidationResult validationResult);
    }
}
