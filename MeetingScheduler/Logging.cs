using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;


namespace MeetingScheduler
{
    static class Logging
    {
        public static List<String> messageBuffer = new List<string>();
        public static event EventHandler newMessage;

        public static void AddMessage(
            string message,
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string filePathString = "",
            [CallerLineNumber] int sourceLineNumber = 0
        )
        {
            string fileName = Path.GetFileName(filePathString);

            messageBuffer.Add($"[{fileName}:{sourceLineNumber} / {memberName}] {message}");

            if (messageBuffer.Count > 20)
            {
                messageBuffer.RemoveAt(0);
            }

            newMessage?.Invoke(null, new EventArgs());
        }
    }
}
