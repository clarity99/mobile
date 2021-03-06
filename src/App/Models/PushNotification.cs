﻿using System;
using System.Collections.Generic;
using Bit.App.Enums;

namespace Bit.App.Models
{
    public class PushNotificationData
    {
        public PushType Type { get; set; }
    }

    public class PushNotificationDataPayload : PushNotificationData
    {
        public string Payload { get; set; }
    }

    public class SyncCipherPushNotification
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string OrganizationId { get; set; }
        public List<Guid> CollectionIds { get; set; }
        public DateTime RevisionDate { get; set; }
    }

    public class SyncFolderPushNotification
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public DateTime RevisionDate { get; set; }
    }

    public class UserPushNotification
    {
        public string UserId { get; set; }
        public DateTime Date { get; set; }
    }
}
