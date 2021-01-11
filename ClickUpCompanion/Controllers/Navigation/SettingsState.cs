using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickUpCompanion.Controllers.Navigation
{
    /// <summary>
    /// App navigation state corresponding to the app settings page.
    /// </summary>
    public class SettingsState : AppNavigationState
    {
        #region Constructors
        // Must define a constructor with the context, in order to allow
        //      a context to create this state, and set this state's
        //      reference to itself as the context (object that is in this
        //      state)
        public SettingsState(AppController controller)
        {
            this.Controller = controller;
        }

        // Must define a constructor with the state passed in, in order to
        //      allow another state to create this state during a state
        //      transition for the context, and allow that state to give
        //      this one the same context (object that is in this state)
        public SettingsState(AppNavigationState state)
        {
            this.Controller = state.Controller;
        }
        #endregion

        #region State Transition Functions
        public override void GotoHome()
        {
            // Change the state to the Home state.
            this.Controller.NavState = new HomeState(this);
        }

        public override void GotoSettings()
        {
            // Nothing to do, as already in this state.
        }
        #endregion
    }
}
