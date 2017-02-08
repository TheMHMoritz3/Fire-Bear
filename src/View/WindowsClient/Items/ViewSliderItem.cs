using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WindowsClient.Items
{
    public class ViewSliderItem
    {
        private ViewSliderItem()
        {
            _Title = "";
            _Content = null;
            _EnumEntry = -1;
        }

        public ViewSliderItem(String title, UIElement content, int enumEntry = -1)
        {
            _Title = title;
            _Content = content;
            _EnumEntry = enumEntry;
        }

        ~ViewSliderItem()
        {  }

        public String Title
        {
            get
            {
                return _Title;
            }
        }

        public UIElement Content
        {
            get
            {
                return _Content;
            }
        }

        public int EnumEntry
        {
            get
            {
                return _EnumEntry;
            }
        }

        String _Title;
        UIElement _Content;
        int _EnumEntry;
    }
}
