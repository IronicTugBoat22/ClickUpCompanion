using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickUpCompanion.EventArguments
{
    /// <summary>
    /// Contains event info for a navigation request from the MainPage.NavigationRequested event.
    /// </summary>
    public class NavigationRequestedEventArgs : EventArgs
    {
        /// <summary>
        /// The enum value of the page being reqested as the target of the navigation.
        /// </summary>
        public PageTypes ToPage { get; private set; }

        public NavigationRequestedEventArgs(PageTypes toPage)
        {
            this.ToPage = toPage;
        }
    }
}
