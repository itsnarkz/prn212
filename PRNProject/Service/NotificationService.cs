using PRNProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRNProject.Service
{
    internal class NotificationService
    {
        private Prn212Context db;

        public NotificationService()
        {
            db = new Prn212Context();   
        }

        public List<Notification> GetNotifications()
        {
            return db.Notifications.ToList();
        }

        public void add(Notification notification)
        {
            db.Add(notification);
            db.SaveChanges();
        }

        public void remove(Notification notification)
        {
            db.Remove(notification);
            db.SaveChanges();
        }
    }
}
