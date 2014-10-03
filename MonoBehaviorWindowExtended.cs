using System;

namespace PluginFramework
{
    public abstract class MonoBehaviorWindowExtended : MonoBehaviourWindow
    {
        protected virtual void Close()
        {
            if (OnClosed != null)
            {
                OnClosed(this, EventArgs.Empty);
            }
        }

        public event EventHandler OnClosed;
    }
}
