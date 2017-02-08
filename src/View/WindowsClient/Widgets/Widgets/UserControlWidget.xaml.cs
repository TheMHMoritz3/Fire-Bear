using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.Generic;

namespace WindowsClient.Widgets.Widgets
{
    /// <summary>
    /// Interaction logic for UserControlWidget.xaml
    /// </summary>
    public partial class UserControlWidget : UserControl
    {
        public UserControlWidget()
        {
            InitializeComponent();
        }

        public void addUser(String UserAndServername)
        {
            AccountListBox.Items.Insert(0, UserAndServername);
        }

        public void addUser(List<String> UserAndServernames)
        {
            foreach(String element in UserAndServernames)
                AccountListBox.Items.Insert(0, element);
        }
    }
}
