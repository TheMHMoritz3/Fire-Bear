using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WindowsClient.Items;

namespace WindowsClient.Manager
{
    public enum DocumentationIndex
    {
        ChatDocumentationIndex,
        OptionsDocumentaitonIndex,
        AccountDocumantationIndex
    }

    public class MenuManager
    {
        public MenuManager()
        {
            setCurrentItem(0);
        }

        private void generateMenu()
        {
            ViewSliderItem item = new ViewSliderItem("Chat", _ChatWidget);
            Items[0] = item;
            item = new ViewSliderItem("Account Management", _AccountWidget);
            Items[1] = item;
            item = new ViewSliderItem("Options", _OptionsWidget);
            Items[2] = item;
        }

        public ViewSliderItem[] WidgetArray
        {
            get
            {
                return Items;
            }
        }

        public void setCurrentItem(int currentItem)
        {
            if ((-1>=currentItem)||(currentItem > CounterOfVariables - 1))
                throw new Exception("Wrong Value");

            CurrentItem = currentItem;
        }

        public UIElement getContentOfCurrentItem()
        {
            return Items[CurrentItem].Content;
        }

        public void setUIElements(UIElement chatWidget, UIElement accountWidget, UIElement optionsWidget)
        {
            _ChatWidget = chatWidget;
            _AccountWidget = accountWidget;
            _OptionsWidget = optionsWidget;
            generateMenu();
        }

        private UIElement _ChatWidget, _AccountWidget, _OptionsWidget;
        private const int CounterOfVariables = 3;
        private ViewSliderItem[] Items = new ViewSliderItem[CounterOfVariables];
        private int CurrentItem;
    }
}
