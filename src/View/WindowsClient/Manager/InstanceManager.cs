using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsClient.Widgets.CentralWidgets;

namespace WindowsClient.Manager
{
    class InstanceManager
    {
        public InstanceManager()
        {
            
        }

        public MenuManager generateMenuManager()
        {
            if (_MenuManager == null)
            {
                _ChatWidget = new ChatWidget();
                _AccountWidget = new AccountManagement();
                _OptionsWidget = new OptionsWidget();

                _MenuManager = new MenuManager();
                _MenuManager.setUIElements(_ChatWidget, _AccountWidget, _OptionsWidget);
            }
            return _MenuManager;
        }

        private MenuManager _MenuManager;

        private ChatWidget _ChatWidget;
        private AccountManagement _AccountWidget;
        private OptionsWidget _OptionsWidget;
    }
}
