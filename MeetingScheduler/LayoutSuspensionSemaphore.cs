using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeetingScheduler
{
    public class LayoutSuspensionSemaphore
    {
        private Control control;
        private int users = 0;

        public LayoutSuspensionSemaphore(Control control)
        {
            this.control = control;
        }

        public void AddUser()
        {
            if (users == 0)
                control.SuspendLayout();

            Logging.AddMessage($"Semaphore for [{control}] increased user count: {users} => {users + 1}");

            users++;
        }

        public void RemoveUser()
        {
            users--;

            Logging.AddMessage($"Semaphore for [{control}] decreased user count: {users + 1} => {users}");

            if (users == 0)
                control.ResumeLayout();
        }

        public Handle Acquire()
        {
            return new Handle(this);
        }
        /// <summary>
        /// Layout suspension semaphore handle
        /// 
        /// This is the method through which external users manage suspension of the underlying control.
        /// When it is constructed, the user count is increased and the layout is suspended if this is the first user.
        /// When it is disposed, the user count is decreased and the layout is resumed if this was the last user.
        /// 
        /// This allows nested usage of suspension handles, operating in the most efficient way by only resuming layout when the last user finishes their suspension request.
        /// 
        /// At base, a control that implements the suspension semaphore could have it acquired through:
        /// 
        /// using (var handle = control.semaphore.Acquire()) {
        ///     // layout-intensive code here
        /// }
        /// 
        /// This will automatically release the handle when exiting the block, and the user count implementation means this works with nested blocks too.
        /// Thus, the most efficient suspension routine should be guaranteed.
        /// 
        /// In practice, the acquisition will probably be put behind a helper function on the control:
        /// 
        /// using (var handle = control.Suspend()) {
        ///     // ...
        /// }
        /// 
        /// </summary>
        public class Handle : IDisposable
        {
            private LayoutSuspensionSemaphore semaphore;

            public Handle(LayoutSuspensionSemaphore semaphore)
            {
                this.semaphore = semaphore;

                Logging.AddMessage($"Handle for [{semaphore.control}] acquired");

                semaphore.AddUser();
            }

            public void Dispose()
            {
                semaphore.RemoveUser();

                Logging.AddMessage($"Handle for [{semaphore.control}] disposed");
            }
        }
    }
}
