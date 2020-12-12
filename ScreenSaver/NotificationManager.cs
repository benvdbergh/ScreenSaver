using OutLook = Microsoft.Office.Interop.Outlook;
using System.Reflection;
using System.Windows.Forms;
using System;
using System.Text;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Collections.Generic;

namespace ScreenSaver
{
    class NotificationManager
    {
        OutLook.Application oApp;
        OutLook._NameSpace oNS;
        OutLook.MAPIFolder oFolder;
        OutLook._Explorer oExp;
        
        public NotificationManager()
        {
            oApp = new OutLook.Application();
            oNS = (OutLook._NameSpace)oApp.GetNamespace("MAPI");
            oFolder = oNS.GetDefaultFolder(OutLook.OlDefaultFolders.olFolderInbox);
            oExp = oFolder.GetExplorer(false);
            oNS.Logon(Missing.Value, Missing.Value, false, true);
        }

        public int getUnreadMail()
        {
            OutLook.Items items = oFolder.Items;
            OutLook.MailItem mail = items.Find("[Unread] = true");
            int unread = 0;
            while (mail != null)
            {
                mail = items.FindNext();
                unread++;
            }

            return unread;
        }

        public System.DateTime GetNext()
        {
            string dateTimeStart = DateTime.Now.ToString("MM/dd/yyyy hh:mm tt");
            DateTime dt = new DateTime(DateTime.Now.Year, DateTime.Now.Month,
                                       DateTime.Now.Day +7, 23, 59, 00, 00);
            string dateTimeEnd = dt.ToString("MM/dd/yyyy hh:mm tt");
            string searchCriteria = "[Start]<=\"" + dateTimeEnd + "\"" + " AND [End]>=\"" +
                                                                      dateTimeStart + "\"";
            StringBuilder strBuilder = null;
            oFolder = oNS.GetDefaultFolder(OutLook.OlDefaultFolders.olFolderCalendar);
            OutLook.Items folderItems = null;
            OutLook.AppointmentItem appItem = null;
            object resultItem = null;
            try
            {
                folderItems = oFolder.Items;
                folderItems.IncludeRecurrences = true;
                folderItems.Sort("[Start]");
                if (folderItems.Count > 0)
                {
                    resultItem = folderItems.Find(searchCriteria);

                    if (resultItem != null)
                    {

                        strBuilder = new StringBuilder();
                        do
                        {
                            if (resultItem is OutLook.AppointmentItem)
                            {
                                appItem = resultItem as OutLook.AppointmentItem;

                                return appItem.Start;
                            }
                            Marshal.ReleaseComObject(resultItem);
                            resultItem = folderItems.FindNext();
                        }
                        while (resultItem != null);
                    }
                }
                if (strBuilder != null)
                    Debug.WriteLine(strBuilder.ToString());
                else
                    Debug.WriteLine("No meetings");

                return DateTime.Now;
            }
            catch (Exception ex)
            {
            }
            finally
            {
                if (folderItems != null) Marshal.ReleaseComObject(folderItems);
            }

            return DateTime.Now;
        }
    }
}
