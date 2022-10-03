using KarmaLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static KarmaLib.KarmaSQL;

namespace KarmaUserLib
{
    public class UserNotification
    {
        public int NotifyID { get; set; }
        public string NotifyModule { get; set; }
        public string NotificationType { get; set; }
        public string NotifyMessage { get; set; }
        public DateTime NotificationDate { get; set; }
        public bool IsActive { get; set; }
        public DateTime NotificationReadDate { get; set; }
        public bool IsPopup { get; set; }
        public string ClickEvent { get; set; }
    }
    public class UserDetails
    {
        public bool ExportData { get; set; }
        public bool ImportData { get; set; }
    }
    public class User
    {
        public int UserID { get; set; }
        public bool IsAdmin { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string EMailAdress { get; set; }
        public string GSMNumber { get; set; }
        public UserDetails UserDetails { get; set; }
    }
    public static class UserLib
    {
        public static User CurrentUser { get; set; }
        public static List<UserNotification> GetUserNotifications(int UserID,bool IsUnread = true)
        {
            List<UserNotification> notifys = new List<UserNotification>();
            string SQL = $"SELECT * FROM tblUserNotify WHERE (UserID = {UserID} )";
            SQL += IsUnread? " AND IsRead = 0" : "";
            var data = GetSQLData(SQL);
            foreach(DataRow row in data.Rows)
            {
                notifys.Add(new UserNotification
                {
                    NotifyID = row["ID"].ToInt(),
                    NotificationDate = Convert.ToDateTime(row["Date"]),
                    NotifyModule = row["Module"].ToString(),
                    NotificationType = row["Type"].ToString(),
                    NotifyMessage = row["Message"].ToString(),
                    NotificationReadDate = row["ReadDate"] is DBNull? DateTime.MinValue : Convert.ToDateTime(row["ReadDate"]),
                    IsActive = row["IsRead"].ToBool(),
                    IsPopup = row["IsPopup"].ToBool(),
                    ClickEvent = row["ClickEvent"].ToString()
                });
            }
            return notifys;
        }
    }
}
